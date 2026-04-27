// machine generated, do not edit
public static partial class JPH
{
    /// ID of a character. Used primarily to identify deleted characters and to sort deterministically.
    /// Generated from class `JPH::CharacterID`.
    /// This is the const half of the class.
    public class Const_CharacterID : JPH.Object<Const_CharacterID>, System.IDisposable, System.IEquatable<JPH.Const_CharacterID>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CharacterID_Destroy(_Underlying *_this);
            __JPH_CharacterID_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CharacterID() {Dispose(false);}

        ///< The value for an invalid character ID
        public static unsafe uint CInvalidCharacterID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_Get_cInvalidCharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_Get_cInvalidCharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_CharacterID_Get_cInvalidCharacterID();
                return *__JPH_CharacterID_Get_cInvalidCharacterID();
            }
        }

        internal unsafe Const_CharacterID(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CharacterID() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterID._Underlying *__JPH_CharacterID_DefaultConstruct();
            _UnderlyingPtr = __JPH_CharacterID_DefaultConstruct();
        }

        /// Generated from constructor `JPH::CharacterID::CharacterID`.
        public unsafe Const_CharacterID(JPH.Const_CharacterID _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterID._Underlying *__JPH_CharacterID_ConstructFromAnother(JPH.CharacterID._Underlying *_other);
            _UnderlyingPtr = __JPH_CharacterID_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::CharacterID::CharacterID`.
        public Const_CharacterID(CharacterID _other) : this((Const_CharacterID)_other) {}

        /// Construct with specific value, make sure you don't use the same value twice!
        /// Generated from constructor `JPH::CharacterID::CharacterID`.
        public unsafe Const_CharacterID(uint inID) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterID._Underlying *__JPH_CharacterID_Construct(uint inID);
            _UnderlyingPtr = __JPH_CharacterID_Construct(inID);
        }

        /// Generated from method `JPH::CharacterID::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterID_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterID_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CharacterID_size_t(ulong inCount);
            return __Jolt_new_JPH_CharacterID_size_t(inCount);
        }

        /// Generated from method `JPH::CharacterID::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CharacterID_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CharacterID_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CharacterID::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterID_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterID_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CharacterID_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_CharacterID_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CharacterID::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterID_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterID_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CharacterID_size_t(ulong inCount);
            return __Jolt_new_array_JPH_CharacterID_size_t(inCount);
        }

        /// Generated from method `JPH::CharacterID::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterID_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CharacterID_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CharacterID_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CharacterID::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterID_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterID_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CharacterID_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_CharacterID_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CharacterID::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterID_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterID_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CharacterID_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_CharacterID_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CharacterID::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CharacterID_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CharacterID_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CharacterID::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterID_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterID_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CharacterID_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_CharacterID_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CharacterID::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterID_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CharacterID_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CharacterID_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Get the numeric value of the ID
        /// Generated from method `JPH::CharacterID::GetValue`.
        public unsafe uint GetValue()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_GetValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_GetValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CharacterID_GetValue(_Underlying *_this);
            return __JPH_CharacterID_GetValue(_UnderlyingPtr);
        }

        /// Check if the ID is valid
        /// Generated from method `JPH::CharacterID::IsInvalid`.
        public unsafe bool IsInvalid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_IsInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_IsInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_CharacterID_IsInvalid(_Underlying *_this);
            return __JPH_CharacterID_IsInvalid(_UnderlyingPtr) != 0;
        }

        /// Equals check
        /// Generated from method `JPH::CharacterID::operator==`.
        public static unsafe bool operator==(JPH.Const_CharacterID _this, JPH.Const_CharacterID inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_CharacterID(JPH.Const_CharacterID._Underlying *_this, JPH.Const_CharacterID._Underlying *inRHS);
            return __Jolt_equal_JPH_CharacterID(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_CharacterID _this, JPH.Const_CharacterID inRHS)
        {
            return !(_this == inRHS);
        }

        /// Smaller than operator, can be used for sorting characters
        /// Generated from method `JPH::CharacterID::operator<`.
        public static unsafe bool operator<(JPH.Const_CharacterID _this, JPH.Const_CharacterID inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_less_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_less_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_less_JPH_CharacterID(JPH.Const_CharacterID._Underlying *_this, JPH.Const_CharacterID._Underlying *inRHS);
            return __Jolt_less_JPH_CharacterID(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator>(JPH.Const_CharacterID _this, JPH.Const_CharacterID inRHS)
        {
            return inRHS < _this;
        }

        public static unsafe bool operator<=(JPH.Const_CharacterID _this, JPH.Const_CharacterID inRHS)
        {
            return !(inRHS < _this);
        }

        public static unsafe bool operator>=(JPH.Const_CharacterID _this, JPH.Const_CharacterID inRHS)
        {
            return !(_this < inRHS);
        }

        /// Get the hash for this character ID
        /// Generated from method `JPH::CharacterID::GetHash`.
        public unsafe ulong GetHash()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_GetHash", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_GetHash", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_CharacterID_GetHash(_Underlying *_this);
            return __JPH_CharacterID_GetHash(_UnderlyingPtr);
        }

        /// Generate the next available character ID
        /// Generated from method `JPH::CharacterID::sNextCharacterID`.
        public static unsafe JPH.CharacterID SNextCharacterID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_sNextCharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_sNextCharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterID._Underlying *__JPH_CharacterID_sNextCharacterID();
            return new(__JPH_CharacterID_sNextCharacterID(), is_owning: true);
        }

        /// Set the next available character ID, can be used after destroying all character to prepare for a second deterministic run
        /// Generated from method `JPH::CharacterID::sSetNextCharacterID`.
        /// Parameter `inNextValue` defaults to `1`.
        public static unsafe void SSetNextCharacterID(uint? inNextValue = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_sSetNextCharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_sSetNextCharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CharacterID_sSetNextCharacterID(uint *inNextValue);
            uint __deref_inNextValue = inNextValue.GetValueOrDefault();
            __JPH_CharacterID_sSetNextCharacterID(inNextValue.HasValue ? &__deref_inNextValue : null);
        }

        // IEquatable:

        public bool Equals(JPH.Const_CharacterID? inRHS)
        {
            if (inRHS is null)
                return false;
            return this == inRHS;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_CharacterID)
                return this == (JPH.Const_CharacterID)other;
            return false;
        }
    }

    /// ID of a character. Used primarily to identify deleted characters and to sort deterministically.
    /// Generated from class `JPH::CharacterID`.
    /// This is the non-const half of the class.
    public class CharacterID : Const_CharacterID
    {
        internal unsafe CharacterID(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CharacterID() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterID._Underlying *__JPH_CharacterID_DefaultConstruct();
            _UnderlyingPtr = __JPH_CharacterID_DefaultConstruct();
        }

        /// Generated from constructor `JPH::CharacterID::CharacterID`.
        public unsafe CharacterID(JPH.Const_CharacterID _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterID._Underlying *__JPH_CharacterID_ConstructFromAnother(JPH.CharacterID._Underlying *_other);
            _UnderlyingPtr = __JPH_CharacterID_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::CharacterID::CharacterID`.
        public CharacterID(CharacterID _other) : this((Const_CharacterID)_other) {}

        /// Construct with specific value, make sure you don't use the same value twice!
        /// Generated from constructor `JPH::CharacterID::CharacterID`.
        public unsafe CharacterID(uint inID) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterID._Underlying *__JPH_CharacterID_Construct(uint inID);
            _UnderlyingPtr = __JPH_CharacterID_Construct(inID);
        }

        /// Generated from method `JPH::CharacterID::operator=`.
        public unsafe JPH.CharacterID Assign(JPH.Const_CharacterID _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterID._Underlying *__JPH_CharacterID_AssignFromAnother(_Underlying *_this, JPH.CharacterID._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_CharacterID_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `CharacterID` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterID`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CharacterID`/`Const_CharacterID` directly.
    public class _InOptMut_CharacterID
    {
        public CharacterID? Opt;

        public _InOptMut_CharacterID() {}
        public _InOptMut_CharacterID(CharacterID value) {Opt = value;}
        public static implicit operator _InOptMut_CharacterID(CharacterID value) {return new(value);}
    }

    /// This is used for optional parameters of class `CharacterID` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterID`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CharacterID`/`Const_CharacterID` to pass it to the function.
    public class _InOptConst_CharacterID
    {
        public Const_CharacterID? Opt;

        public _InOptConst_CharacterID() {}
        public _InOptConst_CharacterID(Const_CharacterID value) {Opt = value;}
        public static implicit operator _InOptConst_CharacterID(Const_CharacterID value) {return new(value);}
    }
}
