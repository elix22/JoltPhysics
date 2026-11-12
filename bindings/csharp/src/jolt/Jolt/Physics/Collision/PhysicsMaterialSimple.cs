// machine generated, do not edit
public static partial class JPH
{
    /// Sample implementation of PhysicsMaterial that just holds the needed properties directly
    /// Generated from class `JPH::PhysicsMaterialSimple`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PhysicsMaterial`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::PhysicsMaterial>`
    /// This is the const half of the class.
    public class Const_PhysicsMaterialSimple : JPH.Object<Const_PhysicsMaterialSimple>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PhysicsMaterial_Release(void *_this);
            __JPH_RefTarget_JPH_PhysicsMaterial_Release(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PhysicsMaterialSimple() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_PhysicsMaterialSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHPhysicsMaterial(Const_PhysicsMaterialSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHPhysicsMaterial._Underlying *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_Underlying *_this);
            JPH.Const_RefTarget_JPHPhysicsMaterial ret = new(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_PhysicsMaterial(Const_PhysicsMaterialSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial(_Underlying *_this);
            JPH.Const_PhysicsMaterial ret = new(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_PhysicsMaterialSimple(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_PhysicsMaterialSimple ret = new(__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_PhysicsMaterialSimple(JPH.Const_RefTarget_JPHPhysicsMaterial parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(JPH.Const_RefTarget_JPHPhysicsMaterial._Underlying *_this);
            Const_PhysicsMaterialSimple ret = new(__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_PhysicsMaterialSimple(JPH.Const_PhysicsMaterial parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial(JPH.Const_PhysicsMaterial._Underlying *_this);
            Const_PhysicsMaterialSimple ret = new(__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_PhysicsMaterialSimple(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_PhysicsMaterialSimple() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsMaterialSimple._Underlying *__JPH_PhysicsMaterialSimple_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsMaterialSimple_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(void *_this);
            __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::PhysicsMaterialSimple::PhysicsMaterialSimple`.
        public unsafe Const_PhysicsMaterialSimple(JPH._ByValue_PhysicsMaterialSimple _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsMaterialSimple._Underlying *__JPH_PhysicsMaterialSimple_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.PhysicsMaterialSimple._Underlying *_other);
            _UnderlyingPtr = __JPH_PhysicsMaterialSimple_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(void *_this);
            __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::PhysicsMaterialSimple::PhysicsMaterialSimple`.
        public Const_PhysicsMaterialSimple(Const_PhysicsMaterialSimple _other) : this(new _ByValue_PhysicsMaterialSimple(_other)) {}

        /// Generated from constructor `JPH::PhysicsMaterialSimple::PhysicsMaterialSimple`.
        public Const_PhysicsMaterialSimple(PhysicsMaterialSimple _other) : this((Const_PhysicsMaterialSimple)_other) {}

        /// Generated from method `JPH::PhysicsMaterialSimple::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PhysicsMaterialSimple_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PhysicsMaterialSimple_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PhysicsMaterialSimple_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_PhysicsMaterialSimple_size_t(inCount);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr(void *inPointer);
            __Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsMaterialSimple_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsMaterialSimple_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PhysicsMaterialSimple_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_PhysicsMaterialSimple_size_t(inCount);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PhysicsMaterialSimple_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PhysicsMaterialSimple_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PhysicsMaterialSimple_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_PhysicsMaterialSimple_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsMaterialSimple_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsMaterialSimple_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PhysicsMaterialSimple_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_PhysicsMaterialSimple_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_void_ptr(inPointer, inPlace);
        }

        // Properties
        /// Generated from method `JPH::PhysicsMaterialSimple::GetDebugName`.
        public unsafe byte? GetDebugName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_GetDebugName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_GetDebugName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__JPH_PhysicsMaterialSimple_GetDebugName(_Underlying *_this);
            var __c_ret = __JPH_PhysicsMaterialSimple_GetDebugName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::GetDebugColor`.
        public unsafe JPH.Color GetDebugColor()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_GetDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_GetDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_PhysicsMaterialSimple_GetDebugColor(_Underlying *_this);
            return new(__JPH_PhysicsMaterialSimple_GetDebugColor(_UnderlyingPtr), is_owning: true);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::PhysicsMaterialSimple::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsMaterialSimple_SetEmbedded(_Underlying *_this);
            __JPH_PhysicsMaterialSimple_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::PhysicsMaterialSimple::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PhysicsMaterialSimple_GetRefCount(_Underlying *_this);
            return __JPH_PhysicsMaterialSimple_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::PhysicsMaterialSimple::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsMaterialSimple_AddRef(_Underlying *_this);
            __JPH_PhysicsMaterialSimple_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PhysicsMaterialSimple::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsMaterialSimple_Release(_Underlying *_this);
            __JPH_PhysicsMaterialSimple_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::PhysicsMaterialSimple::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_PhysicsMaterialSimple_sInternalGetRefCountOffset();
            return __JPH_PhysicsMaterialSimple_sInternalGetRefCountOffset();
        }
    }

    /// Sample implementation of PhysicsMaterial that just holds the needed properties directly
    /// Generated from class `JPH::PhysicsMaterialSimple`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PhysicsMaterial`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::PhysicsMaterial>`
    /// This is the non-const half of the class.
    public class PhysicsMaterialSimple : Const_PhysicsMaterialSimple
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(PhysicsMaterialSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_SerializableObject(PhysicsMaterialSimple self)
            => (JPH.Const_SerializableObject)(JPH.Const_PhysicsMaterialSimple)self;
        public static unsafe implicit operator JPH.RefTarget_JPHPhysicsMaterial(PhysicsMaterialSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPhysicsMaterial._Underlying *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_Underlying *_this);
            JPH.RefTarget_JPHPhysicsMaterial ret = new(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHPhysicsMaterial(PhysicsMaterialSimple self)
            => (JPH.Const_RefTarget_JPHPhysicsMaterial)(JPH.Const_PhysicsMaterialSimple)self;
        public static unsafe implicit operator JPH.PhysicsMaterial(PhysicsMaterialSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsMaterial._Underlying *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial(_Underlying *_this);
            JPH.PhysicsMaterial ret = new(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_PhysicsMaterial(PhysicsMaterialSimple self)
            => (JPH.Const_PhysicsMaterial)(JPH.Const_PhysicsMaterialSimple)self;

        // Downcasts:
        public static unsafe explicit operator PhysicsMaterialSimple(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            PhysicsMaterialSimple ret = new(__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator PhysicsMaterialSimple(JPH.RefTarget_JPHPhysicsMaterial parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(JPH.RefTarget_JPHPhysicsMaterial._Underlying *_this);
            PhysicsMaterialSimple ret = new(__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator PhysicsMaterialSimple(JPH.PhysicsMaterial parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial(JPH.PhysicsMaterial._Underlying *_this);
            PhysicsMaterialSimple ret = new(__JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe PhysicsMaterialSimple(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe PhysicsMaterialSimple() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsMaterialSimple._Underlying *__JPH_PhysicsMaterialSimple_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsMaterialSimple_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(void *_this);
            __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::PhysicsMaterialSimple::PhysicsMaterialSimple`.
        public unsafe PhysicsMaterialSimple(JPH._ByValue_PhysicsMaterialSimple _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsMaterialSimple._Underlying *__JPH_PhysicsMaterialSimple_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.PhysicsMaterialSimple._Underlying *_other);
            _UnderlyingPtr = __JPH_PhysicsMaterialSimple_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(void *_this);
            __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(__JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::PhysicsMaterialSimple::PhysicsMaterialSimple`.
        public PhysicsMaterialSimple(Const_PhysicsMaterialSimple _other) : this(new _ByValue_PhysicsMaterialSimple(_other)) {}

        /// Generated from constructor `JPH::PhysicsMaterialSimple::PhysicsMaterialSimple`.
        public PhysicsMaterialSimple(PhysicsMaterialSimple _other) : this((Const_PhysicsMaterialSimple)_other) {}

        /// Generated from method `JPH::PhysicsMaterialSimple::operator=`.
        public unsafe JPH.PhysicsMaterialSimple Assign(JPH._ByValue_PhysicsMaterialSimple _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterialSimple_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsMaterialSimple._Underlying *__JPH_PhysicsMaterialSimple_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.PhysicsMaterialSimple._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_PhysicsMaterialSimple_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `PhysicsMaterialSimple` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `PhysicsMaterialSimple`/`Const_PhysicsMaterialSimple` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_PhysicsMaterialSimple
    {
        #pragma warning disable CS0649
        internal readonly Const_PhysicsMaterialSimple? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_PhysicsMaterialSimple() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_PhysicsMaterialSimple(Const_PhysicsMaterialSimple new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_PhysicsMaterialSimple(Const_PhysicsMaterialSimple arg) {return new(arg);}
        public _ByValue_PhysicsMaterialSimple(JPH._Moved<PhysicsMaterialSimple> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_PhysicsMaterialSimple(JPH._Moved<PhysicsMaterialSimple> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `PhysicsMaterialSimple` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PhysicsMaterialSimple`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsMaterialSimple`/`Const_PhysicsMaterialSimple` directly.
    public class _InOptMut_PhysicsMaterialSimple
    {
        public PhysicsMaterialSimple? Opt;

        public _InOptMut_PhysicsMaterialSimple() {}
        public _InOptMut_PhysicsMaterialSimple(PhysicsMaterialSimple value) {Opt = value;}
        public static implicit operator _InOptMut_PhysicsMaterialSimple(PhysicsMaterialSimple value) {return new(value);}
    }

    /// This is used for optional parameters of class `PhysicsMaterialSimple` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PhysicsMaterialSimple`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsMaterialSimple`/`Const_PhysicsMaterialSimple` to pass it to the function.
    public class _InOptConst_PhysicsMaterialSimple
    {
        public Const_PhysicsMaterialSimple? Opt;

        public _InOptConst_PhysicsMaterialSimple() {}
        public _InOptConst_PhysicsMaterialSimple(Const_PhysicsMaterialSimple value) {Opt = value;}
        public static implicit operator _InOptConst_PhysicsMaterialSimple(Const_PhysicsMaterialSimple value) {return new(value);}
    }
}
