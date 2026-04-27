// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// ID of a body. This is a way of reasoning about bodies in a multithreaded simulation while avoiding race conditions.
        /// Generated from class `JPH::BodyID`.
        /// This is the const reference to the struct.
        public class ConstBox_BodyID : Jolt.Object<ConstBox_BodyID>, System.IDisposable, System.IEquatable<Jolt.JPH.ConstBox_BodyID>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            /// Get the underlying struct.
            public unsafe ref readonly BodyID _Ref => ref *(BodyID *)_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                Jolt._Free((void *)_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~ConstBox_BodyID() {Dispose(false);}

            public ref readonly Jolt.ArrayUnsignedChar4 data => ref _Ref.data;

            ///< The value for an invalid body ID
            public static unsafe uint CInvalidBodyID
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Get_cInvalidBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Get_cInvalidBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_BodyID_Get_cInvalidBodyID();
                    return *__JPH_BodyID_Get_cInvalidBodyID();
                }
            }

            ///< This bit is used by the broadphase
            public static unsafe uint CBroadPhaseBit
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Get_cBroadPhaseBit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Get_cBroadPhaseBit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_BodyID_Get_cBroadPhaseBit();
                    return *__JPH_BodyID_Get_cBroadPhaseBit();
                }
            }

            ///< Maximum value for body index (also the maximum amount of bodies supported - 1)
            public static unsafe uint CMaxBodyIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Get_cMaxBodyIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Get_cMaxBodyIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_BodyID_Get_cMaxBodyIndex();
                    return *__JPH_BodyID_Get_cMaxBodyIndex();
                }
            }

            ///< Maximum value for the sequence number
            public static unsafe byte CMaxSequenceNumber
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Get_cMaxSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Get_cMaxSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static byte *__JPH_BodyID_Get_cMaxSequenceNumber();
                    return *__JPH_BodyID_Get_cMaxSequenceNumber();
                }
            }

            ///< Number of bits to shift to get the sequence number
            public static unsafe uint CSequenceNumberShift
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Get_cSequenceNumberShift", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Get_cSequenceNumberShift", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_BodyID_Get_cSequenceNumberShift();
                    return *__JPH_BodyID_Get_cSequenceNumberShift();
                }
            }

            /// Make a copy of a struct. (Even though we initially pass `is_owning: false`, we then use the copy constructor to produce an owning instance.)
            public unsafe ConstBox_BodyID(BodyID other) : this(new ConstBox_BodyID((_Underlying *)&other, is_owning: false)) {}
            /// Convert from a struct by copying it. Note that only `ConstBox_BodyID` has this conversion, `Box_BodyID` intentionally doesn't.
            public static implicit operator ConstBox_BodyID(BodyID other) {return new(other);}

            internal unsafe ConstBox_BodyID(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated copy constructor.
            public unsafe ConstBox_BodyID(ConstBox_BodyID _other) : this(null, is_owning: true)
            {
                _UnderlyingPtr = (_Underlying *)Jolt._Alloc(4);
                *(Jolt.JPH.BodyID *)_UnderlyingPtr = *(Jolt.JPH.BodyID *)_other._UnderlyingPtr;
            }

            /// Constructs an empty (default-constructed) instance.
            public unsafe ConstBox_BodyID() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_BodyID_DefaultConstruct();
                _UnderlyingPtr = (_Underlying *)Jolt._Alloc(4);
                *(Jolt.JPH.BodyID *)_UnderlyingPtr = __JPH_BodyID_DefaultConstruct();
            }

            /// Construct from index and sequence number combined in a single uint32 (use with care!)
            /// Generated from constructor `JPH::BodyID::BodyID`.
            public unsafe ConstBox_BodyID(uint inID) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_BodyID_Construct_1(uint inID);
                _UnderlyingPtr = (_Underlying *)Jolt._Alloc(4);
                *(Jolt.JPH.BodyID *)_UnderlyingPtr = __JPH_BodyID_Construct_1(inID);
            }

            /// Construct from index and sequence number
            /// Generated from constructor `JPH::BodyID::BodyID`.
            public unsafe ConstBox_BodyID(uint inID, byte inSequenceNumber) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_BodyID_Construct_2(uint inID, byte inSequenceNumber);
                _UnderlyingPtr = (_Underlying *)Jolt._Alloc(4);
                *(Jolt.JPH.BodyID *)_UnderlyingPtr = __JPH_BodyID_Construct_2(inID, inSequenceNumber);
            }

            /// Generated from method `JPH::BodyID::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BodyID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BodyID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_BodyID_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_BodyID_unsigned_long(inCount);
            }

            /// Generated from method `JPH::BodyID::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_BodyID_void_ptr(void *inPointer);
                __Jolt_delete_JPH_BodyID_void_ptr(inPointer);
            }

            /// Generated from method `JPH::BodyID::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_BodyID_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_BodyID_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::BodyID::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BodyID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BodyID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_BodyID_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_BodyID_unsigned_long(inCount);
            }

            /// Generated from method `JPH::BodyID::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_BodyID_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_BodyID_void_ptr(inPointer);
            }

            /// Generated from method `JPH::BodyID::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_BodyID_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_BodyID_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::BodyID::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BodyID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BodyID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_BodyID_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_BodyID_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::BodyID::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_BodyID_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_BodyID_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::BodyID::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BodyID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BodyID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_BodyID_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_BodyID_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::BodyID::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Get index in body array
            /// Generated from method `JPH::BodyID::GetIndex`.
            public unsafe uint GetIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_GetIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_GetIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_BodyID_GetIndex(_Underlying *_this);
                return __JPH_BodyID_GetIndex(_UnderlyingPtr);
            }

            /// Get sequence number of body.
            /// The sequence number can be used to check if a body ID with the same body index has been reused by another body.
            /// It is mainly used in multi threaded situations where a body is removed and its body index is immediately reused by a body created from another thread.
            /// Functions querying the broadphase can (after acquiring a body lock) detect that the body has been removed (we assume that this won't happen more than 128 times in a row).
            /// Generated from method `JPH::BodyID::GetSequenceNumber`.
            public unsafe byte GetSequenceNumber()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_GetSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_GetSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_BodyID_GetSequenceNumber(_Underlying *_this);
                return __JPH_BodyID_GetSequenceNumber(_UnderlyingPtr);
            }

            /// Returns the index and sequence number combined in an uint32
            /// Generated from method `JPH::BodyID::GetIndexAndSequenceNumber`.
            public unsafe uint GetIndexAndSequenceNumber()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_GetIndexAndSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_GetIndexAndSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_BodyID_GetIndexAndSequenceNumber(_Underlying *_this);
                return __JPH_BodyID_GetIndexAndSequenceNumber(_UnderlyingPtr);
            }

            /// Check if the ID is valid
            /// Generated from method `JPH::BodyID::IsInvalid`.
            public unsafe bool IsInvalid()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_IsInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_IsInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_BodyID_IsInvalid(_Underlying *_this);
                return __JPH_BodyID_IsInvalid(_UnderlyingPtr) != 0;
            }

            /// Equals check
            /// Generated from method `JPH::BodyID::operator==`.
            public static unsafe bool operator==(Jolt.JPH.ConstBox_BodyID _this, Jolt.JPH.ConstBox_BodyID inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_equal_JPH_BodyID(Jolt.JPH.ConstBox_BodyID._Underlying *_this, Jolt.JPH.ConstBox_BodyID._Underlying *inRHS);
                return __Jolt_equal_JPH_BodyID(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
            }

            public static unsafe bool operator!=(Jolt.JPH.ConstBox_BodyID _this, Jolt.JPH.ConstBox_BodyID inRHS)
            {
                return !(_this == inRHS);
            }

            /// Smaller than operator, can be used for sorting bodies
            /// Generated from method `JPH::BodyID::operator<`.
            public static unsafe bool operator<(Jolt.JPH.ConstBox_BodyID _this, Jolt.JPH.ConstBox_BodyID inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_less_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_less_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_less_JPH_BodyID(Jolt.JPH.ConstBox_BodyID._Underlying *_this, Jolt.JPH.ConstBox_BodyID._Underlying *inRHS);
                return __Jolt_less_JPH_BodyID(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
            }

            public static unsafe bool operator>(Jolt.JPH.ConstBox_BodyID _this, Jolt.JPH.ConstBox_BodyID inRHS)
            {
                return inRHS < _this;
            }

            public static unsafe bool operator<=(Jolt.JPH.ConstBox_BodyID _this, Jolt.JPH.ConstBox_BodyID inRHS)
            {
                return !(inRHS < _this);
            }

            public static unsafe bool operator>=(Jolt.JPH.ConstBox_BodyID _this, Jolt.JPH.ConstBox_BodyID inRHS)
            {
                return !(_this < inRHS);
            }

            // IEquatable:

            public bool Equals(Jolt.JPH.ConstBox_BodyID? inRHS)
            {
                if (inRHS is null)
                    return false;
                return this == inRHS;
            }

            public override bool Equals(object? other)
            {
                if (other is null)
                    return false;
                if (other is Jolt.JPH.ConstBox_BodyID)
                    return this == (Jolt.JPH.ConstBox_BodyID)other;
                return false;
            }
        }

        /// ID of a body. This is a way of reasoning about bodies in a multithreaded simulation while avoiding race conditions.
        /// Generated from class `JPH::BodyID`.
        /// This is the non-const reference to the struct.
        public class Box_BodyID : ConstBox_BodyID
        {
            /// Get the underlying struct.
            public unsafe new ref BodyID _Ref => ref *(BodyID *)_UnderlyingPtr;

            public new ref Jolt.ArrayUnsignedChar4 data => ref _Ref.data;

            /// Make a copy of a struct. (Even though we initially pass `is_owning: false`, we then use the copy constructor to produce an owning instance.)
            public unsafe Box_BodyID(BodyID other) : this(new ConstBox_BodyID((_Underlying *)&other, is_owning: false)) {}

            internal unsafe Box_BodyID(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated copy constructor.
            public unsafe Box_BodyID(ConstBox_BodyID _other) : this(null, is_owning: true)
            {
                _UnderlyingPtr = (_Underlying *)Jolt._Alloc(4);
                *(Jolt.JPH.BodyID *)_UnderlyingPtr = *(Jolt.JPH.BodyID *)_other._UnderlyingPtr;
            }

            /// Generated copy assignment.
            public void Assign(ConstBox_BodyID _other) {_Ref = _other._Ref;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Box_BodyID() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_BodyID_DefaultConstruct();
                _UnderlyingPtr = (_Underlying *)Jolt._Alloc(4);
                *(Jolt.JPH.BodyID *)_UnderlyingPtr = __JPH_BodyID_DefaultConstruct();
            }

            /// Construct from index and sequence number combined in a single uint32 (use with care!)
            /// Generated from constructor `JPH::BodyID::BodyID`.
            public unsafe Box_BodyID(uint inID) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_BodyID_Construct_1(uint inID);
                _UnderlyingPtr = (_Underlying *)Jolt._Alloc(4);
                *(Jolt.JPH.BodyID *)_UnderlyingPtr = __JPH_BodyID_Construct_1(inID);
            }

            /// Construct from index and sequence number
            /// Generated from constructor `JPH::BodyID::BodyID`.
            public unsafe Box_BodyID(uint inID, byte inSequenceNumber) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_BodyID_Construct_2(uint inID, byte inSequenceNumber);
                _UnderlyingPtr = (_Underlying *)Jolt._Alloc(4);
                *(Jolt.JPH.BodyID *)_UnderlyingPtr = __JPH_BodyID_Construct_2(inID, inSequenceNumber);
            }
        }

        /// ID of a body. This is a way of reasoning about bodies in a multithreaded simulation while avoiding race conditions.
        /// Generated from class `JPH::BodyID`.
        /// This is the by-value version of the struct.
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit, Size = 4)]
        public struct BodyID : System.IEquatable<Jolt.JPH.BodyID>
        {
            [System.Runtime.InteropServices.FieldOffset(0)]
            public Jolt.ArrayUnsignedChar4 data;

            /// Copy contents from a wrapper class to this struct.
            public static implicit operator BodyID(ConstBox_BodyID other) => other._Ref;

            /// Generated copy constructor.
            public BodyID(BodyID _other) {this = _other;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe BodyID()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_BodyID_DefaultConstruct();
                this = __JPH_BodyID_DefaultConstruct();
            }

            /// Construct from index and sequence number combined in a single uint32 (use with care!)
            /// Generated from constructor `JPH::BodyID::BodyID`.
            public unsafe BodyID(uint inID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_BodyID_Construct_1(uint inID);
                this = __JPH_BodyID_Construct_1(inID);
            }

            /// Construct from index and sequence number
            /// Generated from constructor `JPH::BodyID::BodyID`.
            public unsafe BodyID(uint inID, byte inSequenceNumber)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_BodyID_Construct_2(uint inID, byte inSequenceNumber);
                this = __JPH_BodyID_Construct_2(inID, inSequenceNumber);
            }

            /// Generated from method `JPH::BodyID::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BodyID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BodyID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_BodyID_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_BodyID_unsigned_long(inCount);
            }

            /// Generated from method `JPH::BodyID::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_BodyID_void_ptr(void *inPointer);
                __Jolt_delete_JPH_BodyID_void_ptr(inPointer);
            }

            /// Generated from method `JPH::BodyID::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_BodyID_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_BodyID_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::BodyID::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BodyID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BodyID_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_BodyID_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_BodyID_unsigned_long(inCount);
            }

            /// Generated from method `JPH::BodyID::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_BodyID_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_BodyID_void_ptr(inPointer);
            }

            /// Generated from method `JPH::BodyID::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_BodyID_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_BodyID_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::BodyID::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BodyID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BodyID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_BodyID_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_BodyID_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::BodyID::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BodyID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_BodyID_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_BodyID_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::BodyID::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BodyID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BodyID_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_BodyID_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_BodyID_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::BodyID::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Get index in body array
            /// Generated from method `JPH::BodyID::GetIndex`.
            public readonly unsafe uint GetIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_GetIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_GetIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_BodyID_GetIndex(Jolt.JPH.BodyID *_this);
                fixed (Jolt.JPH.BodyID *__ptr__this = &this)
                {
                    return __JPH_BodyID_GetIndex(__ptr__this);
                }
            }

            /// Get sequence number of body.
            /// The sequence number can be used to check if a body ID with the same body index has been reused by another body.
            /// It is mainly used in multi threaded situations where a body is removed and its body index is immediately reused by a body created from another thread.
            /// Functions querying the broadphase can (after acquiring a body lock) detect that the body has been removed (we assume that this won't happen more than 128 times in a row).
            /// Generated from method `JPH::BodyID::GetSequenceNumber`.
            public readonly unsafe byte GetSequenceNumber()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_GetSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_GetSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_BodyID_GetSequenceNumber(Jolt.JPH.BodyID *_this);
                fixed (Jolt.JPH.BodyID *__ptr__this = &this)
                {
                    return __JPH_BodyID_GetSequenceNumber(__ptr__this);
                }
            }

            /// Returns the index and sequence number combined in an uint32
            /// Generated from method `JPH::BodyID::GetIndexAndSequenceNumber`.
            public readonly unsafe uint GetIndexAndSequenceNumber()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_GetIndexAndSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_GetIndexAndSequenceNumber", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_BodyID_GetIndexAndSequenceNumber(Jolt.JPH.BodyID *_this);
                fixed (Jolt.JPH.BodyID *__ptr__this = &this)
                {
                    return __JPH_BodyID_GetIndexAndSequenceNumber(__ptr__this);
                }
            }

            /// Check if the ID is valid
            /// Generated from method `JPH::BodyID::IsInvalid`.
            public readonly unsafe bool IsInvalid()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyID_IsInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyID_IsInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_BodyID_IsInvalid(Jolt.JPH.BodyID *_this);
                fixed (Jolt.JPH.BodyID *__ptr__this = &this)
                {
                    return __JPH_BodyID_IsInvalid(__ptr__this) != 0;
                }
            }

            /// Equals check
            /// Generated from method `JPH::BodyID::operator==`.
            public static unsafe bool operator==(Jolt.JPH.BodyID _this, Jolt.JPH.BodyID inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_equal_JPH_BodyID(Jolt.JPH.BodyID *_this, Jolt.JPH.BodyID *inRHS);
                return __Jolt_equal_JPH_BodyID(&_this, &inRHS) != 0;
            }

            public static unsafe bool operator!=(Jolt.JPH.BodyID _this, Jolt.JPH.BodyID inRHS)
            {
                return !(_this == inRHS);
            }

            /// Smaller than operator, can be used for sorting bodies
            /// Generated from method `JPH::BodyID::operator<`.
            public static unsafe bool operator<(Jolt.JPH.BodyID _this, Jolt.JPH.BodyID inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_less_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_less_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_less_JPH_BodyID(Jolt.JPH.BodyID *_this, Jolt.JPH.BodyID *inRHS);
                return __Jolt_less_JPH_BodyID(&_this, &inRHS) != 0;
            }

            public static unsafe bool operator>(Jolt.JPH.BodyID _this, Jolt.JPH.BodyID inRHS)
            {
                return inRHS < _this;
            }

            public static unsafe bool operator<=(Jolt.JPH.BodyID _this, Jolt.JPH.BodyID inRHS)
            {
                return !(inRHS < _this);
            }

            public static unsafe bool operator>=(Jolt.JPH.BodyID _this, Jolt.JPH.BodyID inRHS)
            {
                return !(_this < inRHS);
            }

            // IEquatable:

            public bool Equals(Jolt.JPH.BodyID inRHS)
            {
                return this == inRHS;
            }

            public override bool Equals(object? other)
            {
                if (other is null)
                    return false;
                if (other is Jolt.JPH.BodyID)
                    return this == (Jolt.JPH.BodyID)other;
                return false;
            }
        }

        /// This is used as a function parameter when passing `Box_BodyID` by value with a default argument, since trying to use `?` instead seems to prevent us from taking its address.
        /// Usage:
        /// * Pass an instance of `Box_BodyID`/`ConstBox_BodyID` to copy it into the function.
        /// * Pass `null` to use the default argument
        public readonly ref struct _InOpt_BodyID
        {
            public readonly bool HasValue;
            internal readonly BodyID Object;
            public BodyID Value{
                get
                {
                    System.Diagnostics.Trace.Assert(HasValue);
                    return Object;
                }
            }

            public _InOpt_BodyID() {HasValue = false;}
            public _InOpt_BodyID(BodyID new_value) {HasValue = true; Object = new_value;}
            public static implicit operator _InOpt_BodyID(BodyID new_value) {return new(new_value);}
            public _InOpt_BodyID(ConstBox_BodyID new_value) {HasValue = true; Object = new_value._Ref;}
            public static implicit operator _InOpt_BodyID(ConstBox_BodyID new_value) {return new(new_value);}
        }

        /// This is used for optional parameters of class `Box_BodyID` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_BodyID`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Box_BodyID`/`ConstBox_BodyID` directly.
        /// * Pass `new(ref ...)` to pass a reference to `BodyID`.
        public class _InOptMut_BodyID
        {
            public Box_BodyID? Opt;

            public _InOptMut_BodyID() {}
            public _InOptMut_BodyID(Box_BodyID value) {Opt = value;}
            public static implicit operator _InOptMut_BodyID(Box_BodyID value) {return new(value);}
            public unsafe _InOptMut_BodyID(ref BodyID value)
            {
                fixed (BodyID *value_ptr = &value)
                {
                    Opt = new((ConstBox_BodyID._Underlying *)value_ptr, is_owning: false);
                }
            }
        }

        /// This is used for optional parameters of class `Box_BodyID` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_BodyID`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Box_BodyID`/`ConstBox_BodyID` to pass it to the function.
        /// * Pass `new(ref ...)` to pass a reference to `BodyID`.
        public class _InOptConst_BodyID
        {
            public ConstBox_BodyID? Opt;

            public _InOptConst_BodyID() {}
            public _InOptConst_BodyID(ConstBox_BodyID value) {Opt = value;}
            public static implicit operator _InOptConst_BodyID(ConstBox_BodyID value) {return new(value);}
            public unsafe _InOptConst_BodyID(ref readonly BodyID value)
            {
                fixed (BodyID *value_ptr = &value)
                {
                    Opt = new((ConstBox_BodyID._Underlying *)value_ptr, is_owning: false);
                }
            }
        }
    }
}
