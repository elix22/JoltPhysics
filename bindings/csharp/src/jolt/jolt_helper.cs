// machine generated, do not edit
public static partial class Jolt
{
    /// Single-precision 3D vector (velocities, forces, normals).
    /// Generated from class `JoltVec3f`.
    /// This is the const half of the class.
    public class Const_JoltVec3f : Jolt.Object<Const_JoltVec3f>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltVec3f_Destroy(_Underlying *_this);
            __JoltVec3f_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltVec3f() {Dispose(false);}

        public unsafe float x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltVec3f_Get_x(_Underlying *_this);
                return *__JoltVec3f_Get_x(_UnderlyingPtr);
            }
        }

        public unsafe float y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltVec3f_Get_y(_Underlying *_this);
                return *__JoltVec3f_Get_y(_UnderlyingPtr);
            }
        }

        public unsafe float z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltVec3f_Get_z(_Underlying *_this);
                return *__JoltVec3f_Get_z(_UnderlyingPtr);
            }
        }

        internal unsafe Const_JoltVec3f(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltVec3f() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltVec3f_DefaultConstruct();
            _UnderlyingPtr = __JoltVec3f_DefaultConstruct();
        }

        /// Generated from constructor `JoltVec3f::JoltVec3f`.
        public unsafe Const_JoltVec3f(Jolt.Const_JoltVec3f _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltVec3f_ConstructFromAnother(Jolt.JoltVec3f._Underlying *_other);
            _UnderlyingPtr = __JoltVec3f_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltVec3f::JoltVec3f`.
        public Const_JoltVec3f(JoltVec3f _other) : this((Const_JoltVec3f)_other) {}

        /// Generated from constructor `JoltVec3f::JoltVec3f`.
        public unsafe Const_JoltVec3f(float x, float y, float z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltVec3f_Construct(float x, float y, float z);
            _UnderlyingPtr = __JoltVec3f_Construct(x, y, z);
        }
    }

    /// Single-precision 3D vector (velocities, forces, normals).
    /// Generated from class `JoltVec3f`.
    /// This is the non-const half of the class.
    public class JoltVec3f : Const_JoltVec3f
    {
        public new unsafe ref float x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltVec3f_GetMutable_x(_Underlying *_this);
                return ref *__JoltVec3f_GetMutable_x(_UnderlyingPtr);
            }
        }

        public new unsafe ref float y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltVec3f_GetMutable_y(_Underlying *_this);
                return ref *__JoltVec3f_GetMutable_y(_UnderlyingPtr);
            }
        }

        public new unsafe ref float z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltVec3f_GetMutable_z(_Underlying *_this);
                return ref *__JoltVec3f_GetMutable_z(_UnderlyingPtr);
            }
        }

        internal unsafe JoltVec3f(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltVec3f() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltVec3f_DefaultConstruct();
            _UnderlyingPtr = __JoltVec3f_DefaultConstruct();
        }

        /// Generated from constructor `JoltVec3f::JoltVec3f`.
        public unsafe JoltVec3f(Jolt.Const_JoltVec3f _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltVec3f_ConstructFromAnother(Jolt.JoltVec3f._Underlying *_other);
            _UnderlyingPtr = __JoltVec3f_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltVec3f::JoltVec3f`.
        public JoltVec3f(JoltVec3f _other) : this((Const_JoltVec3f)_other) {}

        /// Generated from constructor `JoltVec3f::JoltVec3f`.
        public unsafe JoltVec3f(float x, float y, float z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltVec3f_Construct(float x, float y, float z);
            _UnderlyingPtr = __JoltVec3f_Construct(x, y, z);
        }

        /// Generated from method `JoltVec3f::operator=`.
        public unsafe Jolt.JoltVec3f Assign(Jolt.Const_JoltVec3f _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3f_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3f_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltVec3f_AssignFromAnother(_Underlying *_this, Jolt.JoltVec3f._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltVec3f_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltVec3f` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltVec3f`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltVec3f`/`Const_JoltVec3f` directly.
    public class _InOptMut_JoltVec3f
    {
        public JoltVec3f? Opt;

        public _InOptMut_JoltVec3f() {}
        public _InOptMut_JoltVec3f(JoltVec3f value) {Opt = value;}
        public static implicit operator _InOptMut_JoltVec3f(JoltVec3f value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltVec3f` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltVec3f`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltVec3f`/`Const_JoltVec3f` to pass it to the function.
    public class _InOptConst_JoltVec3f
    {
        public Const_JoltVec3f? Opt;

        public _InOptConst_JoltVec3f() {}
        public _InOptConst_JoltVec3f(Const_JoltVec3f value) {Opt = value;}
        public static implicit operator _InOptConst_JoltVec3f(Const_JoltVec3f value) {return new(value);}
    }

    /// Double-precision 3D vector (world-space positions).
    /// Generated from class `JoltVec3`.
    /// This is the const half of the class.
    public class Const_JoltVec3 : Jolt.Object<Const_JoltVec3>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltVec3_Destroy(_Underlying *_this);
            __JoltVec3_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltVec3() {Dispose(false);}

        public unsafe double x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltVec3_Get_x(_Underlying *_this);
                return *__JoltVec3_Get_x(_UnderlyingPtr);
            }
        }

        public unsafe double y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltVec3_Get_y(_Underlying *_this);
                return *__JoltVec3_Get_y(_UnderlyingPtr);
            }
        }

        public unsafe double z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltVec3_Get_z(_Underlying *_this);
                return *__JoltVec3_Get_z(_UnderlyingPtr);
            }
        }

        internal unsafe Const_JoltVec3(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltVec3() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltVec3_DefaultConstruct();
            _UnderlyingPtr = __JoltVec3_DefaultConstruct();
        }

        /// Generated from constructor `JoltVec3::JoltVec3`.
        public unsafe Const_JoltVec3(Jolt.Const_JoltVec3 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltVec3_ConstructFromAnother(Jolt.JoltVec3._Underlying *_other);
            _UnderlyingPtr = __JoltVec3_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltVec3::JoltVec3`.
        public Const_JoltVec3(JoltVec3 _other) : this((Const_JoltVec3)_other) {}

        /// Generated from constructor `JoltVec3::JoltVec3`.
        public unsafe Const_JoltVec3(double x, double y, double z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltVec3_Construct(double x, double y, double z);
            _UnderlyingPtr = __JoltVec3_Construct(x, y, z);
        }
    }

    /// Double-precision 3D vector (world-space positions).
    /// Generated from class `JoltVec3`.
    /// This is the non-const half of the class.
    public class JoltVec3 : Const_JoltVec3
    {
        public new unsafe ref double x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltVec3_GetMutable_x(_Underlying *_this);
                return ref *__JoltVec3_GetMutable_x(_UnderlyingPtr);
            }
        }

        public new unsafe ref double y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltVec3_GetMutable_y(_Underlying *_this);
                return ref *__JoltVec3_GetMutable_y(_UnderlyingPtr);
            }
        }

        public new unsafe ref double z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltVec3_GetMutable_z(_Underlying *_this);
                return ref *__JoltVec3_GetMutable_z(_UnderlyingPtr);
            }
        }

        internal unsafe JoltVec3(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltVec3() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltVec3_DefaultConstruct();
            _UnderlyingPtr = __JoltVec3_DefaultConstruct();
        }

        /// Generated from constructor `JoltVec3::JoltVec3`.
        public unsafe JoltVec3(Jolt.Const_JoltVec3 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltVec3_ConstructFromAnother(Jolt.JoltVec3._Underlying *_other);
            _UnderlyingPtr = __JoltVec3_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltVec3::JoltVec3`.
        public JoltVec3(JoltVec3 _other) : this((Const_JoltVec3)_other) {}

        /// Generated from constructor `JoltVec3::JoltVec3`.
        public unsafe JoltVec3(double x, double y, double z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltVec3_Construct(double x, double y, double z);
            _UnderlyingPtr = __JoltVec3_Construct(x, y, z);
        }

        /// Generated from method `JoltVec3::operator=`.
        public unsafe Jolt.JoltVec3 Assign(Jolt.Const_JoltVec3 _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltVec3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltVec3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltVec3_AssignFromAnother(_Underlying *_this, Jolt.JoltVec3._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltVec3_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltVec3` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltVec3`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltVec3`/`Const_JoltVec3` directly.
    public class _InOptMut_JoltVec3
    {
        public JoltVec3? Opt;

        public _InOptMut_JoltVec3() {}
        public _InOptMut_JoltVec3(JoltVec3 value) {Opt = value;}
        public static implicit operator _InOptMut_JoltVec3(JoltVec3 value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltVec3` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltVec3`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltVec3`/`Const_JoltVec3` to pass it to the function.
    public class _InOptConst_JoltVec3
    {
        public Const_JoltVec3? Opt;

        public _InOptConst_JoltVec3() {}
        public _InOptConst_JoltVec3(Const_JoltVec3 value) {Opt = value;}
        public static implicit operator _InOptConst_JoltVec3(Const_JoltVec3 value) {return new(value);}
    }

    /// Single-precision quaternion (rotation).
    /// Generated from class `JoltQuat`.
    /// This is the const half of the class.
    public class Const_JoltQuat : Jolt.Object<Const_JoltQuat>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltQuat_Destroy(_Underlying *_this);
            __JoltQuat_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltQuat() {Dispose(false);}

        public unsafe float x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltQuat_Get_x(_Underlying *_this);
                return *__JoltQuat_Get_x(_UnderlyingPtr);
            }
        }

        public unsafe float y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltQuat_Get_y(_Underlying *_this);
                return *__JoltQuat_Get_y(_UnderlyingPtr);
            }
        }

        public unsafe float z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltQuat_Get_z(_Underlying *_this);
                return *__JoltQuat_Get_z(_UnderlyingPtr);
            }
        }

        public unsafe float w
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_Get_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_Get_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltQuat_Get_w(_Underlying *_this);
                return *__JoltQuat_Get_w(_UnderlyingPtr);
            }
        }

        internal unsafe Const_JoltQuat(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltQuat() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltQuat_DefaultConstruct();
            _UnderlyingPtr = __JoltQuat_DefaultConstruct();
        }

        /// Generated from constructor `JoltQuat::JoltQuat`.
        public unsafe Const_JoltQuat(Jolt.Const_JoltQuat _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltQuat_ConstructFromAnother(Jolt.JoltQuat._Underlying *_other);
            _UnderlyingPtr = __JoltQuat_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltQuat::JoltQuat`.
        public Const_JoltQuat(JoltQuat _other) : this((Const_JoltQuat)_other) {}

        /// Generated from constructor `JoltQuat::JoltQuat`.
        public unsafe Const_JoltQuat(float x, float y, float z, float w) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltQuat_Construct(float x, float y, float z, float w);
            _UnderlyingPtr = __JoltQuat_Construct(x, y, z, w);
        }

        /// Generated from method `JoltQuat::Identity`.
        public static unsafe Jolt.JoltQuat Identity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_Identity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_Identity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltQuat_Identity();
            return new(__JoltQuat_Identity(), is_owning: true);
        }

        /// Generated from method `JoltQuat::IsNormalized`.
        public unsafe bool IsNormalized(float tolerance)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltQuat_IsNormalized(_Underlying *_this, float tolerance);
            return __JoltQuat_IsNormalized(_UnderlyingPtr, tolerance) != 0;
        }

        /// Generated from method `JoltQuat::RotateAxisX`.
        public unsafe Jolt.JoltVec3f RotateAxisX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_RotateAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_RotateAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltQuat_RotateAxisX(_Underlying *_this);
            return new(__JoltQuat_RotateAxisX(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltQuat::RotateAxisY`.
        public unsafe Jolt.JoltVec3f RotateAxisY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_RotateAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_RotateAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltQuat_RotateAxisY(_Underlying *_this);
            return new(__JoltQuat_RotateAxisY(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltQuat::RotateAxisZ`.
        public unsafe Jolt.JoltVec3f RotateAxisZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_RotateAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_RotateAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltQuat_RotateAxisZ(_Underlying *_this);
            return new(__JoltQuat_RotateAxisZ(_UnderlyingPtr), is_owning: true);
        }
    }

    /// Single-precision quaternion (rotation).
    /// Generated from class `JoltQuat`.
    /// This is the non-const half of the class.
    public class JoltQuat : Const_JoltQuat
    {
        public new unsafe ref float x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltQuat_GetMutable_x(_Underlying *_this);
                return ref *__JoltQuat_GetMutable_x(_UnderlyingPtr);
            }
        }

        public new unsafe ref float y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltQuat_GetMutable_y(_Underlying *_this);
                return ref *__JoltQuat_GetMutable_y(_UnderlyingPtr);
            }
        }

        public new unsafe ref float z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltQuat_GetMutable_z(_Underlying *_this);
                return ref *__JoltQuat_GetMutable_z(_UnderlyingPtr);
            }
        }

        public new unsafe ref float w
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_GetMutable_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_GetMutable_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltQuat_GetMutable_w(_Underlying *_this);
                return ref *__JoltQuat_GetMutable_w(_UnderlyingPtr);
            }
        }

        internal unsafe JoltQuat(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltQuat() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltQuat_DefaultConstruct();
            _UnderlyingPtr = __JoltQuat_DefaultConstruct();
        }

        /// Generated from constructor `JoltQuat::JoltQuat`.
        public unsafe JoltQuat(Jolt.Const_JoltQuat _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltQuat_ConstructFromAnother(Jolt.JoltQuat._Underlying *_other);
            _UnderlyingPtr = __JoltQuat_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltQuat::JoltQuat`.
        public JoltQuat(JoltQuat _other) : this((Const_JoltQuat)_other) {}

        /// Generated from constructor `JoltQuat::JoltQuat`.
        public unsafe JoltQuat(float x, float y, float z, float w) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltQuat_Construct(float x, float y, float z, float w);
            _UnderlyingPtr = __JoltQuat_Construct(x, y, z, w);
        }

        /// Generated from method `JoltQuat::operator=`.
        public unsafe Jolt.JoltQuat Assign(Jolt.Const_JoltQuat _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltQuat_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltQuat_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltQuat_AssignFromAnother(_Underlying *_this, Jolt.JoltQuat._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltQuat_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltQuat` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltQuat`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltQuat`/`Const_JoltQuat` directly.
    public class _InOptMut_JoltQuat
    {
        public JoltQuat? Opt;

        public _InOptMut_JoltQuat() {}
        public _InOptMut_JoltQuat(JoltQuat value) {Opt = value;}
        public static implicit operator _InOptMut_JoltQuat(JoltQuat value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltQuat` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltQuat`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltQuat`/`Const_JoltQuat` to pass it to the function.
    public class _InOptConst_JoltQuat
    {
        public Const_JoltQuat? Opt;

        public _InOptConst_JoltQuat() {}
        public _InOptConst_JoltQuat(Const_JoltQuat value) {Opt = value;}
        public static implicit operator _InOptConst_JoltQuat(Const_JoltQuat value) {return new(value);}
    }

    /// Float-precision 4x4 column-major transform matrix.
    /// Columns: 0=right(x), 1=up(y), 2=forward(z), 3=translation.
    /// Generated from class `JoltMat44`.
    /// This is the const half of the class.
    public class Const_JoltMat44 : Jolt.Object<Const_JoltMat44>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMat44_Destroy(_Underlying *_this);
            __JoltMat44_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltMat44() {Dispose(false);}

        // column 0
        public unsafe float e00
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e00", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e00", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e00(_Underlying *_this);
                return *__JoltMat44_Get_e00(_UnderlyingPtr);
            }
        }

        // column 0
        public unsafe float e10
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e10(_Underlying *_this);
                return *__JoltMat44_Get_e10(_UnderlyingPtr);
            }
        }

        // column 0
        public unsafe float e20
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e20", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e20", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e20(_Underlying *_this);
                return *__JoltMat44_Get_e20(_UnderlyingPtr);
            }
        }

        // column 0
        public unsafe float e30
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e30", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e30", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e30(_Underlying *_this);
                return *__JoltMat44_Get_e30(_UnderlyingPtr);
            }
        }

        // column 1
        public unsafe float e01
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e01", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e01", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e01(_Underlying *_this);
                return *__JoltMat44_Get_e01(_UnderlyingPtr);
            }
        }

        // column 1
        public unsafe float e11
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e11", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e11", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e11(_Underlying *_this);
                return *__JoltMat44_Get_e11(_UnderlyingPtr);
            }
        }

        // column 1
        public unsafe float e21
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e21", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e21", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e21(_Underlying *_this);
                return *__JoltMat44_Get_e21(_UnderlyingPtr);
            }
        }

        // column 1
        public unsafe float e31
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e31", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e31", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e31(_Underlying *_this);
                return *__JoltMat44_Get_e31(_UnderlyingPtr);
            }
        }

        // column 2
        public unsafe float e02
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e02", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e02", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e02(_Underlying *_this);
                return *__JoltMat44_Get_e02(_UnderlyingPtr);
            }
        }

        // column 2
        public unsafe float e12
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e12(_Underlying *_this);
                return *__JoltMat44_Get_e12(_UnderlyingPtr);
            }
        }

        // column 2
        public unsafe float e22
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e22", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e22", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e22(_Underlying *_this);
                return *__JoltMat44_Get_e22(_UnderlyingPtr);
            }
        }

        // column 2
        public unsafe float e32
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e32(_Underlying *_this);
                return *__JoltMat44_Get_e32(_UnderlyingPtr);
            }
        }

        // column 3 (translation)
        public unsafe float e03
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e03", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e03", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e03(_Underlying *_this);
                return *__JoltMat44_Get_e03(_UnderlyingPtr);
            }
        }

        // column 3 (translation)
        public unsafe float e13
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e13", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e13", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e13(_Underlying *_this);
                return *__JoltMat44_Get_e13(_UnderlyingPtr);
            }
        }

        // column 3 (translation)
        public unsafe float e23
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e23", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e23", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e23(_Underlying *_this);
                return *__JoltMat44_Get_e23(_UnderlyingPtr);
            }
        }

        // column 3 (translation)
        public unsafe float e33
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Get_e33", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Get_e33", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_Get_e33(_Underlying *_this);
                return *__JoltMat44_Get_e33(_UnderlyingPtr);
            }
        }

        internal unsafe Const_JoltMat44(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltMat44() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMat44._Underlying *__JoltMat44_DefaultConstruct();
            _UnderlyingPtr = __JoltMat44_DefaultConstruct();
        }

        /// Generated from constructor `JoltMat44::JoltMat44`.
        public unsafe Const_JoltMat44(Jolt.Const_JoltMat44 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMat44._Underlying *__JoltMat44_ConstructFromAnother(Jolt.JoltMat44._Underlying *_other);
            _UnderlyingPtr = __JoltMat44_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltMat44::JoltMat44`.
        public Const_JoltMat44(JoltMat44 _other) : this((Const_JoltMat44)_other) {}

        /// Generated from method `JoltMat44::Identity`.
        public static unsafe Jolt.JoltMat44 Identity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_Identity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_Identity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMat44._Underlying *__JoltMat44_Identity();
            return new(__JoltMat44_Identity(), is_owning: true);
        }

        /// Generated from method `JoltMat44::GetTranslation`.
        public unsafe Jolt.JoltVec3f GetTranslation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltMat44_GetTranslation(_Underlying *_this);
            return new(__JoltMat44_GetTranslation(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltMat44::GetRotation`.
        public unsafe Jolt.JoltQuat GetRotation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltMat44_GetRotation(_Underlying *_this);
            return new(__JoltMat44_GetRotation(_UnderlyingPtr), is_owning: true);
        }
    }

    /// Float-precision 4x4 column-major transform matrix.
    /// Columns: 0=right(x), 1=up(y), 2=forward(z), 3=translation.
    /// Generated from class `JoltMat44`.
    /// This is the non-const half of the class.
    public class JoltMat44 : Const_JoltMat44
    {
        // column 0
        public new unsafe ref float e00
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e00", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e00", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e00(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e00(_UnderlyingPtr);
            }
        }

        // column 0
        public new unsafe ref float e10
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e10(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e10(_UnderlyingPtr);
            }
        }

        // column 0
        public new unsafe ref float e20
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e20", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e20", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e20(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e20(_UnderlyingPtr);
            }
        }

        // column 0
        public new unsafe ref float e30
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e30", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e30", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e30(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e30(_UnderlyingPtr);
            }
        }

        // column 1
        public new unsafe ref float e01
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e01", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e01", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e01(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e01(_UnderlyingPtr);
            }
        }

        // column 1
        public new unsafe ref float e11
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e11", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e11", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e11(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e11(_UnderlyingPtr);
            }
        }

        // column 1
        public new unsafe ref float e21
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e21", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e21", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e21(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e21(_UnderlyingPtr);
            }
        }

        // column 1
        public new unsafe ref float e31
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e31", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e31", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e31(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e31(_UnderlyingPtr);
            }
        }

        // column 2
        public new unsafe ref float e02
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e02", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e02", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e02(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e02(_UnderlyingPtr);
            }
        }

        // column 2
        public new unsafe ref float e12
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e12(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e12(_UnderlyingPtr);
            }
        }

        // column 2
        public new unsafe ref float e22
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e22", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e22", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e22(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e22(_UnderlyingPtr);
            }
        }

        // column 2
        public new unsafe ref float e32
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e32(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e32(_UnderlyingPtr);
            }
        }

        // column 3 (translation)
        public new unsafe ref float e03
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e03", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e03", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e03(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e03(_UnderlyingPtr);
            }
        }

        // column 3 (translation)
        public new unsafe ref float e13
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e13", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e13", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e13(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e13(_UnderlyingPtr);
            }
        }

        // column 3 (translation)
        public new unsafe ref float e23
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e23", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e23", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e23(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e23(_UnderlyingPtr);
            }
        }

        // column 3 (translation)
        public new unsafe ref float e33
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_GetMutable_e33", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_GetMutable_e33", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltMat44_GetMutable_e33(_Underlying *_this);
                return ref *__JoltMat44_GetMutable_e33(_UnderlyingPtr);
            }
        }

        internal unsafe JoltMat44(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltMat44() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMat44._Underlying *__JoltMat44_DefaultConstruct();
            _UnderlyingPtr = __JoltMat44_DefaultConstruct();
        }

        /// Generated from constructor `JoltMat44::JoltMat44`.
        public unsafe JoltMat44(Jolt.Const_JoltMat44 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMat44._Underlying *__JoltMat44_ConstructFromAnother(Jolt.JoltMat44._Underlying *_other);
            _UnderlyingPtr = __JoltMat44_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltMat44::JoltMat44`.
        public JoltMat44(JoltMat44 _other) : this((Const_JoltMat44)_other) {}

        /// Generated from method `JoltMat44::operator=`.
        public unsafe Jolt.JoltMat44 Assign(Jolt.Const_JoltMat44 _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMat44_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMat44_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMat44._Underlying *__JoltMat44_AssignFromAnother(_Underlying *_this, Jolt.JoltMat44._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltMat44_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltMat44` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltMat44`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltMat44`/`Const_JoltMat44` directly.
    public class _InOptMut_JoltMat44
    {
        public JoltMat44? Opt;

        public _InOptMut_JoltMat44() {}
        public _InOptMut_JoltMat44(JoltMat44 value) {Opt = value;}
        public static implicit operator _InOptMut_JoltMat44(JoltMat44 value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltMat44` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltMat44`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltMat44`/`Const_JoltMat44` to pass it to the function.
    public class _InOptConst_JoltMat44
    {
        public Const_JoltMat44? Opt;

        public _InOptConst_JoltMat44() {}
        public _InOptConst_JoltMat44(Const_JoltMat44 value) {Opt = value;}
        public static implicit operator _InOptConst_JoltMat44(Const_JoltMat44 value) {return new(value);}
    }

    /// Real-precision 4x4 transform: float 3x3 rotation + double translation.
    /// Columns 0-2 are the rotation axes (float); tx/ty/tz is world-space translation.
    /// Generated from class `JoltRMat44`.
    /// This is the const half of the class.
    public class Const_JoltRMat44 : Jolt.Object<Const_JoltRMat44>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltRMat44_Destroy(_Underlying *_this);
            __JoltRMat44_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltRMat44() {Dispose(false);}

        // column 0 (right)
        public unsafe float e00
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_e00", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_e00", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_Get_e00(_Underlying *_this);
                return *__JoltRMat44_Get_e00(_UnderlyingPtr);
            }
        }

        // column 0 (right)
        public unsafe float e10
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_e10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_e10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_Get_e10(_Underlying *_this);
                return *__JoltRMat44_Get_e10(_UnderlyingPtr);
            }
        }

        // column 0 (right)
        public unsafe float e20
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_e20", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_e20", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_Get_e20(_Underlying *_this);
                return *__JoltRMat44_Get_e20(_UnderlyingPtr);
            }
        }

        // column 1 (up)
        public unsafe float e01
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_e01", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_e01", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_Get_e01(_Underlying *_this);
                return *__JoltRMat44_Get_e01(_UnderlyingPtr);
            }
        }

        // column 1 (up)
        public unsafe float e11
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_e11", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_e11", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_Get_e11(_Underlying *_this);
                return *__JoltRMat44_Get_e11(_UnderlyingPtr);
            }
        }

        // column 1 (up)
        public unsafe float e21
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_e21", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_e21", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_Get_e21(_Underlying *_this);
                return *__JoltRMat44_Get_e21(_UnderlyingPtr);
            }
        }

        // column 2 (forward)
        public unsafe float e02
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_e02", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_e02", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_Get_e02(_Underlying *_this);
                return *__JoltRMat44_Get_e02(_UnderlyingPtr);
            }
        }

        // column 2 (forward)
        public unsafe float e12
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_e12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_e12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_Get_e12(_Underlying *_this);
                return *__JoltRMat44_Get_e12(_UnderlyingPtr);
            }
        }

        // column 2 (forward)
        public unsafe float e22
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_e22", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_e22", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_Get_e22(_Underlying *_this);
                return *__JoltRMat44_Get_e22(_UnderlyingPtr);
            }
        }

        // world-space translation
        public unsafe double tx
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_tx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_tx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltRMat44_Get_tx(_Underlying *_this);
                return *__JoltRMat44_Get_tx(_UnderlyingPtr);
            }
        }

        // world-space translation
        public unsafe double ty
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_ty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_ty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltRMat44_Get_ty(_Underlying *_this);
                return *__JoltRMat44_Get_ty(_UnderlyingPtr);
            }
        }

        // world-space translation
        public unsafe double tz
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Get_tz", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Get_tz", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltRMat44_Get_tz(_Underlying *_this);
                return *__JoltRMat44_Get_tz(_UnderlyingPtr);
            }
        }

        internal unsafe Const_JoltRMat44(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltRMat44() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRMat44._Underlying *__JoltRMat44_DefaultConstruct();
            _UnderlyingPtr = __JoltRMat44_DefaultConstruct();
        }

        /// Generated from constructor `JoltRMat44::JoltRMat44`.
        public unsafe Const_JoltRMat44(Jolt.Const_JoltRMat44 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRMat44._Underlying *__JoltRMat44_ConstructFromAnother(Jolt.JoltRMat44._Underlying *_other);
            _UnderlyingPtr = __JoltRMat44_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltRMat44::JoltRMat44`.
        public Const_JoltRMat44(JoltRMat44 _other) : this((Const_JoltRMat44)_other) {}

        /// Generated from method `JoltRMat44::Identity`.
        public static unsafe Jolt.JoltRMat44 Identity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_Identity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_Identity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRMat44._Underlying *__JoltRMat44_Identity();
            return new(__JoltRMat44_Identity(), is_owning: true);
        }

        /// Generated from method `JoltRMat44::GetTranslation`.
        public unsafe Jolt.JoltVec3 GetTranslation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltRMat44_GetTranslation(_Underlying *_this);
            return new(__JoltRMat44_GetTranslation(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltRMat44::GetTranslationF`.
        public unsafe Jolt.JoltVec3f GetTranslationF()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetTranslationF", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetTranslationF", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltRMat44_GetTranslationF(_Underlying *_this);
            return new(__JoltRMat44_GetTranslationF(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltRMat44::GetRotation`.
        public unsafe Jolt.JoltQuat GetRotation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltRMat44_GetRotation(_Underlying *_this);
            return new(__JoltRMat44_GetRotation(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltRMat44::ToMat44`.
        public unsafe Jolt.JoltMat44 ToMat44()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_ToMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_ToMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMat44._Underlying *__JoltRMat44_ToMat44(_Underlying *_this);
            return new(__JoltRMat44_ToMat44(_UnderlyingPtr), is_owning: true);
        }
    }

    /// Real-precision 4x4 transform: float 3x3 rotation + double translation.
    /// Columns 0-2 are the rotation axes (float); tx/ty/tz is world-space translation.
    /// Generated from class `JoltRMat44`.
    /// This is the non-const half of the class.
    public class JoltRMat44 : Const_JoltRMat44
    {
        // column 0 (right)
        public new unsafe ref float e00
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_e00", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_e00", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_GetMutable_e00(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_e00(_UnderlyingPtr);
            }
        }

        // column 0 (right)
        public new unsafe ref float e10
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_e10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_e10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_GetMutable_e10(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_e10(_UnderlyingPtr);
            }
        }

        // column 0 (right)
        public new unsafe ref float e20
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_e20", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_e20", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_GetMutable_e20(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_e20(_UnderlyingPtr);
            }
        }

        // column 1 (up)
        public new unsafe ref float e01
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_e01", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_e01", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_GetMutable_e01(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_e01(_UnderlyingPtr);
            }
        }

        // column 1 (up)
        public new unsafe ref float e11
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_e11", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_e11", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_GetMutable_e11(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_e11(_UnderlyingPtr);
            }
        }

        // column 1 (up)
        public new unsafe ref float e21
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_e21", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_e21", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_GetMutable_e21(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_e21(_UnderlyingPtr);
            }
        }

        // column 2 (forward)
        public new unsafe ref float e02
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_e02", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_e02", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_GetMutable_e02(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_e02(_UnderlyingPtr);
            }
        }

        // column 2 (forward)
        public new unsafe ref float e12
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_e12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_e12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_GetMutable_e12(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_e12(_UnderlyingPtr);
            }
        }

        // column 2 (forward)
        public new unsafe ref float e22
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_e22", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_e22", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JoltRMat44_GetMutable_e22(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_e22(_UnderlyingPtr);
            }
        }

        // world-space translation
        public new unsafe ref double tx
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_tx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_tx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltRMat44_GetMutable_tx(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_tx(_UnderlyingPtr);
            }
        }

        // world-space translation
        public new unsafe ref double ty
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_ty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_ty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltRMat44_GetMutable_ty(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_ty(_UnderlyingPtr);
            }
        }

        // world-space translation
        public new unsafe ref double tz
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_GetMutable_tz", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_GetMutable_tz", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltRMat44_GetMutable_tz(_Underlying *_this);
                return ref *__JoltRMat44_GetMutable_tz(_UnderlyingPtr);
            }
        }

        internal unsafe JoltRMat44(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltRMat44() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRMat44._Underlying *__JoltRMat44_DefaultConstruct();
            _UnderlyingPtr = __JoltRMat44_DefaultConstruct();
        }

        /// Generated from constructor `JoltRMat44::JoltRMat44`.
        public unsafe JoltRMat44(Jolt.Const_JoltRMat44 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRMat44._Underlying *__JoltRMat44_ConstructFromAnother(Jolt.JoltRMat44._Underlying *_other);
            _UnderlyingPtr = __JoltRMat44_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltRMat44::JoltRMat44`.
        public JoltRMat44(JoltRMat44 _other) : this((Const_JoltRMat44)_other) {}

        /// Generated from method `JoltRMat44::operator=`.
        public unsafe Jolt.JoltRMat44 Assign(Jolt.Const_JoltRMat44 _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRMat44_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRMat44_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRMat44._Underlying *__JoltRMat44_AssignFromAnother(_Underlying *_this, Jolt.JoltRMat44._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltRMat44_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltRMat44` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltRMat44`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltRMat44`/`Const_JoltRMat44` directly.
    public class _InOptMut_JoltRMat44
    {
        public JoltRMat44? Opt;

        public _InOptMut_JoltRMat44() {}
        public _InOptMut_JoltRMat44(JoltRMat44 value) {Opt = value;}
        public static implicit operator _InOptMut_JoltRMat44(JoltRMat44 value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltRMat44` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltRMat44`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltRMat44`/`Const_JoltRMat44` to pass it to the function.
    public class _InOptConst_JoltRMat44
    {
        public Const_JoltRMat44? Opt;

        public _InOptConst_JoltRMat44() {}
        public _InOptConst_JoltRMat44(Const_JoltRMat44 value) {Opt = value;}
        public static implicit operator _InOptConst_JoltRMat44(Const_JoltRMat44 value) {return new(value);}
    }

    /// World-space AABB (double-precision min/max).
    /// Generated from class `JoltAABox`.
    /// This is the const half of the class.
    public class Const_JoltAABox : Jolt.Object<Const_JoltAABox>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltAABox_Destroy(_Underlying *_this);
            __JoltAABox_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltAABox() {Dispose(false);}

        public unsafe double minX
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Get_minX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Get_minX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_Get_minX(_Underlying *_this);
                return *__JoltAABox_Get_minX(_UnderlyingPtr);
            }
        }

        public unsafe double minY
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Get_minY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Get_minY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_Get_minY(_Underlying *_this);
                return *__JoltAABox_Get_minY(_UnderlyingPtr);
            }
        }

        public unsafe double minZ
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Get_minZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Get_minZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_Get_minZ(_Underlying *_this);
                return *__JoltAABox_Get_minZ(_UnderlyingPtr);
            }
        }

        public unsafe double maxX
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Get_maxX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Get_maxX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_Get_maxX(_Underlying *_this);
                return *__JoltAABox_Get_maxX(_UnderlyingPtr);
            }
        }

        public unsafe double maxY
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Get_maxY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Get_maxY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_Get_maxY(_Underlying *_this);
                return *__JoltAABox_Get_maxY(_UnderlyingPtr);
            }
        }

        public unsafe double maxZ
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Get_maxZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Get_maxZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_Get_maxZ(_Underlying *_this);
                return *__JoltAABox_Get_maxZ(_UnderlyingPtr);
            }
        }

        internal unsafe Const_JoltAABox(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltAABox() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltAABox._Underlying *__JoltAABox_DefaultConstruct();
            _UnderlyingPtr = __JoltAABox_DefaultConstruct();
        }

        /// Generated from constructor `JoltAABox::JoltAABox`.
        public unsafe Const_JoltAABox(Jolt.Const_JoltAABox _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltAABox._Underlying *__JoltAABox_ConstructFromAnother(Jolt.JoltAABox._Underlying *_other);
            _UnderlyingPtr = __JoltAABox_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltAABox::JoltAABox`.
        public Const_JoltAABox(JoltAABox _other) : this((Const_JoltAABox)_other) {}

        /// Generated from constructor `JoltAABox::JoltAABox`.
        public unsafe Const_JoltAABox(double minX, double minY, double minZ, double maxX, double maxY, double maxZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltAABox._Underlying *__JoltAABox_Construct(double minX, double minY, double minZ, double maxX, double maxY, double maxZ);
            _UnderlyingPtr = __JoltAABox_Construct(minX, minY, minZ, maxX, maxY, maxZ);
        }

        /// Generated from method `JoltAABox::GetCenter`.
        public unsafe Jolt.JoltVec3 GetCenter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_GetCenter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_GetCenter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltAABox_GetCenter(_Underlying *_this);
            return new(__JoltAABox_GetCenter(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltAABox::GetExtent`.
        public unsafe Jolt.JoltVec3 GetExtent()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_GetExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_GetExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltAABox_GetExtent(_Underlying *_this);
            return new(__JoltAABox_GetExtent(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltAABox::Contains`.
        public unsafe bool Contains(double x, double y, double z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Contains", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Contains", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltAABox_Contains(_Underlying *_this, double x, double y, double z);
            return __JoltAABox_Contains(_UnderlyingPtr, x, y, z) != 0;
        }

        /// Generated from method `JoltAABox::Overlaps`.
        public unsafe bool Overlaps(Jolt.Const_JoltAABox other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Overlaps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Overlaps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltAABox_Overlaps(_Underlying *_this, Jolt.Const_JoltAABox._Underlying *other);
            return __JoltAABox_Overlaps(_UnderlyingPtr, other._UnderlyingPtr) != 0;
        }
    }

    /// World-space AABB (double-precision min/max).
    /// Generated from class `JoltAABox`.
    /// This is the non-const half of the class.
    public class JoltAABox : Const_JoltAABox
    {
        public new unsafe ref double minX
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_GetMutable_minX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_GetMutable_minX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_GetMutable_minX(_Underlying *_this);
                return ref *__JoltAABox_GetMutable_minX(_UnderlyingPtr);
            }
        }

        public new unsafe ref double minY
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_GetMutable_minY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_GetMutable_minY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_GetMutable_minY(_Underlying *_this);
                return ref *__JoltAABox_GetMutable_minY(_UnderlyingPtr);
            }
        }

        public new unsafe ref double minZ
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_GetMutable_minZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_GetMutable_minZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_GetMutable_minZ(_Underlying *_this);
                return ref *__JoltAABox_GetMutable_minZ(_UnderlyingPtr);
            }
        }

        public new unsafe ref double maxX
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_GetMutable_maxX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_GetMutable_maxX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_GetMutable_maxX(_Underlying *_this);
                return ref *__JoltAABox_GetMutable_maxX(_UnderlyingPtr);
            }
        }

        public new unsafe ref double maxY
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_GetMutable_maxY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_GetMutable_maxY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_GetMutable_maxY(_Underlying *_this);
                return ref *__JoltAABox_GetMutable_maxY(_UnderlyingPtr);
            }
        }

        public new unsafe ref double maxZ
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_GetMutable_maxZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_GetMutable_maxZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JoltAABox_GetMutable_maxZ(_Underlying *_this);
                return ref *__JoltAABox_GetMutable_maxZ(_UnderlyingPtr);
            }
        }

        internal unsafe JoltAABox(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltAABox() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltAABox._Underlying *__JoltAABox_DefaultConstruct();
            _UnderlyingPtr = __JoltAABox_DefaultConstruct();
        }

        /// Generated from constructor `JoltAABox::JoltAABox`.
        public unsafe JoltAABox(Jolt.Const_JoltAABox _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltAABox._Underlying *__JoltAABox_ConstructFromAnother(Jolt.JoltAABox._Underlying *_other);
            _UnderlyingPtr = __JoltAABox_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltAABox::JoltAABox`.
        public JoltAABox(JoltAABox _other) : this((Const_JoltAABox)_other) {}

        /// Generated from constructor `JoltAABox::JoltAABox`.
        public unsafe JoltAABox(double minX, double minY, double minZ, double maxX, double maxY, double maxZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltAABox._Underlying *__JoltAABox_Construct(double minX, double minY, double minZ, double maxX, double maxY, double maxZ);
            _UnderlyingPtr = __JoltAABox_Construct(minX, minY, minZ, maxX, maxY, maxZ);
        }

        /// Generated from method `JoltAABox::operator=`.
        public unsafe Jolt.JoltAABox Assign(Jolt.Const_JoltAABox _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltAABox._Underlying *__JoltAABox_AssignFromAnother(_Underlying *_this, Jolt.JoltAABox._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltAABox_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JoltAABox::Encapsulate`.
        public unsafe void Encapsulate(double x, double y, double z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltAABox_Encapsulate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltAABox_Encapsulate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltAABox_Encapsulate(_Underlying *_this, double x, double y, double z);
            __JoltAABox_Encapsulate(_UnderlyingPtr, x, y, z);
        }
    }

    /// This is used for optional parameters of class `JoltAABox` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltAABox`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltAABox`/`Const_JoltAABox` directly.
    public class _InOptMut_JoltAABox
    {
        public JoltAABox? Opt;

        public _InOptMut_JoltAABox() {}
        public _InOptMut_JoltAABox(JoltAABox value) {Opt = value;}
        public static implicit operator _InOptMut_JoltAABox(JoltAABox value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltAABox` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltAABox`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltAABox`/`Const_JoltAABox` to pass it to the function.
    public class _InOptConst_JoltAABox
    {
        public Const_JoltAABox? Opt;

        public _InOptConst_JoltAABox() {}
        public _InOptConst_JoltAABox(Const_JoltAABox value) {Opt = value;}
        public static implicit operator _InOptConst_JoltAABox(Const_JoltAABox value) {return new(value);}
    }

    /// Body collision group and sub-group IDs (no group filter = all collide).
    /// Generated from class `JoltCollisionGroup`.
    /// This is the const half of the class.
    public class Const_JoltCollisionGroup : Jolt.Object<Const_JoltCollisionGroup>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltCollisionGroup_Destroy(_Underlying *_this);
            __JoltCollisionGroup_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltCollisionGroup() {Dispose(false);}

        public static unsafe uint InvalidGroup
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_Get_InvalidGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_Get_InvalidGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltCollisionGroup_Get_InvalidGroup();
                return *__JoltCollisionGroup_Get_InvalidGroup();
            }
        }

        public static unsafe uint InvalidSubGroup
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_Get_InvalidSubGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_Get_InvalidSubGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltCollisionGroup_Get_InvalidSubGroup();
                return *__JoltCollisionGroup_Get_InvalidSubGroup();
            }
        }

        public unsafe uint groupID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_Get_groupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_Get_groupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltCollisionGroup_Get_groupID(_Underlying *_this);
                return *__JoltCollisionGroup_Get_groupID(_UnderlyingPtr);
            }
        }

        public unsafe uint subGroupID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_Get_subGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_Get_subGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltCollisionGroup_Get_subGroupID(_Underlying *_this);
                return *__JoltCollisionGroup_Get_subGroupID(_UnderlyingPtr);
            }
        }

        internal unsafe Const_JoltCollisionGroup(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltCollisionGroup() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCollisionGroup._Underlying *__JoltCollisionGroup_DefaultConstruct();
            _UnderlyingPtr = __JoltCollisionGroup_DefaultConstruct();
        }

        /// Generated from constructor `JoltCollisionGroup::JoltCollisionGroup`.
        public unsafe Const_JoltCollisionGroup(Jolt.Const_JoltCollisionGroup _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCollisionGroup._Underlying *__JoltCollisionGroup_ConstructFromAnother(Jolt.JoltCollisionGroup._Underlying *_other);
            _UnderlyingPtr = __JoltCollisionGroup_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltCollisionGroup::JoltCollisionGroup`.
        public Const_JoltCollisionGroup(JoltCollisionGroup _other) : this((Const_JoltCollisionGroup)_other) {}

        /// Generated from constructor `JoltCollisionGroup::JoltCollisionGroup`.
        public unsafe Const_JoltCollisionGroup(uint groupID, uint subGroupID) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCollisionGroup._Underlying *__JoltCollisionGroup_Construct(uint groupID, uint subGroupID);
            _UnderlyingPtr = __JoltCollisionGroup_Construct(groupID, subGroupID);
        }
    }

    /// Body collision group and sub-group IDs (no group filter = all collide).
    /// Generated from class `JoltCollisionGroup`.
    /// This is the non-const half of the class.
    public class JoltCollisionGroup : Const_JoltCollisionGroup
    {
        public new unsafe ref uint groupID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_GetMutable_groupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_GetMutable_groupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltCollisionGroup_GetMutable_groupID(_Underlying *_this);
                return ref *__JoltCollisionGroup_GetMutable_groupID(_UnderlyingPtr);
            }
        }

        public new unsafe ref uint subGroupID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_GetMutable_subGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_GetMutable_subGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltCollisionGroup_GetMutable_subGroupID(_Underlying *_this);
                return ref *__JoltCollisionGroup_GetMutable_subGroupID(_UnderlyingPtr);
            }
        }

        internal unsafe JoltCollisionGroup(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltCollisionGroup() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCollisionGroup._Underlying *__JoltCollisionGroup_DefaultConstruct();
            _UnderlyingPtr = __JoltCollisionGroup_DefaultConstruct();
        }

        /// Generated from constructor `JoltCollisionGroup::JoltCollisionGroup`.
        public unsafe JoltCollisionGroup(Jolt.Const_JoltCollisionGroup _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCollisionGroup._Underlying *__JoltCollisionGroup_ConstructFromAnother(Jolt.JoltCollisionGroup._Underlying *_other);
            _UnderlyingPtr = __JoltCollisionGroup_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltCollisionGroup::JoltCollisionGroup`.
        public JoltCollisionGroup(JoltCollisionGroup _other) : this((Const_JoltCollisionGroup)_other) {}

        /// Generated from constructor `JoltCollisionGroup::JoltCollisionGroup`.
        public unsafe JoltCollisionGroup(uint groupID, uint subGroupID) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCollisionGroup._Underlying *__JoltCollisionGroup_Construct(uint groupID, uint subGroupID);
            _UnderlyingPtr = __JoltCollisionGroup_Construct(groupID, subGroupID);
        }

        /// Generated from method `JoltCollisionGroup::operator=`.
        public unsafe Jolt.JoltCollisionGroup Assign(Jolt.Const_JoltCollisionGroup _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCollisionGroup_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCollisionGroup_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCollisionGroup._Underlying *__JoltCollisionGroup_AssignFromAnother(_Underlying *_this, Jolt.JoltCollisionGroup._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltCollisionGroup_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltCollisionGroup` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltCollisionGroup`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltCollisionGroup`/`Const_JoltCollisionGroup` directly.
    public class _InOptMut_JoltCollisionGroup
    {
        public JoltCollisionGroup? Opt;

        public _InOptMut_JoltCollisionGroup() {}
        public _InOptMut_JoltCollisionGroup(JoltCollisionGroup value) {Opt = value;}
        public static implicit operator _InOptMut_JoltCollisionGroup(JoltCollisionGroup value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltCollisionGroup` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltCollisionGroup`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltCollisionGroup`/`Const_JoltCollisionGroup` to pass it to the function.
    public class _InOptConst_JoltCollisionGroup
    {
        public Const_JoltCollisionGroup? Opt;

        public _InOptConst_JoltCollisionGroup() {}
        public _InOptConst_JoltCollisionGroup(Const_JoltCollisionGroup value) {Opt = value;}
        public static implicit operator _InOptConst_JoltCollisionGroup(Const_JoltCollisionGroup value) {return new(value);}
    }

    /// Non-owning handle to a JPH::PhysicsMaterial.
    /// Obtain via JoltBodyInterface::GetMaterial(). Do not outlive the physics system.
    /// Generated from class `JoltPhysicsMaterial`.
    /// This is the const half of the class.
    public class Const_JoltPhysicsMaterial : Jolt.Object<Const_JoltPhysicsMaterial>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsMaterial_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsMaterial_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsMaterial_Destroy(_Underlying *_this);
            __JoltPhysicsMaterial_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltPhysicsMaterial() {Dispose(false);}

        internal unsafe Const_JoltPhysicsMaterial(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltPhysicsMaterial() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsMaterial._Underlying *__JoltPhysicsMaterial_DefaultConstruct();
            _UnderlyingPtr = __JoltPhysicsMaterial_DefaultConstruct();
        }

        /// Generated from constructor `JoltPhysicsMaterial::JoltPhysicsMaterial`.
        public unsafe Const_JoltPhysicsMaterial(Jolt.Const_JoltPhysicsMaterial _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsMaterial_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsMaterial_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsMaterial._Underlying *__JoltPhysicsMaterial_ConstructFromAnother(Jolt.JoltPhysicsMaterial._Underlying *_other);
            _UnderlyingPtr = __JoltPhysicsMaterial_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltPhysicsMaterial::JoltPhysicsMaterial`.
        public Const_JoltPhysicsMaterial(JoltPhysicsMaterial _other) : this((Const_JoltPhysicsMaterial)_other) {}

        /// Generated from method `JoltPhysicsMaterial::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsMaterial_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsMaterial_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltPhysicsMaterial_IsValid(_Underlying *_this);
            return __JoltPhysicsMaterial_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltPhysicsMaterial::GetDebugName`.
        public unsafe byte? GetDebugName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsMaterial_GetDebugName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsMaterial_GetDebugName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__JoltPhysicsMaterial_GetDebugName(_Underlying *_this);
            var __c_ret = __JoltPhysicsMaterial_GetDebugName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }
    }

    /// Non-owning handle to a JPH::PhysicsMaterial.
    /// Obtain via JoltBodyInterface::GetMaterial(). Do not outlive the physics system.
    /// Generated from class `JoltPhysicsMaterial`.
    /// This is the non-const half of the class.
    public class JoltPhysicsMaterial : Const_JoltPhysicsMaterial
    {
        internal unsafe JoltPhysicsMaterial(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltPhysicsMaterial() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsMaterial._Underlying *__JoltPhysicsMaterial_DefaultConstruct();
            _UnderlyingPtr = __JoltPhysicsMaterial_DefaultConstruct();
        }

        /// Generated from constructor `JoltPhysicsMaterial::JoltPhysicsMaterial`.
        public unsafe JoltPhysicsMaterial(Jolt.Const_JoltPhysicsMaterial _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsMaterial_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsMaterial_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsMaterial._Underlying *__JoltPhysicsMaterial_ConstructFromAnother(Jolt.JoltPhysicsMaterial._Underlying *_other);
            _UnderlyingPtr = __JoltPhysicsMaterial_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltPhysicsMaterial::JoltPhysicsMaterial`.
        public JoltPhysicsMaterial(JoltPhysicsMaterial _other) : this((Const_JoltPhysicsMaterial)_other) {}

        /// Generated from method `JoltPhysicsMaterial::operator=`.
        public unsafe Jolt.JoltPhysicsMaterial Assign(Jolt.Const_JoltPhysicsMaterial _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsMaterial_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsMaterial_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsMaterial._Underlying *__JoltPhysicsMaterial_AssignFromAnother(_Underlying *_this, Jolt.JoltPhysicsMaterial._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltPhysicsMaterial_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltPhysicsMaterial` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltPhysicsMaterial`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltPhysicsMaterial`/`Const_JoltPhysicsMaterial` directly.
    public class _InOptMut_JoltPhysicsMaterial
    {
        public JoltPhysicsMaterial? Opt;

        public _InOptMut_JoltPhysicsMaterial() {}
        public _InOptMut_JoltPhysicsMaterial(JoltPhysicsMaterial value) {Opt = value;}
        public static implicit operator _InOptMut_JoltPhysicsMaterial(JoltPhysicsMaterial value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltPhysicsMaterial` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltPhysicsMaterial`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltPhysicsMaterial`/`Const_JoltPhysicsMaterial` to pass it to the function.
    public class _InOptConst_JoltPhysicsMaterial
    {
        public Const_JoltPhysicsMaterial? Opt;

        public _InOptConst_JoltPhysicsMaterial() {}
        public _InOptConst_JoltPhysicsMaterial(Const_JoltPhysicsMaterial value) {Opt = value;}
        public static implicit operator _InOptConst_JoltPhysicsMaterial(Const_JoltPhysicsMaterial value) {return new(value);}
    }

    /// Non-owning handle to a JPH::TwoBodyConstraint.
    /// Obtain via JoltPhysicsSystem::GetConstraintHandle() or JoltBodyInterface::ActivateConstraint().
    /// Generated from class `JoltTwoBodyConstraint`.
    /// This is the const half of the class.
    public class Const_JoltTwoBodyConstraint : Jolt.Object<Const_JoltTwoBodyConstraint>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTwoBodyConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTwoBodyConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltTwoBodyConstraint_Destroy(_Underlying *_this);
            __JoltTwoBodyConstraint_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltTwoBodyConstraint() {Dispose(false);}

        internal unsafe Const_JoltTwoBodyConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltTwoBodyConstraint() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTwoBodyConstraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTwoBodyConstraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTwoBodyConstraint._Underlying *__JoltTwoBodyConstraint_DefaultConstruct();
            _UnderlyingPtr = __JoltTwoBodyConstraint_DefaultConstruct();
        }

        /// Generated from constructor `JoltTwoBodyConstraint::JoltTwoBodyConstraint`.
        public unsafe Const_JoltTwoBodyConstraint(Jolt.Const_JoltTwoBodyConstraint _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTwoBodyConstraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTwoBodyConstraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTwoBodyConstraint._Underlying *__JoltTwoBodyConstraint_ConstructFromAnother(Jolt.JoltTwoBodyConstraint._Underlying *_other);
            _UnderlyingPtr = __JoltTwoBodyConstraint_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltTwoBodyConstraint::JoltTwoBodyConstraint`.
        public Const_JoltTwoBodyConstraint(JoltTwoBodyConstraint _other) : this((Const_JoltTwoBodyConstraint)_other) {}

        /// Generated from method `JoltTwoBodyConstraint::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTwoBodyConstraint_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTwoBodyConstraint_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltTwoBodyConstraint_IsValid(_Underlying *_this);
            return __JoltTwoBodyConstraint_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltTwoBodyConstraint::GetEnabled`.
        public unsafe bool GetEnabled()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTwoBodyConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTwoBodyConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltTwoBodyConstraint_GetEnabled(_Underlying *_this);
            return __JoltTwoBodyConstraint_GetEnabled(_UnderlyingPtr) != 0;
        }
    }

    /// Non-owning handle to a JPH::TwoBodyConstraint.
    /// Obtain via JoltPhysicsSystem::GetConstraintHandle() or JoltBodyInterface::ActivateConstraint().
    /// Generated from class `JoltTwoBodyConstraint`.
    /// This is the non-const half of the class.
    public class JoltTwoBodyConstraint : Const_JoltTwoBodyConstraint
    {
        internal unsafe JoltTwoBodyConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltTwoBodyConstraint() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTwoBodyConstraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTwoBodyConstraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTwoBodyConstraint._Underlying *__JoltTwoBodyConstraint_DefaultConstruct();
            _UnderlyingPtr = __JoltTwoBodyConstraint_DefaultConstruct();
        }

        /// Generated from constructor `JoltTwoBodyConstraint::JoltTwoBodyConstraint`.
        public unsafe JoltTwoBodyConstraint(Jolt.Const_JoltTwoBodyConstraint _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTwoBodyConstraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTwoBodyConstraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTwoBodyConstraint._Underlying *__JoltTwoBodyConstraint_ConstructFromAnother(Jolt.JoltTwoBodyConstraint._Underlying *_other);
            _UnderlyingPtr = __JoltTwoBodyConstraint_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltTwoBodyConstraint::JoltTwoBodyConstraint`.
        public JoltTwoBodyConstraint(JoltTwoBodyConstraint _other) : this((Const_JoltTwoBodyConstraint)_other) {}

        /// Generated from method `JoltTwoBodyConstraint::operator=`.
        public unsafe Jolt.JoltTwoBodyConstraint Assign(Jolt.Const_JoltTwoBodyConstraint _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTwoBodyConstraint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTwoBodyConstraint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTwoBodyConstraint._Underlying *__JoltTwoBodyConstraint_AssignFromAnother(_Underlying *_this, Jolt.JoltTwoBodyConstraint._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltTwoBodyConstraint_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JoltTwoBodyConstraint::SetEnabled`.
        public unsafe void SetEnabled(bool enabled)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTwoBodyConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTwoBodyConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltTwoBodyConstraint_SetEnabled(_Underlying *_this, byte enabled);
            __JoltTwoBodyConstraint_SetEnabled(_UnderlyingPtr, enabled ? (byte)1 : (byte)0);
        }
    }

    /// This is used for optional parameters of class `JoltTwoBodyConstraint` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltTwoBodyConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltTwoBodyConstraint`/`Const_JoltTwoBodyConstraint` directly.
    public class _InOptMut_JoltTwoBodyConstraint
    {
        public JoltTwoBodyConstraint? Opt;

        public _InOptMut_JoltTwoBodyConstraint() {}
        public _InOptMut_JoltTwoBodyConstraint(JoltTwoBodyConstraint value) {Opt = value;}
        public static implicit operator _InOptMut_JoltTwoBodyConstraint(JoltTwoBodyConstraint value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltTwoBodyConstraint` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltTwoBodyConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltTwoBodyConstraint`/`Const_JoltTwoBodyConstraint` to pass it to the function.
    public class _InOptConst_JoltTwoBodyConstraint
    {
        public Const_JoltTwoBodyConstraint? Opt;

        public _InOptConst_JoltTwoBodyConstraint() {}
        public _InOptConst_JoltTwoBodyConstraint(Const_JoltTwoBodyConstraint value) {Opt = value;}
        public static implicit operator _InOptConst_JoltTwoBodyConstraint(Const_JoltTwoBodyConstraint value) {return new(value);}
    }

    /// Opaque handle to a physics body.
    /// Generated from class `JoltBodyID`.
    /// This is the const half of the class.
    public class Const_JoltBodyID : Jolt.Object<Const_JoltBodyID>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyID_Destroy(_Underlying *_this);
            __JoltBodyID_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltBodyID() {Dispose(false);}

        public unsafe uint value
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_Get_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_Get_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltBodyID_Get_value(_Underlying *_this);
                return *__JoltBodyID_Get_value(_UnderlyingPtr);
            }
        }

        internal unsafe Const_JoltBodyID(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltBodyID() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyID_DefaultConstruct();
            _UnderlyingPtr = __JoltBodyID_DefaultConstruct();
        }

        /// Generated from constructor `JoltBodyID::JoltBodyID`.
        public unsafe Const_JoltBodyID(Jolt.Const_JoltBodyID _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyID_ConstructFromAnother(Jolt.JoltBodyID._Underlying *_other);
            _UnderlyingPtr = __JoltBodyID_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltBodyID::JoltBodyID`.
        public Const_JoltBodyID(JoltBodyID _other) : this((Const_JoltBodyID)_other) {}

        /// Generated from method `JoltBodyID::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltBodyID_IsValid(_Underlying *_this);
            return __JoltBodyID_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltBodyID::IsInvalid`.
        public unsafe bool IsInvalid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_IsInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_IsInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltBodyID_IsInvalid(_Underlying *_this);
            return __JoltBodyID_IsInvalid(_UnderlyingPtr) != 0;
        }
    }

    /// Opaque handle to a physics body.
    /// Generated from class `JoltBodyID`.
    /// This is the non-const half of the class.
    public class JoltBodyID : Const_JoltBodyID
    {
        public new unsafe ref uint value
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_GetMutable_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_GetMutable_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltBodyID_GetMutable_value(_Underlying *_this);
                return ref *__JoltBodyID_GetMutable_value(_UnderlyingPtr);
            }
        }

        internal unsafe JoltBodyID(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltBodyID() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyID_DefaultConstruct();
            _UnderlyingPtr = __JoltBodyID_DefaultConstruct();
        }

        /// Generated from constructor `JoltBodyID::JoltBodyID`.
        public unsafe JoltBodyID(Jolt.Const_JoltBodyID _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyID_ConstructFromAnother(Jolt.JoltBodyID._Underlying *_other);
            _UnderlyingPtr = __JoltBodyID_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltBodyID::JoltBodyID`.
        public JoltBodyID(JoltBodyID _other) : this((Const_JoltBodyID)_other) {}

        /// Generated from method `JoltBodyID::operator=`.
        public unsafe Jolt.JoltBodyID Assign(Jolt.Const_JoltBodyID _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyID_AssignFromAnother(_Underlying *_this, Jolt.JoltBodyID._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltBodyID_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltBodyID` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltBodyID`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBodyID`/`Const_JoltBodyID` directly.
    public class _InOptMut_JoltBodyID
    {
        public JoltBodyID? Opt;

        public _InOptMut_JoltBodyID() {}
        public _InOptMut_JoltBodyID(JoltBodyID value) {Opt = value;}
        public static implicit operator _InOptMut_JoltBodyID(JoltBodyID value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltBodyID` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltBodyID`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBodyID`/`Const_JoltBodyID` to pass it to the function.
    public class _InOptConst_JoltBodyID
    {
        public Const_JoltBodyID? Opt;

        public _InOptConst_JoltBodyID() {}
        public _InOptConst_JoltBodyID(Const_JoltBodyID value) {Opt = value;}
        public static implicit operator _InOptConst_JoltBodyID(Const_JoltBodyID value) {return new(value);}
    }

    /// Growable list of JoltBodyIDs. Used with batch add/remove on JoltBodyInterface.
    /// Generated from class `JoltBodyIDList`.
    /// This is the const half of the class.
    public class Const_JoltBodyIDList : Jolt.Object<Const_JoltBodyIDList>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyIDList_Destroy(_Underlying *_this);
            __JoltBodyIDList_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltBodyIDList() {Dispose(false);}

        internal unsafe Const_JoltBodyIDList(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltBodyIDList() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyIDList._Underlying *__JoltBodyIDList_DefaultConstruct();
            _UnderlyingPtr = __JoltBodyIDList_DefaultConstruct();
        }

        /// Generated from constructor `JoltBodyIDList::JoltBodyIDList`.
        public unsafe Const_JoltBodyIDList(Jolt.Const_JoltBodyIDList _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyIDList._Underlying *__JoltBodyIDList_ConstructFromAnother(Jolt.JoltBodyIDList._Underlying *_other);
            _UnderlyingPtr = __JoltBodyIDList_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltBodyIDList::JoltBodyIDList`.
        public Const_JoltBodyIDList(JoltBodyIDList _other) : this((Const_JoltBodyIDList)_other) {}

        /// Generated from method `JoltBodyIDList::Count`.
        public unsafe int Count()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_Count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_Count", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JoltBodyIDList_Count(_Underlying *_this);
            return __JoltBodyIDList_Count(_UnderlyingPtr);
        }

        /// Generated from method `JoltBodyIDList::Get`.
        public unsafe Jolt.JoltBodyID Get(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_Get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_Get", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyIDList_Get(_Underlying *_this, int index);
            return new(__JoltBodyIDList_Get(_UnderlyingPtr, index), is_owning: true);
        }
    }

    /// Growable list of JoltBodyIDs. Used with batch add/remove on JoltBodyInterface.
    /// Generated from class `JoltBodyIDList`.
    /// This is the non-const half of the class.
    public class JoltBodyIDList : Const_JoltBodyIDList
    {
        internal unsafe JoltBodyIDList(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltBodyIDList() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyIDList._Underlying *__JoltBodyIDList_DefaultConstruct();
            _UnderlyingPtr = __JoltBodyIDList_DefaultConstruct();
        }

        /// Generated from constructor `JoltBodyIDList::JoltBodyIDList`.
        public unsafe JoltBodyIDList(Jolt.Const_JoltBodyIDList _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyIDList._Underlying *__JoltBodyIDList_ConstructFromAnother(Jolt.JoltBodyIDList._Underlying *_other);
            _UnderlyingPtr = __JoltBodyIDList_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltBodyIDList::JoltBodyIDList`.
        public JoltBodyIDList(JoltBodyIDList _other) : this((Const_JoltBodyIDList)_other) {}

        /// Generated from method `JoltBodyIDList::operator=`.
        public unsafe Jolt.JoltBodyIDList Assign(Jolt.Const_JoltBodyIDList _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyIDList._Underlying *__JoltBodyIDList_AssignFromAnother(_Underlying *_this, Jolt.JoltBodyIDList._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltBodyIDList_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JoltBodyIDList::Add`.
        public unsafe void Add(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_Add", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_Add", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyIDList_Add(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltBodyIDList_Add(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyIDList::Clear`.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyIDList_Clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyIDList_Clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyIDList_Clear(_Underlying *_this);
            __JoltBodyIDList_Clear(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `JoltBodyIDList` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltBodyIDList`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBodyIDList`/`Const_JoltBodyIDList` directly.
    public class _InOptMut_JoltBodyIDList
    {
        public JoltBodyIDList? Opt;

        public _InOptMut_JoltBodyIDList() {}
        public _InOptMut_JoltBodyIDList(JoltBodyIDList value) {Opt = value;}
        public static implicit operator _InOptMut_JoltBodyIDList(JoltBodyIDList value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltBodyIDList` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltBodyIDList`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBodyIDList`/`Const_JoltBodyIDList` to pass it to the function.
    public class _InOptConst_JoltBodyIDList
    {
        public Const_JoltBodyIDList? Opt;

        public _InOptConst_JoltBodyIDList() {}
        public _InOptConst_JoltBodyIDList(Const_JoltBodyIDList value) {Opt = value;}
        public static implicit operator _InOptConst_JoltBodyIDList(Const_JoltBodyIDList value) {return new(value);}
    }

    /// Opaque handle to a constraint.
    /// Generated from class `JoltConstraintID`.
    /// This is the const half of the class.
    public class Const_JoltConstraintID : Jolt.Object<Const_JoltConstraintID>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConstraintID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConstraintID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltConstraintID_Destroy(_Underlying *_this);
            __JoltConstraintID_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltConstraintID() {Dispose(false);}

        public unsafe uint value
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConstraintID_Get_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConstraintID_Get_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltConstraintID_Get_value(_Underlying *_this);
                return *__JoltConstraintID_Get_value(_UnderlyingPtr);
            }
        }

        internal unsafe Const_JoltConstraintID(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltConstraintID() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConstraintID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConstraintID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConstraintID._Underlying *__JoltConstraintID_DefaultConstruct();
            _UnderlyingPtr = __JoltConstraintID_DefaultConstruct();
        }

        /// Generated from constructor `JoltConstraintID::JoltConstraintID`.
        public unsafe Const_JoltConstraintID(Jolt.Const_JoltConstraintID _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConstraintID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConstraintID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConstraintID._Underlying *__JoltConstraintID_ConstructFromAnother(Jolt.JoltConstraintID._Underlying *_other);
            _UnderlyingPtr = __JoltConstraintID_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltConstraintID::JoltConstraintID`.
        public Const_JoltConstraintID(JoltConstraintID _other) : this((Const_JoltConstraintID)_other) {}

        /// Generated from method `JoltConstraintID::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConstraintID_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConstraintID_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltConstraintID_IsValid(_Underlying *_this);
            return __JoltConstraintID_IsValid(_UnderlyingPtr) != 0;
        }
    }

    /// Opaque handle to a constraint.
    /// Generated from class `JoltConstraintID`.
    /// This is the non-const half of the class.
    public class JoltConstraintID : Const_JoltConstraintID
    {
        public new unsafe ref uint value
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConstraintID_GetMutable_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConstraintID_GetMutable_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JoltConstraintID_GetMutable_value(_Underlying *_this);
                return ref *__JoltConstraintID_GetMutable_value(_UnderlyingPtr);
            }
        }

        internal unsafe JoltConstraintID(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltConstraintID() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConstraintID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConstraintID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConstraintID._Underlying *__JoltConstraintID_DefaultConstruct();
            _UnderlyingPtr = __JoltConstraintID_DefaultConstruct();
        }

        /// Generated from constructor `JoltConstraintID::JoltConstraintID`.
        public unsafe JoltConstraintID(Jolt.Const_JoltConstraintID _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConstraintID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConstraintID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConstraintID._Underlying *__JoltConstraintID_ConstructFromAnother(Jolt.JoltConstraintID._Underlying *_other);
            _UnderlyingPtr = __JoltConstraintID_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltConstraintID::JoltConstraintID`.
        public JoltConstraintID(JoltConstraintID _other) : this((Const_JoltConstraintID)_other) {}

        /// Generated from method `JoltConstraintID::operator=`.
        public unsafe Jolt.JoltConstraintID Assign(Jolt.Const_JoltConstraintID _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConstraintID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConstraintID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConstraintID._Underlying *__JoltConstraintID_AssignFromAnother(_Underlying *_this, Jolt.JoltConstraintID._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltConstraintID_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltConstraintID` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltConstraintID`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltConstraintID`/`Const_JoltConstraintID` directly.
    public class _InOptMut_JoltConstraintID
    {
        public JoltConstraintID? Opt;

        public _InOptMut_JoltConstraintID() {}
        public _InOptMut_JoltConstraintID(JoltConstraintID value) {Opt = value;}
        public static implicit operator _InOptMut_JoltConstraintID(JoltConstraintID value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltConstraintID` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltConstraintID`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltConstraintID`/`Const_JoltConstraintID` to pass it to the function.
    public class _InOptConst_JoltConstraintID
    {
        public Const_JoltConstraintID? Opt;

        public _InOptConst_JoltConstraintID() {}
        public _InOptConst_JoltConstraintID(Const_JoltConstraintID value) {Opt = value;}
        public static implicit operator _InOptConst_JoltConstraintID(Const_JoltConstraintID value) {return new(value);}
    }

    /// Wraps JPH::BodyInterface. Obtain via JoltPhysicsSystem::GetBodyInterface().
    /// Generated from class `JoltBodyInterface`.
    /// This is the const half of the class.
    public class Const_JoltBodyInterface : Jolt.Object<Const_JoltBodyInterface>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_Destroy(_Underlying *_this);
            __JoltBodyInterface_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltBodyInterface() {Dispose(false);}

        internal unsafe Const_JoltBodyInterface(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltBodyInterface::JoltBodyInterface`.
        public unsafe Const_JoltBodyInterface(Jolt.Const_JoltBodyInterface _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyInterface._Underlying *__JoltBodyInterface_ConstructFromAnother(Jolt.JoltBodyInterface._Underlying *_other);
            _UnderlyingPtr = __JoltBodyInterface_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltBodyInterface::JoltBodyInterface`.
        public Const_JoltBodyInterface(JoltBodyInterface _other) : this((Const_JoltBodyInterface)_other) {}

        /// Generated from method `JoltBodyInterface::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltBodyInterface_IsValid(_Underlying *_this);
            return __JoltBodyInterface_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltBodyInterface::IsAdded`.
        public unsafe bool IsAdded(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_IsAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_IsAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltBodyInterface_IsAdded(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_IsAdded(_UnderlyingPtr, id._UnderlyingPtr) != 0;
        }

        /// Replace the shape on a body.
        /// updateMassProperties: recompute mass/inertia from new shape.
        /// Generated from method `JoltBodyInterface::SetShape`.
        public unsafe void SetShape(Jolt.Const_JoltBodyID id, Jolt.JoltShape? shape, bool updateMassProperties, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetShape(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, Jolt.JoltShape._Underlying *shape, byte updateMassProperties, int activation);
            __JoltBodyInterface_SetShape(_UnderlyingPtr, id._UnderlyingPtr, shape is not null ? shape._UnderlyingPtr : null, updateMassProperties ? (byte)1 : (byte)0, activation);
        }

        /// Notify systems that a MutableCompoundShape was changed in-place.
        /// prevComX/Y/Z: center of mass before the change.
        /// Generated from method `JoltBodyInterface::NotifyShapeChanged`.
        public unsafe void NotifyShapeChanged(Jolt.Const_JoltBodyID id, double prevComX, double prevComY, double prevComZ, bool updateMassProperties, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_NotifyShapeChanged(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double prevComX, double prevComY, double prevComZ, byte updateMassProperties, int activation);
            __JoltBodyInterface_NotifyShapeChanged(_UnderlyingPtr, id._UnderlyingPtr, prevComX, prevComY, prevComZ, updateMassProperties ? (byte)1 : (byte)0, activation);
        }

        /// Generated from method `JoltBodyInterface::GetPosition`.
        public unsafe Jolt.JoltVec3 GetPosition(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltBodyInterface_GetPosition(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetPosition(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::GetCenterOfMassPosition`.
        public unsafe Jolt.JoltVec3 GetCenterOfMassPosition(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltBodyInterface_GetCenterOfMassPosition(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetCenterOfMassPosition(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::GetRotation`.
        public unsafe Jolt.JoltQuat GetRotation(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltBodyInterface_GetRotation(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetRotation(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::GetPositionAndRotation`.
        public unsafe void GetPositionAndRotation(Jolt.Const_JoltBodyID id, Jolt.JoltVec3 outPosition, Jolt.JoltQuat outRotation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_GetPositionAndRotation(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, Jolt.JoltVec3._Underlying *outPosition, Jolt.JoltQuat._Underlying *outRotation);
            __JoltBodyInterface_GetPositionAndRotation(_UnderlyingPtr, id._UnderlyingPtr, outPosition._UnderlyingPtr, outRotation._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::GetLinearVelocity`.
        public unsafe Jolt.JoltVec3f GetLinearVelocity(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltBodyInterface_GetLinearVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetLinearVelocity(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::GetAngularVelocity`.
        public unsafe Jolt.JoltVec3f GetAngularVelocity(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltBodyInterface_GetAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::GetLinearAndAngularVelocity`.
        public unsafe void GetLinearAndAngularVelocity(Jolt.Const_JoltBodyID id, Jolt.JoltVec3f outLinear, Jolt.JoltVec3f outAngular)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_GetLinearAndAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, Jolt.JoltVec3f._Underlying *outLinear, Jolt.JoltVec3f._Underlying *outAngular);
            __JoltBodyInterface_GetLinearAndAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr, outLinear._UnderlyingPtr, outAngular._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::GetPointVelocity`.
        public unsafe Jolt.JoltVec3f GetPointVelocity(Jolt.Const_JoltBodyID id, double px, double py, double pz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltBodyInterface_GetPointVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double px, double py, double pz);
            return new(__JoltBodyInterface_GetPointVelocity(_UnderlyingPtr, id._UnderlyingPtr, px, py, pz), is_owning: true);
        }

        /// Returns JoltBodyType_RigidBody or JoltBodyType_SoftBody.
        /// Generated from method `JoltBodyInterface::GetBodyType`.
        public unsafe int GetBodyType(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetBodyType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetBodyType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JoltBodyInterface_GetBodyType(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetBodyType(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Returns JoltMotionType_*.
        /// Generated from method `JoltBodyInterface::GetMotionType`.
        public unsafe int GetMotionType(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JoltBodyInterface_GetMotionType(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetMotionType(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Returns JoltMotionQuality_*.
        /// Generated from method `JoltBodyInterface::GetMotionQuality`.
        public unsafe int GetMotionQuality(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JoltBodyInterface_GetMotionQuality(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetMotionQuality(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::GetObjectLayer`.
        public unsafe uint GetObjectLayer(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltBodyInterface_GetObjectLayer(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetObjectLayer(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::GetFriction`.
        public unsafe float GetFriction(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltBodyInterface_GetFriction(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetFriction(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::GetRestitution`.
        public unsafe float GetRestitution(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltBodyInterface_GetRestitution(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetRestitution(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::GetGravityFactor`.
        public unsafe float GetGravityFactor(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltBodyInterface_GetGravityFactor(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetGravityFactor(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::GetMaxLinearVelocity`.
        public unsafe float GetMaxLinearVelocity(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltBodyInterface_GetMaxLinearVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetMaxLinearVelocity(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::GetMaxAngularVelocity`.
        public unsafe float GetMaxAngularVelocity(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltBodyInterface_GetMaxAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetMaxAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::IsSensor`.
        public unsafe bool IsSensor(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_IsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_IsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltBodyInterface_IsSensor(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_IsSensor(_UnderlyingPtr, id._UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltBodyInterface::GetUseManifoldReduction`.
        public unsafe bool GetUseManifoldReduction(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltBodyInterface_GetUseManifoldReduction(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetUseManifoldReduction(_UnderlyingPtr, id._UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltBodyInterface::GetUserData`.
        public unsafe ulong GetUserData(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JoltBodyInterface_GetUserData(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_GetUserData(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::IsActive`.
        public unsafe bool IsActive(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltBodyInterface_IsActive(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltBodyInterface_IsActive(_UnderlyingPtr, id._UnderlyingPtr) != 0;
        }

        // ---- Transforms ----------------------------------------------------------
        /// Generated from method `JoltBodyInterface::GetWorldTransform`.
        public unsafe Jolt.JoltRMat44 GetWorldTransform(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRMat44._Underlying *__JoltBodyInterface_GetWorldTransform(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetWorldTransform(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::GetCenterOfMassTransform`.
        public unsafe Jolt.JoltRMat44 GetCenterOfMassTransform(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRMat44._Underlying *__JoltBodyInterface_GetCenterOfMassTransform(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetCenterOfMassTransform(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::GetInverseInertia`.
        public unsafe Jolt.JoltMat44 GetInverseInertia(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMat44._Underlying *__JoltBodyInterface_GetInverseInertia(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetInverseInertia(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::GetCollisionGroup`.
        public unsafe Jolt.JoltCollisionGroup GetCollisionGroup(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCollisionGroup._Underlying *__JoltBodyInterface_GetCollisionGroup(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetCollisionGroup(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Get the material for the body's root sub-shape (works for simple, non-compound shapes).
        /// Generated from method `JoltBodyInterface::GetMaterial`.
        public unsafe Jolt.JoltPhysicsMaterial GetMaterial(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsMaterial._Underlying *__JoltBodyInterface_GetMaterial(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltBodyInterface_GetMaterial(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }
    }

    /// Wraps JPH::BodyInterface. Obtain via JoltPhysicsSystem::GetBodyInterface().
    /// Generated from class `JoltBodyInterface`.
    /// This is the non-const half of the class.
    public class JoltBodyInterface : Const_JoltBodyInterface
    {
        internal unsafe JoltBodyInterface(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltBodyInterface::JoltBodyInterface`.
        public unsafe JoltBodyInterface(Jolt.Const_JoltBodyInterface _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyInterface._Underlying *__JoltBodyInterface_ConstructFromAnother(Jolt.JoltBodyInterface._Underlying *_other);
            _UnderlyingPtr = __JoltBodyInterface_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltBodyInterface::JoltBodyInterface`.
        public JoltBodyInterface(JoltBodyInterface _other) : this((Const_JoltBodyInterface)_other) {}

        /// Generated from method `JoltBodyInterface::operator=`.
        public unsafe Jolt.JoltBodyInterface Assign(Jolt.Const_JoltBodyInterface _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyInterface._Underlying *__JoltBodyInterface_AssignFromAnother(_Underlying *_this, Jolt.JoltBodyInterface._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltBodyInterface_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Create a body but do not add it to the simulation yet.
        /// Returns an invalid ID when out of bodies.
        /// Generated from method `JoltBodyInterface::CreateBody`.
        public unsafe Jolt.JoltBodyID CreateBody(Jolt.JoltBodyCreationSettings? settings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_CreateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_CreateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyInterface_CreateBody(_Underlying *_this, Jolt.JoltBodyCreationSettings._Underlying *settings);
            return new(__JoltBodyInterface_CreateBody(_UnderlyingPtr, settings is not null ? settings._UnderlyingPtr : null), is_owning: true);
        }

        /// Create a body with a specific ID (for deterministic/replicated simulations).
        /// Returns an invalid ID when the body ID is invalid or already in use.
        /// Generated from method `JoltBodyInterface::CreateBodyWithID`.
        public unsafe Jolt.JoltBodyID CreateBodyWithID(Jolt.Const_JoltBodyID targetID, Jolt.JoltBodyCreationSettings? settings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_CreateBodyWithID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_CreateBodyWithID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyInterface_CreateBodyWithID(_Underlying *_this, Jolt.JoltBodyID._Underlying *targetID, Jolt.JoltBodyCreationSettings._Underlying *settings);
            return new(__JoltBodyInterface_CreateBodyWithID(_UnderlyingPtr, targetID._UnderlyingPtr, settings is not null ? settings._UnderlyingPtr : null), is_owning: true);
        }

        /// Create a body and immediately add it to the simulation.
        /// Generated from method `JoltBodyInterface::CreateAndAddBody`.
        public unsafe Jolt.JoltBodyID CreateAndAddBody(Jolt.JoltBodyCreationSettings? settings, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_CreateAndAddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_CreateAndAddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyInterface_CreateAndAddBody(_Underlying *_this, Jolt.JoltBodyCreationSettings._Underlying *settings, int activation);
            return new(__JoltBodyInterface_CreateAndAddBody(_UnderlyingPtr, settings is not null ? settings._UnderlyingPtr : null, activation), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::AddBody`.
        public unsafe void AddBody(Jolt.Const_JoltBodyID id, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, int activation);
            __JoltBodyInterface_AddBody(_UnderlyingPtr, id._UnderlyingPtr, activation);
        }

        /// Generated from method `JoltBodyInterface::RemoveBody`.
        public unsafe void RemoveBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_RemoveBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_RemoveBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_RemoveBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltBodyInterface_RemoveBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Destroy a body that has already been removed from the simulation.
        /// Generated from method `JoltBodyInterface::DestroyBody`.
        public unsafe void DestroyBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_DestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_DestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_DestroyBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltBodyInterface_DestroyBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Remove and destroy in one call.
        /// Generated from method `JoltBodyInterface::RemoveAndDestroyBody`.
        public unsafe void RemoveAndDestroyBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_RemoveAndDestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_RemoveAndDestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_RemoveAndDestroyBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltBodyInterface_RemoveAndDestroyBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Prepare adding bodies in batch; safe to call from a background thread.
        /// Returns an opaque state handle — pass to AddBodiesFinalize or AddBodiesAbort.
        /// The JoltBodyIDList must remain unmodified until Finalize/Abort is called.
        /// Generated from method `JoltBodyInterface::AddBodiesPrepare`.
        /// Returns a mutable pointer.
        public unsafe void *AddBodiesPrepare(Jolt.JoltBodyIDList? bodies)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddBodiesPrepare", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddBodiesPrepare", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltBodyInterface_AddBodiesPrepare(_Underlying *_this, Jolt.JoltBodyIDList._Underlying *bodies);
            return __JoltBodyInterface_AddBodiesPrepare(_UnderlyingPtr, bodies is not null ? bodies._UnderlyingPtr : null);
        }

        /// Finalize a batch add; atomically inserts all bodies into the simulation.
        /// Generated from method `JoltBodyInterface::AddBodiesFinalize`.
        /// Parameter `addState` is a mutable pointer.
        public unsafe void AddBodiesFinalize(Jolt.JoltBodyIDList? bodies, void *addState, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddBodiesFinalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddBodiesFinalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddBodiesFinalize(_Underlying *_this, Jolt.JoltBodyIDList._Underlying *bodies, void *addState, int activation);
            __JoltBodyInterface_AddBodiesFinalize(_UnderlyingPtr, bodies is not null ? bodies._UnderlyingPtr : null, addState, activation);
        }

        /// Abort a prepared batch add without inserting bodies.
        /// Generated from method `JoltBodyInterface::AddBodiesAbort`.
        /// Parameter `addState` is a mutable pointer.
        public unsafe void AddBodiesAbort(Jolt.JoltBodyIDList? bodies, void *addState)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddBodiesAbort", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddBodiesAbort", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddBodiesAbort(_Underlying *_this, Jolt.JoltBodyIDList._Underlying *bodies, void *addState);
            __JoltBodyInterface_AddBodiesAbort(_UnderlyingPtr, bodies is not null ? bodies._UnderlyingPtr : null, addState);
        }

        /// Remove multiple bodies from the simulation in one call.
        /// Generated from method `JoltBodyInterface::RemoveBodies`.
        public unsafe void RemoveBodies(Jolt.JoltBodyIDList? bodies)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_RemoveBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_RemoveBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_RemoveBodies(_Underlying *_this, Jolt.JoltBodyIDList._Underlying *bodies);
            __JoltBodyInterface_RemoveBodies(_UnderlyingPtr, bodies is not null ? bodies._UnderlyingPtr : null);
        }

        /// Destroy multiple bodies (must all be removed from the simulation first).
        /// Generated from method `JoltBodyInterface::DestroyBodies`.
        public unsafe void DestroyBodies(Jolt.JoltBodyIDList? bodies)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_DestroyBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_DestroyBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_DestroyBodies(_Underlying *_this, Jolt.JoltBodyIDList._Underlying *bodies);
            __JoltBodyInterface_DestroyBodies(_UnderlyingPtr, bodies is not null ? bodies._UnderlyingPtr : null);
        }

        // ---- Position / rotation -------------------------------------------------
        /// Generated from method `JoltBodyInterface::SetPosition`.
        public unsafe void SetPosition(Jolt.Const_JoltBodyID id, double x, double y, double z, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetPosition(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double x, double y, double z, int activation);
            __JoltBodyInterface_SetPosition(_UnderlyingPtr, id._UnderlyingPtr, x, y, z, activation);
        }

        /// Generated from method `JoltBodyInterface::SetRotation`.
        public unsafe void SetRotation(Jolt.Const_JoltBodyID id, float qx, float qy, float qz, float qw, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetRotation(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float qx, float qy, float qz, float qw, int activation);
            __JoltBodyInterface_SetRotation(_UnderlyingPtr, id._UnderlyingPtr, qx, qy, qz, qw, activation);
        }

        /// Generated from method `JoltBodyInterface::SetPositionAndRotation`.
        public unsafe void SetPositionAndRotation(Jolt.Const_JoltBodyID id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetPositionAndRotation(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation);
            __JoltBodyInterface_SetPositionAndRotation(_UnderlyingPtr, id._UnderlyingPtr, x, y, z, qx, qy, qz, qw, activation);
        }

        /// Like SetPositionAndRotation but only updates when the change is above a small threshold.
        /// Generated from method `JoltBodyInterface::SetPositionAndRotationWhenChanged`.
        public unsafe void SetPositionAndRotationWhenChanged(Jolt.Const_JoltBodyID id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetPositionAndRotationWhenChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetPositionAndRotationWhenChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetPositionAndRotationWhenChanged(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation);
            __JoltBodyInterface_SetPositionAndRotationWhenChanged(_UnderlyingPtr, id._UnderlyingPtr, x, y, z, qx, qy, qz, qw, activation);
        }

        /// Generated from method `JoltBodyInterface::MoveKinematic`.
        public unsafe void MoveKinematic(Jolt.Const_JoltBodyID id, double x, double y, double z, float qx, float qy, float qz, float qw, float deltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_MoveKinematic(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double x, double y, double z, float qx, float qy, float qz, float qw, float deltaTime);
            __JoltBodyInterface_MoveKinematic(_UnderlyingPtr, id._UnderlyingPtr, x, y, z, qx, qy, qz, qw, deltaTime);
        }

        /// Generated from method `JoltBodyInterface::SetPositionRotationAndVelocity`.
        public unsafe void SetPositionRotationAndVelocity(Jolt.Const_JoltBodyID id, double x, double y, double z, float qx, float qy, float qz, float qw, float lvx, float lvy, float lvz, float avx, float avy, float avz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetPositionRotationAndVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetPositionRotationAndVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetPositionRotationAndVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double x, double y, double z, float qx, float qy, float qz, float qw, float lvx, float lvy, float lvz, float avx, float avy, float avz);
            __JoltBodyInterface_SetPositionRotationAndVelocity(_UnderlyingPtr, id._UnderlyingPtr, x, y, z, qx, qy, qz, qw, lvx, lvy, lvz, avx, avy, avz);
        }

        // ---- Velocity ------------------------------------------------------------
        /// Generated from method `JoltBodyInterface::SetLinearVelocity`.
        public unsafe void SetLinearVelocity(Jolt.Const_JoltBodyID id, float vx, float vy, float vz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetLinearVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float vx, float vy, float vz);
            __JoltBodyInterface_SetLinearVelocity(_UnderlyingPtr, id._UnderlyingPtr, vx, vy, vz);
        }

        /// Generated from method `JoltBodyInterface::AddLinearVelocity`.
        public unsafe void AddLinearVelocity(Jolt.Const_JoltBodyID id, float vx, float vy, float vz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddLinearVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float vx, float vy, float vz);
            __JoltBodyInterface_AddLinearVelocity(_UnderlyingPtr, id._UnderlyingPtr, vx, vy, vz);
        }

        /// Generated from method `JoltBodyInterface::SetAngularVelocity`.
        public unsafe void SetAngularVelocity(Jolt.Const_JoltBodyID id, float vx, float vy, float vz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float vx, float vy, float vz);
            __JoltBodyInterface_SetAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr, vx, vy, vz);
        }

        /// Generated from method `JoltBodyInterface::SetLinearAndAngularVelocity`.
        public unsafe void SetLinearAndAngularVelocity(Jolt.Const_JoltBodyID id, float lvx, float lvy, float lvz, float avx, float avy, float avz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetLinearAndAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float lvx, float lvy, float lvz, float avx, float avy, float avz);
            __JoltBodyInterface_SetLinearAndAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr, lvx, lvy, lvz, avx, avy, avz);
        }

        /// Generated from method `JoltBodyInterface::AddLinearAndAngularVelocity`.
        public unsafe void AddLinearAndAngularVelocity(Jolt.Const_JoltBodyID id, float lvx, float lvy, float lvz, float avx, float avy, float avz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddLinearAndAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float lvx, float lvy, float lvz, float avx, float avy, float avz);
            __JoltBodyInterface_AddLinearAndAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr, lvx, lvy, lvz, avx, avy, avz);
        }

        // ---- Forces / impulses ---------------------------------------------------
        /// Generated from method `JoltBodyInterface::AddForce`.
        public unsafe void AddForce(Jolt.Const_JoltBodyID id, float fx, float fy, float fz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddForce(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float fx, float fy, float fz);
            __JoltBodyInterface_AddForce(_UnderlyingPtr, id._UnderlyingPtr, fx, fy, fz);
        }

        /// Generated from method `JoltBodyInterface::AddForceAtPosition`.
        public unsafe void AddForceAtPosition(Jolt.Const_JoltBodyID id, float fx, float fy, float fz, double px, double py, double pz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddForceAtPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddForceAtPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddForceAtPosition(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float fx, float fy, float fz, double px, double py, double pz);
            __JoltBodyInterface_AddForceAtPosition(_UnderlyingPtr, id._UnderlyingPtr, fx, fy, fz, px, py, pz);
        }

        /// Generated from method `JoltBodyInterface::AddTorque`.
        public unsafe void AddTorque(Jolt.Const_JoltBodyID id, float tx, float ty, float tz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddTorque(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float tx, float ty, float tz);
            __JoltBodyInterface_AddTorque(_UnderlyingPtr, id._UnderlyingPtr, tx, ty, tz);
        }

        /// Generated from method `JoltBodyInterface::AddForceAndTorque`.
        public unsafe void AddForceAndTorque(Jolt.Const_JoltBodyID id, float fx, float fy, float fz, float tx, float ty, float tz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddForceAndTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddForceAndTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddForceAndTorque(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float fx, float fy, float fz, float tx, float ty, float tz);
            __JoltBodyInterface_AddForceAndTorque(_UnderlyingPtr, id._UnderlyingPtr, fx, fy, fz, tx, ty, tz);
        }

        /// Generated from method `JoltBodyInterface::AddImpulse`.
        public unsafe void AddImpulse(Jolt.Const_JoltBodyID id, float ix, float iy, float iz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddImpulse(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float ix, float iy, float iz);
            __JoltBodyInterface_AddImpulse(_UnderlyingPtr, id._UnderlyingPtr, ix, iy, iz);
        }

        /// Generated from method `JoltBodyInterface::AddImpulseAtPosition`.
        public unsafe void AddImpulseAtPosition(Jolt.Const_JoltBodyID id, float ix, float iy, float iz, double px, double py, double pz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddImpulseAtPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddImpulseAtPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddImpulseAtPosition(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float ix, float iy, float iz, double px, double py, double pz);
            __JoltBodyInterface_AddImpulseAtPosition(_UnderlyingPtr, id._UnderlyingPtr, ix, iy, iz, px, py, pz);
        }

        /// Generated from method `JoltBodyInterface::AddAngularImpulse`.
        public unsafe void AddAngularImpulse(Jolt.Const_JoltBodyID id, float ix, float iy, float iz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_AddAngularImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_AddAngularImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_AddAngularImpulse(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float ix, float iy, float iz);
            __JoltBodyInterface_AddAngularImpulse(_UnderlyingPtr, id._UnderlyingPtr, ix, iy, iz);
        }

        /// Apply a buoyancy impulse. Returns true when the body is in the fluid.
        /// surfaceNX/Y/Z: world-space surface normal pointing away from fluid.
        /// fluidVX/Y/Z: velocity of the fluid (usually zero for still water).
        /// gravX/Y/Z: gravity vector (e.g. 0,-9.81,0).
        /// Generated from method `JoltBodyInterface::ApplyBuoyancyImpulse`.
        public unsafe bool ApplyBuoyancyImpulse(Jolt.Const_JoltBodyID id, double surfacePosX, double surfacePosY, double surfacePosZ, float surfaceNX, float surfaceNY, float surfaceNZ, float buoyancy, float linearDrag, float angularDrag, float fluidVX, float fluidVY, float fluidVZ, float gravX, float gravY, float gravZ, float deltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_ApplyBuoyancyImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_ApplyBuoyancyImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltBodyInterface_ApplyBuoyancyImpulse(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double surfacePosX, double surfacePosY, double surfacePosZ, float surfaceNX, float surfaceNY, float surfaceNZ, float buoyancy, float linearDrag, float angularDrag, float fluidVX, float fluidVY, float fluidVZ, float gravX, float gravY, float gravZ, float deltaTime);
            return __JoltBodyInterface_ApplyBuoyancyImpulse(_UnderlyingPtr, id._UnderlyingPtr, surfacePosX, surfacePosY, surfacePosZ, surfaceNX, surfaceNY, surfaceNZ, buoyancy, linearDrag, angularDrag, fluidVX, fluidVY, fluidVZ, gravX, gravY, gravZ, deltaTime) != 0;
        }

        /// Generated from method `JoltBodyInterface::SetMotionType`.
        public unsafe void SetMotionType(Jolt.Const_JoltBodyID id, int motionType, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetMotionType(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, int motionType, int activation);
            __JoltBodyInterface_SetMotionType(_UnderlyingPtr, id._UnderlyingPtr, motionType, activation);
        }

        /// Generated from method `JoltBodyInterface::SetMotionQuality`.
        public unsafe void SetMotionQuality(Jolt.Const_JoltBodyID id, int motionQuality)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetMotionQuality(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, int motionQuality);
            __JoltBodyInterface_SetMotionQuality(_UnderlyingPtr, id._UnderlyingPtr, motionQuality);
        }

        /// Generated from method `JoltBodyInterface::SetObjectLayer`.
        public unsafe void SetObjectLayer(Jolt.Const_JoltBodyID id, uint layer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetObjectLayer(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, uint layer);
            __JoltBodyInterface_SetObjectLayer(_UnderlyingPtr, id._UnderlyingPtr, layer);
        }

        /// Generated from method `JoltBodyInterface::SetFriction`.
        public unsafe void SetFriction(Jolt.Const_JoltBodyID id, float friction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetFriction(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float friction);
            __JoltBodyInterface_SetFriction(_UnderlyingPtr, id._UnderlyingPtr, friction);
        }

        /// Generated from method `JoltBodyInterface::SetRestitution`.
        public unsafe void SetRestitution(Jolt.Const_JoltBodyID id, float restitution)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetRestitution(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float restitution);
            __JoltBodyInterface_SetRestitution(_UnderlyingPtr, id._UnderlyingPtr, restitution);
        }

        /// Generated from method `JoltBodyInterface::SetGravityFactor`.
        public unsafe void SetGravityFactor(Jolt.Const_JoltBodyID id, float factor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetGravityFactor(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float factor);
            __JoltBodyInterface_SetGravityFactor(_UnderlyingPtr, id._UnderlyingPtr, factor);
        }

        /// Generated from method `JoltBodyInterface::SetMaxLinearVelocity`.
        public unsafe void SetMaxLinearVelocity(Jolt.Const_JoltBodyID id, float v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetMaxLinearVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float v);
            __JoltBodyInterface_SetMaxLinearVelocity(_UnderlyingPtr, id._UnderlyingPtr, v);
        }

        /// Generated from method `JoltBodyInterface::SetMaxAngularVelocity`.
        public unsafe void SetMaxAngularVelocity(Jolt.Const_JoltBodyID id, float v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetMaxAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float v);
            __JoltBodyInterface_SetMaxAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr, v);
        }

        /// Generated from method `JoltBodyInterface::SetIsSensor`.
        public unsafe void SetIsSensor(Jolt.Const_JoltBodyID id, bool isSensor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetIsSensor(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, byte isSensor);
            __JoltBodyInterface_SetIsSensor(_UnderlyingPtr, id._UnderlyingPtr, isSensor ? (byte)1 : (byte)0);
        }

        /// Generated from method `JoltBodyInterface::SetUseManifoldReduction`.
        public unsafe void SetUseManifoldReduction(Jolt.Const_JoltBodyID id, bool useReduction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetUseManifoldReduction(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, byte useReduction);
            __JoltBodyInterface_SetUseManifoldReduction(_UnderlyingPtr, id._UnderlyingPtr, useReduction ? (byte)1 : (byte)0);
        }

        /// Generated from method `JoltBodyInterface::SetUserData`.
        public unsafe void SetUserData(Jolt.Const_JoltBodyID id, ulong userData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetUserData(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, ulong userData);
            __JoltBodyInterface_SetUserData(_UnderlyingPtr, id._UnderlyingPtr, userData);
        }

        // ---- Activation ----------------------------------------------------------
        /// Generated from method `JoltBodyInterface::ActivateBody`.
        public unsafe void ActivateBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_ActivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_ActivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_ActivateBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltBodyInterface_ActivateBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::ActivateBodies`.
        public unsafe void ActivateBodies(Jolt.JoltBodyIDList? bodies)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_ActivateBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_ActivateBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_ActivateBodies(_Underlying *_this, Jolt.JoltBodyIDList._Underlying *bodies);
            __JoltBodyInterface_ActivateBodies(_UnderlyingPtr, bodies is not null ? bodies._UnderlyingPtr : null);
        }

        /// Generated from method `JoltBodyInterface::DeactivateBody`.
        public unsafe void DeactivateBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_DeactivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_DeactivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_DeactivateBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltBodyInterface_DeactivateBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltBodyInterface::DeactivateBodies`.
        public unsafe void DeactivateBodies(Jolt.JoltBodyIDList? bodies)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_DeactivateBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_DeactivateBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_DeactivateBodies(_Underlying *_this, Jolt.JoltBodyIDList._Underlying *bodies);
            __JoltBodyInterface_DeactivateBodies(_UnderlyingPtr, bodies is not null ? bodies._UnderlyingPtr : null);
        }

        /// Generated from method `JoltBodyInterface::ResetSleepTimer`.
        public unsafe void ResetSleepTimer(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_ResetSleepTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_ResetSleepTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_ResetSleepTimer(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltBodyInterface_ResetSleepTimer(_UnderlyingPtr, id._UnderlyingPtr);
        }

        // ---- Misc ----------------------------------------------------------------
        /// Generated from method `JoltBodyInterface::InvalidateContactCache`.
        public unsafe void InvalidateContactCache(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_InvalidateContactCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_InvalidateContactCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_InvalidateContactCache(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltBodyInterface_InvalidateContactCache(_UnderlyingPtr, id._UnderlyingPtr);
        }

        // ---- Collision group -----------------------------------------------------
        /// Generated from method `JoltBodyInterface::SetCollisionGroup`.
        public unsafe void SetCollisionGroup(Jolt.Const_JoltBodyID id, Jolt.Const_JoltCollisionGroup group)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_SetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_SetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_SetCollisionGroup(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, Jolt.Const_JoltCollisionGroup._Underlying *group);
            __JoltBodyInterface_SetCollisionGroup(_UnderlyingPtr, id._UnderlyingPtr, group._UnderlyingPtr);
        }

        /// Activate all bodies whose bounding box overlaps box, across all object layers.
        /// Generated from method `JoltBodyInterface::ActivateBodiesInAABox`.
        public unsafe void ActivateBodiesInAABox(Jolt.Const_JoltAABox box)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_ActivateBodiesInAABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_ActivateBodiesInAABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_ActivateBodiesInAABox(_Underlying *_this, Jolt.Const_JoltAABox._Underlying *box);
            __JoltBodyInterface_ActivateBodiesInAABox(_UnderlyingPtr, box._UnderlyingPtr);
        }

        /// Activate non-static bodies attached to a constraint.
        /// Generated from method `JoltBodyInterface::ActivateConstraint`.
        public unsafe void ActivateConstraint(Jolt.Const_JoltTwoBodyConstraint constraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_ActivateConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_ActivateConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyInterface_ActivateConstraint(_Underlying *_this, Jolt.Const_JoltTwoBodyConstraint._Underlying *constraint);
            __JoltBodyInterface_ActivateConstraint(_UnderlyingPtr, constraint._UnderlyingPtr);
        }

        // ---- Soft body -----------------------------------------------------------
        /// Generated from method `JoltBodyInterface::CreateSoftBody`.
        public unsafe Jolt.JoltBodyID CreateSoftBody(Jolt.JoltSoftBodyCreationSettings? settings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_CreateSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_CreateSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyInterface_CreateSoftBody(_Underlying *_this, Jolt.JoltSoftBodyCreationSettings._Underlying *settings);
            return new(__JoltBodyInterface_CreateSoftBody(_UnderlyingPtr, settings is not null ? settings._UnderlyingPtr : null), is_owning: true);
        }

        /// Generated from method `JoltBodyInterface::CreateAndAddSoftBody`.
        public unsafe Jolt.JoltBodyID CreateAndAddSoftBody(Jolt.JoltSoftBodyCreationSettings? settings, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyInterface_CreateAndAddSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyInterface_CreateAndAddSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltBodyInterface_CreateAndAddSoftBody(_Underlying *_this, Jolt.JoltSoftBodyCreationSettings._Underlying *settings, int activation);
            return new(__JoltBodyInterface_CreateAndAddSoftBody(_UnderlyingPtr, settings is not null ? settings._UnderlyingPtr : null, activation), is_owning: true);
        }
    }

    /// This is used for optional parameters of class `JoltBodyInterface` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltBodyInterface`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBodyInterface`/`Const_JoltBodyInterface` directly.
    public class _InOptMut_JoltBodyInterface
    {
        public JoltBodyInterface? Opt;

        public _InOptMut_JoltBodyInterface() {}
        public _InOptMut_JoltBodyInterface(JoltBodyInterface value) {Opt = value;}
        public static implicit operator _InOptMut_JoltBodyInterface(JoltBodyInterface value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltBodyInterface` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltBodyInterface`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBodyInterface`/`Const_JoltBodyInterface` to pass it to the function.
    public class _InOptConst_JoltBodyInterface
    {
        public Const_JoltBodyInterface? Opt;

        public _InOptConst_JoltBodyInterface() {}
        public _InOptConst_JoltBodyInterface(Const_JoltBodyInterface value) {Opt = value;}
        public static implicit operator _InOptConst_JoltBodyInterface(Const_JoltBodyInterface value) {return new(value);}
    }

    /// Base class for all collision shapes.
    /// Shapes are ref-counted; call Release() when you no longer need the handle.
    /// Generated from class `JoltShape`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JoltBoxShape`
    ///     `JoltCapsuleShape`
    ///     `JoltConvexHullShape`
    ///     `JoltCylinderShape`
    ///     `JoltEmptyShape`
    ///     `JoltHeightFieldShape`
    ///     `JoltMeshShape`
    ///     `JoltMutableCompoundShape`
    ///     `JoltOffsetCenterOfMassShape`
    ///     `JoltPlaneShape`
    ///     `JoltRotatedTranslatedShape`
    ///     `JoltScaledShape`
    ///     `JoltSphereShape`
    ///     `JoltStaticCompoundShape`
    ///     `JoltTaperedCapsuleShape`
    ///     `JoltTaperedCylinderShape`
    ///     `JoltTriangleShape`
    /// This is the const half of the class.
    public class Const_JoltShape : Jolt.Object<Const_JoltShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltShape_Destroy(_Underlying *_this);
            __JoltShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltShape() {Dispose(false);}

        internal unsafe Const_JoltShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltShape::JoltShape`.
        public unsafe Const_JoltShape(Jolt._ByValue_JoltShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltShape._Underlying *_other);
            _UnderlyingPtr = __JoltShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltShape::JoltShape`.
        public Const_JoltShape(Const_JoltShape _other) : this(new _ByValue_JoltShape(_other)) {}

        /// Generated from constructor `JoltShape::JoltShape`.
        public Const_JoltShape(JoltShape _other) : this((Const_JoltShape)_other) {}

        /// Generated from method `JoltShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltShape_IsValid(_Underlying *_this);
            return __JoltShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltShape_getHandle(_Underlying *_this);
            return __JoltShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Base class for all collision shapes.
    /// Shapes are ref-counted; call Release() when you no longer need the handle.
    /// Generated from class `JoltShape`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JoltBoxShape`
    ///     `JoltCapsuleShape`
    ///     `JoltConvexHullShape`
    ///     `JoltCylinderShape`
    ///     `JoltEmptyShape`
    ///     `JoltHeightFieldShape`
    ///     `JoltMeshShape`
    ///     `JoltMutableCompoundShape`
    ///     `JoltOffsetCenterOfMassShape`
    ///     `JoltPlaneShape`
    ///     `JoltRotatedTranslatedShape`
    ///     `JoltScaledShape`
    ///     `JoltSphereShape`
    ///     `JoltStaticCompoundShape`
    ///     `JoltTaperedCapsuleShape`
    ///     `JoltTaperedCylinderShape`
    ///     `JoltTriangleShape`
    /// This is the non-const half of the class.
    public class JoltShape : Const_JoltShape
    {
        internal unsafe JoltShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltShape::JoltShape`.
        public unsafe JoltShape(Jolt._ByValue_JoltShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltShape._Underlying *_other);
            _UnderlyingPtr = __JoltShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltShape::JoltShape`.
        public JoltShape(Const_JoltShape _other) : this(new _ByValue_JoltShape(_other)) {}

        /// Generated from constructor `JoltShape::JoltShape`.
        public JoltShape(JoltShape _other) : this((Const_JoltShape)_other) {}

        /// Generated from method `JoltShape::operator=`.
        public unsafe Jolt.JoltShape Assign(Jolt._ByValue_JoltShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltShape_Release(_Underlying *_this);
            __JoltShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltShape`/`Const_JoltShape` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltShape(Const_JoltShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltShape(Const_JoltShape arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltShape`/`Const_JoltShape` directly.
    public class _InOptMut_JoltShape
    {
        public JoltShape? Opt;

        public _InOptMut_JoltShape() {}
        public _InOptMut_JoltShape(JoltShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltShape(JoltShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltShape`/`Const_JoltShape` to pass it to the function.
    public class _InOptConst_JoltShape
    {
        public Const_JoltShape? Opt;

        public _InOptConst_JoltShape() {}
        public _InOptConst_JoltShape(Const_JoltShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltShape(Const_JoltShape value) {return new(value);}
    }

    /// Axis-aligned box shape.
    /// Generated from class `JoltBoxShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltBoxShape : Jolt.Object<Const_JoltBoxShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBoxShape_Destroy(_Underlying *_this);
            __JoltBoxShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltBoxShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltBoxShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltBoxShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltBoxShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltBoxShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltBoxShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltBoxShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public unsafe Const_JoltBoxShape(Jolt._ByValue_JoltBoxShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBoxShape._Underlying *__JoltBoxShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltBoxShape._Underlying *_other);
            _UnderlyingPtr = __JoltBoxShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public Const_JoltBoxShape(Const_JoltBoxShape _other) : this(new _ByValue_JoltBoxShape(_other)) {}

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public Const_JoltBoxShape(JoltBoxShape _other) : this((Const_JoltBoxShape)_other) {}

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public unsafe Const_JoltBoxShape(double halfX, double halfY, double halfZ, float convexRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBoxShape._Underlying *__JoltBoxShape_Construct_4(double halfX, double halfY, double halfZ, float convexRadius);
            _UnderlyingPtr = __JoltBoxShape_Construct_4(halfX, halfY, halfZ, convexRadius);
        }

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public unsafe Const_JoltBoxShape(double halfX, double halfY, double halfZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBoxShape._Underlying *__JoltBoxShape_Construct_3(double halfX, double halfY, double halfZ);
            _UnderlyingPtr = __JoltBoxShape_Construct_3(halfX, halfY, halfZ);
        }

        /// Generated from method `JoltBoxShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltBoxShape_IsValid(_Underlying *_this);
            return __JoltBoxShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltBoxShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltBoxShape_getHandle(_Underlying *_this);
            return __JoltBoxShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Axis-aligned box shape.
    /// Generated from class `JoltBoxShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltBoxShape : Const_JoltBoxShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltBoxShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltBoxShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltBoxShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltBoxShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltBoxShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltBoxShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public unsafe JoltBoxShape(Jolt._ByValue_JoltBoxShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBoxShape._Underlying *__JoltBoxShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltBoxShape._Underlying *_other);
            _UnderlyingPtr = __JoltBoxShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public JoltBoxShape(Const_JoltBoxShape _other) : this(new _ByValue_JoltBoxShape(_other)) {}

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public JoltBoxShape(JoltBoxShape _other) : this((Const_JoltBoxShape)_other) {}

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public unsafe JoltBoxShape(double halfX, double halfY, double halfZ, float convexRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBoxShape._Underlying *__JoltBoxShape_Construct_4(double halfX, double halfY, double halfZ, float convexRadius);
            _UnderlyingPtr = __JoltBoxShape_Construct_4(halfX, halfY, halfZ, convexRadius);
        }

        /// Generated from constructor `JoltBoxShape::JoltBoxShape`.
        public unsafe JoltBoxShape(double halfX, double halfY, double halfZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBoxShape._Underlying *__JoltBoxShape_Construct_3(double halfX, double halfY, double halfZ);
            _UnderlyingPtr = __JoltBoxShape_Construct_3(halfX, halfY, halfZ);
        }

        /// Generated from method `JoltBoxShape::operator=`.
        public unsafe Jolt.JoltBoxShape Assign(Jolt._ByValue_JoltBoxShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBoxShape._Underlying *__JoltBoxShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltBoxShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltBoxShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltBoxShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBoxShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBoxShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBoxShape_Release(_Underlying *_this);
            __JoltBoxShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltBoxShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltBoxShape`/`Const_JoltBoxShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltBoxShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltBoxShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltBoxShape(Const_JoltBoxShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltBoxShape(Const_JoltBoxShape arg) {return new(arg);}
        public _ByValue_JoltBoxShape(Jolt._Moved<JoltBoxShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltBoxShape(Jolt._Moved<JoltBoxShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltBoxShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltBoxShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBoxShape`/`Const_JoltBoxShape` directly.
    public class _InOptMut_JoltBoxShape
    {
        public JoltBoxShape? Opt;

        public _InOptMut_JoltBoxShape() {}
        public _InOptMut_JoltBoxShape(JoltBoxShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltBoxShape(JoltBoxShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltBoxShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltBoxShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBoxShape`/`Const_JoltBoxShape` to pass it to the function.
    public class _InOptConst_JoltBoxShape
    {
        public Const_JoltBoxShape? Opt;

        public _InOptConst_JoltBoxShape() {}
        public _InOptConst_JoltBoxShape(Const_JoltBoxShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltBoxShape(Const_JoltBoxShape value) {return new(value);}
    }

    /// Sphere shape.
    /// Generated from class `JoltSphereShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltSphereShape : Jolt.Object<Const_JoltSphereShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSphereShape_Destroy(_Underlying *_this);
            __JoltSphereShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltSphereShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltSphereShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltSphereShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltSphereShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltSphereShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltSphereShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltSphereShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltSphereShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltSphereShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public unsafe Const_JoltSphereShape(Jolt._ByValue_JoltSphereShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSphereShape._Underlying *__JoltSphereShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltSphereShape._Underlying *_other);
            _UnderlyingPtr = __JoltSphereShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public Const_JoltSphereShape(Const_JoltSphereShape _other) : this(new _ByValue_JoltSphereShape(_other)) {}

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public Const_JoltSphereShape(JoltSphereShape _other) : this((Const_JoltSphereShape)_other) {}

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public unsafe Const_JoltSphereShape(float radius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSphereShape._Underlying *__JoltSphereShape_Construct(float radius);
            _UnderlyingPtr = __JoltSphereShape_Construct(radius);
        }

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public static unsafe implicit operator Const_JoltSphereShape(float radius) {return new(radius);}

        /// Generated from method `JoltSphereShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltSphereShape_IsValid(_Underlying *_this);
            return __JoltSphereShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltSphereShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltSphereShape_getHandle(_Underlying *_this);
            return __JoltSphereShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Sphere shape.
    /// Generated from class `JoltSphereShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltSphereShape : Const_JoltSphereShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltSphereShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltSphereShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltSphereShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltSphereShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltSphereShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltSphereShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltSphereShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltSphereShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public unsafe JoltSphereShape(Jolt._ByValue_JoltSphereShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSphereShape._Underlying *__JoltSphereShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltSphereShape._Underlying *_other);
            _UnderlyingPtr = __JoltSphereShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public JoltSphereShape(Const_JoltSphereShape _other) : this(new _ByValue_JoltSphereShape(_other)) {}

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public JoltSphereShape(JoltSphereShape _other) : this((Const_JoltSphereShape)_other) {}

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public unsafe JoltSphereShape(float radius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSphereShape._Underlying *__JoltSphereShape_Construct(float radius);
            _UnderlyingPtr = __JoltSphereShape_Construct(radius);
        }

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public static unsafe implicit operator JoltSphereShape(float radius) {return new(radius);}

        /// Generated from method `JoltSphereShape::operator=`.
        public unsafe Jolt.JoltSphereShape Assign(Jolt._ByValue_JoltSphereShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSphereShape._Underlying *__JoltSphereShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltSphereShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltSphereShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltSphereShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSphereShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSphereShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSphereShape_Release(_Underlying *_this);
            __JoltSphereShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltSphereShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltSphereShape`/`Const_JoltSphereShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltSphereShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltSphereShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltSphereShape(Const_JoltSphereShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltSphereShape(Const_JoltSphereShape arg) {return new(arg);}
        public _ByValue_JoltSphereShape(Jolt._Moved<JoltSphereShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltSphereShape(Jolt._Moved<JoltSphereShape> arg) {return new(arg);}

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public static unsafe implicit operator _ByValue_JoltSphereShape(float radius) {return new Jolt._Moved<Jolt.JoltSphereShape>(radius);}
    }

    /// This is used for optional parameters of class `JoltSphereShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltSphereShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltSphereShape`/`Const_JoltSphereShape` directly.
    public class _InOptMut_JoltSphereShape
    {
        public JoltSphereShape? Opt;

        public _InOptMut_JoltSphereShape() {}
        public _InOptMut_JoltSphereShape(JoltSphereShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltSphereShape(JoltSphereShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltSphereShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltSphereShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltSphereShape`/`Const_JoltSphereShape` to pass it to the function.
    public class _InOptConst_JoltSphereShape
    {
        public Const_JoltSphereShape? Opt;

        public _InOptConst_JoltSphereShape() {}
        public _InOptConst_JoltSphereShape(Const_JoltSphereShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltSphereShape(Const_JoltSphereShape value) {return new(value);}

        /// Generated from constructor `JoltSphereShape::JoltSphereShape`.
        public static unsafe implicit operator _InOptConst_JoltSphereShape(float radius) {return new Const_JoltSphereShape(radius);}
    }

    /// Capsule shape (cylinder with hemispherical caps).  halfHeight is the
    /// half-height of the cylinder part only (total body height = 2*(halfHeight+radius)).
    /// Generated from class `JoltCapsuleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltCapsuleShape : Jolt.Object<Const_JoltCapsuleShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltCapsuleShape_Destroy(_Underlying *_this);
            __JoltCapsuleShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltCapsuleShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltCapsuleShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltCapsuleShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltCapsuleShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltCapsuleShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltCapsuleShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltCapsuleShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
        public unsafe Const_JoltCapsuleShape(Jolt._ByValue_JoltCapsuleShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCapsuleShape._Underlying *__JoltCapsuleShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltCapsuleShape._Underlying *_other);
            _UnderlyingPtr = __JoltCapsuleShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
        public Const_JoltCapsuleShape(Const_JoltCapsuleShape _other) : this(new _ByValue_JoltCapsuleShape(_other)) {}

        /// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
        public Const_JoltCapsuleShape(JoltCapsuleShape _other) : this((Const_JoltCapsuleShape)_other) {}

        /// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
        public unsafe Const_JoltCapsuleShape(float halfHeight, float radius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCapsuleShape._Underlying *__JoltCapsuleShape_Construct(float halfHeight, float radius);
            _UnderlyingPtr = __JoltCapsuleShape_Construct(halfHeight, radius);
        }

        /// Generated from method `JoltCapsuleShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltCapsuleShape_IsValid(_Underlying *_this);
            return __JoltCapsuleShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltCapsuleShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltCapsuleShape_getHandle(_Underlying *_this);
            return __JoltCapsuleShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Capsule shape (cylinder with hemispherical caps).  halfHeight is the
    /// half-height of the cylinder part only (total body height = 2*(halfHeight+radius)).
    /// Generated from class `JoltCapsuleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltCapsuleShape : Const_JoltCapsuleShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltCapsuleShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltCapsuleShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltCapsuleShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltCapsuleShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltCapsuleShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltCapsuleShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
        public unsafe JoltCapsuleShape(Jolt._ByValue_JoltCapsuleShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCapsuleShape._Underlying *__JoltCapsuleShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltCapsuleShape._Underlying *_other);
            _UnderlyingPtr = __JoltCapsuleShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
        public JoltCapsuleShape(Const_JoltCapsuleShape _other) : this(new _ByValue_JoltCapsuleShape(_other)) {}

        /// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
        public JoltCapsuleShape(JoltCapsuleShape _other) : this((Const_JoltCapsuleShape)_other) {}

        /// Generated from constructor `JoltCapsuleShape::JoltCapsuleShape`.
        public unsafe JoltCapsuleShape(float halfHeight, float radius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCapsuleShape._Underlying *__JoltCapsuleShape_Construct(float halfHeight, float radius);
            _UnderlyingPtr = __JoltCapsuleShape_Construct(halfHeight, radius);
        }

        /// Generated from method `JoltCapsuleShape::operator=`.
        public unsafe Jolt.JoltCapsuleShape Assign(Jolt._ByValue_JoltCapsuleShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCapsuleShape._Underlying *__JoltCapsuleShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltCapsuleShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltCapsuleShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltCapsuleShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCapsuleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCapsuleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltCapsuleShape_Release(_Underlying *_this);
            __JoltCapsuleShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltCapsuleShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltCapsuleShape`/`Const_JoltCapsuleShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltCapsuleShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltCapsuleShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltCapsuleShape(Const_JoltCapsuleShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltCapsuleShape(Const_JoltCapsuleShape arg) {return new(arg);}
        public _ByValue_JoltCapsuleShape(Jolt._Moved<JoltCapsuleShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltCapsuleShape(Jolt._Moved<JoltCapsuleShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltCapsuleShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltCapsuleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltCapsuleShape`/`Const_JoltCapsuleShape` directly.
    public class _InOptMut_JoltCapsuleShape
    {
        public JoltCapsuleShape? Opt;

        public _InOptMut_JoltCapsuleShape() {}
        public _InOptMut_JoltCapsuleShape(JoltCapsuleShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltCapsuleShape(JoltCapsuleShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltCapsuleShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltCapsuleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltCapsuleShape`/`Const_JoltCapsuleShape` to pass it to the function.
    public class _InOptConst_JoltCapsuleShape
    {
        public Const_JoltCapsuleShape? Opt;

        public _InOptConst_JoltCapsuleShape() {}
        public _InOptConst_JoltCapsuleShape(Const_JoltCapsuleShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltCapsuleShape(Const_JoltCapsuleShape value) {return new(value);}
    }

    /// Upright cylinder shape.
    /// Generated from class `JoltCylinderShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltCylinderShape : Jolt.Object<Const_JoltCylinderShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltCylinderShape_Destroy(_Underlying *_this);
            __JoltCylinderShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltCylinderShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltCylinderShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltCylinderShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltCylinderShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltCylinderShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltCylinderShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltCylinderShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltCylinderShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public unsafe Const_JoltCylinderShape(Jolt._ByValue_JoltCylinderShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCylinderShape._Underlying *__JoltCylinderShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltCylinderShape._Underlying *_other);
            _UnderlyingPtr = __JoltCylinderShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public Const_JoltCylinderShape(Const_JoltCylinderShape _other) : this(new _ByValue_JoltCylinderShape(_other)) {}

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public Const_JoltCylinderShape(JoltCylinderShape _other) : this((Const_JoltCylinderShape)_other) {}

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public unsafe Const_JoltCylinderShape(float halfHeight, float radius, float convexRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCylinderShape._Underlying *__JoltCylinderShape_Construct_3(float halfHeight, float radius, float convexRadius);
            _UnderlyingPtr = __JoltCylinderShape_Construct_3(halfHeight, radius, convexRadius);
        }

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public unsafe Const_JoltCylinderShape(float halfHeight, float radius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCylinderShape._Underlying *__JoltCylinderShape_Construct_2(float halfHeight, float radius);
            _UnderlyingPtr = __JoltCylinderShape_Construct_2(halfHeight, radius);
        }

        /// Generated from method `JoltCylinderShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltCylinderShape_IsValid(_Underlying *_this);
            return __JoltCylinderShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltCylinderShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltCylinderShape_getHandle(_Underlying *_this);
            return __JoltCylinderShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Upright cylinder shape.
    /// Generated from class `JoltCylinderShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltCylinderShape : Const_JoltCylinderShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltCylinderShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltCylinderShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltCylinderShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltCylinderShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltCylinderShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltCylinderShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltCylinderShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public unsafe JoltCylinderShape(Jolt._ByValue_JoltCylinderShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCylinderShape._Underlying *__JoltCylinderShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltCylinderShape._Underlying *_other);
            _UnderlyingPtr = __JoltCylinderShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public JoltCylinderShape(Const_JoltCylinderShape _other) : this(new _ByValue_JoltCylinderShape(_other)) {}

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public JoltCylinderShape(JoltCylinderShape _other) : this((Const_JoltCylinderShape)_other) {}

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public unsafe JoltCylinderShape(float halfHeight, float radius, float convexRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCylinderShape._Underlying *__JoltCylinderShape_Construct_3(float halfHeight, float radius, float convexRadius);
            _UnderlyingPtr = __JoltCylinderShape_Construct_3(halfHeight, radius, convexRadius);
        }

        /// Generated from constructor `JoltCylinderShape::JoltCylinderShape`.
        public unsafe JoltCylinderShape(float halfHeight, float radius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCylinderShape._Underlying *__JoltCylinderShape_Construct_2(float halfHeight, float radius);
            _UnderlyingPtr = __JoltCylinderShape_Construct_2(halfHeight, radius);
        }

        /// Generated from method `JoltCylinderShape::operator=`.
        public unsafe Jolt.JoltCylinderShape Assign(Jolt._ByValue_JoltCylinderShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltCylinderShape._Underlying *__JoltCylinderShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltCylinderShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltCylinderShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltCylinderShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltCylinderShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltCylinderShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltCylinderShape_Release(_Underlying *_this);
            __JoltCylinderShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltCylinderShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltCylinderShape`/`Const_JoltCylinderShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltCylinderShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltCylinderShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltCylinderShape(Const_JoltCylinderShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltCylinderShape(Const_JoltCylinderShape arg) {return new(arg);}
        public _ByValue_JoltCylinderShape(Jolt._Moved<JoltCylinderShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltCylinderShape(Jolt._Moved<JoltCylinderShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltCylinderShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltCylinderShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltCylinderShape`/`Const_JoltCylinderShape` directly.
    public class _InOptMut_JoltCylinderShape
    {
        public JoltCylinderShape? Opt;

        public _InOptMut_JoltCylinderShape() {}
        public _InOptMut_JoltCylinderShape(JoltCylinderShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltCylinderShape(JoltCylinderShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltCylinderShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltCylinderShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltCylinderShape`/`Const_JoltCylinderShape` to pass it to the function.
    public class _InOptConst_JoltCylinderShape
    {
        public Const_JoltCylinderShape? Opt;

        public _InOptConst_JoltCylinderShape() {}
        public _InOptConst_JoltCylinderShape(Const_JoltCylinderShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltCylinderShape(Const_JoltCylinderShape value) {return new(value);}
    }

    /// A shape rotated and translated relative to a child shape.
    /// Generated from class `JoltRotatedTranslatedShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltRotatedTranslatedShape : Jolt.Object<Const_JoltRotatedTranslatedShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltRotatedTranslatedShape_Destroy(_Underlying *_this);
            __JoltRotatedTranslatedShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltRotatedTranslatedShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltRotatedTranslatedShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltRotatedTranslatedShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltRotatedTranslatedShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltRotatedTranslatedShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltRotatedTranslatedShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltRotatedTranslatedShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
        public unsafe Const_JoltRotatedTranslatedShape(Jolt._ByValue_JoltRotatedTranslatedShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRotatedTranslatedShape._Underlying *__JoltRotatedTranslatedShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltRotatedTranslatedShape._Underlying *_other);
            _UnderlyingPtr = __JoltRotatedTranslatedShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
        public Const_JoltRotatedTranslatedShape(Const_JoltRotatedTranslatedShape _other) : this(new _ByValue_JoltRotatedTranslatedShape(_other)) {}

        /// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
        public Const_JoltRotatedTranslatedShape(JoltRotatedTranslatedShape _other) : this((Const_JoltRotatedTranslatedShape)_other) {}

        /// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
        public unsafe Const_JoltRotatedTranslatedShape(Jolt.JoltShape? inner, double posX, double posY, double posZ, float qx, float qy, float qz, float qw) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRotatedTranslatedShape._Underlying *__JoltRotatedTranslatedShape_Construct(Jolt.JoltShape._Underlying *inner, double posX, double posY, double posZ, float qx, float qy, float qz, float qw);
            _UnderlyingPtr = __JoltRotatedTranslatedShape_Construct(inner is not null ? inner._UnderlyingPtr : null, posX, posY, posZ, qx, qy, qz, qw);
        }

        /// Generated from method `JoltRotatedTranslatedShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltRotatedTranslatedShape_IsValid(_Underlying *_this);
            return __JoltRotatedTranslatedShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltRotatedTranslatedShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltRotatedTranslatedShape_getHandle(_Underlying *_this);
            return __JoltRotatedTranslatedShape_getHandle(_UnderlyingPtr);
        }
    }

    /// A shape rotated and translated relative to a child shape.
    /// Generated from class `JoltRotatedTranslatedShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltRotatedTranslatedShape : Const_JoltRotatedTranslatedShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltRotatedTranslatedShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltRotatedTranslatedShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltRotatedTranslatedShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltRotatedTranslatedShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltRotatedTranslatedShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltRotatedTranslatedShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
        public unsafe JoltRotatedTranslatedShape(Jolt._ByValue_JoltRotatedTranslatedShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRotatedTranslatedShape._Underlying *__JoltRotatedTranslatedShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltRotatedTranslatedShape._Underlying *_other);
            _UnderlyingPtr = __JoltRotatedTranslatedShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
        public JoltRotatedTranslatedShape(Const_JoltRotatedTranslatedShape _other) : this(new _ByValue_JoltRotatedTranslatedShape(_other)) {}

        /// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
        public JoltRotatedTranslatedShape(JoltRotatedTranslatedShape _other) : this((Const_JoltRotatedTranslatedShape)_other) {}

        /// Generated from constructor `JoltRotatedTranslatedShape::JoltRotatedTranslatedShape`.
        public unsafe JoltRotatedTranslatedShape(Jolt.JoltShape? inner, double posX, double posY, double posZ, float qx, float qy, float qz, float qw) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRotatedTranslatedShape._Underlying *__JoltRotatedTranslatedShape_Construct(Jolt.JoltShape._Underlying *inner, double posX, double posY, double posZ, float qx, float qy, float qz, float qw);
            _UnderlyingPtr = __JoltRotatedTranslatedShape_Construct(inner is not null ? inner._UnderlyingPtr : null, posX, posY, posZ, qx, qy, qz, qw);
        }

        /// Generated from method `JoltRotatedTranslatedShape::operator=`.
        public unsafe Jolt.JoltRotatedTranslatedShape Assign(Jolt._ByValue_JoltRotatedTranslatedShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltRotatedTranslatedShape._Underlying *__JoltRotatedTranslatedShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltRotatedTranslatedShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltRotatedTranslatedShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltRotatedTranslatedShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltRotatedTranslatedShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltRotatedTranslatedShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltRotatedTranslatedShape_Release(_Underlying *_this);
            __JoltRotatedTranslatedShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltRotatedTranslatedShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltRotatedTranslatedShape`/`Const_JoltRotatedTranslatedShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltRotatedTranslatedShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltRotatedTranslatedShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltRotatedTranslatedShape(Const_JoltRotatedTranslatedShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltRotatedTranslatedShape(Const_JoltRotatedTranslatedShape arg) {return new(arg);}
        public _ByValue_JoltRotatedTranslatedShape(Jolt._Moved<JoltRotatedTranslatedShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltRotatedTranslatedShape(Jolt._Moved<JoltRotatedTranslatedShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltRotatedTranslatedShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltRotatedTranslatedShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltRotatedTranslatedShape`/`Const_JoltRotatedTranslatedShape` directly.
    public class _InOptMut_JoltRotatedTranslatedShape
    {
        public JoltRotatedTranslatedShape? Opt;

        public _InOptMut_JoltRotatedTranslatedShape() {}
        public _InOptMut_JoltRotatedTranslatedShape(JoltRotatedTranslatedShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltRotatedTranslatedShape(JoltRotatedTranslatedShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltRotatedTranslatedShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltRotatedTranslatedShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltRotatedTranslatedShape`/`Const_JoltRotatedTranslatedShape` to pass it to the function.
    public class _InOptConst_JoltRotatedTranslatedShape
    {
        public Const_JoltRotatedTranslatedShape? Opt;

        public _InOptConst_JoltRotatedTranslatedShape() {}
        public _InOptConst_JoltRotatedTranslatedShape(Const_JoltRotatedTranslatedShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltRotatedTranslatedShape(Const_JoltRotatedTranslatedShape value) {return new(value);}
    }

    /// Capsule with different radii at each end.
    /// Generated from class `JoltTaperedCapsuleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltTaperedCapsuleShape : Jolt.Object<Const_JoltTaperedCapsuleShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltTaperedCapsuleShape_Destroy(_Underlying *_this);
            __JoltTaperedCapsuleShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltTaperedCapsuleShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltTaperedCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltTaperedCapsuleShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltTaperedCapsuleShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltTaperedCapsuleShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltTaperedCapsuleShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltTaperedCapsuleShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltTaperedCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltTaperedCapsuleShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
        public unsafe Const_JoltTaperedCapsuleShape(Jolt._ByValue_JoltTaperedCapsuleShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCapsuleShape._Underlying *__JoltTaperedCapsuleShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltTaperedCapsuleShape._Underlying *_other);
            _UnderlyingPtr = __JoltTaperedCapsuleShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
        public Const_JoltTaperedCapsuleShape(Const_JoltTaperedCapsuleShape _other) : this(new _ByValue_JoltTaperedCapsuleShape(_other)) {}

        /// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
        public Const_JoltTaperedCapsuleShape(JoltTaperedCapsuleShape _other) : this((Const_JoltTaperedCapsuleShape)_other) {}

        /// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
        public unsafe Const_JoltTaperedCapsuleShape(float halfHeight, float topRadius, float bottomRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCapsuleShape._Underlying *__JoltTaperedCapsuleShape_Construct(float halfHeight, float topRadius, float bottomRadius);
            _UnderlyingPtr = __JoltTaperedCapsuleShape_Construct(halfHeight, topRadius, bottomRadius);
        }

        /// Generated from method `JoltTaperedCapsuleShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltTaperedCapsuleShape_IsValid(_Underlying *_this);
            return __JoltTaperedCapsuleShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltTaperedCapsuleShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltTaperedCapsuleShape_getHandle(_Underlying *_this);
            return __JoltTaperedCapsuleShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Capsule with different radii at each end.
    /// Generated from class `JoltTaperedCapsuleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltTaperedCapsuleShape : Const_JoltTaperedCapsuleShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltTaperedCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltTaperedCapsuleShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltTaperedCapsuleShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltTaperedCapsuleShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltTaperedCapsuleShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltTaperedCapsuleShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltTaperedCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltTaperedCapsuleShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
        public unsafe JoltTaperedCapsuleShape(Jolt._ByValue_JoltTaperedCapsuleShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCapsuleShape._Underlying *__JoltTaperedCapsuleShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltTaperedCapsuleShape._Underlying *_other);
            _UnderlyingPtr = __JoltTaperedCapsuleShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
        public JoltTaperedCapsuleShape(Const_JoltTaperedCapsuleShape _other) : this(new _ByValue_JoltTaperedCapsuleShape(_other)) {}

        /// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
        public JoltTaperedCapsuleShape(JoltTaperedCapsuleShape _other) : this((Const_JoltTaperedCapsuleShape)_other) {}

        /// Generated from constructor `JoltTaperedCapsuleShape::JoltTaperedCapsuleShape`.
        public unsafe JoltTaperedCapsuleShape(float halfHeight, float topRadius, float bottomRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCapsuleShape._Underlying *__JoltTaperedCapsuleShape_Construct(float halfHeight, float topRadius, float bottomRadius);
            _UnderlyingPtr = __JoltTaperedCapsuleShape_Construct(halfHeight, topRadius, bottomRadius);
        }

        /// Generated from method `JoltTaperedCapsuleShape::operator=`.
        public unsafe Jolt.JoltTaperedCapsuleShape Assign(Jolt._ByValue_JoltTaperedCapsuleShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCapsuleShape._Underlying *__JoltTaperedCapsuleShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltTaperedCapsuleShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltTaperedCapsuleShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltTaperedCapsuleShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCapsuleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCapsuleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltTaperedCapsuleShape_Release(_Underlying *_this);
            __JoltTaperedCapsuleShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltTaperedCapsuleShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltTaperedCapsuleShape`/`Const_JoltTaperedCapsuleShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltTaperedCapsuleShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltTaperedCapsuleShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltTaperedCapsuleShape(Const_JoltTaperedCapsuleShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltTaperedCapsuleShape(Const_JoltTaperedCapsuleShape arg) {return new(arg);}
        public _ByValue_JoltTaperedCapsuleShape(Jolt._Moved<JoltTaperedCapsuleShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltTaperedCapsuleShape(Jolt._Moved<JoltTaperedCapsuleShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltTaperedCapsuleShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltTaperedCapsuleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltTaperedCapsuleShape`/`Const_JoltTaperedCapsuleShape` directly.
    public class _InOptMut_JoltTaperedCapsuleShape
    {
        public JoltTaperedCapsuleShape? Opt;

        public _InOptMut_JoltTaperedCapsuleShape() {}
        public _InOptMut_JoltTaperedCapsuleShape(JoltTaperedCapsuleShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltTaperedCapsuleShape(JoltTaperedCapsuleShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltTaperedCapsuleShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltTaperedCapsuleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltTaperedCapsuleShape`/`Const_JoltTaperedCapsuleShape` to pass it to the function.
    public class _InOptConst_JoltTaperedCapsuleShape
    {
        public Const_JoltTaperedCapsuleShape? Opt;

        public _InOptConst_JoltTaperedCapsuleShape() {}
        public _InOptConst_JoltTaperedCapsuleShape(Const_JoltTaperedCapsuleShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltTaperedCapsuleShape(Const_JoltTaperedCapsuleShape value) {return new(value);}
    }

    /// Cylinder with different radii at each end.
    /// Generated from class `JoltTaperedCylinderShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltTaperedCylinderShape : Jolt.Object<Const_JoltTaperedCylinderShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltTaperedCylinderShape_Destroy(_Underlying *_this);
            __JoltTaperedCylinderShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltTaperedCylinderShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltTaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltTaperedCylinderShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltTaperedCylinderShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltTaperedCylinderShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltTaperedCylinderShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltTaperedCylinderShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltTaperedCylinderShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltTaperedCylinderShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public unsafe Const_JoltTaperedCylinderShape(Jolt._ByValue_JoltTaperedCylinderShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCylinderShape._Underlying *__JoltTaperedCylinderShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltTaperedCylinderShape._Underlying *_other);
            _UnderlyingPtr = __JoltTaperedCylinderShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public Const_JoltTaperedCylinderShape(Const_JoltTaperedCylinderShape _other) : this(new _ByValue_JoltTaperedCylinderShape(_other)) {}

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public Const_JoltTaperedCylinderShape(JoltTaperedCylinderShape _other) : this((Const_JoltTaperedCylinderShape)_other) {}

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public unsafe Const_JoltTaperedCylinderShape(float halfHeight, float topRadius, float bottomRadius, float convexRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCylinderShape._Underlying *__JoltTaperedCylinderShape_Construct_4(float halfHeight, float topRadius, float bottomRadius, float convexRadius);
            _UnderlyingPtr = __JoltTaperedCylinderShape_Construct_4(halfHeight, topRadius, bottomRadius, convexRadius);
        }

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public unsafe Const_JoltTaperedCylinderShape(float halfHeight, float topRadius, float bottomRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCylinderShape._Underlying *__JoltTaperedCylinderShape_Construct_3(float halfHeight, float topRadius, float bottomRadius);
            _UnderlyingPtr = __JoltTaperedCylinderShape_Construct_3(halfHeight, topRadius, bottomRadius);
        }

        /// Generated from method `JoltTaperedCylinderShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltTaperedCylinderShape_IsValid(_Underlying *_this);
            return __JoltTaperedCylinderShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltTaperedCylinderShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltTaperedCylinderShape_getHandle(_Underlying *_this);
            return __JoltTaperedCylinderShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Cylinder with different radii at each end.
    /// Generated from class `JoltTaperedCylinderShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltTaperedCylinderShape : Const_JoltTaperedCylinderShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltTaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltTaperedCylinderShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltTaperedCylinderShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltTaperedCylinderShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltTaperedCylinderShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltTaperedCylinderShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltTaperedCylinderShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltTaperedCylinderShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public unsafe JoltTaperedCylinderShape(Jolt._ByValue_JoltTaperedCylinderShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCylinderShape._Underlying *__JoltTaperedCylinderShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltTaperedCylinderShape._Underlying *_other);
            _UnderlyingPtr = __JoltTaperedCylinderShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public JoltTaperedCylinderShape(Const_JoltTaperedCylinderShape _other) : this(new _ByValue_JoltTaperedCylinderShape(_other)) {}

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public JoltTaperedCylinderShape(JoltTaperedCylinderShape _other) : this((Const_JoltTaperedCylinderShape)_other) {}

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public unsafe JoltTaperedCylinderShape(float halfHeight, float topRadius, float bottomRadius, float convexRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCylinderShape._Underlying *__JoltTaperedCylinderShape_Construct_4(float halfHeight, float topRadius, float bottomRadius, float convexRadius);
            _UnderlyingPtr = __JoltTaperedCylinderShape_Construct_4(halfHeight, topRadius, bottomRadius, convexRadius);
        }

        /// Generated from constructor `JoltTaperedCylinderShape::JoltTaperedCylinderShape`.
        public unsafe JoltTaperedCylinderShape(float halfHeight, float topRadius, float bottomRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCylinderShape._Underlying *__JoltTaperedCylinderShape_Construct_3(float halfHeight, float topRadius, float bottomRadius);
            _UnderlyingPtr = __JoltTaperedCylinderShape_Construct_3(halfHeight, topRadius, bottomRadius);
        }

        /// Generated from method `JoltTaperedCylinderShape::operator=`.
        public unsafe Jolt.JoltTaperedCylinderShape Assign(Jolt._ByValue_JoltTaperedCylinderShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTaperedCylinderShape._Underlying *__JoltTaperedCylinderShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltTaperedCylinderShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltTaperedCylinderShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltTaperedCylinderShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTaperedCylinderShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTaperedCylinderShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltTaperedCylinderShape_Release(_Underlying *_this);
            __JoltTaperedCylinderShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltTaperedCylinderShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltTaperedCylinderShape`/`Const_JoltTaperedCylinderShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltTaperedCylinderShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltTaperedCylinderShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltTaperedCylinderShape(Const_JoltTaperedCylinderShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltTaperedCylinderShape(Const_JoltTaperedCylinderShape arg) {return new(arg);}
        public _ByValue_JoltTaperedCylinderShape(Jolt._Moved<JoltTaperedCylinderShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltTaperedCylinderShape(Jolt._Moved<JoltTaperedCylinderShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltTaperedCylinderShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltTaperedCylinderShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltTaperedCylinderShape`/`Const_JoltTaperedCylinderShape` directly.
    public class _InOptMut_JoltTaperedCylinderShape
    {
        public JoltTaperedCylinderShape? Opt;

        public _InOptMut_JoltTaperedCylinderShape() {}
        public _InOptMut_JoltTaperedCylinderShape(JoltTaperedCylinderShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltTaperedCylinderShape(JoltTaperedCylinderShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltTaperedCylinderShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltTaperedCylinderShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltTaperedCylinderShape`/`Const_JoltTaperedCylinderShape` to pass it to the function.
    public class _InOptConst_JoltTaperedCylinderShape
    {
        public Const_JoltTaperedCylinderShape? Opt;

        public _InOptConst_JoltTaperedCylinderShape() {}
        public _InOptConst_JoltTaperedCylinderShape(Const_JoltTaperedCylinderShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltTaperedCylinderShape(Const_JoltTaperedCylinderShape value) {return new(value);}
    }

    /// Single triangle shape. Useful for debugging and simple static colliders.
    /// Generated from class `JoltTriangleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltTriangleShape : Jolt.Object<Const_JoltTriangleShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltTriangleShape_Destroy(_Underlying *_this);
            __JoltTriangleShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltTriangleShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltTriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltTriangleShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltTriangleShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltTriangleShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltTriangleShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltTriangleShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltTriangleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltTriangleShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public unsafe Const_JoltTriangleShape(Jolt._ByValue_JoltTriangleShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTriangleShape._Underlying *__JoltTriangleShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltTriangleShape._Underlying *_other);
            _UnderlyingPtr = __JoltTriangleShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public Const_JoltTriangleShape(Const_JoltTriangleShape _other) : this(new _ByValue_JoltTriangleShape(_other)) {}

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public Const_JoltTriangleShape(JoltTriangleShape _other) : this((Const_JoltTriangleShape)_other) {}

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public unsafe Const_JoltTriangleShape(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTriangleShape._Underlying *__JoltTriangleShape_Construct_9(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z);
            _UnderlyingPtr = __JoltTriangleShape_Construct_9(v1x, v1y, v1z, v2x, v2y, v2z, v3x, v3y, v3z);
        }

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public unsafe Const_JoltTriangleShape(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z, float convexRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_Construct_10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_Construct_10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTriangleShape._Underlying *__JoltTriangleShape_Construct_10(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z, float convexRadius);
            _UnderlyingPtr = __JoltTriangleShape_Construct_10(v1x, v1y, v1z, v2x, v2y, v2z, v3x, v3y, v3z, convexRadius);
        }

        /// Generated from method `JoltTriangleShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltTriangleShape_IsValid(_Underlying *_this);
            return __JoltTriangleShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltTriangleShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltTriangleShape_getHandle(_Underlying *_this);
            return __JoltTriangleShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Single triangle shape. Useful for debugging and simple static colliders.
    /// Generated from class `JoltTriangleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltTriangleShape : Const_JoltTriangleShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltTriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltTriangleShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltTriangleShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltTriangleShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltTriangleShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltTriangleShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltTriangleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltTriangleShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public unsafe JoltTriangleShape(Jolt._ByValue_JoltTriangleShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTriangleShape._Underlying *__JoltTriangleShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltTriangleShape._Underlying *_other);
            _UnderlyingPtr = __JoltTriangleShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public JoltTriangleShape(Const_JoltTriangleShape _other) : this(new _ByValue_JoltTriangleShape(_other)) {}

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public JoltTriangleShape(JoltTriangleShape _other) : this((Const_JoltTriangleShape)_other) {}

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public unsafe JoltTriangleShape(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTriangleShape._Underlying *__JoltTriangleShape_Construct_9(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z);
            _UnderlyingPtr = __JoltTriangleShape_Construct_9(v1x, v1y, v1z, v2x, v2y, v2z, v3x, v3y, v3z);
        }

        /// Generated from constructor `JoltTriangleShape::JoltTriangleShape`.
        public unsafe JoltTriangleShape(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z, float convexRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_Construct_10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_Construct_10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTriangleShape._Underlying *__JoltTriangleShape_Construct_10(float v1x, float v1y, float v1z, float v2x, float v2y, float v2z, float v3x, float v3y, float v3z, float convexRadius);
            _UnderlyingPtr = __JoltTriangleShape_Construct_10(v1x, v1y, v1z, v2x, v2y, v2z, v3x, v3y, v3z, convexRadius);
        }

        /// Generated from method `JoltTriangleShape::operator=`.
        public unsafe Jolt.JoltTriangleShape Assign(Jolt._ByValue_JoltTriangleShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTriangleShape._Underlying *__JoltTriangleShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltTriangleShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltTriangleShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltTriangleShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltTriangleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltTriangleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltTriangleShape_Release(_Underlying *_this);
            __JoltTriangleShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltTriangleShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltTriangleShape`/`Const_JoltTriangleShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltTriangleShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltTriangleShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltTriangleShape(Const_JoltTriangleShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltTriangleShape(Const_JoltTriangleShape arg) {return new(arg);}
        public _ByValue_JoltTriangleShape(Jolt._Moved<JoltTriangleShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltTriangleShape(Jolt._Moved<JoltTriangleShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltTriangleShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltTriangleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltTriangleShape`/`Const_JoltTriangleShape` directly.
    public class _InOptMut_JoltTriangleShape
    {
        public JoltTriangleShape? Opt;

        public _InOptMut_JoltTriangleShape() {}
        public _InOptMut_JoltTriangleShape(JoltTriangleShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltTriangleShape(JoltTriangleShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltTriangleShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltTriangleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltTriangleShape`/`Const_JoltTriangleShape` to pass it to the function.
    public class _InOptConst_JoltTriangleShape
    {
        public Const_JoltTriangleShape? Opt;

        public _InOptConst_JoltTriangleShape() {}
        public _InOptConst_JoltTriangleShape(Const_JoltTriangleShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltTriangleShape(Const_JoltTriangleShape value) {return new(value);}
    }

    /// Infinite half-space plane. The plane is defined by a normal (nx, ny, nz) and a signed
    /// distance constant d, giving the equation: dot(n, p) + d = 0.
    /// halfExtent controls the broad-phase AABB size (default 1000).
    /// Generated from class `JoltPlaneShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltPlaneShape : Jolt.Object<Const_JoltPlaneShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPlaneShape_Destroy(_Underlying *_this);
            __JoltPlaneShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltPlaneShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltPlaneShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltPlaneShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltPlaneShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltPlaneShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltPlaneShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltPlaneShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltPlaneShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltPlaneShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public unsafe Const_JoltPlaneShape(Jolt._ByValue_JoltPlaneShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPlaneShape._Underlying *__JoltPlaneShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltPlaneShape._Underlying *_other);
            _UnderlyingPtr = __JoltPlaneShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public Const_JoltPlaneShape(Const_JoltPlaneShape _other) : this(new _ByValue_JoltPlaneShape(_other)) {}

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public Const_JoltPlaneShape(JoltPlaneShape _other) : this((Const_JoltPlaneShape)_other) {}

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public unsafe Const_JoltPlaneShape(float nx, float ny, float nz, float d, float halfExtent) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPlaneShape._Underlying *__JoltPlaneShape_Construct_5(float nx, float ny, float nz, float d, float halfExtent);
            _UnderlyingPtr = __JoltPlaneShape_Construct_5(nx, ny, nz, d, halfExtent);
        }

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public unsafe Const_JoltPlaneShape(float nx, float ny, float nz, float d) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPlaneShape._Underlying *__JoltPlaneShape_Construct_4(float nx, float ny, float nz, float d);
            _UnderlyingPtr = __JoltPlaneShape_Construct_4(nx, ny, nz, d);
        }

        /// Generated from method `JoltPlaneShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltPlaneShape_IsValid(_Underlying *_this);
            return __JoltPlaneShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltPlaneShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltPlaneShape_getHandle(_Underlying *_this);
            return __JoltPlaneShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Infinite half-space plane. The plane is defined by a normal (nx, ny, nz) and a signed
    /// distance constant d, giving the equation: dot(n, p) + d = 0.
    /// halfExtent controls the broad-phase AABB size (default 1000).
    /// Generated from class `JoltPlaneShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltPlaneShape : Const_JoltPlaneShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltPlaneShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltPlaneShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltPlaneShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltPlaneShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltPlaneShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltPlaneShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltPlaneShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltPlaneShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public unsafe JoltPlaneShape(Jolt._ByValue_JoltPlaneShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPlaneShape._Underlying *__JoltPlaneShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltPlaneShape._Underlying *_other);
            _UnderlyingPtr = __JoltPlaneShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public JoltPlaneShape(Const_JoltPlaneShape _other) : this(new _ByValue_JoltPlaneShape(_other)) {}

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public JoltPlaneShape(JoltPlaneShape _other) : this((Const_JoltPlaneShape)_other) {}

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public unsafe JoltPlaneShape(float nx, float ny, float nz, float d, float halfExtent) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPlaneShape._Underlying *__JoltPlaneShape_Construct_5(float nx, float ny, float nz, float d, float halfExtent);
            _UnderlyingPtr = __JoltPlaneShape_Construct_5(nx, ny, nz, d, halfExtent);
        }

        /// Generated from constructor `JoltPlaneShape::JoltPlaneShape`.
        public unsafe JoltPlaneShape(float nx, float ny, float nz, float d) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPlaneShape._Underlying *__JoltPlaneShape_Construct_4(float nx, float ny, float nz, float d);
            _UnderlyingPtr = __JoltPlaneShape_Construct_4(nx, ny, nz, d);
        }

        /// Generated from method `JoltPlaneShape::operator=`.
        public unsafe Jolt.JoltPlaneShape Assign(Jolt._ByValue_JoltPlaneShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPlaneShape._Underlying *__JoltPlaneShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltPlaneShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltPlaneShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltPlaneShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPlaneShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPlaneShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPlaneShape_Release(_Underlying *_this);
            __JoltPlaneShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltPlaneShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltPlaneShape`/`Const_JoltPlaneShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltPlaneShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltPlaneShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltPlaneShape(Const_JoltPlaneShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltPlaneShape(Const_JoltPlaneShape arg) {return new(arg);}
        public _ByValue_JoltPlaneShape(Jolt._Moved<JoltPlaneShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltPlaneShape(Jolt._Moved<JoltPlaneShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltPlaneShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltPlaneShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltPlaneShape`/`Const_JoltPlaneShape` directly.
    public class _InOptMut_JoltPlaneShape
    {
        public JoltPlaneShape? Opt;

        public _InOptMut_JoltPlaneShape() {}
        public _InOptMut_JoltPlaneShape(JoltPlaneShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltPlaneShape(JoltPlaneShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltPlaneShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltPlaneShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltPlaneShape`/`Const_JoltPlaneShape` to pass it to the function.
    public class _InOptConst_JoltPlaneShape
    {
        public Const_JoltPlaneShape? Opt;

        public _InOptConst_JoltPlaneShape() {}
        public _InOptConst_JoltPlaneShape(Const_JoltPlaneShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltPlaneShape(Const_JoltPlaneShape value) {return new(value);}
    }

    /// Zero-volume placeholder shape. comX/Y/Z places the center of mass.
    /// Generated from class `JoltEmptyShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltEmptyShape : Jolt.Object<Const_JoltEmptyShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltEmptyShape_Destroy(_Underlying *_this);
            __JoltEmptyShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltEmptyShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltEmptyShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltEmptyShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltEmptyShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltEmptyShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltEmptyShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltEmptyShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltEmptyShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltEmptyShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltEmptyShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltEmptyShape._Underlying *__JoltEmptyShape_DefaultConstruct();
            _UnderlyingPtr = __JoltEmptyShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
        public unsafe Const_JoltEmptyShape(Jolt._ByValue_JoltEmptyShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltEmptyShape._Underlying *__JoltEmptyShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltEmptyShape._Underlying *_other);
            _UnderlyingPtr = __JoltEmptyShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
        public Const_JoltEmptyShape(Const_JoltEmptyShape _other) : this(new _ByValue_JoltEmptyShape(_other)) {}

        /// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
        public Const_JoltEmptyShape(JoltEmptyShape _other) : this((Const_JoltEmptyShape)_other) {}

        /// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
        public unsafe Const_JoltEmptyShape(float comX, float comY, float comZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltEmptyShape._Underlying *__JoltEmptyShape_Construct(float comX, float comY, float comZ);
            _UnderlyingPtr = __JoltEmptyShape_Construct(comX, comY, comZ);
        }

        /// Generated from method `JoltEmptyShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltEmptyShape_IsValid(_Underlying *_this);
            return __JoltEmptyShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltEmptyShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltEmptyShape_getHandle(_Underlying *_this);
            return __JoltEmptyShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Zero-volume placeholder shape. comX/Y/Z places the center of mass.
    /// Generated from class `JoltEmptyShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltEmptyShape : Const_JoltEmptyShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltEmptyShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltEmptyShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltEmptyShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltEmptyShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltEmptyShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltEmptyShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltEmptyShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltEmptyShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltEmptyShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltEmptyShape._Underlying *__JoltEmptyShape_DefaultConstruct();
            _UnderlyingPtr = __JoltEmptyShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
        public unsafe JoltEmptyShape(Jolt._ByValue_JoltEmptyShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltEmptyShape._Underlying *__JoltEmptyShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltEmptyShape._Underlying *_other);
            _UnderlyingPtr = __JoltEmptyShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
        public JoltEmptyShape(Const_JoltEmptyShape _other) : this(new _ByValue_JoltEmptyShape(_other)) {}

        /// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
        public JoltEmptyShape(JoltEmptyShape _other) : this((Const_JoltEmptyShape)_other) {}

        /// Generated from constructor `JoltEmptyShape::JoltEmptyShape`.
        public unsafe JoltEmptyShape(float comX, float comY, float comZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltEmptyShape._Underlying *__JoltEmptyShape_Construct(float comX, float comY, float comZ);
            _UnderlyingPtr = __JoltEmptyShape_Construct(comX, comY, comZ);
        }

        /// Generated from method `JoltEmptyShape::operator=`.
        public unsafe Jolt.JoltEmptyShape Assign(Jolt._ByValue_JoltEmptyShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltEmptyShape._Underlying *__JoltEmptyShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltEmptyShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltEmptyShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltEmptyShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltEmptyShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltEmptyShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltEmptyShape_Release(_Underlying *_this);
            __JoltEmptyShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltEmptyShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `JoltEmptyShape`/`Const_JoltEmptyShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltEmptyShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltEmptyShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltEmptyShape() {PassByMode = Jolt._PassBy.default_construct;}
        public _ByValue_JoltEmptyShape(Const_JoltEmptyShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltEmptyShape(Const_JoltEmptyShape arg) {return new(arg);}
        public _ByValue_JoltEmptyShape(Jolt._Moved<JoltEmptyShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltEmptyShape(Jolt._Moved<JoltEmptyShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltEmptyShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltEmptyShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltEmptyShape`/`Const_JoltEmptyShape` directly.
    public class _InOptMut_JoltEmptyShape
    {
        public JoltEmptyShape? Opt;

        public _InOptMut_JoltEmptyShape() {}
        public _InOptMut_JoltEmptyShape(JoltEmptyShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltEmptyShape(JoltEmptyShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltEmptyShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltEmptyShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltEmptyShape`/`Const_JoltEmptyShape` to pass it to the function.
    public class _InOptConst_JoltEmptyShape
    {
        public Const_JoltEmptyShape? Opt;

        public _InOptConst_JoltEmptyShape() {}
        public _InOptConst_JoltEmptyShape(Const_JoltEmptyShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltEmptyShape(Const_JoltEmptyShape value) {return new(value);}
    }

    /// Scales a child shape non-uniformly along each axis.
    /// Generated from class `JoltScaledShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltScaledShape : Jolt.Object<Const_JoltScaledShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltScaledShape_Destroy(_Underlying *_this);
            __JoltScaledShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltScaledShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltScaledShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltScaledShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltScaledShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltScaledShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltScaledShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltScaledShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltScaledShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltScaledShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltScaledShape::JoltScaledShape`.
        public unsafe Const_JoltScaledShape(Jolt._ByValue_JoltScaledShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltScaledShape._Underlying *__JoltScaledShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltScaledShape._Underlying *_other);
            _UnderlyingPtr = __JoltScaledShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltScaledShape::JoltScaledShape`.
        public Const_JoltScaledShape(Const_JoltScaledShape _other) : this(new _ByValue_JoltScaledShape(_other)) {}

        /// Generated from constructor `JoltScaledShape::JoltScaledShape`.
        public Const_JoltScaledShape(JoltScaledShape _other) : this((Const_JoltScaledShape)_other) {}

        /// Generated from constructor `JoltScaledShape::JoltScaledShape`.
        public unsafe Const_JoltScaledShape(Jolt.JoltShape? inner, float sx, float sy, float sz) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltScaledShape._Underlying *__JoltScaledShape_Construct(Jolt.JoltShape._Underlying *inner, float sx, float sy, float sz);
            _UnderlyingPtr = __JoltScaledShape_Construct(inner is not null ? inner._UnderlyingPtr : null, sx, sy, sz);
        }

        /// Generated from method `JoltScaledShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltScaledShape_IsValid(_Underlying *_this);
            return __JoltScaledShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltScaledShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltScaledShape_getHandle(_Underlying *_this);
            return __JoltScaledShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Scales a child shape non-uniformly along each axis.
    /// Generated from class `JoltScaledShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltScaledShape : Const_JoltScaledShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltScaledShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltScaledShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltScaledShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltScaledShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltScaledShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltScaledShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltScaledShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltScaledShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltScaledShape::JoltScaledShape`.
        public unsafe JoltScaledShape(Jolt._ByValue_JoltScaledShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltScaledShape._Underlying *__JoltScaledShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltScaledShape._Underlying *_other);
            _UnderlyingPtr = __JoltScaledShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltScaledShape::JoltScaledShape`.
        public JoltScaledShape(Const_JoltScaledShape _other) : this(new _ByValue_JoltScaledShape(_other)) {}

        /// Generated from constructor `JoltScaledShape::JoltScaledShape`.
        public JoltScaledShape(JoltScaledShape _other) : this((Const_JoltScaledShape)_other) {}

        /// Generated from constructor `JoltScaledShape::JoltScaledShape`.
        public unsafe JoltScaledShape(Jolt.JoltShape? inner, float sx, float sy, float sz) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltScaledShape._Underlying *__JoltScaledShape_Construct(Jolt.JoltShape._Underlying *inner, float sx, float sy, float sz);
            _UnderlyingPtr = __JoltScaledShape_Construct(inner is not null ? inner._UnderlyingPtr : null, sx, sy, sz);
        }

        /// Generated from method `JoltScaledShape::operator=`.
        public unsafe Jolt.JoltScaledShape Assign(Jolt._ByValue_JoltScaledShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltScaledShape._Underlying *__JoltScaledShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltScaledShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltScaledShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltScaledShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltScaledShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltScaledShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltScaledShape_Release(_Underlying *_this);
            __JoltScaledShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltScaledShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltScaledShape`/`Const_JoltScaledShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltScaledShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltScaledShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltScaledShape(Const_JoltScaledShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltScaledShape(Const_JoltScaledShape arg) {return new(arg);}
        public _ByValue_JoltScaledShape(Jolt._Moved<JoltScaledShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltScaledShape(Jolt._Moved<JoltScaledShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltScaledShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltScaledShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltScaledShape`/`Const_JoltScaledShape` directly.
    public class _InOptMut_JoltScaledShape
    {
        public JoltScaledShape? Opt;

        public _InOptMut_JoltScaledShape() {}
        public _InOptMut_JoltScaledShape(JoltScaledShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltScaledShape(JoltScaledShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltScaledShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltScaledShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltScaledShape`/`Const_JoltScaledShape` to pass it to the function.
    public class _InOptConst_JoltScaledShape
    {
        public Const_JoltScaledShape? Opt;

        public _InOptConst_JoltScaledShape() {}
        public _InOptConst_JoltScaledShape(Const_JoltScaledShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltScaledShape(Const_JoltScaledShape value) {return new(value);}
    }

    /// Shifts the center-of-mass of a child shape.
    /// Generated from class `JoltOffsetCenterOfMassShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltOffsetCenterOfMassShape : Jolt.Object<Const_JoltOffsetCenterOfMassShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltOffsetCenterOfMassShape_Destroy(_Underlying *_this);
            __JoltOffsetCenterOfMassShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltOffsetCenterOfMassShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltOffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltOffsetCenterOfMassShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltOffsetCenterOfMassShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltOffsetCenterOfMassShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltOffsetCenterOfMassShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltOffsetCenterOfMassShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltOffsetCenterOfMassShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltOffsetCenterOfMassShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
        public unsafe Const_JoltOffsetCenterOfMassShape(Jolt._ByValue_JoltOffsetCenterOfMassShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltOffsetCenterOfMassShape._Underlying *__JoltOffsetCenterOfMassShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltOffsetCenterOfMassShape._Underlying *_other);
            _UnderlyingPtr = __JoltOffsetCenterOfMassShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
        public Const_JoltOffsetCenterOfMassShape(Const_JoltOffsetCenterOfMassShape _other) : this(new _ByValue_JoltOffsetCenterOfMassShape(_other)) {}

        /// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
        public Const_JoltOffsetCenterOfMassShape(JoltOffsetCenterOfMassShape _other) : this((Const_JoltOffsetCenterOfMassShape)_other) {}

        /// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
        public unsafe Const_JoltOffsetCenterOfMassShape(Jolt.JoltShape? inner, float offsetX, float offsetY, float offsetZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltOffsetCenterOfMassShape._Underlying *__JoltOffsetCenterOfMassShape_Construct(Jolt.JoltShape._Underlying *inner, float offsetX, float offsetY, float offsetZ);
            _UnderlyingPtr = __JoltOffsetCenterOfMassShape_Construct(inner is not null ? inner._UnderlyingPtr : null, offsetX, offsetY, offsetZ);
        }

        /// Generated from method `JoltOffsetCenterOfMassShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltOffsetCenterOfMassShape_IsValid(_Underlying *_this);
            return __JoltOffsetCenterOfMassShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltOffsetCenterOfMassShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltOffsetCenterOfMassShape_getHandle(_Underlying *_this);
            return __JoltOffsetCenterOfMassShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Shifts the center-of-mass of a child shape.
    /// Generated from class `JoltOffsetCenterOfMassShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltOffsetCenterOfMassShape : Const_JoltOffsetCenterOfMassShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltOffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltOffsetCenterOfMassShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltOffsetCenterOfMassShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltOffsetCenterOfMassShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltOffsetCenterOfMassShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltOffsetCenterOfMassShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltOffsetCenterOfMassShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltOffsetCenterOfMassShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
        public unsafe JoltOffsetCenterOfMassShape(Jolt._ByValue_JoltOffsetCenterOfMassShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltOffsetCenterOfMassShape._Underlying *__JoltOffsetCenterOfMassShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltOffsetCenterOfMassShape._Underlying *_other);
            _UnderlyingPtr = __JoltOffsetCenterOfMassShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
        public JoltOffsetCenterOfMassShape(Const_JoltOffsetCenterOfMassShape _other) : this(new _ByValue_JoltOffsetCenterOfMassShape(_other)) {}

        /// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
        public JoltOffsetCenterOfMassShape(JoltOffsetCenterOfMassShape _other) : this((Const_JoltOffsetCenterOfMassShape)_other) {}

        /// Generated from constructor `JoltOffsetCenterOfMassShape::JoltOffsetCenterOfMassShape`.
        public unsafe JoltOffsetCenterOfMassShape(Jolt.JoltShape? inner, float offsetX, float offsetY, float offsetZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltOffsetCenterOfMassShape._Underlying *__JoltOffsetCenterOfMassShape_Construct(Jolt.JoltShape._Underlying *inner, float offsetX, float offsetY, float offsetZ);
            _UnderlyingPtr = __JoltOffsetCenterOfMassShape_Construct(inner is not null ? inner._UnderlyingPtr : null, offsetX, offsetY, offsetZ);
        }

        /// Generated from method `JoltOffsetCenterOfMassShape::operator=`.
        public unsafe Jolt.JoltOffsetCenterOfMassShape Assign(Jolt._ByValue_JoltOffsetCenterOfMassShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltOffsetCenterOfMassShape._Underlying *__JoltOffsetCenterOfMassShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltOffsetCenterOfMassShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltOffsetCenterOfMassShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltOffsetCenterOfMassShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltOffsetCenterOfMassShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltOffsetCenterOfMassShape_Release(_Underlying *_this);
            __JoltOffsetCenterOfMassShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltOffsetCenterOfMassShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltOffsetCenterOfMassShape`/`Const_JoltOffsetCenterOfMassShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltOffsetCenterOfMassShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltOffsetCenterOfMassShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltOffsetCenterOfMassShape(Const_JoltOffsetCenterOfMassShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltOffsetCenterOfMassShape(Const_JoltOffsetCenterOfMassShape arg) {return new(arg);}
        public _ByValue_JoltOffsetCenterOfMassShape(Jolt._Moved<JoltOffsetCenterOfMassShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
        public static implicit operator _ByValue_JoltOffsetCenterOfMassShape(Jolt._Moved<JoltOffsetCenterOfMassShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltOffsetCenterOfMassShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltOffsetCenterOfMassShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltOffsetCenterOfMassShape`/`Const_JoltOffsetCenterOfMassShape` directly.
    public class _InOptMut_JoltOffsetCenterOfMassShape
    {
        public JoltOffsetCenterOfMassShape? Opt;

        public _InOptMut_JoltOffsetCenterOfMassShape() {}
        public _InOptMut_JoltOffsetCenterOfMassShape(JoltOffsetCenterOfMassShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltOffsetCenterOfMassShape(JoltOffsetCenterOfMassShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltOffsetCenterOfMassShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltOffsetCenterOfMassShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltOffsetCenterOfMassShape`/`Const_JoltOffsetCenterOfMassShape` to pass it to the function.
    public class _InOptConst_JoltOffsetCenterOfMassShape
    {
        public Const_JoltOffsetCenterOfMassShape? Opt;

        public _InOptConst_JoltOffsetCenterOfMassShape() {}
        public _InOptConst_JoltOffsetCenterOfMassShape(Const_JoltOffsetCenterOfMassShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltOffsetCenterOfMassShape(Const_JoltOffsetCenterOfMassShape value) {return new(value);}
    }

    /// Static (immutable after finalization) compound of multiple child shapes.
    /// Call AddSubShape() to build, then Finalize() before using as a shape.
    /// Generated from class `JoltStaticCompoundShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltStaticCompoundShape : Jolt.Object<Const_JoltStaticCompoundShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltStaticCompoundShape_Destroy(_Underlying *_this);
            __JoltStaticCompoundShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltStaticCompoundShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltStaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltStaticCompoundShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltStaticCompoundShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltStaticCompoundShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltStaticCompoundShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltStaticCompoundShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltStaticCompoundShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltStaticCompoundShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltStaticCompoundShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltStaticCompoundShape._Underlying *__JoltStaticCompoundShape_DefaultConstruct();
            _UnderlyingPtr = __JoltStaticCompoundShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltStaticCompoundShape::JoltStaticCompoundShape`.
        public unsafe Const_JoltStaticCompoundShape(Jolt._ByValue_JoltStaticCompoundShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltStaticCompoundShape._Underlying *__JoltStaticCompoundShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltStaticCompoundShape._Underlying *_other);
            _UnderlyingPtr = __JoltStaticCompoundShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltStaticCompoundShape::JoltStaticCompoundShape`.
        public Const_JoltStaticCompoundShape(Const_JoltStaticCompoundShape _other) : this(new _ByValue_JoltStaticCompoundShape(_other)) {}

        /// Generated from constructor `JoltStaticCompoundShape::JoltStaticCompoundShape`.
        public Const_JoltStaticCompoundShape(JoltStaticCompoundShape _other) : this((Const_JoltStaticCompoundShape)_other) {}

        /// Generated from method `JoltStaticCompoundShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltStaticCompoundShape_IsValid(_Underlying *_this);
            return __JoltStaticCompoundShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltStaticCompoundShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltStaticCompoundShape_getHandle(_Underlying *_this);
            return __JoltStaticCompoundShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Static (immutable after finalization) compound of multiple child shapes.
    /// Call AddSubShape() to build, then Finalize() before using as a shape.
    /// Generated from class `JoltStaticCompoundShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltStaticCompoundShape : Const_JoltStaticCompoundShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltStaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltStaticCompoundShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltStaticCompoundShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltStaticCompoundShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltStaticCompoundShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltStaticCompoundShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltStaticCompoundShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltStaticCompoundShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltStaticCompoundShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltStaticCompoundShape._Underlying *__JoltStaticCompoundShape_DefaultConstruct();
            _UnderlyingPtr = __JoltStaticCompoundShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltStaticCompoundShape::JoltStaticCompoundShape`.
        public unsafe JoltStaticCompoundShape(Jolt._ByValue_JoltStaticCompoundShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltStaticCompoundShape._Underlying *__JoltStaticCompoundShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltStaticCompoundShape._Underlying *_other);
            _UnderlyingPtr = __JoltStaticCompoundShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltStaticCompoundShape::JoltStaticCompoundShape`.
        public JoltStaticCompoundShape(Const_JoltStaticCompoundShape _other) : this(new _ByValue_JoltStaticCompoundShape(_other)) {}

        /// Generated from constructor `JoltStaticCompoundShape::JoltStaticCompoundShape`.
        public JoltStaticCompoundShape(JoltStaticCompoundShape _other) : this((Const_JoltStaticCompoundShape)_other) {}

        /// Generated from method `JoltStaticCompoundShape::operator=`.
        public unsafe Jolt.JoltStaticCompoundShape Assign(Jolt._ByValue_JoltStaticCompoundShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltStaticCompoundShape._Underlying *__JoltStaticCompoundShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltStaticCompoundShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltStaticCompoundShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltStaticCompoundShape::AddSubShape`.
        public unsafe void AddSubShape(Jolt.JoltShape? shape, double px, double py, double pz, float qx, float qy, float qz, float qw)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_AddSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_AddSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltStaticCompoundShape_AddSubShape(_Underlying *_this, Jolt.JoltShape._Underlying *shape, double px, double py, double pz, float qx, float qy, float qz, float qw);
            __JoltStaticCompoundShape_AddSubShape(_UnderlyingPtr, shape is not null ? shape._UnderlyingPtr : null, px, py, pz, qx, qy, qz, qw);
        }

        /// Generated from method `JoltStaticCompoundShape::Finalize`.
        public unsafe void Finalize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_Finalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_Finalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltStaticCompoundShape_Finalize(_Underlying *_this);
            __JoltStaticCompoundShape_Finalize(_UnderlyingPtr);
        }

        /// Generated from method `JoltStaticCompoundShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltStaticCompoundShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltStaticCompoundShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltStaticCompoundShape_Release(_Underlying *_this);
            __JoltStaticCompoundShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltStaticCompoundShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `JoltStaticCompoundShape`/`Const_JoltStaticCompoundShape` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltStaticCompoundShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltStaticCompoundShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltStaticCompoundShape() {PassByMode = Jolt._PassBy.default_construct;}
        public _ByValue_JoltStaticCompoundShape(Const_JoltStaticCompoundShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltStaticCompoundShape(Const_JoltStaticCompoundShape arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltStaticCompoundShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltStaticCompoundShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltStaticCompoundShape`/`Const_JoltStaticCompoundShape` directly.
    public class _InOptMut_JoltStaticCompoundShape
    {
        public JoltStaticCompoundShape? Opt;

        public _InOptMut_JoltStaticCompoundShape() {}
        public _InOptMut_JoltStaticCompoundShape(JoltStaticCompoundShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltStaticCompoundShape(JoltStaticCompoundShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltStaticCompoundShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltStaticCompoundShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltStaticCompoundShape`/`Const_JoltStaticCompoundShape` to pass it to the function.
    public class _InOptConst_JoltStaticCompoundShape
    {
        public Const_JoltStaticCompoundShape? Opt;

        public _InOptConst_JoltStaticCompoundShape() {}
        public _InOptConst_JoltStaticCompoundShape(Const_JoltStaticCompoundShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltStaticCompoundShape(Const_JoltStaticCompoundShape value) {return new(value);}
    }

    /// Mutable compound shape — sub-shapes can be modified after finalization.
    /// Call AddSubShape() + Finalize() to build, then use Append/Remove/Modify
    /// for runtime changes.
    /// Generated from class `JoltMutableCompoundShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltMutableCompoundShape : Jolt.Object<Const_JoltMutableCompoundShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMutableCompoundShape_Destroy(_Underlying *_this);
            __JoltMutableCompoundShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltMutableCompoundShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltMutableCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltMutableCompoundShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltMutableCompoundShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltMutableCompoundShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltMutableCompoundShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltMutableCompoundShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltMutableCompoundShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltMutableCompoundShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltMutableCompoundShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMutableCompoundShape._Underlying *__JoltMutableCompoundShape_DefaultConstruct();
            _UnderlyingPtr = __JoltMutableCompoundShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltMutableCompoundShape::JoltMutableCompoundShape`.
        public unsafe Const_JoltMutableCompoundShape(Jolt._ByValue_JoltMutableCompoundShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMutableCompoundShape._Underlying *__JoltMutableCompoundShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltMutableCompoundShape._Underlying *_other);
            _UnderlyingPtr = __JoltMutableCompoundShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltMutableCompoundShape::JoltMutableCompoundShape`.
        public Const_JoltMutableCompoundShape(Const_JoltMutableCompoundShape _other) : this(new _ByValue_JoltMutableCompoundShape(_other)) {}

        /// Generated from constructor `JoltMutableCompoundShape::JoltMutableCompoundShape`.
        public Const_JoltMutableCompoundShape(JoltMutableCompoundShape _other) : this((Const_JoltMutableCompoundShape)_other) {}

        /// Generated from method `JoltMutableCompoundShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltMutableCompoundShape_IsValid(_Underlying *_this);
            return __JoltMutableCompoundShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltMutableCompoundShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltMutableCompoundShape_getHandle(_Underlying *_this);
            return __JoltMutableCompoundShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Mutable compound shape — sub-shapes can be modified after finalization.
    /// Call AddSubShape() + Finalize() to build, then use Append/Remove/Modify
    /// for runtime changes.
    /// Generated from class `JoltMutableCompoundShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltMutableCompoundShape : Const_JoltMutableCompoundShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltMutableCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltMutableCompoundShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltMutableCompoundShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltMutableCompoundShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltMutableCompoundShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltMutableCompoundShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltMutableCompoundShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltMutableCompoundShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltMutableCompoundShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMutableCompoundShape._Underlying *__JoltMutableCompoundShape_DefaultConstruct();
            _UnderlyingPtr = __JoltMutableCompoundShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltMutableCompoundShape::JoltMutableCompoundShape`.
        public unsafe JoltMutableCompoundShape(Jolt._ByValue_JoltMutableCompoundShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMutableCompoundShape._Underlying *__JoltMutableCompoundShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltMutableCompoundShape._Underlying *_other);
            _UnderlyingPtr = __JoltMutableCompoundShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltMutableCompoundShape::JoltMutableCompoundShape`.
        public JoltMutableCompoundShape(Const_JoltMutableCompoundShape _other) : this(new _ByValue_JoltMutableCompoundShape(_other)) {}

        /// Generated from constructor `JoltMutableCompoundShape::JoltMutableCompoundShape`.
        public JoltMutableCompoundShape(JoltMutableCompoundShape _other) : this((Const_JoltMutableCompoundShape)_other) {}

        /// Generated from method `JoltMutableCompoundShape::operator=`.
        public unsafe Jolt.JoltMutableCompoundShape Assign(Jolt._ByValue_JoltMutableCompoundShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMutableCompoundShape._Underlying *__JoltMutableCompoundShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltMutableCompoundShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltMutableCompoundShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Add a sub-shape during the build phase (before Finalize).
        /// Generated from method `JoltMutableCompoundShape::AddSubShape`.
        public unsafe void AddSubShape(Jolt.JoltShape? shape, double px, double py, double pz, float qx, float qy, float qz, float qw)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_AddSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_AddSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMutableCompoundShape_AddSubShape(_Underlying *_this, Jolt.JoltShape._Underlying *shape, double px, double py, double pz, float qx, float qy, float qz, float qw);
            __JoltMutableCompoundShape_AddSubShape(_UnderlyingPtr, shape is not null ? shape._UnderlyingPtr : null, px, py, pz, qx, qy, qz, qw);
        }

        /// Generated from method `JoltMutableCompoundShape::Finalize`.
        public unsafe void Finalize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_Finalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_Finalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMutableCompoundShape_Finalize(_Underlying *_this);
            __JoltMutableCompoundShape_Finalize(_UnderlyingPtr);
        }

        /// Append a sub-shape at runtime (after Finalize). Returns the sub-shape index.
        /// Generated from method `JoltMutableCompoundShape::AppendSubShape`.
        public unsafe uint AppendSubShape(Jolt.JoltShape? shape, double px, double py, double pz, float qx, float qy, float qz, float qw)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_AppendSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_AppendSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltMutableCompoundShape_AppendSubShape(_Underlying *_this, Jolt.JoltShape._Underlying *shape, double px, double py, double pz, float qx, float qy, float qz, float qw);
            return __JoltMutableCompoundShape_AppendSubShape(_UnderlyingPtr, shape is not null ? shape._UnderlyingPtr : null, px, py, pz, qx, qy, qz, qw);
        }

        /// Generated from method `JoltMutableCompoundShape::RemoveSubShape`.
        public unsafe void RemoveSubShape(uint index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_RemoveSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_RemoveSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMutableCompoundShape_RemoveSubShape(_Underlying *_this, uint index);
            __JoltMutableCompoundShape_RemoveSubShape(_UnderlyingPtr, index);
        }

        /// Generated from method `JoltMutableCompoundShape::ModifySubShape`.
        public unsafe void ModifySubShape(uint index, double px, double py, double pz, float qx, float qy, float qz, float qw)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_ModifySubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_ModifySubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMutableCompoundShape_ModifySubShape(_Underlying *_this, uint index, double px, double py, double pz, float qx, float qy, float qz, float qw);
            __JoltMutableCompoundShape_ModifySubShape(_UnderlyingPtr, index, px, py, pz, qx, qy, qz, qw);
        }

        /// Generated from method `JoltMutableCompoundShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMutableCompoundShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMutableCompoundShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMutableCompoundShape_Release(_Underlying *_this);
            __JoltMutableCompoundShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltMutableCompoundShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `JoltMutableCompoundShape`/`Const_JoltMutableCompoundShape` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltMutableCompoundShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltMutableCompoundShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltMutableCompoundShape() {PassByMode = Jolt._PassBy.default_construct;}
        public _ByValue_JoltMutableCompoundShape(Const_JoltMutableCompoundShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltMutableCompoundShape(Const_JoltMutableCompoundShape arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltMutableCompoundShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltMutableCompoundShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltMutableCompoundShape`/`Const_JoltMutableCompoundShape` directly.
    public class _InOptMut_JoltMutableCompoundShape
    {
        public JoltMutableCompoundShape? Opt;

        public _InOptMut_JoltMutableCompoundShape() {}
        public _InOptMut_JoltMutableCompoundShape(JoltMutableCompoundShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltMutableCompoundShape(JoltMutableCompoundShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltMutableCompoundShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltMutableCompoundShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltMutableCompoundShape`/`Const_JoltMutableCompoundShape` to pass it to the function.
    public class _InOptConst_JoltMutableCompoundShape
    {
        public Const_JoltMutableCompoundShape? Opt;

        public _InOptConst_JoltMutableCompoundShape() {}
        public _InOptConst_JoltMutableCompoundShape(Const_JoltMutableCompoundShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltMutableCompoundShape(Const_JoltMutableCompoundShape value) {return new(value);}
    }

    /// Triangle-mesh shape (static terrain/level geometry).
    /// Call AddVertex() + AddFace() to build, then Finalize().
    /// Generated from class `JoltMeshShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltMeshShape : Jolt.Object<Const_JoltMeshShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMeshShape_Destroy(_Underlying *_this);
            __JoltMeshShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltMeshShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltMeshShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltMeshShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltMeshShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltMeshShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltMeshShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltMeshShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltMeshShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltMeshShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltMeshShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMeshShape._Underlying *__JoltMeshShape_DefaultConstruct();
            _UnderlyingPtr = __JoltMeshShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltMeshShape::JoltMeshShape`.
        public unsafe Const_JoltMeshShape(Jolt._ByValue_JoltMeshShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMeshShape._Underlying *__JoltMeshShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltMeshShape._Underlying *_other);
            _UnderlyingPtr = __JoltMeshShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltMeshShape::JoltMeshShape`.
        public Const_JoltMeshShape(Const_JoltMeshShape _other) : this(new _ByValue_JoltMeshShape(_other)) {}

        /// Generated from constructor `JoltMeshShape::JoltMeshShape`.
        public Const_JoltMeshShape(JoltMeshShape _other) : this((Const_JoltMeshShape)_other) {}

        /// Generated from method `JoltMeshShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltMeshShape_IsValid(_Underlying *_this);
            return __JoltMeshShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltMeshShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltMeshShape_getHandle(_Underlying *_this);
            return __JoltMeshShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Triangle-mesh shape (static terrain/level geometry).
    /// Call AddVertex() + AddFace() to build, then Finalize().
    /// Generated from class `JoltMeshShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltMeshShape : Const_JoltMeshShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltMeshShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltMeshShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltMeshShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltMeshShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltMeshShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltMeshShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltMeshShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltMeshShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltMeshShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMeshShape._Underlying *__JoltMeshShape_DefaultConstruct();
            _UnderlyingPtr = __JoltMeshShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltMeshShape::JoltMeshShape`.
        public unsafe JoltMeshShape(Jolt._ByValue_JoltMeshShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMeshShape._Underlying *__JoltMeshShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltMeshShape._Underlying *_other);
            _UnderlyingPtr = __JoltMeshShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltMeshShape::JoltMeshShape`.
        public JoltMeshShape(Const_JoltMeshShape _other) : this(new _ByValue_JoltMeshShape(_other)) {}

        /// Generated from constructor `JoltMeshShape::JoltMeshShape`.
        public JoltMeshShape(JoltMeshShape _other) : this((Const_JoltMeshShape)_other) {}

        /// Generated from method `JoltMeshShape::operator=`.
        public unsafe Jolt.JoltMeshShape Assign(Jolt._ByValue_JoltMeshShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltMeshShape._Underlying *__JoltMeshShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltMeshShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltMeshShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltMeshShape::AddVertex`.
        public unsafe void AddVertex(float x, float y, float z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_AddVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_AddVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMeshShape_AddVertex(_Underlying *_this, float x, float y, float z);
            __JoltMeshShape_AddVertex(_UnderlyingPtr, x, y, z);
        }

        /// Generated from method `JoltMeshShape::AddFace`.
        public unsafe void AddFace(uint v0, uint v1, uint v2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_AddFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_AddFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMeshShape_AddFace(_Underlying *_this, uint v0, uint v1, uint v2);
            __JoltMeshShape_AddFace(_UnderlyingPtr, v0, v1, v2);
        }

        /// Generated from method `JoltMeshShape::Finalize`.
        public unsafe void Finalize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_Finalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_Finalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMeshShape_Finalize(_Underlying *_this);
            __JoltMeshShape_Finalize(_UnderlyingPtr);
        }

        /// Generated from method `JoltMeshShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltMeshShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltMeshShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltMeshShape_Release(_Underlying *_this);
            __JoltMeshShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltMeshShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `JoltMeshShape`/`Const_JoltMeshShape` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltMeshShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltMeshShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltMeshShape() {PassByMode = Jolt._PassBy.default_construct;}
        public _ByValue_JoltMeshShape(Const_JoltMeshShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltMeshShape(Const_JoltMeshShape arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltMeshShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltMeshShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltMeshShape`/`Const_JoltMeshShape` directly.
    public class _InOptMut_JoltMeshShape
    {
        public JoltMeshShape? Opt;

        public _InOptMut_JoltMeshShape() {}
        public _InOptMut_JoltMeshShape(JoltMeshShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltMeshShape(JoltMeshShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltMeshShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltMeshShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltMeshShape`/`Const_JoltMeshShape` to pass it to the function.
    public class _InOptConst_JoltMeshShape
    {
        public Const_JoltMeshShape? Opt;

        public _InOptConst_JoltMeshShape() {}
        public _InOptConst_JoltMeshShape(Const_JoltMeshShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltMeshShape(Const_JoltMeshShape value) {return new(value);}
    }

    /// Convex hull shape built from a point cloud.
    /// Call AddPoint() for each input point, then Finalize(convexRadius).
    /// Generated from class `JoltConvexHullShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltConvexHullShape : Jolt.Object<Const_JoltConvexHullShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltConvexHullShape_Destroy(_Underlying *_this);
            __JoltConvexHullShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltConvexHullShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltConvexHullShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltConvexHullShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltConvexHullShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltConvexHullShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltConvexHullShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltConvexHullShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltConvexHullShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltConvexHullShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltConvexHullShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConvexHullShape._Underlying *__JoltConvexHullShape_DefaultConstruct();
            _UnderlyingPtr = __JoltConvexHullShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltConvexHullShape::JoltConvexHullShape`.
        public unsafe Const_JoltConvexHullShape(Jolt._ByValue_JoltConvexHullShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConvexHullShape._Underlying *__JoltConvexHullShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltConvexHullShape._Underlying *_other);
            _UnderlyingPtr = __JoltConvexHullShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltConvexHullShape::JoltConvexHullShape`.
        public Const_JoltConvexHullShape(Const_JoltConvexHullShape _other) : this(new _ByValue_JoltConvexHullShape(_other)) {}

        /// Generated from constructor `JoltConvexHullShape::JoltConvexHullShape`.
        public Const_JoltConvexHullShape(JoltConvexHullShape _other) : this((Const_JoltConvexHullShape)_other) {}

        /// Generated from method `JoltConvexHullShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltConvexHullShape_IsValid(_Underlying *_this);
            return __JoltConvexHullShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltConvexHullShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltConvexHullShape_getHandle(_Underlying *_this);
            return __JoltConvexHullShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Convex hull shape built from a point cloud.
    /// Call AddPoint() for each input point, then Finalize(convexRadius).
    /// Generated from class `JoltConvexHullShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltConvexHullShape : Const_JoltConvexHullShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltConvexHullShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltConvexHullShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltConvexHullShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltConvexHullShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltConvexHullShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltConvexHullShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltConvexHullShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltConvexHullShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltConvexHullShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConvexHullShape._Underlying *__JoltConvexHullShape_DefaultConstruct();
            _UnderlyingPtr = __JoltConvexHullShape_DefaultConstruct();
        }

        /// Generated from constructor `JoltConvexHullShape::JoltConvexHullShape`.
        public unsafe JoltConvexHullShape(Jolt._ByValue_JoltConvexHullShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConvexHullShape._Underlying *__JoltConvexHullShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltConvexHullShape._Underlying *_other);
            _UnderlyingPtr = __JoltConvexHullShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltConvexHullShape::JoltConvexHullShape`.
        public JoltConvexHullShape(Const_JoltConvexHullShape _other) : this(new _ByValue_JoltConvexHullShape(_other)) {}

        /// Generated from constructor `JoltConvexHullShape::JoltConvexHullShape`.
        public JoltConvexHullShape(JoltConvexHullShape _other) : this((Const_JoltConvexHullShape)_other) {}

        /// Generated from method `JoltConvexHullShape::operator=`.
        public unsafe Jolt.JoltConvexHullShape Assign(Jolt._ByValue_JoltConvexHullShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConvexHullShape._Underlying *__JoltConvexHullShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltConvexHullShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltConvexHullShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltConvexHullShape::AddPoint`.
        public unsafe void AddPoint(float x, float y, float z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_AddPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_AddPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltConvexHullShape_AddPoint(_Underlying *_this, float x, float y, float z);
            __JoltConvexHullShape_AddPoint(_UnderlyingPtr, x, y, z);
        }

        /// Generated from method `JoltConvexHullShape::Finalize`.
        public unsafe void Finalize(float convexRadius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_Finalize_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_Finalize_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltConvexHullShape_Finalize_1(_Underlying *_this, float convexRadius);
            __JoltConvexHullShape_Finalize_1(_UnderlyingPtr, convexRadius);
        }

        /// Generated from method `JoltConvexHullShape::Finalize`.
        public unsafe void Finalize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_Finalize_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_Finalize_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltConvexHullShape_Finalize_0(_Underlying *_this);
            __JoltConvexHullShape_Finalize_0(_UnderlyingPtr);
        }

        /// Generated from method `JoltConvexHullShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltConvexHullShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltConvexHullShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltConvexHullShape_Release(_Underlying *_this);
            __JoltConvexHullShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltConvexHullShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `JoltConvexHullShape`/`Const_JoltConvexHullShape` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltConvexHullShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltConvexHullShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltConvexHullShape() {PassByMode = Jolt._PassBy.default_construct;}
        public _ByValue_JoltConvexHullShape(Const_JoltConvexHullShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltConvexHullShape(Const_JoltConvexHullShape arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltConvexHullShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltConvexHullShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltConvexHullShape`/`Const_JoltConvexHullShape` directly.
    public class _InOptMut_JoltConvexHullShape
    {
        public JoltConvexHullShape? Opt;

        public _InOptMut_JoltConvexHullShape() {}
        public _InOptMut_JoltConvexHullShape(JoltConvexHullShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltConvexHullShape(JoltConvexHullShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltConvexHullShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltConvexHullShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltConvexHullShape`/`Const_JoltConvexHullShape` to pass it to the function.
    public class _InOptConst_JoltConvexHullShape
    {
        public Const_JoltConvexHullShape? Opt;

        public _InOptConst_JoltConvexHullShape() {}
        public _InOptConst_JoltConvexHullShape(Const_JoltConvexHullShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltConvexHullShape(Const_JoltConvexHullShape value) {return new(value);}
    }

    /// Height-field terrain shape (uniform sampleCount × sampleCount grid).
    /// Call SetSample() to fill height values, then Finalize().
    /// Position of sample (x,y) = offset + scale * (x, height, y).
    /// Generated from class `JoltHeightFieldShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the const half of the class.
    public class Const_JoltHeightFieldShape : Jolt.Object<Const_JoltHeightFieldShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHeightFieldShape_Destroy(_Underlying *_this);
            __JoltHeightFieldShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltHeightFieldShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Jolt.Const_JoltShape(Const_JoltHeightFieldShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.Const_JoltShape._Underlying *__JoltHeightFieldShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.Const_JoltShape ret = new(__JoltHeightFieldShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JoltHeightFieldShape?(Jolt.Const_JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltHeightFieldShape_DynamicDowncastFrom_JoltShape(Jolt.Const_JoltShape._Underlying *_this);
            var ptr = __JoltHeightFieldShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_JoltHeightFieldShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JoltHeightFieldShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
        public unsafe Const_JoltHeightFieldShape(Jolt._ByValue_JoltHeightFieldShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHeightFieldShape._Underlying *__JoltHeightFieldShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltHeightFieldShape._Underlying *_other);
            _UnderlyingPtr = __JoltHeightFieldShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
        public Const_JoltHeightFieldShape(Const_JoltHeightFieldShape _other) : this(new _ByValue_JoltHeightFieldShape(_other)) {}

        /// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
        public Const_JoltHeightFieldShape(JoltHeightFieldShape _other) : this((Const_JoltHeightFieldShape)_other) {}

        /// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
        public unsafe Const_JoltHeightFieldShape(uint sampleCount, float offsetX, float offsetY, float offsetZ, float scaleX, float scaleY, float scaleZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHeightFieldShape._Underlying *__JoltHeightFieldShape_Construct(uint sampleCount, float offsetX, float offsetY, float offsetZ, float scaleX, float scaleY, float scaleZ);
            _UnderlyingPtr = __JoltHeightFieldShape_Construct(sampleCount, offsetX, offsetY, offsetZ, scaleX, scaleY, scaleZ);
        }

        /// Generated from method `JoltHeightFieldShape::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltHeightFieldShape_IsValid(_Underlying *_this);
            return __JoltHeightFieldShape_IsValid(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltHeightFieldShape::getHandle`.
        /// Returns a mutable pointer.
        public unsafe void *GetHandle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_getHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JoltHeightFieldShape_getHandle(_Underlying *_this);
            return __JoltHeightFieldShape_getHandle(_UnderlyingPtr);
        }
    }

    /// Height-field terrain shape (uniform sampleCount × sampleCount grid).
    /// Call SetSample() to fill height values, then Finalize().
    /// Position of sample (x,y) = offset + scale * (x, height, y).
    /// Generated from class `JoltHeightFieldShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JoltShape`
    /// This is the non-const half of the class.
    public class JoltHeightFieldShape : Const_JoltHeightFieldShape
    {
        // Upcasts:
        public static unsafe implicit operator Jolt.JoltShape(JoltHeightFieldShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_UpcastTo_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltShape._Underlying *__JoltHeightFieldShape_UpcastTo_JoltShape(_Underlying *_this);
            Jolt.JoltShape ret = new(__JoltHeightFieldShape_UpcastTo_JoltShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator JoltHeightFieldShape?(Jolt.JoltShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_DynamicDowncastFrom_JoltShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JoltHeightFieldShape_DynamicDowncastFrom_JoltShape(Jolt.JoltShape._Underlying *_this);
            var ptr = __JoltHeightFieldShape_DynamicDowncastFrom_JoltShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            JoltHeightFieldShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JoltHeightFieldShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
        public unsafe JoltHeightFieldShape(Jolt._ByValue_JoltHeightFieldShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHeightFieldShape._Underlying *__JoltHeightFieldShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JoltHeightFieldShape._Underlying *_other);
            _UnderlyingPtr = __JoltHeightFieldShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
        public JoltHeightFieldShape(Const_JoltHeightFieldShape _other) : this(new _ByValue_JoltHeightFieldShape(_other)) {}

        /// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
        public JoltHeightFieldShape(JoltHeightFieldShape _other) : this((Const_JoltHeightFieldShape)_other) {}

        /// Generated from constructor `JoltHeightFieldShape::JoltHeightFieldShape`.
        public unsafe JoltHeightFieldShape(uint sampleCount, float offsetX, float offsetY, float offsetZ, float scaleX, float scaleY, float scaleZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHeightFieldShape._Underlying *__JoltHeightFieldShape_Construct(uint sampleCount, float offsetX, float offsetY, float offsetZ, float scaleX, float scaleY, float scaleZ);
            _UnderlyingPtr = __JoltHeightFieldShape_Construct(sampleCount, offsetX, offsetY, offsetZ, scaleX, scaleY, scaleZ);
        }

        /// Generated from method `JoltHeightFieldShape::operator=`.
        public unsafe Jolt.JoltHeightFieldShape Assign(Jolt._ByValue_JoltHeightFieldShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHeightFieldShape._Underlying *__JoltHeightFieldShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JoltHeightFieldShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JoltHeightFieldShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JoltHeightFieldShape::SetSample`.
        public unsafe void SetSample(uint x, uint y, float height)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_SetSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_SetSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHeightFieldShape_SetSample(_Underlying *_this, uint x, uint y, float height);
            __JoltHeightFieldShape_SetSample(_UnderlyingPtr, x, y, height);
        }

        /// Generated from method `JoltHeightFieldShape::Finalize`.
        public unsafe void Finalize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_Finalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_Finalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHeightFieldShape_Finalize(_Underlying *_this);
            __JoltHeightFieldShape_Finalize(_UnderlyingPtr);
        }

        /// Generated from method `JoltHeightFieldShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHeightFieldShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHeightFieldShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHeightFieldShape_Release(_Underlying *_this);
            __JoltHeightFieldShape_Release(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JoltHeightFieldShape` by value.
    /// Usage:
    /// * Pass an instance of `JoltHeightFieldShape`/`Const_JoltHeightFieldShape` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JoltHeightFieldShape
    {
        #pragma warning disable CS0649
        internal readonly Const_JoltHeightFieldShape? Value;
        #pragma warning restore CS0649
        internal readonly Jolt._PassBy PassByMode;
        public _ByValue_JoltHeightFieldShape(Const_JoltHeightFieldShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
        public static implicit operator _ByValue_JoltHeightFieldShape(Const_JoltHeightFieldShape arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `JoltHeightFieldShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltHeightFieldShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltHeightFieldShape`/`Const_JoltHeightFieldShape` directly.
    public class _InOptMut_JoltHeightFieldShape
    {
        public JoltHeightFieldShape? Opt;

        public _InOptMut_JoltHeightFieldShape() {}
        public _InOptMut_JoltHeightFieldShape(JoltHeightFieldShape value) {Opt = value;}
        public static implicit operator _InOptMut_JoltHeightFieldShape(JoltHeightFieldShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltHeightFieldShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltHeightFieldShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltHeightFieldShape`/`Const_JoltHeightFieldShape` to pass it to the function.
    public class _InOptConst_JoltHeightFieldShape
    {
        public Const_JoltHeightFieldShape? Opt;

        public _InOptConst_JoltHeightFieldShape() {}
        public _InOptConst_JoltHeightFieldShape(Const_JoltHeightFieldShape value) {Opt = value;}
        public static implicit operator _InOptConst_JoltHeightFieldShape(Const_JoltHeightFieldShape value) {return new(value);}
    }

    /// Parameters used when adding a body to the physics system.
    /// Generated from class `JoltBodyCreationSettings`.
    /// This is the const half of the class.
    public class Const_JoltBodyCreationSettings : Jolt.Object<Const_JoltBodyCreationSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_Destroy(_Underlying *_this);
            __JoltBodyCreationSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltBodyCreationSettings() {Dispose(false);}

        internal unsafe Const_JoltBodyCreationSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
        public unsafe Const_JoltBodyCreationSettings(Jolt.Const_JoltBodyCreationSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyCreationSettings._Underlying *__JoltBodyCreationSettings_ConstructFromAnother(Jolt.JoltBodyCreationSettings._Underlying *_other);
            _UnderlyingPtr = __JoltBodyCreationSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
        public Const_JoltBodyCreationSettings(JoltBodyCreationSettings _other) : this((Const_JoltBodyCreationSettings)_other) {}

        /// Create settings for a body with the given shape.
        /// layer should be one of JoltObjectLayer values (0=NonMoving, 1=Moving).
        /// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
        public unsafe Const_JoltBodyCreationSettings(Jolt.JoltShape? shape, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, int motionType, uint objectLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_Construct_10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_Construct_10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyCreationSettings._Underlying *__JoltBodyCreationSettings_Construct_10(Jolt.JoltShape._Underlying *shape, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, int motionType, uint objectLayer);
            _UnderlyingPtr = __JoltBodyCreationSettings_Construct_10(shape is not null ? shape._UnderlyingPtr : null, posX, posY, posZ, qx, qy, qz, qw, motionType, objectLayer);
        }

        /// Shorthand: identity rotation.
        /// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
        public unsafe Const_JoltBodyCreationSettings(Jolt.JoltShape? shape, double posX, double posY, double posZ, int motionType, uint objectLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_Construct_6", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_Construct_6", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyCreationSettings._Underlying *__JoltBodyCreationSettings_Construct_6(Jolt.JoltShape._Underlying *shape, double posX, double posY, double posZ, int motionType, uint objectLayer);
            _UnderlyingPtr = __JoltBodyCreationSettings_Construct_6(shape is not null ? shape._UnderlyingPtr : null, posX, posY, posZ, motionType, objectLayer);
        }
    }

    /// Parameters used when adding a body to the physics system.
    /// Generated from class `JoltBodyCreationSettings`.
    /// This is the non-const half of the class.
    public class JoltBodyCreationSettings : Const_JoltBodyCreationSettings
    {
        internal unsafe JoltBodyCreationSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
        public unsafe JoltBodyCreationSettings(Jolt.Const_JoltBodyCreationSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyCreationSettings._Underlying *__JoltBodyCreationSettings_ConstructFromAnother(Jolt.JoltBodyCreationSettings._Underlying *_other);
            _UnderlyingPtr = __JoltBodyCreationSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
        public JoltBodyCreationSettings(JoltBodyCreationSettings _other) : this((Const_JoltBodyCreationSettings)_other) {}

        /// Create settings for a body with the given shape.
        /// layer should be one of JoltObjectLayer values (0=NonMoving, 1=Moving).
        /// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
        public unsafe JoltBodyCreationSettings(Jolt.JoltShape? shape, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, int motionType, uint objectLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_Construct_10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_Construct_10", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyCreationSettings._Underlying *__JoltBodyCreationSettings_Construct_10(Jolt.JoltShape._Underlying *shape, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, int motionType, uint objectLayer);
            _UnderlyingPtr = __JoltBodyCreationSettings_Construct_10(shape is not null ? shape._UnderlyingPtr : null, posX, posY, posZ, qx, qy, qz, qw, motionType, objectLayer);
        }

        /// Shorthand: identity rotation.
        /// Generated from constructor `JoltBodyCreationSettings::JoltBodyCreationSettings`.
        public unsafe JoltBodyCreationSettings(Jolt.JoltShape? shape, double posX, double posY, double posZ, int motionType, uint objectLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_Construct_6", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_Construct_6", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyCreationSettings._Underlying *__JoltBodyCreationSettings_Construct_6(Jolt.JoltShape._Underlying *shape, double posX, double posY, double posZ, int motionType, uint objectLayer);
            _UnderlyingPtr = __JoltBodyCreationSettings_Construct_6(shape is not null ? shape._UnderlyingPtr : null, posX, posY, posZ, motionType, objectLayer);
        }

        /// Generated from method `JoltBodyCreationSettings::operator=`.
        public unsafe Jolt.JoltBodyCreationSettings Assign(Jolt.Const_JoltBodyCreationSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyCreationSettings._Underlying *__JoltBodyCreationSettings_AssignFromAnother(_Underlying *_this, Jolt.JoltBodyCreationSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltBodyCreationSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JoltBodyCreationSettings::SetPosition`.
        public unsafe void SetPosition(double x, double y, double z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_SetPosition(_Underlying *_this, double x, double y, double z);
            __JoltBodyCreationSettings_SetPosition(_UnderlyingPtr, x, y, z);
        }

        /// Generated from method `JoltBodyCreationSettings::SetRotation`.
        public unsafe void SetRotation(float qx, float qy, float qz, float qw)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_SetRotation(_Underlying *_this, float qx, float qy, float qz, float qw);
            __JoltBodyCreationSettings_SetRotation(_UnderlyingPtr, qx, qy, qz, qw);
        }

        /// Generated from method `JoltBodyCreationSettings::SetLinearVelocity`.
        public unsafe void SetLinearVelocity(float vx, float vy, float vz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_SetLinearVelocity(_Underlying *_this, float vx, float vy, float vz);
            __JoltBodyCreationSettings_SetLinearVelocity(_UnderlyingPtr, vx, vy, vz);
        }

        /// Generated from method `JoltBodyCreationSettings::SetAngularVelocity`.
        public unsafe void SetAngularVelocity(float vx, float vy, float vz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_SetAngularVelocity(_Underlying *_this, float vx, float vy, float vz);
            __JoltBodyCreationSettings_SetAngularVelocity(_UnderlyingPtr, vx, vy, vz);
        }

        /// Generated from method `JoltBodyCreationSettings::SetFriction`.
        public unsafe void SetFriction(float f)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_SetFriction(_Underlying *_this, float f);
            __JoltBodyCreationSettings_SetFriction(_UnderlyingPtr, f);
        }

        /// Generated from method `JoltBodyCreationSettings::SetRestitution`.
        public unsafe void SetRestitution(float r)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_SetRestitution(_Underlying *_this, float r);
            __JoltBodyCreationSettings_SetRestitution(_UnderlyingPtr, r);
        }

        /// Generated from method `JoltBodyCreationSettings::SetGravityFactor`.
        public unsafe void SetGravityFactor(float f)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_SetGravityFactor(_Underlying *_this, float f);
            __JoltBodyCreationSettings_SetGravityFactor(_UnderlyingPtr, f);
        }

        /// Generated from method `JoltBodyCreationSettings::SetIsSensor`.
        public unsafe void SetIsSensor(bool isSensor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_SetIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_SetIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_SetIsSensor(_Underlying *_this, byte isSensor);
            __JoltBodyCreationSettings_SetIsSensor(_UnderlyingPtr, isSensor ? (byte)1 : (byte)0);
        }

        /// Generated from method `JoltBodyCreationSettings::SetObjectLayer`.
        public unsafe void SetObjectLayer(uint layer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltBodyCreationSettings_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltBodyCreationSettings_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltBodyCreationSettings_SetObjectLayer(_Underlying *_this, uint layer);
            __JoltBodyCreationSettings_SetObjectLayer(_UnderlyingPtr, layer);
        }
    }

    /// This is used for optional parameters of class `JoltBodyCreationSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltBodyCreationSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBodyCreationSettings`/`Const_JoltBodyCreationSettings` directly.
    public class _InOptMut_JoltBodyCreationSettings
    {
        public JoltBodyCreationSettings? Opt;

        public _InOptMut_JoltBodyCreationSettings() {}
        public _InOptMut_JoltBodyCreationSettings(JoltBodyCreationSettings value) {Opt = value;}
        public static implicit operator _InOptMut_JoltBodyCreationSettings(JoltBodyCreationSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltBodyCreationSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltBodyCreationSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltBodyCreationSettings`/`Const_JoltBodyCreationSettings` to pass it to the function.
    public class _InOptConst_JoltBodyCreationSettings
    {
        public Const_JoltBodyCreationSettings? Opt;

        public _InOptConst_JoltBodyCreationSettings() {}
        public _InOptConst_JoltBodyCreationSettings(Const_JoltBodyCreationSettings value) {Opt = value;}
        public static implicit operator _InOptConst_JoltBodyCreationSettings(Const_JoltBodyCreationSettings value) {return new(value);}
    }

    /// Defines the mesh topology of a soft body: vertices, faces, edge constraints.
    /// Shared (ref-counted) between multiple soft body instances.
    /// Build order: AddVertex → AddFace → AddEdgeConstraint (or CalculateEdgeLengths) → Optimize.
    /// Generated from class `JoltSoftBodySharedSettings`.
    /// This is the const half of the class.
    public class Const_JoltSoftBodySharedSettings : Jolt.Object<Const_JoltSoftBodySharedSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodySharedSettings_Destroy(_Underlying *_this);
            __JoltSoftBodySharedSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltSoftBodySharedSettings() {Dispose(false);}

        internal unsafe Const_JoltSoftBodySharedSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltSoftBodySharedSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodySharedSettings._Underlying *__JoltSoftBodySharedSettings_DefaultConstruct();
            _UnderlyingPtr = __JoltSoftBodySharedSettings_DefaultConstruct();
        }

        /// Generated from constructor `JoltSoftBodySharedSettings::JoltSoftBodySharedSettings`.
        public unsafe Const_JoltSoftBodySharedSettings(Jolt.Const_JoltSoftBodySharedSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodySharedSettings._Underlying *__JoltSoftBodySharedSettings_ConstructFromAnother(Jolt.JoltSoftBodySharedSettings._Underlying *_other);
            _UnderlyingPtr = __JoltSoftBodySharedSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltSoftBodySharedSettings::JoltSoftBodySharedSettings`.
        public Const_JoltSoftBodySharedSettings(JoltSoftBodySharedSettings _other) : this((Const_JoltSoftBodySharedSettings)_other) {}

        /// Generated from method `JoltSoftBodySharedSettings::GetVertexCount`.
        public unsafe int GetVertexCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_GetVertexCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_GetVertexCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JoltSoftBodySharedSettings_GetVertexCount(_Underlying *_this);
            return __JoltSoftBodySharedSettings_GetVertexCount(_UnderlyingPtr);
        }

        /// Generated from method `JoltSoftBodySharedSettings::GetFaceCount`.
        public unsafe int GetFaceCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_GetFaceCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_GetFaceCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JoltSoftBodySharedSettings_GetFaceCount(_Underlying *_this);
            return __JoltSoftBodySharedSettings_GetFaceCount(_UnderlyingPtr);
        }

        /// Generated from method `JoltSoftBodySharedSettings::GetEdgeCount`.
        public unsafe int GetEdgeCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_GetEdgeCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_GetEdgeCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JoltSoftBodySharedSettings_GetEdgeCount(_Underlying *_this);
            return __JoltSoftBodySharedSettings_GetEdgeCount(_UnderlyingPtr);
        }
    }

    /// Defines the mesh topology of a soft body: vertices, faces, edge constraints.
    /// Shared (ref-counted) between multiple soft body instances.
    /// Build order: AddVertex → AddFace → AddEdgeConstraint (or CalculateEdgeLengths) → Optimize.
    /// Generated from class `JoltSoftBodySharedSettings`.
    /// This is the non-const half of the class.
    public class JoltSoftBodySharedSettings : Const_JoltSoftBodySharedSettings
    {
        internal unsafe JoltSoftBodySharedSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltSoftBodySharedSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodySharedSettings._Underlying *__JoltSoftBodySharedSettings_DefaultConstruct();
            _UnderlyingPtr = __JoltSoftBodySharedSettings_DefaultConstruct();
        }

        /// Generated from constructor `JoltSoftBodySharedSettings::JoltSoftBodySharedSettings`.
        public unsafe JoltSoftBodySharedSettings(Jolt.Const_JoltSoftBodySharedSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodySharedSettings._Underlying *__JoltSoftBodySharedSettings_ConstructFromAnother(Jolt.JoltSoftBodySharedSettings._Underlying *_other);
            _UnderlyingPtr = __JoltSoftBodySharedSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltSoftBodySharedSettings::JoltSoftBodySharedSettings`.
        public JoltSoftBodySharedSettings(JoltSoftBodySharedSettings _other) : this((Const_JoltSoftBodySharedSettings)_other) {}

        /// Generated from method `JoltSoftBodySharedSettings::operator=`.
        public unsafe Jolt.JoltSoftBodySharedSettings Assign(Jolt.Const_JoltSoftBodySharedSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodySharedSettings._Underlying *__JoltSoftBodySharedSettings_AssignFromAnother(_Underlying *_this, Jolt.JoltSoftBodySharedSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltSoftBodySharedSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Add a particle at (x,y,z). invMass=0 pins it (kinematic vertex).
        /// Generated from method `JoltSoftBodySharedSettings::AddVertex`.
        public unsafe void AddVertex(float x, float y, float z, float invMass)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_AddVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_AddVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodySharedSettings_AddVertex(_Underlying *_this, float x, float y, float z, float invMass);
            __JoltSoftBodySharedSettings_AddVertex(_UnderlyingPtr, x, y, z, invMass);
        }

        /// Add a triangular face by vertex indices.
        /// Generated from method `JoltSoftBodySharedSettings::AddFace`.
        public unsafe void AddFace(uint v0, uint v1, uint v2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_AddFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_AddFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodySharedSettings_AddFace(_Underlying *_this, uint v0, uint v1, uint v2);
            __JoltSoftBodySharedSettings_AddFace(_UnderlyingPtr, v0, v1, v2);
        }

        /// Add an explicit edge-length spring between two vertices.
        /// compliance: 0 = perfectly rigid, larger = softer.
        /// restLength: target length; pass <=0 to auto-compute from current vertex positions.
        /// Generated from method `JoltSoftBodySharedSettings::AddEdgeConstraint`.
        public unsafe void AddEdgeConstraint(uint v0, uint v1, float compliance, float restLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_AddEdgeConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_AddEdgeConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodySharedSettings_AddEdgeConstraint(_Underlying *_this, uint v0, uint v1, float compliance, float restLength);
            __JoltSoftBodySharedSettings_AddEdgeConstraint(_UnderlyingPtr, v0, v1, compliance, restLength);
        }

        /// Convenience: add edge with auto-computed rest length.
        /// Generated from method `JoltSoftBodySharedSettings::AddEdgeConstraintAuto`.
        public unsafe void AddEdgeConstraintAuto(uint v0, uint v1, float compliance)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_AddEdgeConstraintAuto", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_AddEdgeConstraintAuto", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodySharedSettings_AddEdgeConstraintAuto(_Underlying *_this, uint v0, uint v1, float compliance);
            __JoltSoftBodySharedSettings_AddEdgeConstraintAuto(_UnderlyingPtr, v0, v1, compliance);
        }

        /// Compute rest lengths for all edges whose mRestLength == 1.0 (the default).
        /// Generated from method `JoltSoftBodySharedSettings::CalculateEdgeLengths`.
        public unsafe void CalculateEdgeLengths()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_CalculateEdgeLengths", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_CalculateEdgeLengths", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodySharedSettings_CalculateEdgeLengths(_Underlying *_this);
            __JoltSoftBodySharedSettings_CalculateEdgeLengths(_UnderlyingPtr);
        }

        /// Must be called once after building. Reorders constraints for parallel solving.
        /// Generated from method `JoltSoftBodySharedSettings::Optimize`.
        public unsafe void Optimize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodySharedSettings_Optimize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodySharedSettings_Optimize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodySharedSettings_Optimize(_Underlying *_this);
            __JoltSoftBodySharedSettings_Optimize(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `JoltSoftBodySharedSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltSoftBodySharedSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltSoftBodySharedSettings`/`Const_JoltSoftBodySharedSettings` directly.
    public class _InOptMut_JoltSoftBodySharedSettings
    {
        public JoltSoftBodySharedSettings? Opt;

        public _InOptMut_JoltSoftBodySharedSettings() {}
        public _InOptMut_JoltSoftBodySharedSettings(JoltSoftBodySharedSettings value) {Opt = value;}
        public static implicit operator _InOptMut_JoltSoftBodySharedSettings(JoltSoftBodySharedSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltSoftBodySharedSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltSoftBodySharedSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltSoftBodySharedSettings`/`Const_JoltSoftBodySharedSettings` to pass it to the function.
    public class _InOptConst_JoltSoftBodySharedSettings
    {
        public Const_JoltSoftBodySharedSettings? Opt;

        public _InOptConst_JoltSoftBodySharedSettings() {}
        public _InOptConst_JoltSoftBodySharedSettings(Const_JoltSoftBodySharedSettings value) {Opt = value;}
        public static implicit operator _InOptConst_JoltSoftBodySharedSettings(Const_JoltSoftBodySharedSettings value) {return new(value);}
    }

    /// Parameters for creating a soft body.
    /// Generated from class `JoltSoftBodyCreationSettings`.
    /// This is the const half of the class.
    public class Const_JoltSoftBodyCreationSettings : Jolt.Object<Const_JoltSoftBodyCreationSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodyCreationSettings_Destroy(_Underlying *_this);
            __JoltSoftBodyCreationSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltSoftBodyCreationSettings() {Dispose(false);}

        internal unsafe Const_JoltSoftBodyCreationSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
        public unsafe Const_JoltSoftBodyCreationSettings(Jolt.Const_JoltSoftBodyCreationSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodyCreationSettings._Underlying *__JoltSoftBodyCreationSettings_ConstructFromAnother(Jolt.JoltSoftBodyCreationSettings._Underlying *_other);
            _UnderlyingPtr = __JoltSoftBodyCreationSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
        public Const_JoltSoftBodyCreationSettings(JoltSoftBodyCreationSettings _other) : this((Const_JoltSoftBodyCreationSettings)_other) {}

        /// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
        public unsafe Const_JoltSoftBodyCreationSettings(Jolt.JoltSoftBodySharedSettings? settings, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, uint objectLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodyCreationSettings._Underlying *__JoltSoftBodyCreationSettings_Construct_9(Jolt.JoltSoftBodySharedSettings._Underlying *settings, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, uint objectLayer);
            _UnderlyingPtr = __JoltSoftBodyCreationSettings_Construct_9(settings is not null ? settings._UnderlyingPtr : null, posX, posY, posZ, qx, qy, qz, qw, objectLayer);
        }

        /// Convenience: identity rotation.
        /// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
        public unsafe Const_JoltSoftBodyCreationSettings(Jolt.JoltSoftBodySharedSettings? settings, double posX, double posY, double posZ, uint objectLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodyCreationSettings._Underlying *__JoltSoftBodyCreationSettings_Construct_5(Jolt.JoltSoftBodySharedSettings._Underlying *settings, double posX, double posY, double posZ, uint objectLayer);
            _UnderlyingPtr = __JoltSoftBodyCreationSettings_Construct_5(settings is not null ? settings._UnderlyingPtr : null, posX, posY, posZ, objectLayer);
        }
    }

    /// Parameters for creating a soft body.
    /// Generated from class `JoltSoftBodyCreationSettings`.
    /// This is the non-const half of the class.
    public class JoltSoftBodyCreationSettings : Const_JoltSoftBodyCreationSettings
    {
        internal unsafe JoltSoftBodyCreationSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
        public unsafe JoltSoftBodyCreationSettings(Jolt.Const_JoltSoftBodyCreationSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodyCreationSettings._Underlying *__JoltSoftBodyCreationSettings_ConstructFromAnother(Jolt.JoltSoftBodyCreationSettings._Underlying *_other);
            _UnderlyingPtr = __JoltSoftBodyCreationSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
        public JoltSoftBodyCreationSettings(JoltSoftBodyCreationSettings _other) : this((Const_JoltSoftBodyCreationSettings)_other) {}

        /// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
        public unsafe JoltSoftBodyCreationSettings(Jolt.JoltSoftBodySharedSettings? settings, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, uint objectLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodyCreationSettings._Underlying *__JoltSoftBodyCreationSettings_Construct_9(Jolt.JoltSoftBodySharedSettings._Underlying *settings, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, uint objectLayer);
            _UnderlyingPtr = __JoltSoftBodyCreationSettings_Construct_9(settings is not null ? settings._UnderlyingPtr : null, posX, posY, posZ, qx, qy, qz, qw, objectLayer);
        }

        /// Convenience: identity rotation.
        /// Generated from constructor `JoltSoftBodyCreationSettings::JoltSoftBodyCreationSettings`.
        public unsafe JoltSoftBodyCreationSettings(Jolt.JoltSoftBodySharedSettings? settings, double posX, double posY, double posZ, uint objectLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodyCreationSettings._Underlying *__JoltSoftBodyCreationSettings_Construct_5(Jolt.JoltSoftBodySharedSettings._Underlying *settings, double posX, double posY, double posZ, uint objectLayer);
            _UnderlyingPtr = __JoltSoftBodyCreationSettings_Construct_5(settings is not null ? settings._UnderlyingPtr : null, posX, posY, posZ, objectLayer);
        }

        /// Generated from method `JoltSoftBodyCreationSettings::operator=`.
        public unsafe Jolt.JoltSoftBodyCreationSettings Assign(Jolt.Const_JoltSoftBodyCreationSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltSoftBodyCreationSettings._Underlying *__JoltSoftBodyCreationSettings_AssignFromAnother(_Underlying *_this, Jolt.JoltSoftBodyCreationSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltSoftBodyCreationSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JoltSoftBodyCreationSettings::SetPosition`.
        public unsafe void SetPosition(double x, double y, double z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodyCreationSettings_SetPosition(_Underlying *_this, double x, double y, double z);
            __JoltSoftBodyCreationSettings_SetPosition(_UnderlyingPtr, x, y, z);
        }

        /// Generated from method `JoltSoftBodyCreationSettings::SetRotation`.
        public unsafe void SetRotation(float qx, float qy, float qz, float qw)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodyCreationSettings_SetRotation(_Underlying *_this, float qx, float qy, float qz, float qw);
            __JoltSoftBodyCreationSettings_SetRotation(_UnderlyingPtr, qx, qy, qz, qw);
        }

        /// Generated from method `JoltSoftBodyCreationSettings::SetObjectLayer`.
        public unsafe void SetObjectLayer(uint layer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodyCreationSettings_SetObjectLayer(_Underlying *_this, uint layer);
            __JoltSoftBodyCreationSettings_SetObjectLayer(_UnderlyingPtr, layer);
        }

        /// Generated from method `JoltSoftBodyCreationSettings::SetMakeRotationIdentity`.
        public unsafe void SetMakeRotationIdentity(bool v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetMakeRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetMakeRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodyCreationSettings_SetMakeRotationIdentity(_Underlying *_this, byte v);
            __JoltSoftBodyCreationSettings_SetMakeRotationIdentity(_UnderlyingPtr, v ? (byte)1 : (byte)0);
        }

        /// Generated from method `JoltSoftBodyCreationSettings::SetNumIterations`.
        public unsafe void SetNumIterations(uint n)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltSoftBodyCreationSettings_SetNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltSoftBodyCreationSettings_SetNumIterations(_Underlying *_this, uint n);
            __JoltSoftBodyCreationSettings_SetNumIterations(_UnderlyingPtr, n);
        }
    }

    /// This is used for optional parameters of class `JoltSoftBodyCreationSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltSoftBodyCreationSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltSoftBodyCreationSettings`/`Const_JoltSoftBodyCreationSettings` directly.
    public class _InOptMut_JoltSoftBodyCreationSettings
    {
        public JoltSoftBodyCreationSettings? Opt;

        public _InOptMut_JoltSoftBodyCreationSettings() {}
        public _InOptMut_JoltSoftBodyCreationSettings(JoltSoftBodyCreationSettings value) {Opt = value;}
        public static implicit operator _InOptMut_JoltSoftBodyCreationSettings(JoltSoftBodyCreationSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltSoftBodyCreationSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltSoftBodyCreationSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltSoftBodyCreationSettings`/`Const_JoltSoftBodyCreationSettings` to pass it to the function.
    public class _InOptConst_JoltSoftBodyCreationSettings
    {
        public Const_JoltSoftBodyCreationSettings? Opt;

        public _InOptConst_JoltSoftBodyCreationSettings() {}
        public _InOptConst_JoltSoftBodyCreationSettings(Const_JoltSoftBodyCreationSettings value) {Opt = value;}
        public static implicit operator _InOptConst_JoltSoftBodyCreationSettings(Const_JoltSoftBodyCreationSettings value) {return new(value);}
    }

    /// The main Jolt physics simulation. Manages a job system, temp allocator,
    /// and the full PhysicsSystem internally. The Jolt library itself is
    /// initialised automatically on first construction and cleaned up on last
    /// destruction.
    /// Generated from class `JoltPhysicsSystem`.
    /// This is the const half of the class.
    public class Const_JoltPhysicsSystem : Jolt.Object<Const_JoltPhysicsSystem>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_Destroy(_Underlying *_this);
            __JoltPhysicsSystem_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltPhysicsSystem() {Dispose(false);}

        internal unsafe Const_JoltPhysicsSystem(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltPhysicsSystem() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsSystem._Underlying *__JoltPhysicsSystem_DefaultConstruct();
            _UnderlyingPtr = __JoltPhysicsSystem_DefaultConstruct();
        }

        /// Generated from constructor `JoltPhysicsSystem::JoltPhysicsSystem`.
        public unsafe Const_JoltPhysicsSystem(Jolt.Const_JoltPhysicsSystem _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsSystem._Underlying *__JoltPhysicsSystem_ConstructFromAnother(Jolt.JoltPhysicsSystem._Underlying *_other);
            _UnderlyingPtr = __JoltPhysicsSystem_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltPhysicsSystem::JoltPhysicsSystem`.
        public Const_JoltPhysicsSystem(JoltPhysicsSystem _other) : this((Const_JoltPhysicsSystem)_other) {}

        /// Construct with explicit capacities.
        /// Generated from constructor `JoltPhysicsSystem::JoltPhysicsSystem`.
        public unsafe Const_JoltPhysicsSystem(uint maxBodies, uint maxBodyPairs, uint maxContactConstraints) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsSystem._Underlying *__JoltPhysicsSystem_Construct(uint maxBodies, uint maxBodyPairs, uint maxContactConstraints);
            _UnderlyingPtr = __JoltPhysicsSystem_Construct(maxBodies, maxBodyPairs, maxContactConstraints);
        }

        /// Generated from method `JoltPhysicsSystem::GetGravity`.
        public unsafe Jolt.JoltVec3 GetGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltPhysicsSystem_GetGravity(_Underlying *_this);
            return new(__JoltPhysicsSystem_GetGravity(_UnderlyingPtr), is_owning: true);
        }

        // ---- Body queries --------------------------------------------------------
        /// Generated from method `JoltPhysicsSystem::GetBodyPosition`.
        public unsafe Jolt.JoltVec3 GetBodyPosition(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltPhysicsSystem_GetBodyPosition(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltPhysicsSystem_GetBodyPosition(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltPhysicsSystem::GetBodyRotation`.
        public unsafe Jolt.JoltQuat GetBodyRotation(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltQuat._Underlying *__JoltPhysicsSystem_GetBodyRotation(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltPhysicsSystem_GetBodyRotation(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltPhysicsSystem::GetBodyLinearVelocity`.
        public unsafe Jolt.JoltVec3f GetBodyLinearVelocity(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltPhysicsSystem_GetBodyLinearVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltPhysicsSystem_GetBodyLinearVelocity(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltPhysicsSystem::GetBodyAngularVelocity`.
        public unsafe Jolt.JoltVec3f GetBodyAngularVelocity(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3f._Underlying *__JoltPhysicsSystem_GetBodyAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltPhysicsSystem_GetBodyAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltPhysicsSystem::IsBodyActive`.
        public unsafe bool IsBodyActive(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_IsBodyActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_IsBodyActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltPhysicsSystem_IsBodyActive(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltPhysicsSystem_IsBodyActive(_UnderlyingPtr, id._UnderlyingPtr) != 0;
        }

        /// Generated from method `JoltPhysicsSystem::GetFriction`.
        public unsafe float GetFriction(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltPhysicsSystem_GetFriction(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltPhysicsSystem_GetFriction(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltPhysicsSystem::GetRestitution`.
        public unsafe float GetRestitution(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltPhysicsSystem_GetRestitution(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltPhysicsSystem_GetRestitution(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltPhysicsSystem::GetGravityFactor`.
        public unsafe float GetGravityFactor(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltPhysicsSystem_GetGravityFactor(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltPhysicsSystem_GetGravityFactor(_UnderlyingPtr, id._UnderlyingPtr);
        }

        // ---- Statistics ----------------------------------------------------------
        /// Generated from method `JoltPhysicsSystem::GetNumBodies`.
        public unsafe uint GetNumBodies()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetNumBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetNumBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltPhysicsSystem_GetNumBodies(_Underlying *_this);
            return __JoltPhysicsSystem_GetNumBodies(_UnderlyingPtr);
        }

        /// Generated from method `JoltPhysicsSystem::GetNumActiveBodies`.
        public unsafe uint GetNumActiveBodies()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetNumActiveBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetNumActiveBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltPhysicsSystem_GetNumActiveBodies(_Underlying *_this);
            return __JoltPhysicsSystem_GetNumActiveBodies(_UnderlyingPtr);
        }
    }

    /// The main Jolt physics simulation. Manages a job system, temp allocator,
    /// and the full PhysicsSystem internally. The Jolt library itself is
    /// initialised automatically on first construction and cleaned up on last
    /// destruction.
    /// Generated from class `JoltPhysicsSystem`.
    /// This is the non-const half of the class.
    public class JoltPhysicsSystem : Const_JoltPhysicsSystem
    {
        internal unsafe JoltPhysicsSystem(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltPhysicsSystem() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsSystem._Underlying *__JoltPhysicsSystem_DefaultConstruct();
            _UnderlyingPtr = __JoltPhysicsSystem_DefaultConstruct();
        }

        /// Generated from constructor `JoltPhysicsSystem::JoltPhysicsSystem`.
        public unsafe JoltPhysicsSystem(Jolt.Const_JoltPhysicsSystem _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsSystem._Underlying *__JoltPhysicsSystem_ConstructFromAnother(Jolt.JoltPhysicsSystem._Underlying *_other);
            _UnderlyingPtr = __JoltPhysicsSystem_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltPhysicsSystem::JoltPhysicsSystem`.
        public JoltPhysicsSystem(JoltPhysicsSystem _other) : this((Const_JoltPhysicsSystem)_other) {}

        /// Construct with explicit capacities.
        /// Generated from constructor `JoltPhysicsSystem::JoltPhysicsSystem`.
        public unsafe JoltPhysicsSystem(uint maxBodies, uint maxBodyPairs, uint maxContactConstraints) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsSystem._Underlying *__JoltPhysicsSystem_Construct(uint maxBodies, uint maxBodyPairs, uint maxContactConstraints);
            _UnderlyingPtr = __JoltPhysicsSystem_Construct(maxBodies, maxBodyPairs, maxContactConstraints);
        }

        /// Generated from method `JoltPhysicsSystem::operator=`.
        public unsafe Jolt.JoltPhysicsSystem Assign(Jolt.Const_JoltPhysicsSystem _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltPhysicsSystem._Underlying *__JoltPhysicsSystem_AssignFromAnother(_Underlying *_this, Jolt.JoltPhysicsSystem._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltPhysicsSystem_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        // ---- Simulation ----------------------------------------------------------
        /// Generated from method `JoltPhysicsSystem::SetGravity`.
        public unsafe void SetGravity(double x, double y, double z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetGravity(_Underlying *_this, double x, double y, double z);
            __JoltPhysicsSystem_SetGravity(_UnderlyingPtr, x, y, z);
        }

        /// Advance the simulation. deltaTime is typically 1/60.
        /// collisionSteps: increase for fast-moving objects (normally 1).
        /// Generated from method `JoltPhysicsSystem::Update`.
        public unsafe void Update(float deltaTime, int collisionSteps)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_Update(_Underlying *_this, float deltaTime, int collisionSteps);
            __JoltPhysicsSystem_Update(_UnderlyingPtr, deltaTime, collisionSteps);
        }

        /// Optimise the broad phase. Call after loading a static level before
        /// starting to simulate.
        /// Generated from method `JoltPhysicsSystem::OptimizeBroadPhase`.
        public unsafe void OptimizeBroadPhase()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_OptimizeBroadPhase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_OptimizeBroadPhase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_OptimizeBroadPhase(_Underlying *_this);
            __JoltPhysicsSystem_OptimizeBroadPhase(_UnderlyingPtr);
        }

        /// Create a body from settings and add it to the simulation.
        /// Generated from method `JoltPhysicsSystem::CreateAndAddBody`.
        public unsafe Jolt.JoltBodyID CreateAndAddBody(Jolt.JoltBodyCreationSettings? settings, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_CreateAndAddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_CreateAndAddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltPhysicsSystem_CreateAndAddBody(_Underlying *_this, Jolt.JoltBodyCreationSettings._Underlying *settings, int activation);
            return new(__JoltPhysicsSystem_CreateAndAddBody(_UnderlyingPtr, settings is not null ? settings._UnderlyingPtr : null, activation), is_owning: true);
        }

        /// Remove a body from the simulation (body data preserved, can re-add).
        /// Generated from method `JoltPhysicsSystem::RemoveBody`.
        public unsafe void RemoveBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_RemoveBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_RemoveBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_RemoveBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltPhysicsSystem_RemoveBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Permanently destroy a body. ID is invalid after this call.
        /// Generated from method `JoltPhysicsSystem::DestroyBody`.
        public unsafe void DestroyBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_DestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_DestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_DestroyBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltPhysicsSystem_DestroyBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Remove and destroy in one call.
        /// Generated from method `JoltPhysicsSystem::RemoveAndDestroyBody`.
        public unsafe void RemoveAndDestroyBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_RemoveAndDestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_RemoveAndDestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_RemoveAndDestroyBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltPhysicsSystem_RemoveAndDestroyBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        // ---- Body control --------------------------------------------------------
        /// Generated from method `JoltPhysicsSystem::SetBodyPosition`.
        public unsafe void SetBodyPosition(Jolt.Const_JoltBodyID id, double x, double y, double z, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetBodyPosition(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double x, double y, double z, int activation);
            __JoltPhysicsSystem_SetBodyPosition(_UnderlyingPtr, id._UnderlyingPtr, x, y, z, activation);
        }

        /// Generated from method `JoltPhysicsSystem::SetBodyRotation`.
        public unsafe void SetBodyRotation(Jolt.Const_JoltBodyID id, float qx, float qy, float qz, float qw, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetBodyRotation(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float qx, float qy, float qz, float qw, int activation);
            __JoltPhysicsSystem_SetBodyRotation(_UnderlyingPtr, id._UnderlyingPtr, qx, qy, qz, qw, activation);
        }

        /// Generated from method `JoltPhysicsSystem::SetBodyPositionAndRotation`.
        public unsafe void SetBodyPositionAndRotation(Jolt.Const_JoltBodyID id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetBodyPositionAndRotation(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation);
            __JoltPhysicsSystem_SetBodyPositionAndRotation(_UnderlyingPtr, id._UnderlyingPtr, x, y, z, qx, qy, qz, qw, activation);
        }

        /// Generated from method `JoltPhysicsSystem::SetBodyLinearVelocity`.
        public unsafe void SetBodyLinearVelocity(Jolt.Const_JoltBodyID id, float vx, float vy, float vz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetBodyLinearVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float vx, float vy, float vz);
            __JoltPhysicsSystem_SetBodyLinearVelocity(_UnderlyingPtr, id._UnderlyingPtr, vx, vy, vz);
        }

        /// Generated from method `JoltPhysicsSystem::SetBodyAngularVelocity`.
        public unsafe void SetBodyAngularVelocity(Jolt.Const_JoltBodyID id, float vx, float vy, float vz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetBodyAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float vx, float vy, float vz);
            __JoltPhysicsSystem_SetBodyAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr, vx, vy, vz);
        }

        /// Generated from method `JoltPhysicsSystem::SetBodyLinearAndAngularVelocity`.
        public unsafe void SetBodyLinearAndAngularVelocity(Jolt.Const_JoltBodyID id, float lvx, float lvy, float lvz, float avx, float avy, float avz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetBodyLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetBodyLinearAndAngularVelocity(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float lvx, float lvy, float lvz, float avx, float avy, float avz);
            __JoltPhysicsSystem_SetBodyLinearAndAngularVelocity(_UnderlyingPtr, id._UnderlyingPtr, lvx, lvy, lvz, avx, avy, avz);
        }

        /// Generated from method `JoltPhysicsSystem::AddForce`.
        public unsafe void AddForce(Jolt.Const_JoltBodyID id, float fx, float fy, float fz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AddForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AddForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_AddForce(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float fx, float fy, float fz);
            __JoltPhysicsSystem_AddForce(_UnderlyingPtr, id._UnderlyingPtr, fx, fy, fz);
        }

        /// Generated from method `JoltPhysicsSystem::AddForceAtPosition`.
        public unsafe void AddForceAtPosition(Jolt.Const_JoltBodyID id, float fx, float fy, float fz, double px, double py, double pz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AddForceAtPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AddForceAtPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_AddForceAtPosition(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float fx, float fy, float fz, double px, double py, double pz);
            __JoltPhysicsSystem_AddForceAtPosition(_UnderlyingPtr, id._UnderlyingPtr, fx, fy, fz, px, py, pz);
        }

        /// Generated from method `JoltPhysicsSystem::AddTorque`.
        public unsafe void AddTorque(Jolt.Const_JoltBodyID id, float tx, float ty, float tz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AddTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AddTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_AddTorque(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float tx, float ty, float tz);
            __JoltPhysicsSystem_AddTorque(_UnderlyingPtr, id._UnderlyingPtr, tx, ty, tz);
        }

        /// Generated from method `JoltPhysicsSystem::AddImpulse`.
        public unsafe void AddImpulse(Jolt.Const_JoltBodyID id, float ix, float iy, float iz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AddImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AddImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_AddImpulse(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float ix, float iy, float iz);
            __JoltPhysicsSystem_AddImpulse(_UnderlyingPtr, id._UnderlyingPtr, ix, iy, iz);
        }

        /// Generated from method `JoltPhysicsSystem::AddAngularImpulse`.
        public unsafe void AddAngularImpulse(Jolt.Const_JoltBodyID id, float ix, float iy, float iz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AddAngularImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AddAngularImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_AddAngularImpulse(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float ix, float iy, float iz);
            __JoltPhysicsSystem_AddAngularImpulse(_UnderlyingPtr, id._UnderlyingPtr, ix, iy, iz);
        }

        /// Generated from method `JoltPhysicsSystem::ActivateBody`.
        public unsafe void ActivateBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_ActivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_ActivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_ActivateBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltPhysicsSystem_ActivateBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltPhysicsSystem::DeactivateBody`.
        public unsafe void DeactivateBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_DeactivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_DeactivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_DeactivateBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltPhysicsSystem_DeactivateBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        // ---- Body properties -----------------------------------------------------
        /// Generated from method `JoltPhysicsSystem::SetFriction`.
        public unsafe void SetFriction(Jolt.Const_JoltBodyID id, float friction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetFriction(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float friction);
            __JoltPhysicsSystem_SetFriction(_UnderlyingPtr, id._UnderlyingPtr, friction);
        }

        /// Generated from method `JoltPhysicsSystem::SetRestitution`.
        public unsafe void SetRestitution(Jolt.Const_JoltBodyID id, float restitution)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetRestitution(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float restitution);
            __JoltPhysicsSystem_SetRestitution(_UnderlyingPtr, id._UnderlyingPtr, restitution);
        }

        /// Generated from method `JoltPhysicsSystem::SetGravityFactor`.
        public unsafe void SetGravityFactor(Jolt.Const_JoltBodyID id, float factor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetGravityFactor(_Underlying *_this, Jolt.JoltBodyID._Underlying *id, float factor);
            __JoltPhysicsSystem_SetGravityFactor(_UnderlyingPtr, id._UnderlyingPtr, factor);
        }

        /// Connect two bodies at fixed relative positions/orientations.
        /// Generated from method `JoltPhysicsSystem::AddFixedConstraint`.
        public unsafe Jolt.JoltConstraintID AddFixedConstraint(Jolt.Const_JoltBodyID body1, Jolt.Const_JoltBodyID body2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AddFixedConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AddFixedConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConstraintID._Underlying *__JoltPhysicsSystem_AddFixedConstraint(_Underlying *_this, Jolt.JoltBodyID._Underlying *body1, Jolt.JoltBodyID._Underlying *body2);
            return new(__JoltPhysicsSystem_AddFixedConstraint(_UnderlyingPtr, body1._UnderlyingPtr, body2._UnderlyingPtr), is_owning: true);
        }

        /// Distance constraint: keep two bodies between [minDist, maxDist].
        /// Generated from method `JoltPhysicsSystem::AddDistanceConstraint`.
        public unsafe Jolt.JoltConstraintID AddDistanceConstraint(Jolt.Const_JoltBodyID body1, Jolt.Const_JoltBodyID body2, float minDist, float maxDist)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AddDistanceConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AddDistanceConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConstraintID._Underlying *__JoltPhysicsSystem_AddDistanceConstraint(_Underlying *_this, Jolt.JoltBodyID._Underlying *body1, Jolt.JoltBodyID._Underlying *body2, float minDist, float maxDist);
            return new(__JoltPhysicsSystem_AddDistanceConstraint(_UnderlyingPtr, body1._UnderlyingPtr, body2._UnderlyingPtr, minDist, maxDist), is_owning: true);
        }

        /// Point constraint: two bodies share a common world-space pivot.
        /// Generated from method `JoltPhysicsSystem::AddPointConstraint`.
        public unsafe Jolt.JoltConstraintID AddPointConstraint(Jolt.Const_JoltBodyID body1, Jolt.Const_JoltBodyID body2, double pivotX, double pivotY, double pivotZ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AddPointConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AddPointConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConstraintID._Underlying *__JoltPhysicsSystem_AddPointConstraint(_Underlying *_this, Jolt.JoltBodyID._Underlying *body1, Jolt.JoltBodyID._Underlying *body2, double pivotX, double pivotY, double pivotZ);
            return new(__JoltPhysicsSystem_AddPointConstraint(_UnderlyingPtr, body1._UnderlyingPtr, body2._UnderlyingPtr, pivotX, pivotY, pivotZ), is_owning: true);
        }

        /// Hinge constraint: bodies rotate about a shared axis.
        /// Generated from method `JoltPhysicsSystem::AddHingeConstraint`.
        public unsafe Jolt.JoltConstraintID AddHingeConstraint(Jolt.Const_JoltBodyID body1, Jolt.Const_JoltBodyID body2, double pivotX, double pivotY, double pivotZ, float axisX, float axisY, float axisZ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_AddHingeConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_AddHingeConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltConstraintID._Underlying *__JoltPhysicsSystem_AddHingeConstraint(_Underlying *_this, Jolt.JoltBodyID._Underlying *body1, Jolt.JoltBodyID._Underlying *body2, double pivotX, double pivotY, double pivotZ, float axisX, float axisY, float axisZ);
            return new(__JoltPhysicsSystem_AddHingeConstraint(_UnderlyingPtr, body1._UnderlyingPtr, body2._UnderlyingPtr, pivotX, pivotY, pivotZ, axisX, axisY, axisZ), is_owning: true);
        }

        /// Remove and destroy a constraint.
        /// Generated from method `JoltPhysicsSystem::DestroyConstraint`.
        public unsafe void DestroyConstraint(Jolt.Const_JoltConstraintID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_DestroyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_DestroyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_DestroyConstraint(_Underlying *_this, Jolt.JoltConstraintID._Underlying *id);
            __JoltPhysicsSystem_DestroyConstraint(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Enable or disable an existing constraint.
        /// Generated from method `JoltPhysicsSystem::SetConstraintEnabled`.
        public unsafe void SetConstraintEnabled(Jolt.Const_JoltConstraintID id, bool enabled)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_SetConstraintEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_SetConstraintEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltPhysicsSystem_SetConstraintEnabled(_Underlying *_this, Jolt.JoltConstraintID._Underlying *id, byte enabled);
            __JoltPhysicsSystem_SetConstraintEnabled(_UnderlyingPtr, id._UnderlyingPtr, enabled ? (byte)1 : (byte)0);
        }

        // ---- Soft body -----------------------------------------------------------
        /// Generated from method `JoltPhysicsSystem::CreateAndAddSoftBody`.
        public unsafe Jolt.JoltBodyID CreateAndAddSoftBody(Jolt.JoltSoftBodyCreationSettings? settings, int activation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_CreateAndAddSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_CreateAndAddSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltPhysicsSystem_CreateAndAddSoftBody(_Underlying *_this, Jolt.JoltSoftBodyCreationSettings._Underlying *settings, int activation);
            return new(__JoltPhysicsSystem_CreateAndAddSoftBody(_UnderlyingPtr, settings is not null ? settings._UnderlyingPtr : null, activation), is_owning: true);
        }

        /// Get a non-owning handle to a constraint created via AddFixedConstraint etc.
        /// Generated from method `JoltPhysicsSystem::GetConstraintHandle`.
        public unsafe Jolt.JoltTwoBodyConstraint GetConstraintHandle(Jolt.Const_JoltConstraintID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetConstraintHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetConstraintHandle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltTwoBodyConstraint._Underlying *__JoltPhysicsSystem_GetConstraintHandle(_Underlying *_this, Jolt.JoltConstraintID._Underlying *id);
            return new(__JoltPhysicsSystem_GetConstraintHandle(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Returns a non-owning handle to the body interface.
        /// The JoltPhysicsSystem must outlive the returned JoltBodyInterface.
        /// Generated from method `JoltPhysicsSystem::GetBodyInterface`.
        public unsafe Jolt.JoltBodyInterface GetBodyInterface()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltPhysicsSystem_GetBodyInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyInterface._Underlying *__JoltPhysicsSystem_GetBodyInterface(_Underlying *_this);
            return new(__JoltPhysicsSystem_GetBodyInterface(_UnderlyingPtr), is_owning: true);
        }
    }

    /// This is used for optional parameters of class `JoltPhysicsSystem` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltPhysicsSystem`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltPhysicsSystem`/`Const_JoltPhysicsSystem` directly.
    public class _InOptMut_JoltPhysicsSystem
    {
        public JoltPhysicsSystem? Opt;

        public _InOptMut_JoltPhysicsSystem() {}
        public _InOptMut_JoltPhysicsSystem(JoltPhysicsSystem value) {Opt = value;}
        public static implicit operator _InOptMut_JoltPhysicsSystem(JoltPhysicsSystem value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltPhysicsSystem` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltPhysicsSystem`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltPhysicsSystem`/`Const_JoltPhysicsSystem` to pass it to the function.
    public class _InOptConst_JoltPhysicsSystem
    {
        public Const_JoltPhysicsSystem? Opt;

        public _InOptConst_JoltPhysicsSystem() {}
        public _InOptConst_JoltPhysicsSystem(Const_JoltPhysicsSystem value) {Opt = value;}
        public static implicit operator _InOptConst_JoltPhysicsSystem(Const_JoltPhysicsSystem value) {return new(value);}
    }

    /// Simplified wrapper kept for backward compatibility. Prefer JoltPhysicsSystem
    /// for new code.
    /// Generated from class `JoltWorld`.
    /// This is the const half of the class.
    public class Const_JoltWorld : Jolt.Object<Const_JoltWorld>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltWorld_Destroy(_Underlying *_this);
            __JoltWorld_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltWorld() {Dispose(false);}

        internal unsafe Const_JoltWorld(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltWorld() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltWorld._Underlying *__JoltWorld_DefaultConstruct();
            _UnderlyingPtr = __JoltWorld_DefaultConstruct();
        }

        /// Generated from constructor `JoltWorld::JoltWorld`.
        public unsafe Const_JoltWorld(Jolt.Const_JoltWorld _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltWorld._Underlying *__JoltWorld_ConstructFromAnother(Jolt.JoltWorld._Underlying *_other);
            _UnderlyingPtr = __JoltWorld_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltWorld::JoltWorld`.
        public Const_JoltWorld(JoltWorld _other) : this((Const_JoltWorld)_other) {}

        /// Generated from method `JoltWorld::GetBodyPosition`.
        public unsafe Jolt.JoltVec3 GetBodyPosition(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_GetBodyPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_GetBodyPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltVec3._Underlying *__JoltWorld_GetBodyPosition(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return new(__JoltWorld_GetBodyPosition(_UnderlyingPtr, id._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JoltWorld::IsBodyActive`.
        public unsafe bool IsBodyActive(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_IsBodyActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_IsBodyActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltWorld_IsBodyActive(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            return __JoltWorld_IsBodyActive(_UnderlyingPtr, id._UnderlyingPtr) != 0;
        }
    }

    /// Simplified wrapper kept for backward compatibility. Prefer JoltPhysicsSystem
    /// for new code.
    /// Generated from class `JoltWorld`.
    /// This is the non-const half of the class.
    public class JoltWorld : Const_JoltWorld
    {
        internal unsafe JoltWorld(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltWorld() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltWorld._Underlying *__JoltWorld_DefaultConstruct();
            _UnderlyingPtr = __JoltWorld_DefaultConstruct();
        }

        /// Generated from constructor `JoltWorld::JoltWorld`.
        public unsafe JoltWorld(Jolt.Const_JoltWorld _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltWorld._Underlying *__JoltWorld_ConstructFromAnother(Jolt.JoltWorld._Underlying *_other);
            _UnderlyingPtr = __JoltWorld_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltWorld::JoltWorld`.
        public JoltWorld(JoltWorld _other) : this((Const_JoltWorld)_other) {}

        /// Generated from method `JoltWorld::operator=`.
        public unsafe Jolt.JoltWorld Assign(Jolt.Const_JoltWorld _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltWorld._Underlying *__JoltWorld_AssignFromAnother(_Underlying *_this, Jolt.JoltWorld._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltWorld_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JoltWorld::SetGravity`.
        public unsafe void SetGravity(double x, double y, double z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_SetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_SetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltWorld_SetGravity(_Underlying *_this, double x, double y, double z);
            __JoltWorld_SetGravity(_UnderlyingPtr, x, y, z);
        }

        /// Generated from method `JoltWorld::AddStaticBox`.
        public unsafe Jolt.JoltBodyID AddStaticBox(double halfX, double halfY, double halfZ, double posX, double posY, double posZ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_AddStaticBox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_AddStaticBox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltWorld_AddStaticBox(_Underlying *_this, double halfX, double halfY, double halfZ, double posX, double posY, double posZ);
            return new(__JoltWorld_AddStaticBox(_UnderlyingPtr, halfX, halfY, halfZ, posX, posY, posZ), is_owning: true);
        }

        /// Generated from method `JoltWorld::AddDynamicSphere`.
        public unsafe Jolt.JoltBodyID AddDynamicSphere(double radius, double posX, double posY, double posZ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_AddDynamicSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_AddDynamicSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltBodyID._Underlying *__JoltWorld_AddDynamicSphere(_Underlying *_this, double radius, double posX, double posY, double posZ);
            return new(__JoltWorld_AddDynamicSphere(_UnderlyingPtr, radius, posX, posY, posZ), is_owning: true);
        }

        /// Generated from method `JoltWorld::Update`.
        public unsafe void Update(double deltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltWorld_Update(_Underlying *_this, double deltaTime);
            __JoltWorld_Update(_UnderlyingPtr, deltaTime);
        }

        /// Generated from method `JoltWorld::OptimizeBroadPhase`.
        public unsafe void OptimizeBroadPhase()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_OptimizeBroadPhase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_OptimizeBroadPhase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltWorld_OptimizeBroadPhase(_Underlying *_this);
            __JoltWorld_OptimizeBroadPhase(_UnderlyingPtr);
        }

        /// Generated from method `JoltWorld::RemoveBody`.
        public unsafe void RemoveBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_RemoveBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_RemoveBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltWorld_RemoveBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltWorld_RemoveBody(_UnderlyingPtr, id._UnderlyingPtr);
        }

        /// Generated from method `JoltWorld::DestroyBody`.
        public unsafe void DestroyBody(Jolt.Const_JoltBodyID id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltWorld_DestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltWorld_DestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltWorld_DestroyBody(_Underlying *_this, Jolt.JoltBodyID._Underlying *id);
            __JoltWorld_DestroyBody(_UnderlyingPtr, id._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `JoltWorld` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltWorld`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltWorld`/`Const_JoltWorld` directly.
    public class _InOptMut_JoltWorld
    {
        public JoltWorld? Opt;

        public _InOptMut_JoltWorld() {}
        public _InOptMut_JoltWorld(JoltWorld value) {Opt = value;}
        public static implicit operator _InOptMut_JoltWorld(JoltWorld value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltWorld` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltWorld`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltWorld`/`Const_JoltWorld` to pass it to the function.
    public class _InOptConst_JoltWorld
    {
        public Const_JoltWorld? Opt;

        public _InOptConst_JoltWorld() {}
        public _InOptConst_JoltWorld(Const_JoltWorld value) {Opt = value;}
        public static implicit operator _InOptConst_JoltWorld(Const_JoltWorld value) {return new(value);}
    }
}
