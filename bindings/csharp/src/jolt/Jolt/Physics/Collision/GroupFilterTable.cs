// machine generated, do not edit
public static partial class JPH
{
    /// Implementation of GroupFilter that stores a bit table with one bit per sub shape ID pair to determine if they collide or not
    ///
    /// The collision rules:
    /// - If one of the objects is in the cInvalidGroup the objects will collide.
    /// - If the objects are in different groups they will collide.
    /// - If they're in the same group but their collision filter is different they will not collide.
    /// - If they're in the same group and their collision filters match, we'll use the SubGroupID and the table below.
    ///
    /// For N = 6 sub groups the table will look like:
    ///
    ///		            sub group 1 --->
    ///		sub group 2 x.....
    ///		     |      ox....
    ///		     |      oox...
    ///		     V      ooox..
    ///		            oooox.
    ///		            ooooox
    ///
    /// * 'x' means sub group 1 == sub group 2 and we define this to never collide.
    /// * 'o' is a bit that we have to store that defines if the sub groups collide or not.
    /// * '.' is a bit we don't need to store because the table is symmetric, we take care that group 2 > group 1 by swapping sub group 1 and sub group 2 if needed.
    ///
    /// The total number of bits we need to store is (N * (N - 1)) / 2
    /// Generated from class `JPH::GroupFilterTable`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::GroupFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::GroupFilter>`
    /// This is the const half of the class.
    public class Const_GroupFilterTable : JPH.Object<Const_GroupFilterTable>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_Release(void *_this);
            __JPH_RefTarget_JPH_GroupFilter_Release(__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_GroupFilterTable() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_GroupFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHGroupFilter(Const_GroupFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHGroupFilter._Underlying *__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            JPH.Const_RefTarget_JPHGroupFilter ret = new(__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_GroupFilter(Const_GroupFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_GroupFilter._Underlying *__JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter(_Underlying *_this);
            JPH.Const_GroupFilter ret = new(__JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_GroupFilterTable(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_GroupFilterTable ret = new(__JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_GroupFilterTable(JPH.Const_RefTarget_JPHGroupFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(JPH.Const_RefTarget_JPHGroupFilter._Underlying *_this);
            Const_GroupFilterTable ret = new(__JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_GroupFilterTable(JPH.Const_GroupFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter(JPH.Const_GroupFilter._Underlying *_this);
            Const_GroupFilterTable ret = new(__JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_GroupFilterTable(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs the table with inNumSubGroups subgroups, initially all collision pairs are enabled except when the sub group ID is the same
        /// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
        /// Parameter `inNumSubGroups` defaults to `0`.
        public unsafe Const_GroupFilterTable(uint? inNumSubGroups = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.GroupFilterTable._Underlying *__JPH_GroupFilterTable_Construct(uint *inNumSubGroups);
            uint __deref_inNumSubGroups = inNumSubGroups.GetValueOrDefault();
            _UnderlyingPtr = __JPH_GroupFilterTable_Construct(inNumSubGroups.HasValue ? &__deref_inNumSubGroups : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_AddRef(void *_this);
            __JPH_RefTarget_JPH_GroupFilter_AddRef(__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_UnderlyingPtr));
        }

        /// Copy constructor
        /// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
        public unsafe Const_GroupFilterTable(JPH._ByValue_GroupFilterTable inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.GroupFilterTable._Underlying *__JPH_GroupFilterTable_ConstructFromAnother(JPH._PassBy inRHS_pass_by, JPH.GroupFilterTable._Underlying *inRHS);
            _UnderlyingPtr = __JPH_GroupFilterTable_ConstructFromAnother(inRHS.PassByMode, inRHS.Value is not null ? inRHS.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_AddRef(void *_this);
            __JPH_RefTarget_JPH_GroupFilter_AddRef(__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_UnderlyingPtr));
            if (inRHS.Value is not null) _KeepAlive(inRHS.Value);
        }

        /// Copy constructor
        /// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
        public Const_GroupFilterTable(Const_GroupFilterTable inRHS) : this(new _ByValue_GroupFilterTable(inRHS)) {}

        /// Copy constructor
        /// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
        public Const_GroupFilterTable(GroupFilterTable inRHS) : this((Const_GroupFilterTable)inRHS) {}

        /// Generated from method `JPH::GroupFilterTable::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_GroupFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_GroupFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_GroupFilterTable_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_GroupFilterTable_size_t(inCount);
        }

        /// Generated from method `JPH::GroupFilterTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_GroupFilterTable_void_ptr(void *inPointer);
            __Jolt_delete_JPH_GroupFilterTable_void_ptr(inPointer);
        }

        /// Generated from method `JPH::GroupFilterTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_GroupFilterTable_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_GroupFilterTable_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::GroupFilterTable::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_GroupFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_GroupFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_GroupFilterTable_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_GroupFilterTable_size_t(inCount);
        }

        /// Generated from method `JPH::GroupFilterTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_GroupFilterTable_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_GroupFilterTable_void_ptr(inPointer);
        }

        /// Generated from method `JPH::GroupFilterTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_GroupFilterTable_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_GroupFilterTable_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::GroupFilterTable::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_GroupFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_GroupFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_GroupFilterTable_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_GroupFilterTable_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::GroupFilterTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_GroupFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_GroupFilterTable_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::GroupFilterTable::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_GroupFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_GroupFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_GroupFilterTable_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_GroupFilterTable_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::GroupFilterTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_GroupFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_GroupFilterTable_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Checks if two CollisionGroups collide
        /// Generated from method `JPH::GroupFilterTable::CanCollide`.
        public unsafe bool CanCollide(JPH.Const_CollisionGroup inGroup1, JPH.Const_CollisionGroup inGroup2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_CanCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_CanCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_GroupFilterTable_CanCollide(_Underlying *_this, JPH.Const_CollisionGroup._Underlying *inGroup1, JPH.Const_CollisionGroup._Underlying *inGroup2);
            return __JPH_GroupFilterTable_CanCollide(_UnderlyingPtr, inGroup1._UnderlyingPtr, inGroup2._UnderlyingPtr) != 0;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::GroupFilterTable::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_GroupFilterTable_SetEmbedded(_Underlying *_this);
            __JPH_GroupFilterTable_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::GroupFilterTable::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_GroupFilterTable_GetRefCount(_Underlying *_this);
            return __JPH_GroupFilterTable_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::GroupFilterTable::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_GroupFilterTable_AddRef(_Underlying *_this);
            __JPH_GroupFilterTable_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::GroupFilterTable::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_GroupFilterTable_Release(_Underlying *_this);
            __JPH_GroupFilterTable_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::GroupFilterTable::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_GroupFilterTable_sInternalGetRefCountOffset();
            return __JPH_GroupFilterTable_sInternalGetRefCountOffset();
        }
    }

    /// Implementation of GroupFilter that stores a bit table with one bit per sub shape ID pair to determine if they collide or not
    ///
    /// The collision rules:
    /// - If one of the objects is in the cInvalidGroup the objects will collide.
    /// - If the objects are in different groups they will collide.
    /// - If they're in the same group but their collision filter is different they will not collide.
    /// - If they're in the same group and their collision filters match, we'll use the SubGroupID and the table below.
    ///
    /// For N = 6 sub groups the table will look like:
    ///
    ///		            sub group 1 --->
    ///		sub group 2 x.....
    ///		     |      ox....
    ///		     |      oox...
    ///		     V      ooox..
    ///		            oooox.
    ///		            ooooox
    ///
    /// * 'x' means sub group 1 == sub group 2 and we define this to never collide.
    /// * 'o' is a bit that we have to store that defines if the sub groups collide or not.
    /// * '.' is a bit we don't need to store because the table is symmetric, we take care that group 2 > group 1 by swapping sub group 1 and sub group 2 if needed.
    ///
    /// The total number of bits we need to store is (N * (N - 1)) / 2
    /// Generated from class `JPH::GroupFilterTable`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::GroupFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::GroupFilter>`
    /// This is the non-const half of the class.
    public class GroupFilterTable : Const_GroupFilterTable
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(GroupFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_SerializableObject(GroupFilterTable self)
            => (JPH.Const_SerializableObject)(JPH.Const_GroupFilterTable)self;
        public static unsafe implicit operator JPH.RefTarget_JPHGroupFilter(GroupFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHGroupFilter._Underlying *__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            JPH.RefTarget_JPHGroupFilter ret = new(__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHGroupFilter(GroupFilterTable self)
            => (JPH.Const_RefTarget_JPHGroupFilter)(JPH.Const_GroupFilterTable)self;
        public static unsafe implicit operator JPH.GroupFilter(GroupFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.GroupFilter._Underlying *__JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter(_Underlying *_this);
            JPH.GroupFilter ret = new(__JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_GroupFilter(GroupFilterTable self)
            => (JPH.Const_GroupFilter)(JPH.Const_GroupFilterTable)self;

        // Downcasts:
        public static unsafe explicit operator GroupFilterTable(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            GroupFilterTable ret = new(__JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator GroupFilterTable(JPH.RefTarget_JPHGroupFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(JPH.RefTarget_JPHGroupFilter._Underlying *_this);
            GroupFilterTable ret = new(__JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator GroupFilterTable(JPH.GroupFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter(JPH.GroupFilter._Underlying *_this);
            GroupFilterTable ret = new(__JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe GroupFilterTable(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs the table with inNumSubGroups subgroups, initially all collision pairs are enabled except when the sub group ID is the same
        /// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
        /// Parameter `inNumSubGroups` defaults to `0`.
        public unsafe GroupFilterTable(uint? inNumSubGroups = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.GroupFilterTable._Underlying *__JPH_GroupFilterTable_Construct(uint *inNumSubGroups);
            uint __deref_inNumSubGroups = inNumSubGroups.GetValueOrDefault();
            _UnderlyingPtr = __JPH_GroupFilterTable_Construct(inNumSubGroups.HasValue ? &__deref_inNumSubGroups : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_AddRef(void *_this);
            __JPH_RefTarget_JPH_GroupFilter_AddRef(__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_UnderlyingPtr));
        }

        /// Copy constructor
        /// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
        public unsafe GroupFilterTable(JPH._ByValue_GroupFilterTable inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.GroupFilterTable._Underlying *__JPH_GroupFilterTable_ConstructFromAnother(JPH._PassBy inRHS_pass_by, JPH.GroupFilterTable._Underlying *inRHS);
            _UnderlyingPtr = __JPH_GroupFilterTable_ConstructFromAnother(inRHS.PassByMode, inRHS.Value is not null ? inRHS.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_AddRef(void *_this);
            __JPH_RefTarget_JPH_GroupFilter_AddRef(__JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_UnderlyingPtr));
            if (inRHS.Value is not null) _KeepAlive(inRHS.Value);
        }

        /// Copy constructor
        /// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
        public GroupFilterTable(Const_GroupFilterTable inRHS) : this(new _ByValue_GroupFilterTable(inRHS)) {}

        /// Copy constructor
        /// Generated from constructor `JPH::GroupFilterTable::GroupFilterTable`.
        public GroupFilterTable(GroupFilterTable inRHS) : this((Const_GroupFilterTable)inRHS) {}

        /// Generated from method `JPH::GroupFilterTable::operator=`.
        public unsafe JPH.GroupFilterTable Assign(JPH._ByValue_GroupFilterTable _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilterTable_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilterTable_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.GroupFilterTable._Underlying *__JPH_GroupFilterTable_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.GroupFilterTable._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_GroupFilterTable_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `GroupFilterTable` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `GroupFilterTable`/`Const_GroupFilterTable` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_GroupFilterTable
    {
        #pragma warning disable CS0649
        internal readonly Const_GroupFilterTable? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_GroupFilterTable() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_GroupFilterTable(Const_GroupFilterTable new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_GroupFilterTable(Const_GroupFilterTable arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `GroupFilterTable` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_GroupFilterTable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `GroupFilterTable`/`Const_GroupFilterTable` directly.
    public class _InOptMut_GroupFilterTable
    {
        public GroupFilterTable? Opt;

        public _InOptMut_GroupFilterTable() {}
        public _InOptMut_GroupFilterTable(GroupFilterTable value) {Opt = value;}
        public static implicit operator _InOptMut_GroupFilterTable(GroupFilterTable value) {return new(value);}
    }

    /// This is used for optional parameters of class `GroupFilterTable` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_GroupFilterTable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `GroupFilterTable`/`Const_GroupFilterTable` to pass it to the function.
    public class _InOptConst_GroupFilterTable
    {
        public Const_GroupFilterTable? Opt;

        public _InOptConst_GroupFilterTable() {}
        public _InOptConst_GroupFilterTable(Const_GroupFilterTable value) {Opt = value;}
        public static implicit operator _InOptConst_GroupFilterTable(Const_GroupFilterTable value) {return new(value);}
    }
}
