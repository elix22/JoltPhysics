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

    /// Base class for all collision shapes.
    /// Shapes are ref-counted; call Release() when you no longer need the handle.
    /// Generated from class `JoltShape`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JoltBoxShape`
    ///     `JoltCapsuleShape`
    ///     `JoltCylinderShape`
    ///     `JoltRotatedTranslatedShape`
    ///     `JoltSphereShape`
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
    ///     `JoltCylinderShape`
    ///     `JoltRotatedTranslatedShape`
    ///     `JoltSphereShape`
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
