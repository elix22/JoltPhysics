// machine generated, do not edit
public static partial class JPH
{
    /// A pair of bodies and their sub shape ID's. Can be used as a key in a map to find a contact point.
    /// Generated from class `JPH::SubShapeIDPair`.
    /// This is the const half of the class.
    public class Const_SubShapeIDPair : JPH.Object<Const_SubShapeIDPair>, System.IDisposable, System.IEquatable<JPH.Const_SubShapeIDPair>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SubShapeIDPair_Destroy(_Underlying *_this);
            __JPH_SubShapeIDPair_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SubShapeIDPair() {Dispose(false);}

        internal unsafe Const_SubShapeIDPair(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SubShapeIDPair() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeIDPair._Underlying *__JPH_SubShapeIDPair_DefaultConstruct();
            _UnderlyingPtr = __JPH_SubShapeIDPair_DefaultConstruct();
        }

        /// Generated from constructor `JPH::SubShapeIDPair::SubShapeIDPair`.
        public unsafe Const_SubShapeIDPair(JPH.Const_SubShapeIDPair _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeIDPair._Underlying *__JPH_SubShapeIDPair_ConstructFromAnother(JPH.SubShapeIDPair._Underlying *_other);
            _UnderlyingPtr = __JPH_SubShapeIDPair_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SubShapeIDPair::SubShapeIDPair`.
        public Const_SubShapeIDPair(SubShapeIDPair _other) : this((Const_SubShapeIDPair)_other) {}

        /// Generated from constructor `JPH::SubShapeIDPair::SubShapeIDPair`.
        public unsafe Const_SubShapeIDPair(in JPH.BodyID inBody1ID, JPH.Const_SubShapeID inSubShapeID1, in JPH.BodyID inBody2ID, JPH.Const_SubShapeID inSubShapeID2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeIDPair._Underlying *__JPH_SubShapeIDPair_Construct(JPH.BodyID *inBody1ID, JPH.Const_SubShapeID._Underlying *inSubShapeID1, JPH.BodyID *inBody2ID, JPH.Const_SubShapeID._Underlying *inSubShapeID2);
            fixed (JPH.BodyID *__ptr_inBody1ID = &inBody1ID)
            {
                fixed (JPH.BodyID *__ptr_inBody2ID = &inBody2ID)
                {
                    _UnderlyingPtr = __JPH_SubShapeIDPair_Construct(__ptr_inBody1ID, inSubShapeID1._UnderlyingPtr, __ptr_inBody2ID, inSubShapeID2._UnderlyingPtr);
                }
            }
        }

        /// Generated from method `JPH::SubShapeIDPair::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SubShapeIDPair_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SubShapeIDPair_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SubShapeIDPair_size_t(ulong inCount);
            return __Jolt_new_JPH_SubShapeIDPair_size_t(inCount);
        }

        /// Generated from method `JPH::SubShapeIDPair::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeIDPair_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeIDPair_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SubShapeIDPair_void_ptr(void *inPointer);
            __Jolt_delete_JPH_SubShapeIDPair_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SubShapeIDPair::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeIDPair_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeIDPair_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SubShapeIDPair_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_SubShapeIDPair_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SubShapeIDPair::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SubShapeIDPair_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SubShapeIDPair_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SubShapeIDPair_size_t(ulong inCount);
            return __Jolt_new_array_JPH_SubShapeIDPair_size_t(inCount);
        }

        /// Generated from method `JPH::SubShapeIDPair::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeIDPair_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeIDPair_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SubShapeIDPair_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_SubShapeIDPair_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SubShapeIDPair::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SubShapeIDPair::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SubShapeIDPair_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SubShapeIDPair_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SubShapeIDPair_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_SubShapeIDPair_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SubShapeIDPair::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeIDPair_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SubShapeIDPair_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SubShapeIDPair_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_SubShapeIDPair_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SubShapeIDPair::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SubShapeIDPair_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SubShapeIDPair_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SubShapeIDPair_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_SubShapeIDPair_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SubShapeIDPair::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Equality operator
        /// Generated from method `JPH::SubShapeIDPair::operator==`.
        public static unsafe bool operator==(JPH.Const_SubShapeIDPair _this, JPH.Const_SubShapeIDPair inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_SubShapeIDPair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_SubShapeIDPair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_SubShapeIDPair(JPH.Const_SubShapeIDPair._Underlying *_this, JPH.Const_SubShapeIDPair._Underlying *inRHS);
            return __Jolt_equal_JPH_SubShapeIDPair(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_SubShapeIDPair _this, JPH.Const_SubShapeIDPair inRHS)
        {
            return !(_this == inRHS);
        }

        /// Less than operator, used to consistently order contact points for a deterministic simulation
        /// Generated from method `JPH::SubShapeIDPair::operator<`.
        public static unsafe bool operator<(JPH.Const_SubShapeIDPair _this, JPH.Const_SubShapeIDPair inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_less_JPH_SubShapeIDPair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_less_JPH_SubShapeIDPair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_less_JPH_SubShapeIDPair(JPH.Const_SubShapeIDPair._Underlying *_this, JPH.Const_SubShapeIDPair._Underlying *inRHS);
            return __Jolt_less_JPH_SubShapeIDPair(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator>(JPH.Const_SubShapeIDPair _this, JPH.Const_SubShapeIDPair inRHS)
        {
            return inRHS < _this;
        }

        public static unsafe bool operator<=(JPH.Const_SubShapeIDPair _this, JPH.Const_SubShapeIDPair inRHS)
        {
            return !(inRHS < _this);
        }

        public static unsafe bool operator>=(JPH.Const_SubShapeIDPair _this, JPH.Const_SubShapeIDPair inRHS)
        {
            return !(_this < inRHS);
        }

        /// Generated from method `JPH::SubShapeIDPair::GetBody1ID`.
        public unsafe ref readonly JPH.BodyID GetBody1ID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_GetBody1ID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_GetBody1ID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__JPH_SubShapeIDPair_GetBody1ID(_Underlying *_this);
            return ref *__JPH_SubShapeIDPair_GetBody1ID(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SubShapeIDPair::GetSubShapeID1`.
        public unsafe JPH.Const_SubShapeID GetSubShapeID1()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_GetSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_GetSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SubShapeID._Underlying *__JPH_SubShapeIDPair_GetSubShapeID1(_Underlying *_this);
            return new(__JPH_SubShapeIDPair_GetSubShapeID1(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SubShapeIDPair::GetBody2ID`.
        public unsafe ref readonly JPH.BodyID GetBody2ID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_GetBody2ID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_GetBody2ID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__JPH_SubShapeIDPair_GetBody2ID(_Underlying *_this);
            return ref *__JPH_SubShapeIDPair_GetBody2ID(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SubShapeIDPair::GetSubShapeID2`.
        public unsafe JPH.Const_SubShapeID GetSubShapeID2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_GetSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_GetSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SubShapeID._Underlying *__JPH_SubShapeIDPair_GetSubShapeID2(_Underlying *_this);
            return new(__JPH_SubShapeIDPair_GetSubShapeID2(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SubShapeIDPair::GetHash`.
        public unsafe ulong GetHash()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_GetHash", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_GetHash", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_SubShapeIDPair_GetHash(_Underlying *_this);
            return __JPH_SubShapeIDPair_GetHash(_UnderlyingPtr);
        }

        // IEquatable:

        public bool Equals(JPH.Const_SubShapeIDPair? inRHS)
        {
            if (inRHS is null)
                return false;
            return this == inRHS;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_SubShapeIDPair)
                return this == (JPH.Const_SubShapeIDPair)other;
            return false;
        }
    }

    /// A pair of bodies and their sub shape ID's. Can be used as a key in a map to find a contact point.
    /// Generated from class `JPH::SubShapeIDPair`.
    /// This is the non-const half of the class.
    public class SubShapeIDPair : Const_SubShapeIDPair
    {
        internal unsafe SubShapeIDPair(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SubShapeIDPair() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeIDPair._Underlying *__JPH_SubShapeIDPair_DefaultConstruct();
            _UnderlyingPtr = __JPH_SubShapeIDPair_DefaultConstruct();
        }

        /// Generated from constructor `JPH::SubShapeIDPair::SubShapeIDPair`.
        public unsafe SubShapeIDPair(JPH.Const_SubShapeIDPair _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeIDPair._Underlying *__JPH_SubShapeIDPair_ConstructFromAnother(JPH.SubShapeIDPair._Underlying *_other);
            _UnderlyingPtr = __JPH_SubShapeIDPair_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SubShapeIDPair::SubShapeIDPair`.
        public SubShapeIDPair(SubShapeIDPair _other) : this((Const_SubShapeIDPair)_other) {}

        /// Generated from constructor `JPH::SubShapeIDPair::SubShapeIDPair`.
        public unsafe SubShapeIDPair(in JPH.BodyID inBody1ID, JPH.Const_SubShapeID inSubShapeID1, in JPH.BodyID inBody2ID, JPH.Const_SubShapeID inSubShapeID2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeIDPair._Underlying *__JPH_SubShapeIDPair_Construct(JPH.BodyID *inBody1ID, JPH.Const_SubShapeID._Underlying *inSubShapeID1, JPH.BodyID *inBody2ID, JPH.Const_SubShapeID._Underlying *inSubShapeID2);
            fixed (JPH.BodyID *__ptr_inBody1ID = &inBody1ID)
            {
                fixed (JPH.BodyID *__ptr_inBody2ID = &inBody2ID)
                {
                    _UnderlyingPtr = __JPH_SubShapeIDPair_Construct(__ptr_inBody1ID, inSubShapeID1._UnderlyingPtr, __ptr_inBody2ID, inSubShapeID2._UnderlyingPtr);
                }
            }
        }

        /// Generated from method `JPH::SubShapeIDPair::operator=`.
        public unsafe JPH.SubShapeIDPair Assign(JPH.Const_SubShapeIDPair _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SubShapeIDPair_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SubShapeIDPair_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeIDPair._Underlying *__JPH_SubShapeIDPair_AssignFromAnother(_Underlying *_this, JPH.SubShapeIDPair._Underlying *_other);
            JPH.SubShapeIDPair __ret;
            __ret = new(__JPH_SubShapeIDPair_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used for optional parameters of class `SubShapeIDPair` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SubShapeIDPair`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SubShapeIDPair`/`Const_SubShapeIDPair` directly.
    public class _InOptMut_SubShapeIDPair
    {
        public SubShapeIDPair? Opt;

        public _InOptMut_SubShapeIDPair() {}
        public _InOptMut_SubShapeIDPair(SubShapeIDPair value) {Opt = value;}
        public static implicit operator _InOptMut_SubShapeIDPair(SubShapeIDPair value) {return new(value);}
    }

    /// This is used for optional parameters of class `SubShapeIDPair` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SubShapeIDPair`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SubShapeIDPair`/`Const_SubShapeIDPair` to pass it to the function.
    public class _InOptConst_SubShapeIDPair
    {
        public Const_SubShapeIDPair? Opt;

        public _InOptConst_SubShapeIDPair() {}
        public _InOptConst_SubShapeIDPair(Const_SubShapeIDPair value) {Opt = value;}
        public static implicit operator _InOptConst_SubShapeIDPair(Const_SubShapeIDPair value) {return new(value);}
    }
}
