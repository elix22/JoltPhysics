// machine generated, do not edit
public static partial class JPH
{
    /// Templatized matrix class
    /// Generated from class `JPH::Matrix<2, 2>`.
    /// This is the const half of the class.
    public class Const_Matrix_2_2 : JPH.Object<Const_Matrix_2_2>, System.IDisposable, System.IEquatable<JPH.Const_Matrix_2_2>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Matrix_2_2_Destroy(_Underlying *_this);
            __JPH_Matrix_2_2_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Matrix_2_2() {Dispose(false);}

        ///< Column
        public unsafe JPH.ArrayVector2_2 mCol
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_Get_mCol", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_Get_mCol", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vector_2._Underlying *__JPH_Matrix_2_2_Get_mCol(_Underlying *_this);
                return new(__JPH_Matrix_2_2_Get_mCol(_UnderlyingPtr));
            }
        }

        internal unsafe Const_Matrix_2_2(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Matrix_2_2() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_DefaultConstruct();
            _UnderlyingPtr = __JPH_Matrix_2_2_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Matrix<2, 2>::Matrix`.
        public unsafe Const_Matrix_2_2(JPH._ByValue_Matrix_2_2 inM2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_ConstructFromAnother(JPH._PassBy inM2_pass_by, JPH.Matrix_2_2._Underlying *inM2);
            _UnderlyingPtr = __JPH_Matrix_2_2_ConstructFromAnother(inM2.PassByMode, inM2.Value is not null ? inM2.Value._UnderlyingPtr : null);
            if (inM2.Value is not null) _KeepAlive(inM2.Value);
        }

        /// Generated from constructor `JPH::Matrix<2, 2>::Matrix`.
        public Const_Matrix_2_2(Const_Matrix_2_2 inM2) : this(new _ByValue_Matrix_2_2(inM2)) {}

        /// Generated from constructor `JPH::Matrix<2, 2>::Matrix`.
        public Const_Matrix_2_2(Matrix_2_2 inM2) : this((Const_Matrix_2_2)inM2) {}

        /// Dimensions
        /// Generated from method `JPH::Matrix<2, 2>::GetRows`.
        public unsafe uint GetRows()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_GetRows", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_GetRows", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Matrix_2_2_GetRows(_Underlying *_this);
            return __JPH_Matrix_2_2_GetRows(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Matrix<2, 2>::GetCols`.
        public unsafe uint GetCols()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_GetCols", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_GetCols", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Matrix_2_2_GetCols(_Underlying *_this);
            return __JPH_Matrix_2_2_GetCols(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Matrix<2, 2>::sZero`.
        public static unsafe JPH.Matrix_2_2 SZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_sZero();
            return new(__JPH_Matrix_2_2_sZero(), is_owning: true);
        }

        /// Check if this matrix consists of all zeros
        /// Generated from method `JPH::Matrix<2, 2>::IsZero`.
        public unsafe bool IsZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_IsZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_IsZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Matrix_2_2_IsZero(_Underlying *_this);
            return __JPH_Matrix_2_2_IsZero(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JPH::Matrix<2, 2>::sIdentity`.
        public static unsafe JPH.Matrix_2_2 SIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_sIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_sIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_sIdentity();
            return new(__JPH_Matrix_2_2_sIdentity(), is_owning: true);
        }

        /// Check if this matrix is identity
        /// Generated from method `JPH::Matrix<2, 2>::IsIdentity`.
        public unsafe bool IsIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_IsIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_IsIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Matrix_2_2_IsIdentity(_Underlying *_this);
            return __JPH_Matrix_2_2_IsIdentity(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JPH::Matrix<2, 2>::sDiagonal`.
        public static unsafe JPH.Matrix_2_2 SDiagonal(JPH.Const_Vector_2 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_sDiagonal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_sDiagonal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_sDiagonal(JPH.Const_Vector_2._Underlying *inV);
            return new(__JPH_Matrix_2_2_sDiagonal(inV._UnderlyingPtr), is_owning: true);
        }

        /// Get float component by element index
        /// Generated from method `JPH::Matrix<2, 2>::operator()`.
        public unsafe float Call(uint inRow, uint inColumn)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Matrix_2_2_call(_Underlying *_this, uint inRow, uint inColumn);
            return __JPH_Matrix_2_2_call(_UnderlyingPtr, inRow, inColumn);
        }

        /// Comparison
        /// Generated from method `JPH::Matrix<2, 2>::operator==`.
        public static unsafe bool operator==(JPH.Const_Matrix_2_2 _this, JPH.Const_Matrix_2_2 inM2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_Matrix_2_2(JPH.Const_Matrix_2_2._Underlying *_this, JPH.Const_Matrix_2_2._Underlying *inM2);
            return __Jolt_equal_JPH_Matrix_2_2(_this._UnderlyingPtr, inM2._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_Matrix_2_2 _this, JPH.Const_Matrix_2_2 inM2)
        {
            return !(_this == inM2);
        }

        /// Multiply vector by matrix
        /// Generated from method `JPH::Matrix<2, 2>::operator*`.
        public static unsafe JPH.Vector_2 operator*(JPH.Const_Matrix_2_2 _this, JPH.Const_Vector_2 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Matrix_2_2_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Matrix_2_2_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__Jolt_mul_JPH_Matrix_2_2_JPH_Vector_2(JPH.Const_Matrix_2_2._Underlying *_this, JPH.Const_Vector_2._Underlying *inV);
            return new(__Jolt_mul_JPH_Matrix_2_2_JPH_Vector_2(_this._UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Multiply matrix with float
        /// Generated from method `JPH::Matrix<2, 2>::operator*`.
        public static unsafe JPH.Matrix_2_2 operator*(JPH.Const_Matrix_2_2 _this, float inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Matrix_2_2_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Matrix_2_2_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__Jolt_mul_JPH_Matrix_2_2_float(JPH.Const_Matrix_2_2._Underlying *_this, float inV);
            return new(__Jolt_mul_JPH_Matrix_2_2_float(_this._UnderlyingPtr, inV), is_owning: true);
        }

        /// Per element addition of matrix
        /// Generated from method `JPH::Matrix<2, 2>::operator+`.
        public static unsafe JPH.Matrix_2_2 operator+(JPH.Const_Matrix_2_2 _this, JPH.Const_Matrix_2_2 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_add_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_add_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__Jolt_add_JPH_Matrix_2_2(JPH.Const_Matrix_2_2._Underlying *_this, JPH.Const_Matrix_2_2._Underlying *inM);
            return new(__Jolt_add_JPH_Matrix_2_2(_this._UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Per element subtraction of matrix
        /// Generated from method `JPH::Matrix<2, 2>::operator-`.
        public static unsafe JPH.Matrix_2_2 operator-(JPH.Const_Matrix_2_2 _this, JPH.Const_Matrix_2_2 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_sub_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_sub_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__Jolt_sub_JPH_Matrix_2_2(JPH.Const_Matrix_2_2._Underlying *_this, JPH.Const_Matrix_2_2._Underlying *inM);
            return new(__Jolt_sub_JPH_Matrix_2_2(_this._UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Transpose matrix
        /// Generated from method `JPH::Matrix<2, 2>::Transposed`.
        public unsafe JPH.Matrix_2_2 Transposed()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_Transposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_Transposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_Transposed(_Underlying *_this);
            return new(__JPH_Matrix_2_2_Transposed(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Matrix<2, 2>::Inversed`.
        public unsafe JPH.Matrix_2_2 Inversed()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_Inversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_Inversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_Inversed(_Underlying *_this);
            return new(__JPH_Matrix_2_2_Inversed(_UnderlyingPtr), is_owning: true);
        }

        /// Column access
        /// Generated from method `JPH::Matrix<2, 2>::GetColumn`.
        public unsafe JPH.Const_Vector_2 GetColumn(int inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_GetColumn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_GetColumn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Vector_2._Underlying *__JPH_Matrix_2_2_GetColumn(_Underlying *_this, int inIdx);
            return new(__JPH_Matrix_2_2_GetColumn(_UnderlyingPtr, inIdx), is_owning: false);
        }

        /// Generated from function `JPH::operator*`.
        public static unsafe JPH.Matrix_2_2 operator*(float inV, JPH.Const_Matrix_2_2 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_float_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_float_JPH_Matrix_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__Jolt_mul_float_JPH_Matrix_2_2(float inV, JPH.Const_Matrix_2_2._Underlying *inM);
            return new(__Jolt_mul_float_JPH_Matrix_2_2(inV, inM._UnderlyingPtr), is_owning: true);
        }

        // IEquatable:

        public bool Equals(JPH.Const_Matrix_2_2? inM2)
        {
            if (inM2 is null)
                return false;
            return this == inM2;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_Matrix_2_2)
                return this == (JPH.Const_Matrix_2_2)other;
            return false;
        }
    }

    /// Templatized matrix class
    /// Generated from class `JPH::Matrix<2, 2>`.
    /// This is the non-const half of the class.
    public class Matrix_2_2 : Const_Matrix_2_2
    {
        ///< Column
        new public unsafe JPH.ArrayVector2_2 mCol
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_GetMutable_mCol", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_GetMutable_mCol", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vector_2._Underlying *__JPH_Matrix_2_2_GetMutable_mCol(_Underlying *_this);
                return new(__JPH_Matrix_2_2_GetMutable_mCol(_UnderlyingPtr));
            }
        }

        internal unsafe Matrix_2_2(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Matrix_2_2() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_DefaultConstruct();
            _UnderlyingPtr = __JPH_Matrix_2_2_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Matrix<2, 2>::Matrix`.
        public unsafe Matrix_2_2(JPH._ByValue_Matrix_2_2 inM2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_ConstructFromAnother(JPH._PassBy inM2_pass_by, JPH.Matrix_2_2._Underlying *inM2);
            _UnderlyingPtr = __JPH_Matrix_2_2_ConstructFromAnother(inM2.PassByMode, inM2.Value is not null ? inM2.Value._UnderlyingPtr : null);
            if (inM2.Value is not null) _KeepAlive(inM2.Value);
        }

        /// Generated from constructor `JPH::Matrix<2, 2>::Matrix`.
        public Matrix_2_2(Const_Matrix_2_2 inM2) : this(new _ByValue_Matrix_2_2(inM2)) {}

        /// Generated from constructor `JPH::Matrix<2, 2>::Matrix`.
        public Matrix_2_2(Matrix_2_2 inM2) : this((Const_Matrix_2_2)inM2) {}

        /// Assignment
        /// Generated from method `JPH::Matrix<2, 2>::operator=`.
        public unsafe JPH.Matrix_2_2 Assign(JPH._ByValue_Matrix_2_2 inM2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Matrix_2_2._Underlying *__JPH_Matrix_2_2_AssignFromAnother(_Underlying *_this, JPH._PassBy inM2_pass_by, JPH.Matrix_2_2._Underlying *inM2);
            JPH.Matrix_2_2 __ret;
            __ret = new(__JPH_Matrix_2_2_AssignFromAnother(_UnderlyingPtr, inM2.PassByMode, inM2.Value is not null ? inM2.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (inM2.Value is not null) _KeepAlive(inM2.Value);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Zero matrix
        /// Generated from method `JPH::Matrix<2, 2>::SetZero`.
        public unsafe void SetZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_SetZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_SetZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Matrix_2_2_SetZero(_Underlying *_this);
            __JPH_Matrix_2_2_SetZero(_UnderlyingPtr);
        }

        /// Identity matrix
        /// Generated from method `JPH::Matrix<2, 2>::SetIdentity`.
        public unsafe void SetIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_SetIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_SetIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Matrix_2_2_SetIdentity(_Underlying *_this);
            __JPH_Matrix_2_2_SetIdentity(_UnderlyingPtr);
        }

        /// Diagonal matrix
        /// Generated from method `JPH::Matrix<2, 2>::SetDiagonal`.
        public unsafe void SetDiagonal(JPH.Const_Vector_2 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_SetDiagonal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_SetDiagonal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Matrix_2_2_SetDiagonal(_Underlying *_this, JPH.Const_Vector_2._Underlying *inV);
            __JPH_Matrix_2_2_SetDiagonal(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Matrix<2, 2>::operator()`.
        public unsafe new ref float Call(uint inRow, uint inColumn)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_call_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_call_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float *__JPH_Matrix_2_2_call_mut(_Underlying *_this, uint inRow, uint inColumn);
            return ref *__JPH_Matrix_2_2_call_mut(_UnderlyingPtr, inRow, inColumn);
        }

        /// Specialization of SetInversed for 2x2 matrix
        /// Generated from method `JPH::Matrix<2, 2>::SetInversed`.
        public unsafe bool SetInversed(JPH.Const_Matrix_2_2 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_SetInversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_SetInversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Matrix_2_2_SetInversed(_Underlying *_this, JPH.Const_Matrix_2_2._Underlying *inM);
            return __JPH_Matrix_2_2_SetInversed(_UnderlyingPtr, inM._UnderlyingPtr) != 0;
        }

        /// Generated from method `JPH::Matrix<2, 2>::GetColumn`.
        public unsafe new JPH.Vector_2 GetColumn(int inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Matrix_2_2_GetColumn_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Matrix_2_2_GetColumn_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Matrix_2_2_GetColumn_mut(_Underlying *_this, int inIdx);
            return new(__JPH_Matrix_2_2_GetColumn_mut(_UnderlyingPtr, inIdx), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `Matrix_2_2` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `Matrix_2_2`/`Const_Matrix_2_2` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_Matrix_2_2
    {
        #pragma warning disable CS0649
        internal readonly Const_Matrix_2_2? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_Matrix_2_2() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_Matrix_2_2(Const_Matrix_2_2 new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_Matrix_2_2(Const_Matrix_2_2 arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `Matrix_2_2` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Matrix_2_2`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Matrix_2_2`/`Const_Matrix_2_2` directly.
    public class _InOptMut_Matrix_2_2
    {
        public Matrix_2_2? Opt;

        public _InOptMut_Matrix_2_2() {}
        public _InOptMut_Matrix_2_2(Matrix_2_2 value) {Opt = value;}
        public static implicit operator _InOptMut_Matrix_2_2(Matrix_2_2 value) {return new(value);}
    }

    /// This is used for optional parameters of class `Matrix_2_2` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Matrix_2_2`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Matrix_2_2`/`Const_Matrix_2_2` to pass it to the function.
    public class _InOptConst_Matrix_2_2
    {
        public Const_Matrix_2_2? Opt;

        public _InOptConst_Matrix_2_2() {}
        public _InOptConst_Matrix_2_2(Const_Matrix_2_2 value) {Opt = value;}
        public static implicit operator _InOptConst_Matrix_2_2(Const_Matrix_2_2 value) {return new(value);}
    }
}
