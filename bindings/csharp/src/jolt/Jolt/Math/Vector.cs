// machine generated, do not edit
public static partial class JPH
{
    /// Templatized vector class
    /// Generated from class `JPH::Vector<2>`.
    /// This is the const half of the class.
    public class Const_Vector_2 : JPH.Object<Const_Vector_2>, System.IDisposable, System.IEquatable<JPH.Const_Vector_2>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Vector_2_Destroy(_Underlying *_this);
            __JPH_Vector_2_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Vector_2() {Dispose(false);}

        public unsafe ref JPH.ArrayFloat2 mf32
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_Get_mF32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_Get_mF32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ArrayFloat2 *__JPH_Vector_2_Get_mF32(_Underlying *_this);
                return ref *(__JPH_Vector_2_Get_mF32(_UnderlyingPtr));
            }
        }

        internal unsafe Const_Vector_2(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Vector_2() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_DefaultConstruct();
            _UnderlyingPtr = __JPH_Vector_2_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Vector<2>::Vector`.
        public unsafe Const_Vector_2(JPH.Const_Vector_2 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_ConstructFromAnother(JPH.Vector_2._Underlying *_other);
            _UnderlyingPtr = __JPH_Vector_2_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::Vector<2>::Vector`.
        public Const_Vector_2(Vector_2 _other) : this((Const_Vector_2)_other) {}

        /// Dimensions
        /// Generated from method `JPH::Vector<2>::GetRows`.
        public unsafe uint GetRows()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_GetRows", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_GetRows", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Vector_2_GetRows(_Underlying *_this);
            return __JPH_Vector_2_GetRows(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Vector<2>::sZero`.
        public static unsafe JPH.Vector_2 SZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_sZero();
            return new(__JPH_Vector_2_sZero(), is_owning: true);
        }

        /// Get float component by index
        /// Generated from method `JPH::Vector<2>::operator[]`.
        public unsafe float this[uint inCoordinate]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vector_2_index(_Underlying *_this, uint inCoordinate);
                return __JPH_Vector_2_index(_UnderlyingPtr, inCoordinate);
            }
        }

        /// Comparison
        /// Generated from method `JPH::Vector<2>::operator==`.
        public static unsafe bool operator==(JPH.Const_Vector_2 _this, JPH.Const_Vector_2 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_Vector_2(JPH.Const_Vector_2._Underlying *_this, JPH.Const_Vector_2._Underlying *inV2);
            return __Jolt_equal_JPH_Vector_2(_this._UnderlyingPtr, inV2._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_Vector_2 _this, JPH.Const_Vector_2 inV2)
        {
            return !(_this == inV2);
        }

        /// Test if vector consists of all zeros
        /// Generated from method `JPH::Vector<2>::IsZero`.
        public unsafe bool IsZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_IsZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_IsZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Vector_2_IsZero(_Underlying *_this);
            return __JPH_Vector_2_IsZero(_UnderlyingPtr) != 0;
        }

        /// Test if two vectors are close to each other
        /// Generated from method `JPH::Vector<2>::IsClose`.
        /// Parameter `inMaxDistSq` defaults to `9.99999996e-13f`.
        public unsafe bool IsClose(JPH.Const_Vector_2 inV2, float? inMaxDistSq = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Vector_2_IsClose(_Underlying *_this, JPH.Const_Vector_2._Underlying *inV2, float *inMaxDistSq);
            float __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
            return __JPH_Vector_2_IsClose(_UnderlyingPtr, inV2._UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
        }

        /// Multiply vector with float
        /// Generated from method `JPH::Vector<2>::operator*`.
        public static unsafe JPH.Vector_2 operator*(JPH.Const_Vector_2 _this, float inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Vector_2_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Vector_2_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__Jolt_mul_JPH_Vector_2_float(JPH.Const_Vector_2._Underlying *_this, float inV2);
            return new(__Jolt_mul_JPH_Vector_2_float(_this._UnderlyingPtr, inV2), is_owning: true);
        }

        /// Divide vector by float
        /// Generated from method `JPH::Vector<2>::operator/`.
        public static unsafe JPH.Vector_2 operator/(JPH.Const_Vector_2 _this, float inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_div_JPH_Vector_2_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_div_JPH_Vector_2_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__Jolt_div_JPH_Vector_2_float(JPH.Const_Vector_2._Underlying *_this, float inV2);
            return new(__Jolt_div_JPH_Vector_2_float(_this._UnderlyingPtr, inV2), is_owning: true);
        }

        /// Add two float vectors (component wise)
        /// Generated from method `JPH::Vector<2>::operator+`.
        public static unsafe JPH.Vector_2 operator+(JPH.Const_Vector_2 _this, JPH.Const_Vector_2 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_add_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_add_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__Jolt_add_JPH_Vector_2(JPH.Const_Vector_2._Underlying *_this, JPH.Const_Vector_2._Underlying *inV2);
            return new(__Jolt_add_JPH_Vector_2(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Negate
        /// Generated from method `JPH::Vector<2>::operator-`.
        public static unsafe JPH.Vector_2 operator-(JPH.Const_Vector_2 _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_neg_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_neg_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__Jolt_neg_JPH_Vector_2(JPH.Const_Vector_2._Underlying *_this);
            return new(__Jolt_neg_JPH_Vector_2(_this._UnderlyingPtr), is_owning: true);
        }

        /// Subtract two float vectors (component wise)
        /// Generated from method `JPH::Vector<2>::operator-`.
        public static unsafe JPH.Vector_2 operator-(JPH.Const_Vector_2 _this, JPH.Const_Vector_2 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_sub_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_sub_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__Jolt_sub_JPH_Vector_2(JPH.Const_Vector_2._Underlying *_this, JPH.Const_Vector_2._Underlying *inV2);
            return new(__Jolt_sub_JPH_Vector_2(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Dot product
        /// Generated from method `JPH::Vector<2>::Dot`.
        public unsafe float Dot(JPH.Const_Vector_2 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Vector_2_Dot(_Underlying *_this, JPH.Const_Vector_2._Underlying *inV2);
            return __JPH_Vector_2_Dot(_UnderlyingPtr, inV2._UnderlyingPtr);
        }

        /// Squared length of vector
        /// Generated from method `JPH::Vector<2>::LengthSq`.
        public unsafe float LengthSq()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Vector_2_LengthSq(_Underlying *_this);
            return __JPH_Vector_2_LengthSq(_UnderlyingPtr);
        }

        /// Length of vector
        /// Generated from method `JPH::Vector<2>::Length`.
        public unsafe float Length()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Vector_2_Length(_Underlying *_this);
            return __JPH_Vector_2_Length(_UnderlyingPtr);
        }

        /// Normalize vector
        /// Generated from method `JPH::Vector<2>::Normalized`.
        public unsafe JPH.Vector_2 Normalized()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_Normalized(_Underlying *_this);
            return new(__JPH_Vector_2_Normalized(_UnderlyingPtr), is_owning: true);
        }

        /// Multiply vector with float
        /// Generated from function `JPH::operator*`.
        public static unsafe JPH.Vector_2 operator*(float inV1, JPH.Const_Vector_2 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_float_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_float_JPH_Vector_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__Jolt_mul_float_JPH_Vector_2(float inV1, JPH.Const_Vector_2._Underlying *inV2);
            return new(__Jolt_mul_float_JPH_Vector_2(inV1, inV2._UnderlyingPtr), is_owning: true);
        }

        // IEquatable:

        public bool Equals(JPH.Const_Vector_2? inV2)
        {
            if (inV2 is null)
                return false;
            return this == inV2;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_Vector_2)
                return this == (JPH.Const_Vector_2)other;
            return false;
        }
    }

    /// Templatized vector class
    /// Generated from class `JPH::Vector<2>`.
    /// This is the non-const half of the class.
    public class Vector_2 : Const_Vector_2
    {
        new public unsafe ref JPH.ArrayFloat2 mf32
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_GetMutable_mF32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_GetMutable_mF32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ArrayFloat2 *__JPH_Vector_2_GetMutable_mF32(_Underlying *_this);
                return ref *(__JPH_Vector_2_GetMutable_mF32(_UnderlyingPtr));
            }
        }

        internal unsafe Vector_2(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Vector_2() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_DefaultConstruct();
            _UnderlyingPtr = __JPH_Vector_2_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Vector<2>::Vector`.
        public unsafe Vector_2(JPH.Const_Vector_2 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_ConstructFromAnother(JPH.Vector_2._Underlying *_other);
            _UnderlyingPtr = __JPH_Vector_2_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::Vector<2>::Vector`.
        public Vector_2(Vector_2 _other) : this((Const_Vector_2)_other) {}

        /// Assignment
        /// Generated from method `JPH::Vector<2>::operator=`.
        public unsafe JPH.Vector_2 Assign(JPH.Const_Vector_2 _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_AssignFromAnother(_Underlying *_this, JPH.Vector_2._Underlying *_other);
            JPH.Vector_2 __ret;
            __ret = new(__JPH_Vector_2_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Vector with all zeros
        /// Generated from method `JPH::Vector<2>::SetZero`.
        public unsafe void SetZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_SetZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_SetZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Vector_2_SetZero(_Underlying *_this);
            __JPH_Vector_2_SetZero(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Vector<2>::operator[]`.
        public unsafe new ref float this[uint inCoordinate]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_Vector_2_index_mut(_Underlying *_this, uint inCoordinate);
                return ref *__JPH_Vector_2_index_mut(_UnderlyingPtr, inCoordinate);
            }
        }

        /// Generated from method `JPH::Vector<2>::operator*=`.
        public unsafe JPH.Vector_2 MulAssign(float inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_mul_assign(_Underlying *_this, float inV2);
            JPH.Vector_2 __ret;
            __ret = new(__JPH_Vector_2_mul_assign(_UnderlyingPtr, inV2), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Generated from method `JPH::Vector<2>::operator/=`.
        public unsafe JPH.Vector_2 DivAssign(float inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_div_assign(_Underlying *_this, float inV2);
            JPH.Vector_2 __ret;
            __ret = new(__JPH_Vector_2_div_assign(_UnderlyingPtr, inV2), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Generated from method `JPH::Vector<2>::operator+=`.
        public unsafe JPH.Vector_2 AddAssign(JPH.Const_Vector_2 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_add_assign(_Underlying *_this, JPH.Const_Vector_2._Underlying *inV2);
            JPH.Vector_2 __ret;
            __ret = new(__JPH_Vector_2_add_assign(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Generated from method `JPH::Vector<2>::operator-=`.
        public unsafe JPH.Vector_2 SubAssign(JPH.Const_Vector_2 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vector_2._Underlying *__JPH_Vector_2_sub_assign(_Underlying *_this, JPH.Const_Vector_2._Underlying *inV2);
            JPH.Vector_2 __ret;
            __ret = new(__JPH_Vector_2_sub_assign(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Check if vector is normalized
        /// Generated from method `JPH::Vector<2>::IsNormalized`.
        /// Parameter `inToleranceSq` defaults to `9.99999997e-7f`.
        public unsafe bool IsNormalized(float? inToleranceSq = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Vector_2_IsNormalized(_Underlying *_this, float *inToleranceSq);
            float __deref_inToleranceSq = inToleranceSq.GetValueOrDefault();
            return __JPH_Vector_2_IsNormalized(_UnderlyingPtr, inToleranceSq.HasValue ? &__deref_inToleranceSq : null) != 0;
        }
    }

    /// This is used for optional parameters of class `Vector_2` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Vector_2`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Vector_2`/`Const_Vector_2` directly.
    public class _InOptMut_Vector_2
    {
        public Vector_2? Opt;

        public _InOptMut_Vector_2() {}
        public _InOptMut_Vector_2(Vector_2 value) {Opt = value;}
        public static implicit operator _InOptMut_Vector_2(Vector_2 value) {return new(value);}
    }

    /// This is used for optional parameters of class `Vector_2` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Vector_2`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Vector_2`/`Const_Vector_2` to pass it to the function.
    public class _InOptConst_Vector_2
    {
        public Const_Vector_2? Opt;

        public _InOptConst_Vector_2() {}
        public _InOptConst_Vector_2(Const_Vector_2 value) {Opt = value;}
        public static implicit operator _InOptConst_Vector_2(Const_Vector_2 value) {return new(value);}
    }
}
