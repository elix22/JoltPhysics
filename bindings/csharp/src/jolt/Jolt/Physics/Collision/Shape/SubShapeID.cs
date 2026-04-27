// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// @brief A sub shape id contains a path to an element (usually a triangle or other primitive type) of a compound shape
        ///
        /// Each sub shape knows how many bits it needs to encode its ID, so knows how many bits to take from the sub shape ID.
        ///
        /// For example:
        /// * We have a CompoundShape A with 5 child shapes (identify sub shape using 3 bits AAA)
        /// * One of its child shapes is CompoundShape B which has 3 child shapes (identify sub shape using 2 bits BB)
        /// * One of its child shapes is MeshShape C which contains enough triangles to need 7 bits to identify a triangle (identify sub shape using 7 bits CCCCCCC, note that MeshShape is block based and sorts triangles spatially, you can't assume that the first triangle will have bit pattern 0000000).
        ///
        /// The bit pattern of the sub shape ID to identify a triangle in MeshShape C will then be CCCCCCCBBAAA.
        ///
        /// A sub shape ID will become invalid when the structure of the shape changes. For example, if a child shape is removed from a compound shape, the sub shape ID will no longer be valid.
        /// This can be a problem when caching sub shape IDs from one frame to the next. See comments at ContactListener::OnContactPersisted / OnContactRemoved.
        /// Generated from class `JPH::SubShapeID`.
        /// This is the const half of the class.
        public class Const_SubShapeID : Jolt.Object<Const_SubShapeID>, System.IDisposable, System.IEquatable<Jolt.JPH.Const_SubShapeID>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SubShapeID_Destroy(_Underlying *_this);
                __JPH_SubShapeID_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_SubShapeID() {Dispose(false);}

            /// How many bits we can store in this ID
            public static unsafe uint MaxBits
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_Get_MaxBits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_Get_MaxBits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SubShapeID_Get_MaxBits();
                    return *__JPH_SubShapeID_Get_MaxBits();
                }
            }

            internal unsafe Const_SubShapeID(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_SubShapeID() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SubShapeID._Underlying *__JPH_SubShapeID_DefaultConstruct();
                _UnderlyingPtr = __JPH_SubShapeID_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SubShapeID::SubShapeID`.
            public unsafe Const_SubShapeID(Jolt.JPH.Const_SubShapeID _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SubShapeID._Underlying *__JPH_SubShapeID_ConstructFromAnother(Jolt.JPH.SubShapeID._Underlying *_other);
                _UnderlyingPtr = __JPH_SubShapeID_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SubShapeID::SubShapeID`.
            public Const_SubShapeID(SubShapeID _other) : this((Const_SubShapeID)_other) {}

            /// Generated from method `JPH::SubShapeID::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SubShapeID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SubShapeID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SubShapeID_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_SubShapeID_unsigned_long(inCount);
            }

            /// Generated from method `JPH::SubShapeID::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SubShapeID_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SubShapeID_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SubShapeID::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SubShapeID_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_SubShapeID_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::SubShapeID::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SubShapeID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SubShapeID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SubShapeID_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_SubShapeID_unsigned_long(inCount);
            }

            /// Generated from method `JPH::SubShapeID::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SubShapeID_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SubShapeID_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SubShapeID::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SubShapeID_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_SubShapeID_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::SubShapeID::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SubShapeID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SubShapeID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SubShapeID_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_SubShapeID_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SubShapeID::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SubShapeID_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SubShapeID_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SubShapeID::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SubShapeID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SubShapeID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SubShapeID_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_SubShapeID_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SubShapeID::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SubShapeID_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SubShapeID_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Get the next id in the chain of ids (pops parents before children)
            /// Generated from method `JPH::SubShapeID::PopID`.
            public unsafe uint PopID(uint inBits, Jolt.JPH.SubShapeID outRemainder)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_PopID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_PopID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_SubShapeID_PopID(_Underlying *_this, uint inBits, Jolt.JPH.SubShapeID._Underlying *outRemainder);
                return __JPH_SubShapeID_PopID(_UnderlyingPtr, inBits, outRemainder._UnderlyingPtr);
            }

            /// Get the value of the path to the sub shape ID
            /// Generated from method `JPH::SubShapeID::GetValue`.
            public unsafe uint GetValue()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_GetValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_GetValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_SubShapeID_GetValue(_Underlying *_this);
                return __JPH_SubShapeID_GetValue(_UnderlyingPtr);
            }

            /// Check if there is any bits of subshape ID left.
            /// Note that this is not a 100% guarantee as the subshape ID could consist of all 1 bits. Use for asserts only.
            /// Generated from method `JPH::SubShapeID::IsEmpty`.
            public unsafe bool IsEmpty()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_IsEmpty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_IsEmpty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_SubShapeID_IsEmpty(_Underlying *_this);
                return __JPH_SubShapeID_IsEmpty(_UnderlyingPtr) != 0;
            }

            /// Check equal
            /// Generated from method `JPH::SubShapeID::operator==`.
            public static unsafe bool operator==(Jolt.JPH.Const_SubShapeID _this, Jolt.JPH.Const_SubShapeID inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_SubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_SubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_equal_JPH_SubShapeID(Jolt.JPH.Const_SubShapeID._Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inRHS);
                return __Jolt_equal_JPH_SubShapeID(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
            }

            public static unsafe bool operator!=(Jolt.JPH.Const_SubShapeID _this, Jolt.JPH.Const_SubShapeID inRHS)
            {
                return !(_this == inRHS);
            }

            // IEquatable:

            public bool Equals(Jolt.JPH.Const_SubShapeID? inRHS)
            {
                if (inRHS is null)
                    return false;
                return this == inRHS;
            }

            public override bool Equals(object? other)
            {
                if (other is null)
                    return false;
                if (other is Jolt.JPH.Const_SubShapeID)
                    return this == (Jolt.JPH.Const_SubShapeID)other;
                return false;
            }
        }

        /// @brief A sub shape id contains a path to an element (usually a triangle or other primitive type) of a compound shape
        ///
        /// Each sub shape knows how many bits it needs to encode its ID, so knows how many bits to take from the sub shape ID.
        ///
        /// For example:
        /// * We have a CompoundShape A with 5 child shapes (identify sub shape using 3 bits AAA)
        /// * One of its child shapes is CompoundShape B which has 3 child shapes (identify sub shape using 2 bits BB)
        /// * One of its child shapes is MeshShape C which contains enough triangles to need 7 bits to identify a triangle (identify sub shape using 7 bits CCCCCCC, note that MeshShape is block based and sorts triangles spatially, you can't assume that the first triangle will have bit pattern 0000000).
        ///
        /// The bit pattern of the sub shape ID to identify a triangle in MeshShape C will then be CCCCCCCBBAAA.
        ///
        /// A sub shape ID will become invalid when the structure of the shape changes. For example, if a child shape is removed from a compound shape, the sub shape ID will no longer be valid.
        /// This can be a problem when caching sub shape IDs from one frame to the next. See comments at ContactListener::OnContactPersisted / OnContactRemoved.
        /// Generated from class `JPH::SubShapeID`.
        /// This is the non-const half of the class.
        public class SubShapeID : Const_SubShapeID
        {
            internal unsafe SubShapeID(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe SubShapeID() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SubShapeID._Underlying *__JPH_SubShapeID_DefaultConstruct();
                _UnderlyingPtr = __JPH_SubShapeID_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SubShapeID::SubShapeID`.
            public unsafe SubShapeID(Jolt.JPH.Const_SubShapeID _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SubShapeID._Underlying *__JPH_SubShapeID_ConstructFromAnother(Jolt.JPH.SubShapeID._Underlying *_other);
                _UnderlyingPtr = __JPH_SubShapeID_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SubShapeID::SubShapeID`.
            public SubShapeID(SubShapeID _other) : this((Const_SubShapeID)_other) {}

            /// Generated from method `JPH::SubShapeID::operator=`.
            public unsafe Jolt.JPH.SubShapeID Assign(Jolt.JPH.Const_SubShapeID _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SubShapeID._Underlying *__JPH_SubShapeID_AssignFromAnother(_Underlying *_this, Jolt.JPH.SubShapeID._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SubShapeID_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }

            /// Set the value of the sub shape ID (use with care!)
            /// Generated from method `JPH::SubShapeID::SetValue`.
            public unsafe void SetValue(uint inValue)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeID_SetValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeID_SetValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SubShapeID_SetValue(_Underlying *_this, uint inValue);
                __JPH_SubShapeID_SetValue(_UnderlyingPtr, inValue);
            }
        }

        /// This is used for optional parameters of class `SubShapeID` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_SubShapeID`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SubShapeID`/`Const_SubShapeID` directly.
        public class _InOptMut_SubShapeID
        {
            public SubShapeID? Opt;

            public _InOptMut_SubShapeID() {}
            public _InOptMut_SubShapeID(SubShapeID value) {Opt = value;}
            public static implicit operator _InOptMut_SubShapeID(SubShapeID value) {return new(value);}
        }

        /// This is used for optional parameters of class `SubShapeID` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_SubShapeID`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SubShapeID`/`Const_SubShapeID` to pass it to the function.
        public class _InOptConst_SubShapeID
        {
            public Const_SubShapeID? Opt;

            public _InOptConst_SubShapeID() {}
            public _InOptConst_SubShapeID(Const_SubShapeID value) {Opt = value;}
            public static implicit operator _InOptConst_SubShapeID(Const_SubShapeID value) {return new(value);}
        }
    }
}
