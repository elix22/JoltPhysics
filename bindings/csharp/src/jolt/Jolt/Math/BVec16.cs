// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// A vector consisting of 16 bytes
        /// Generated from class `JPH::BVec16`.
        /// This is the const half of the class.
        public class Const_BVec16 : Jolt.Object<Const_BVec16>, System.IDisposable, System.IEquatable<Jolt.JPH.Const_BVec16>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_BVec16_Destroy(_Underlying *_this);
                __JPH_BVec16_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_BVec16() {Dispose(false);}

            internal unsafe Const_BVec16(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_BVec16() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_DefaultConstruct();
                _UnderlyingPtr = __JPH_BVec16_DefaultConstruct();
            }

            /// Generated from constructor `JPH::BVec16::BVec16`.
            public unsafe Const_BVec16(Jolt.JPH.Const_BVec16 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_ConstructFromAnother(Jolt.JPH.BVec16._Underlying *inRHS);
                _UnderlyingPtr = __JPH_BVec16_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::BVec16::BVec16`.
            public Const_BVec16(BVec16 inRHS) : this((Const_BVec16)inRHS) {}

            /// Create a vector from 16 bytes
            /// Generated from constructor `JPH::BVec16::BVec16`.
            public unsafe Const_BVec16(byte inB0, byte inB1, byte inB2, byte inB3, byte inB4, byte inB5, byte inB6, byte inB7, byte inB8, byte inB9, byte inB10, byte inB11, byte inB12, byte inB13, byte inB14, byte inB15) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_Construct_16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_Construct_16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_Construct_16(byte inB0, byte inB1, byte inB2, byte inB3, byte inB4, byte inB5, byte inB6, byte inB7, byte inB8, byte inB9, byte inB10, byte inB11, byte inB12, byte inB13, byte inB14, byte inB15);
                _UnderlyingPtr = __JPH_BVec16_Construct_16(inB0, inB1, inB2, inB3, inB4, inB5, inB6, inB7, inB8, inB9, inB10, inB11, inB12, inB13, inB14, inB15);
            }

            /// Create a vector from two uint64's
            /// Generated from constructor `JPH::BVec16::BVec16`.
            public unsafe Const_BVec16(ulong inV0, ulong inV1) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_Construct_2(ulong inV0, ulong inV1);
                _UnderlyingPtr = __JPH_BVec16_Construct_2(inV0, inV1);
            }

            /// Generated from method `JPH::BVec16::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BVec16_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BVec16_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_BVec16_size_t(ulong inCount);
                return __Jolt_new_JPH_BVec16_size_t(inCount);
            }

            /// Generated from method `JPH::BVec16::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BVec16_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BVec16_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_BVec16_void_ptr(void *inPointer);
                __Jolt_delete_JPH_BVec16_void_ptr(inPointer);
            }

            /// Generated from method `JPH::BVec16::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BVec16_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BVec16_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_BVec16_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_BVec16_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::BVec16::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BVec16_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BVec16_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_BVec16_size_t(ulong inCount);
                return __Jolt_new_array_JPH_BVec16_size_t(inCount);
            }

            /// Generated from method `JPH::BVec16::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BVec16_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BVec16_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_BVec16_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_BVec16_void_ptr(inPointer);
            }

            /// Generated from method `JPH::BVec16::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BVec16_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BVec16_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_BVec16_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_BVec16_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::BVec16::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BVec16_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BVec16_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_BVec16_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_BVec16_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::BVec16::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BVec16_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BVec16_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_BVec16_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_BVec16_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::BVec16::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BVec16_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BVec16_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_BVec16_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_BVec16_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::BVec16::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BVec16_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BVec16_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_BVec16_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_BVec16_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Comparison
            /// Generated from method `JPH::BVec16::operator==`.
            public static unsafe bool operator==(Jolt.JPH.Const_BVec16 _this, Jolt.JPH.Const_BVec16 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_BVec16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_BVec16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_equal_JPH_BVec16(Jolt.JPH.Const_BVec16._Underlying *_this, Jolt.JPH.BVec16._Underlying *inV2);
                return __Jolt_equal_JPH_BVec16(_this._UnderlyingPtr, inV2._UnderlyingPtr) != 0;
            }

            public static unsafe bool operator!=(Jolt.JPH.Const_BVec16 _this, Jolt.JPH.Const_BVec16 inV2)
            {
                return !(_this == inV2);
            }

            /// Vector with all zeros
            /// Generated from method `JPH::BVec16::sZero`.
            public static unsafe Jolt.JPH.BVec16 SZero()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_sZero();
                return new(__JPH_BVec16_sZero(), is_owning: true);
            }

            /// Replicate int inV across all components
            /// Generated from method `JPH::BVec16::sReplicate`.
            public static unsafe Jolt.JPH.BVec16 SReplicate(byte inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_sReplicate(byte inV);
                return new(__JPH_BVec16_sReplicate(inV), is_owning: true);
            }

            /// Load 16 bytes from memory
            /// Generated from method `JPH::BVec16::sLoadByte16`.
            public static unsafe Jolt.JPH.BVec16 SLoadByte16(byte? inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_sLoadByte16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_sLoadByte16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_sLoadByte16(byte *inV);
                byte __deref_inV = inV.GetValueOrDefault();
                return new(__JPH_BVec16_sLoadByte16(inV.HasValue ? &__deref_inV : null), is_owning: true);
            }

            /// Equals (component wise), highest bit of each component that is set is considered true
            /// Generated from method `JPH::BVec16::sEquals`.
            public static unsafe Jolt.JPH.BVec16 SEquals(Jolt.JPH.Const_BVec16 inV1, Jolt.JPH.Const_BVec16 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_sEquals(Jolt.JPH.BVec16._Underlying *inV1, Jolt.JPH.BVec16._Underlying *inV2);
                return new(__JPH_BVec16_sEquals(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical or (component wise)
            /// Generated from method `JPH::BVec16::sOr`.
            public static unsafe Jolt.JPH.BVec16 SOr(Jolt.JPH.Const_BVec16 inV1, Jolt.JPH.Const_BVec16 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_sOr(Jolt.JPH.BVec16._Underlying *inV1, Jolt.JPH.BVec16._Underlying *inV2);
                return new(__JPH_BVec16_sOr(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical xor (component wise)
            /// Generated from method `JPH::BVec16::sXor`.
            public static unsafe Jolt.JPH.BVec16 SXor(Jolt.JPH.Const_BVec16 inV1, Jolt.JPH.Const_BVec16 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_sXor(Jolt.JPH.BVec16._Underlying *inV1, Jolt.JPH.BVec16._Underlying *inV2);
                return new(__JPH_BVec16_sXor(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical and (component wise)
            /// Generated from method `JPH::BVec16::sAnd`.
            public static unsafe Jolt.JPH.BVec16 SAnd(Jolt.JPH.Const_BVec16 inV1, Jolt.JPH.Const_BVec16 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_sAnd(Jolt.JPH.BVec16._Underlying *inV1, Jolt.JPH.BVec16._Underlying *inV2);
                return new(__JPH_BVec16_sAnd(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical not (component wise)
            /// Generated from method `JPH::BVec16::sNot`.
            public static unsafe Jolt.JPH.BVec16 SNot(Jolt.JPH.Const_BVec16 inV1)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_sNot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_sNot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_sNot(Jolt.JPH.BVec16._Underlying *inV1);
                return new(__JPH_BVec16_sNot(inV1._UnderlyingPtr), is_owning: true);
            }

            /// Get component by index
            /// Generated from method `JPH::BVec16::operator[]`.
            public unsafe byte this[uint inCoordinate]
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static byte __JPH_BVec16_index(_Underlying *_this, uint inCoordinate);
                    return __JPH_BVec16_index(_UnderlyingPtr, inCoordinate);
                }
            }

            /// Test if any of the components are true (true is when highest bit of component is set)
            /// Generated from method `JPH::BVec16::TestAnyTrue`.
            public unsafe bool TestAnyTrue()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_TestAnyTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_TestAnyTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_BVec16_TestAnyTrue(_Underlying *_this);
                return __JPH_BVec16_TestAnyTrue(_UnderlyingPtr) != 0;
            }

            /// Test if all components are true (true is when highest bit of component is set)
            /// Generated from method `JPH::BVec16::TestAllTrue`.
            public unsafe bool TestAllTrue()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_TestAllTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_TestAllTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_BVec16_TestAllTrue(_Underlying *_this);
                return __JPH_BVec16_TestAllTrue(_UnderlyingPtr) != 0;
            }

            /// Store if mU8[0] is true in bit 0, mU8[1] in bit 1, etc. (true is when highest bit of component is set)
            /// Generated from method `JPH::BVec16::GetTrues`.
            public unsafe int GetTrues()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_GetTrues", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_GetTrues", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_BVec16_GetTrues(_Underlying *_this);
                return __JPH_BVec16_GetTrues(_UnderlyingPtr);
            }

            // IEquatable:

            public bool Equals(Jolt.JPH.Const_BVec16? inV2)
            {
                if (inV2 is null)
                    return false;
                return this == inV2;
            }

            public override bool Equals(object? other)
            {
                if (other is null)
                    return false;
                if (other is Jolt.JPH.Const_BVec16)
                    return this == (Jolt.JPH.Const_BVec16)other;
                return false;
            }
        }

        /// A vector consisting of 16 bytes
        /// Generated from class `JPH::BVec16`.
        /// This is the non-const half of the class.
        public class BVec16 : Const_BVec16
        {
            internal unsafe BVec16(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe BVec16() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_DefaultConstruct();
                _UnderlyingPtr = __JPH_BVec16_DefaultConstruct();
            }

            /// Generated from constructor `JPH::BVec16::BVec16`.
            public unsafe BVec16(Jolt.JPH.Const_BVec16 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_ConstructFromAnother(Jolt.JPH.BVec16._Underlying *inRHS);
                _UnderlyingPtr = __JPH_BVec16_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::BVec16::BVec16`.
            public BVec16(BVec16 inRHS) : this((Const_BVec16)inRHS) {}

            /// Create a vector from 16 bytes
            /// Generated from constructor `JPH::BVec16::BVec16`.
            public unsafe BVec16(byte inB0, byte inB1, byte inB2, byte inB3, byte inB4, byte inB5, byte inB6, byte inB7, byte inB8, byte inB9, byte inB10, byte inB11, byte inB12, byte inB13, byte inB14, byte inB15) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_Construct_16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_Construct_16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_Construct_16(byte inB0, byte inB1, byte inB2, byte inB3, byte inB4, byte inB5, byte inB6, byte inB7, byte inB8, byte inB9, byte inB10, byte inB11, byte inB12, byte inB13, byte inB14, byte inB15);
                _UnderlyingPtr = __JPH_BVec16_Construct_16(inB0, inB1, inB2, inB3, inB4, inB5, inB6, inB7, inB8, inB9, inB10, inB11, inB12, inB13, inB14, inB15);
            }

            /// Create a vector from two uint64's
            /// Generated from constructor `JPH::BVec16::BVec16`.
            public unsafe BVec16(ulong inV0, ulong inV1) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_Construct_2(ulong inV0, ulong inV1);
                _UnderlyingPtr = __JPH_BVec16_Construct_2(inV0, inV1);
            }

            /// Generated from method `JPH::BVec16::operator=`.
            public unsafe Jolt.JPH.BVec16 Assign(Jolt.JPH.Const_BVec16 inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BVec16._Underlying *__JPH_BVec16_AssignFromAnother(_Underlying *_this, Jolt.JPH.BVec16._Underlying *inRHS);
                Jolt.JPH.BVec16 __ret;
                __ret = new(__JPH_BVec16_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
                _DiscardKeepAlive();
                _KeepAlive(inRHS);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Generated from method `JPH::BVec16::operator[]`.
            public unsafe new ref byte this[uint inCoordinate]
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BVec16_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BVec16_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static byte *__JPH_BVec16_index_mut(_Underlying *_this, uint inCoordinate);
                    return ref *__JPH_BVec16_index_mut(_UnderlyingPtr, inCoordinate);
                }
            }
        }

        /// This is used for optional parameters of class `BVec16` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_BVec16`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `BVec16`/`Const_BVec16` directly.
        public class _InOptMut_BVec16
        {
            public BVec16? Opt;

            public _InOptMut_BVec16() {}
            public _InOptMut_BVec16(BVec16 value) {Opt = value;}
            public static implicit operator _InOptMut_BVec16(BVec16 value) {return new(value);}
        }

        /// This is used for optional parameters of class `BVec16` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_BVec16`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `BVec16`/`Const_BVec16` to pass it to the function.
        public class _InOptConst_BVec16
        {
            public Const_BVec16? Opt;

            public _InOptConst_BVec16() {}
            public _InOptConst_BVec16(Const_BVec16 value) {Opt = value;}
            public static implicit operator _InOptConst_BVec16(Const_BVec16 value) {return new(value);}
        }
    }
}
