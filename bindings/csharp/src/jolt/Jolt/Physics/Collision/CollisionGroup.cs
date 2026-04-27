// machine generated, do not edit
public static partial class JPH
{
    /// Two objects collide with each other if:
    /// - Both don't have a group filter
    /// - The first group filter says that the objects can collide
    /// - Or if there's no filter for the first object, the second group filter says the objects can collide
    /// Generated from class `JPH::CollisionGroup`.
    /// This is the const half of the class.
    public class Const_CollisionGroup : JPH.Object<Const_CollisionGroup>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CollisionGroup_Destroy(_Underlying *_this);
            __JPH_CollisionGroup_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CollisionGroup() {Dispose(false);}

        public static unsafe uint CInvalidGroup
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_Get_cInvalidGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_Get_cInvalidGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_CollisionGroup_Get_cInvalidGroup();
                return *__JPH_CollisionGroup_Get_cInvalidGroup();
            }
        }

        public static unsafe uint CInvalidSubGroup
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_Get_cInvalidSubGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_Get_cInvalidSubGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_CollisionGroup_Get_cInvalidSubGroup();
                return *__JPH_CollisionGroup_Get_cInvalidSubGroup();
            }
        }

        /// An invalid collision group
        public static unsafe JPH.Const_CollisionGroup SInvalid
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_Get_sInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_Get_sInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_CollisionGroup._Underlying *__JPH_CollisionGroup_Get_sInvalid();
                return new(__JPH_CollisionGroup_Get_sInvalid(), is_owning: false);
            }
        }

        internal unsafe Const_CollisionGroup(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CollisionGroup() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollisionGroup._Underlying *__JPH_CollisionGroup_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollisionGroup_DefaultConstruct();
        }

        /// Generated from constructor `JPH::CollisionGroup::CollisionGroup`.
        public unsafe Const_CollisionGroup(JPH._ByValue_CollisionGroup _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollisionGroup._Underlying *__JPH_CollisionGroup_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CollisionGroup._Underlying *_other);
            _UnderlyingPtr = __JPH_CollisionGroup_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::CollisionGroup::CollisionGroup`.
        public Const_CollisionGroup(Const_CollisionGroup _other) : this(new _ByValue_CollisionGroup(_other)) {}

        /// Generated from constructor `JPH::CollisionGroup::CollisionGroup`.
        public Const_CollisionGroup(CollisionGroup _other) : this((Const_CollisionGroup)_other) {}

        /// Generated from method `JPH::CollisionGroup::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollisionGroup_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollisionGroup_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollisionGroup_size_t(ulong inCount);
            return __Jolt_new_JPH_CollisionGroup_size_t(inCount);
        }

        /// Generated from method `JPH::CollisionGroup::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollisionGroup_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollisionGroup_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollisionGroup_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CollisionGroup_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollisionGroup::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollisionGroup_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollisionGroup_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollisionGroup_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_CollisionGroup_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollisionGroup::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollisionGroup_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollisionGroup_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollisionGroup_size_t(ulong inCount);
            return __Jolt_new_array_JPH_CollisionGroup_size_t(inCount);
        }

        /// Generated from method `JPH::CollisionGroup::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollisionGroup_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollisionGroup_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollisionGroup_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CollisionGroup_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollisionGroup::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollisionGroup_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollisionGroup_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollisionGroup_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_CollisionGroup_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollisionGroup::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollisionGroup_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollisionGroup_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollisionGroup_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_CollisionGroup_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollisionGroup::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollisionGroup_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollisionGroup_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollisionGroup_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CollisionGroup_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CollisionGroup::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollisionGroup_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollisionGroup_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollisionGroup_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_CollisionGroup_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollisionGroup::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollisionGroup_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollisionGroup_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollisionGroup_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CollisionGroup_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CollisionGroup::GetGroupID`.
        public unsafe uint GetGroupID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_GetGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_GetGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CollisionGroup_GetGroupID(_Underlying *_this);
            return __JPH_CollisionGroup_GetGroupID(_UnderlyingPtr);
        }

        /// Generated from method `JPH::CollisionGroup::GetSubGroupID`.
        public unsafe uint GetSubGroupID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_GetSubGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_GetSubGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CollisionGroup_GetSubGroupID(_Underlying *_this);
            return __JPH_CollisionGroup_GetSubGroupID(_UnderlyingPtr);
        }

        /// Check if this object collides with another object
        /// Generated from method `JPH::CollisionGroup::CanCollide`.
        public unsafe bool CanCollide(JPH.Const_CollisionGroup inOther)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_CanCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_CanCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_CollisionGroup_CanCollide(_Underlying *_this, JPH.Const_CollisionGroup._Underlying *inOther);
            return __JPH_CollisionGroup_CanCollide(_UnderlyingPtr, inOther._UnderlyingPtr) != 0;
        }
    }

    /// Two objects collide with each other if:
    /// - Both don't have a group filter
    /// - The first group filter says that the objects can collide
    /// - Or if there's no filter for the first object, the second group filter says the objects can collide
    /// Generated from class `JPH::CollisionGroup`.
    /// This is the non-const half of the class.
    public class CollisionGroup : Const_CollisionGroup
    {
        internal unsafe CollisionGroup(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CollisionGroup() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollisionGroup._Underlying *__JPH_CollisionGroup_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollisionGroup_DefaultConstruct();
        }

        /// Generated from constructor `JPH::CollisionGroup::CollisionGroup`.
        public unsafe CollisionGroup(JPH._ByValue_CollisionGroup _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollisionGroup._Underlying *__JPH_CollisionGroup_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CollisionGroup._Underlying *_other);
            _UnderlyingPtr = __JPH_CollisionGroup_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::CollisionGroup::CollisionGroup`.
        public CollisionGroup(Const_CollisionGroup _other) : this(new _ByValue_CollisionGroup(_other)) {}

        /// Generated from constructor `JPH::CollisionGroup::CollisionGroup`.
        public CollisionGroup(CollisionGroup _other) : this((Const_CollisionGroup)_other) {}

        /// Generated from method `JPH::CollisionGroup::operator=`.
        public unsafe JPH.CollisionGroup Assign(JPH._ByValue_CollisionGroup _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollisionGroup._Underlying *__JPH_CollisionGroup_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.CollisionGroup._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_CollisionGroup_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Set the main group id for this object
        /// Generated from method `JPH::CollisionGroup::SetGroupID`.
        public unsafe void SetGroupID(uint inID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_SetGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_SetGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CollisionGroup_SetGroupID(_Underlying *_this, uint inID);
            __JPH_CollisionGroup_SetGroupID(_UnderlyingPtr, inID);
        }

        /// Add this object to a sub group
        /// Generated from method `JPH::CollisionGroup::SetSubGroupID`.
        public unsafe void SetSubGroupID(uint inID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollisionGroup_SetSubGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollisionGroup_SetSubGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CollisionGroup_SetSubGroupID(_Underlying *_this, uint inID);
            __JPH_CollisionGroup_SetSubGroupID(_UnderlyingPtr, inID);
        }
    }

    /// This is used as a function parameter when the underlying function receives `CollisionGroup` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `CollisionGroup`/`Const_CollisionGroup` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_CollisionGroup
    {
        #pragma warning disable CS0649
        internal readonly Const_CollisionGroup? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_CollisionGroup() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_CollisionGroup(Const_CollisionGroup new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_CollisionGroup(Const_CollisionGroup arg) {return new(arg);}
        public _ByValue_CollisionGroup(JPH._Moved<CollisionGroup> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_CollisionGroup(JPH._Moved<CollisionGroup> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `CollisionGroup` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CollisionGroup`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollisionGroup`/`Const_CollisionGroup` directly.
    public class _InOptMut_CollisionGroup
    {
        public CollisionGroup? Opt;

        public _InOptMut_CollisionGroup() {}
        public _InOptMut_CollisionGroup(CollisionGroup value) {Opt = value;}
        public static implicit operator _InOptMut_CollisionGroup(CollisionGroup value) {return new(value);}
    }

    /// This is used for optional parameters of class `CollisionGroup` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CollisionGroup`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollisionGroup`/`Const_CollisionGroup` to pass it to the function.
    public class _InOptConst_CollisionGroup
    {
        public Const_CollisionGroup? Opt;

        public _InOptConst_CollisionGroup() {}
        public _InOptConst_CollisionGroup(Const_CollisionGroup value) {Opt = value;}
        public static implicit operator _InOptConst_CollisionGroup(Const_CollisionGroup value) {return new(value);}
    }
}
