// machine generated, do not edit
public static partial class Jolt
{
    public static partial class Std
    {
        /// This is the const half of the class.
        public class Const_Ostream : Jolt.Object<Const_Ostream>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            internal unsafe Const_Ostream(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}
        }

        /// This is the non-const half of the class.
        public class Ostream : Const_Ostream
        {
            internal unsafe Ostream(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_Vec4 inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_Vec4(_Underlying *inStream, Jolt.JPH.Vec4._Underlying *inV);
                return new(__Jolt_print_JPH_Vec4(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_Vec3 inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_Vec3(_Underlying *inStream, Jolt.JPH.Vec3._Underlying *inV);
                return new(__Jolt_print_JPH_Vec3(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_UVec4 inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_UVec4(_Underlying *inStream, Jolt.JPH.UVec4._Underlying *inV);
                return new(__Jolt_print_JPH_UVec4(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_Mat44 inM)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_Mat44(_Underlying *inStream, Jolt.JPH.Const_Mat44._Underlying *inM);
                return new(__Jolt_print_JPH_Mat44(_UnderlyingPtr, inM._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_Quat inQ)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_Quat(_Underlying *inStream, Jolt.JPH.Quat._Underlying *inQ);
                return new(__Jolt_print_JPH_Quat(_UnderlyingPtr, inQ._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_DVec3 inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_DVec3(_Underlying *inStream, Jolt.JPH.Const_DVec3._Underlying *inV);
                return new(__Jolt_print_JPH_DVec3(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_DMat44 inM)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_DMat44(_Underlying *inStream, Jolt.JPH.Const_DMat44._Underlying *inM);
                return new(__Jolt_print_JPH_DMat44(_UnderlyingPtr, inM._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_BVec16 inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_BVec16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_BVec16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_BVec16(_Underlying *inStream, Jolt.JPH.BVec16._Underlying *inV);
                return new(__Jolt_print_JPH_BVec16(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_Vector_2 inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_Vector_2(_Underlying *inStream, Jolt.JPH.Const_Vector_2._Underlying *inV);
                return new(__Jolt_print_JPH_Vector_2(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_Matrix_2_2 inM)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_Matrix_2_2(_Underlying *inStream, Jolt.JPH.Const_Matrix_2_2._Underlying *inM);
                return new(__Jolt_print_JPH_Matrix_2_2(_UnderlyingPtr, inM._UnderlyingPtr), is_owning: false);
            }

            /// To String
            /// Generated from function `JPH::operator<<`.
            public unsafe Jolt.Std.Ostream Lshift(Jolt.JPH.Const_Float2 inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_print_JPH_Float2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_print_JPH_Float2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.Std.Ostream._Underlying *__Jolt_print_JPH_Float2(_Underlying *inStream, Jolt.JPH.Const_Float2._Underlying *inV);
                return new(__Jolt_print_JPH_Float2(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Ostream` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Ostream`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Ostream`/`Const_Ostream` directly.
        public class _InOptMut_Ostream
        {
            public Ostream? Opt;

            public _InOptMut_Ostream() {}
            public _InOptMut_Ostream(Ostream value) {Opt = value;}
            public static implicit operator _InOptMut_Ostream(Ostream value) {return new(value);}
        }

        /// This is used for optional parameters of class `Ostream` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Ostream`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Ostream`/`Const_Ostream` to pass it to the function.
        public class _InOptConst_Ostream
        {
            public Const_Ostream? Opt;

            public _InOptConst_Ostream() {}
            public _InOptConst_Ostream(Const_Ostream value) {Opt = value;}
            public static implicit operator _InOptConst_Ostream(Const_Ostream value) {return new(value);}
        }

        /// This is the const half of the class.
        public class Const_Istream : Jolt.Object<Const_Istream>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            internal unsafe Const_Istream(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}
        }

        /// This is the non-const half of the class.
        public class Istream : Const_Istream
        {
            internal unsafe Istream(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}
        }

        /// This is used for optional parameters of class `Istream` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Istream`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Istream`/`Const_Istream` directly.
        public class _InOptMut_Istream
        {
            public Istream? Opt;

            public _InOptMut_Istream() {}
            public _InOptMut_Istream(Istream value) {Opt = value;}
            public static implicit operator _InOptMut_Istream(Istream value) {return new(value);}
        }

        /// This is used for optional parameters of class `Istream` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Istream`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Istream`/`Const_Istream` to pass it to the function.
        public class _InOptConst_Istream
        {
            public Const_Istream? Opt;

            public _InOptConst_Istream() {}
            public _InOptConst_Istream(Const_Istream value) {Opt = value;}
            public static implicit operator _InOptConst_Istream(Const_Istream value) {return new(value);}
        }
    }

    /// Returns the `stdout` stream.
    public static unsafe Jolt.Std.Ostream GetStdCout()
    {
        #if __IOS__
        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_GetStdCout", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_GetStdCout", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static Jolt.Std.Ostream._Underlying *__Jolt_GetStdCout();
        return new(__Jolt_GetStdCout(), is_owning: false);
    }

    /// Returns the `stderr` stream, buffered.
    public static unsafe Jolt.Std.Ostream GetStdCerr()
    {
        #if __IOS__
        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_GetStdCerr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_GetStdCerr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static Jolt.Std.Ostream._Underlying *__Jolt_GetStdCerr();
        return new(__Jolt_GetStdCerr(), is_owning: false);
    }

    /// Returns the `stderr` stream, unbuffered.
    public static unsafe Jolt.Std.Ostream GetStdClog()
    {
        #if __IOS__
        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_GetStdClog", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_GetStdClog", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static Jolt.Std.Ostream._Underlying *__Jolt_GetStdClog();
        return new(__Jolt_GetStdClog(), is_owning: false);
    }

    /// Returns the `stdin` stream.
    public static unsafe Jolt.Std.Istream GetStdCin()
    {
        #if __IOS__
        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_GetStdCin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_GetStdCin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static Jolt.Std.Istream._Underlying *__Jolt_GetStdCin();
        return new(__Jolt_GetStdCin(), is_owning: false);
    }
}
