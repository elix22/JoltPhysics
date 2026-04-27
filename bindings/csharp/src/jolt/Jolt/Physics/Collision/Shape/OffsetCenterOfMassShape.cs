// machine generated, do not edit
public static partial class JPH
{
    /// Class that constructs an OffsetCenterOfMassShape
    /// Generated from class `JPH::OffsetCenterOfMassShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DecoratedShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the const half of the class.
    public class Const_OffsetCenterOfMassShapeSettings : JPH.Object<Const_OffsetCenterOfMassShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShapeSettings_Destroy(_Underlying *_this);
            __JPH_OffsetCenterOfMassShapeSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_OffsetCenterOfMassShapeSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_OffsetCenterOfMassShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(Const_OffsetCenterOfMassShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeSettings(Const_OffsetCenterOfMassShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_ShapeSettings ret = new(__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_DecoratedShapeSettings(Const_OffsetCenterOfMassShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_DecoratedShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(_Underlying *_this);
            JPH.Const_DecoratedShapeSettings ret = new(__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_OffsetCenterOfMassShapeSettings?(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_OffsetCenterOfMassShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_OffsetCenterOfMassShapeSettings?(JPH.Const_ShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(JPH.Const_ShapeSettings._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_OffsetCenterOfMassShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_OffsetCenterOfMassShapeSettings?(JPH.Const_DecoratedShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings(JPH.Const_DecoratedShapeSettings._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_OffsetCenterOfMassShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Offset to be applied to the center of mass of the child shape
        public unsafe JPH.Const_Vec3 mOffset
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Get_mOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Get_mOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_OffsetCenterOfMassShapeSettings_Get_mOffset(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_OffsetCenterOfMassShapeSettings_Get_mOffset(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// User data (to be used freely by the application)
        public unsafe ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_OffsetCenterOfMassShapeSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_OffsetCenterOfMassShapeSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_OffsetCenterOfMassShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_OffsetCenterOfMassShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public unsafe Const_OffsetCenterOfMassShapeSettings(JPH._ByValue_OffsetCenterOfMassShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.OffsetCenterOfMassShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public Const_OffsetCenterOfMassShapeSettings(Const_OffsetCenterOfMassShapeSettings _other) : this(new _ByValue_OffsetCenterOfMassShapeSettings(_other)) {}

        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public Const_OffsetCenterOfMassShapeSettings(OffsetCenterOfMassShapeSettings _other) : this((Const_OffsetCenterOfMassShapeSettings)_other) {}

        /// Construct with shape settings, can be serialized.
        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public unsafe Const_OffsetCenterOfMassShapeSettings(JPH.Const_Vec3 inOffset, JPH.Const_ShapeSettings? inShape) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr(JPH.Vec3._Underlying *inOffset, JPH.Const_ShapeSettings._Underlying *inShape);
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr(inOffset._UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
        }

        /// Variant that uses a concrete shape, which means this object cannot be serialized.
        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public unsafe Const_OffsetCenterOfMassShapeSettings(JPH.Const_Vec3 inOffset, JPH.Const_Shape? inShape) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr(JPH.Vec3._Underlying *inOffset, JPH.Const_Shape._Underlying *inShape);
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr(inOffset._UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t(ulong inCount);
            return __Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t(ulong inCount);
            return __Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShapeSettings_SetEmbedded(_Underlying *_this);
            __JPH_OffsetCenterOfMassShapeSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_OffsetCenterOfMassShapeSettings_GetRefCount(_Underlying *_this);
            return __JPH_OffsetCenterOfMassShapeSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShapeSettings_AddRef(_Underlying *_this);
            __JPH_OffsetCenterOfMassShapeSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShapeSettings_Release(_Underlying *_this);
            __JPH_OffsetCenterOfMassShapeSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_OffsetCenterOfMassShapeSettings_sInternalGetRefCountOffset();
            return __JPH_OffsetCenterOfMassShapeSettings_sInternalGetRefCountOffset();
        }
    }

    /// Class that constructs an OffsetCenterOfMassShape
    /// Generated from class `JPH::OffsetCenterOfMassShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DecoratedShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the non-const half of the class.
    public class OffsetCenterOfMassShapeSettings : Const_OffsetCenterOfMassShapeSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(OffsetCenterOfMassShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHShapeSettings(OffsetCenterOfMassShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.RefTarget_JPHShapeSettings ret = new(__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ShapeSettings(OffsetCenterOfMassShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.ShapeSettings ret = new(__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.DecoratedShapeSettings(OffsetCenterOfMassShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DecoratedShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(_Underlying *_this);
            JPH.DecoratedShapeSettings ret = new(__JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator OffsetCenterOfMassShapeSettings?(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
            if (ptr is null) return null;
            OffsetCenterOfMassShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator OffsetCenterOfMassShapeSettings?(JPH.ShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(JPH.ShapeSettings._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
            if (ptr is null) return null;
            OffsetCenterOfMassShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator OffsetCenterOfMassShapeSettings?(JPH.DecoratedShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings(JPH.DecoratedShapeSettings._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings(parent._UnderlyingPtr);
            if (ptr is null) return null;
            OffsetCenterOfMassShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Offset to be applied to the center of mass of the child shape
        public new unsafe JPH.Vec3 mOffset
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_GetMutable_mOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_GetMutable_mOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_OffsetCenterOfMassShapeSettings_GetMutable_mOffset(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_OffsetCenterOfMassShapeSettings_GetMutable_mOffset(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// User data (to be used freely by the application)
        public new unsafe ref ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_OffsetCenterOfMassShapeSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_OffsetCenterOfMassShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe OffsetCenterOfMassShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe OffsetCenterOfMassShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public unsafe OffsetCenterOfMassShapeSettings(JPH._ByValue_OffsetCenterOfMassShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.OffsetCenterOfMassShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public OffsetCenterOfMassShapeSettings(Const_OffsetCenterOfMassShapeSettings _other) : this(new _ByValue_OffsetCenterOfMassShapeSettings(_other)) {}

        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public OffsetCenterOfMassShapeSettings(OffsetCenterOfMassShapeSettings _other) : this((Const_OffsetCenterOfMassShapeSettings)_other) {}

        /// Construct with shape settings, can be serialized.
        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public unsafe OffsetCenterOfMassShapeSettings(JPH.Const_Vec3 inOffset, JPH.Const_ShapeSettings? inShape) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr(JPH.Vec3._Underlying *inOffset, JPH.Const_ShapeSettings._Underlying *inShape);
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr(inOffset._UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
        }

        /// Variant that uses a concrete shape, which means this object cannot be serialized.
        /// Generated from constructor `JPH::OffsetCenterOfMassShapeSettings::OffsetCenterOfMassShapeSettings`.
        public unsafe OffsetCenterOfMassShapeSettings(JPH.Const_Vec3 inOffset, JPH.Const_Shape? inShape) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr(JPH.Vec3._Underlying *inOffset, JPH.Const_Shape._Underlying *inShape);
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr(inOffset._UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::operator=`.
        public unsafe JPH.OffsetCenterOfMassShapeSettings Assign(JPH._ByValue_OffsetCenterOfMassShapeSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShapeSettings._Underlying *__JPH_OffsetCenterOfMassShapeSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.OffsetCenterOfMassShapeSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_OffsetCenterOfMassShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
        /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
        /// Generated from method `JPH::OffsetCenterOfMassShapeSettings::ClearCachedResult`.
        public unsafe void ClearCachedResult()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShapeSettings_ClearCachedResult(_Underlying *_this);
            __JPH_OffsetCenterOfMassShapeSettings_ClearCachedResult(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `OffsetCenterOfMassShapeSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `OffsetCenterOfMassShapeSettings`/`Const_OffsetCenterOfMassShapeSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_OffsetCenterOfMassShapeSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_OffsetCenterOfMassShapeSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_OffsetCenterOfMassShapeSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_OffsetCenterOfMassShapeSettings(Const_OffsetCenterOfMassShapeSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_OffsetCenterOfMassShapeSettings(Const_OffsetCenterOfMassShapeSettings arg) {return new(arg);}
        public _ByValue_OffsetCenterOfMassShapeSettings(JPH._Moved<OffsetCenterOfMassShapeSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_OffsetCenterOfMassShapeSettings(JPH._Moved<OffsetCenterOfMassShapeSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `OffsetCenterOfMassShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_OffsetCenterOfMassShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `OffsetCenterOfMassShapeSettings`/`Const_OffsetCenterOfMassShapeSettings` directly.
    public class _InOptMut_OffsetCenterOfMassShapeSettings
    {
        public OffsetCenterOfMassShapeSettings? Opt;

        public _InOptMut_OffsetCenterOfMassShapeSettings() {}
        public _InOptMut_OffsetCenterOfMassShapeSettings(OffsetCenterOfMassShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_OffsetCenterOfMassShapeSettings(OffsetCenterOfMassShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `OffsetCenterOfMassShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_OffsetCenterOfMassShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `OffsetCenterOfMassShapeSettings`/`Const_OffsetCenterOfMassShapeSettings` to pass it to the function.
    public class _InOptConst_OffsetCenterOfMassShapeSettings
    {
        public Const_OffsetCenterOfMassShapeSettings? Opt;

        public _InOptConst_OffsetCenterOfMassShapeSettings() {}
        public _InOptConst_OffsetCenterOfMassShapeSettings(Const_OffsetCenterOfMassShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_OffsetCenterOfMassShapeSettings(Const_OffsetCenterOfMassShapeSettings value) {return new(value);}
    }

    /// This shape will shift the center of mass of a child shape, it can e.g. be used to lower the center of mass of an unstable object like a boat to make it stable
    /// Generated from class `JPH::OffsetCenterOfMassShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DecoratedShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the const half of the class.
    public class Const_OffsetCenterOfMassShape : JPH.Object<Const_OffsetCenterOfMassShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShape_Destroy(_Underlying *_this);
            __JPH_OffsetCenterOfMassShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_OffsetCenterOfMassShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(Const_OffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShape._Underlying *__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.Const_RefTarget_JPHShape ret = new(__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_OffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Shape(Const_OffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Const_Shape ret = new(__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_DecoratedShape(Const_OffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_DecoratedShape._Underlying *__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape(_Underlying *_this);
            JPH.Const_DecoratedShape ret = new(__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_OffsetCenterOfMassShape?(JPH.Const_Shape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_Shape(JPH.Const_Shape._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_OffsetCenterOfMassShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_OffsetCenterOfMassShape?(JPH.Const_DecoratedShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_DecoratedShape(JPH.Const_DecoratedShape._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_DecoratedShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_OffsetCenterOfMassShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
        public static unsafe int CGetTrianglesMinTrianglesRequested
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_OffsetCenterOfMassShape_Get_cGetTrianglesMinTrianglesRequested();
                return *__JPH_OffsetCenterOfMassShape_Get_cGetTrianglesMinTrianglesRequested();
            }
        }

        internal unsafe Const_OffsetCenterOfMassShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_OffsetCenterOfMassShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShape._Underlying *__JPH_OffsetCenterOfMassShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShape_DefaultConstruct();
        }

        /// Generated from constructor `JPH::OffsetCenterOfMassShape::OffsetCenterOfMassShape`.
        public unsafe Const_OffsetCenterOfMassShape(JPH.Const_Shape? inShape, JPH.Const_Vec3 inOffset) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShape._Underlying *__JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inOffset);
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr(inShape is not null ? inShape._UnderlyingPtr : null, inOffset._UnderlyingPtr);
        }

        /// Get world space bounds including convex radius.
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_DMat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_DMat44(_Underlying *_this, JPH.Const_DMat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_DMat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_OffsetCenterOfMassShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_OffsetCenterOfMassShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_OffsetCenterOfMassShape_size_t(ulong inCount);
            return __Jolt_new_JPH_OffsetCenterOfMassShape_size_t(inCount);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr(void *inPointer);
            __Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t(ulong inCount);
            return __Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t(inCount);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_OffsetCenterOfMassShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_OffsetCenterOfMassShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_OffsetCenterOfMassShape_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_OffsetCenterOfMassShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Access the offset that is applied to the center of mass
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetOffset`.
        public unsafe JPH.Vec3 GetOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_OffsetCenterOfMassShape_GetOffset(_Underlying *_this);
            return new(__JPH_OffsetCenterOfMassShape_GetOffset(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetCenterOfMass
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetCenterOfMass`.
        public unsafe JPH.Vec3 GetCenterOfMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_OffsetCenterOfMassShape_GetCenterOfMass(_Underlying *_this);
            return new(__JPH_OffsetCenterOfMassShape_GetCenterOfMass(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetLocalBounds
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetLocalBounds`.
        public unsafe JPH.AABox GetLocalBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_OffsetCenterOfMassShape_GetLocalBounds(_Underlying *_this);
            return new(__JPH_OffsetCenterOfMassShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetWorldSpaceBounds
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_Mat44(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_Mat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetInnerRadius
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetInnerRadius`.
        public unsafe float GetInnerRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_OffsetCenterOfMassShape_GetInnerRadius(_Underlying *_this);
            return __JPH_OffsetCenterOfMassShape_GetInnerRadius(_UnderlyingPtr);
        }

        // See Shape::GetSurfaceNormal
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetSurfaceNormal`.
        public unsafe JPH.Vec3 GetSurfaceNormal(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inLocalSurfacePosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_OffsetCenterOfMassShape_GetSurfaceNormal(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inLocalSurfacePosition);
            return new(__JPH_OffsetCenterOfMassShape_GetSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inLocalSurfacePosition._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetTrianglesStart
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetTrianglesStart`.
        public unsafe void GetTrianglesStart(JPH.Shape.GetTrianglesContext ioContext, JPH.Const_AABox inBox, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShape_GetTrianglesStart(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, JPH.Const_AABox._Underlying *inBox, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale);
            __JPH_OffsetCenterOfMassShape_GetTrianglesStart(_UnderlyingPtr, ioContext._UnderlyingPtr, inBox._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        // See Shape::GetTrianglesNext
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetTrianglesNext`.
        public unsafe int GetTrianglesNext(JPH.Shape.GetTrianglesContext ioContext, int inMaxTrianglesRequested, JPH.Float3? outTriangleVertices, void **outMaterials = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_OffsetCenterOfMassShape_GetTrianglesNext(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, int inMaxTrianglesRequested, JPH.Float3._Underlying *outTriangleVertices, void **outMaterials);
            return __JPH_OffsetCenterOfMassShape_GetTrianglesNext(_UnderlyingPtr, ioContext._UnderlyingPtr, inMaxTrianglesRequested, outTriangleVertices is not null ? outTriangleVertices._UnderlyingPtr : null, outMaterials);
        }

        // See Shape::GetStats
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetStats`.
        public unsafe JPH.Shape.Stats GetStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape.Stats._Underlying *__JPH_OffsetCenterOfMassShape_GetStats(_Underlying *_this);
            return new(__JPH_OffsetCenterOfMassShape_GetStats(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetVolume
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_OffsetCenterOfMassShape_GetVolume(_Underlying *_this);
            return __JPH_OffsetCenterOfMassShape_GetVolume(_UnderlyingPtr);
        }

        // Register shape functions with the registry
        /// Generated from method `JPH::OffsetCenterOfMassShape::sRegister`.
        public static void SRegister()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShape_sRegister();
            __JPH_OffsetCenterOfMassShape_sRegister();
        }

        /// Access to the decorated inner shape
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetInnerShape`.
        public unsafe JPH.Const_Shape? GetInnerShape()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetInnerShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetInnerShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_OffsetCenterOfMassShape_GetInnerShape(_Underlying *_this);
            var __c_ret = __JPH_OffsetCenterOfMassShape_GetInnerShape(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        // See Shape::MustBeStatic
        /// Generated from method `JPH::OffsetCenterOfMassShape::MustBeStatic`.
        public unsafe bool MustBeStatic()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_OffsetCenterOfMassShape_MustBeStatic(_Underlying *_this);
            return __JPH_OffsetCenterOfMassShape_MustBeStatic(_UnderlyingPtr) != 0;
        }

        // See Shape::GetSubShapeIDBitsRecursive
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetSubShapeIDBitsRecursive`.
        public unsafe uint GetSubShapeIDBitsRecursive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_OffsetCenterOfMassShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
            return __JPH_OffsetCenterOfMassShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
        }

        // See Shape::GetLeafShape
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetLeafShape`.
        public unsafe JPH.Const_Shape? GetLeafShape(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_OffsetCenterOfMassShape_GetLeafShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            var __c_ret = __JPH_OffsetCenterOfMassShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetMaterial
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetMaterial`.
        public unsafe JPH.Const_PhysicsMaterial? GetMaterial(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_OffsetCenterOfMassShape_GetMaterial(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            var __c_ret = __JPH_OffsetCenterOfMassShape_GetMaterial(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetSubShapeUserData
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetSubShapeUserData`.
        public unsafe ulong GetSubShapeUserData(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_OffsetCenterOfMassShape_GetSubShapeUserData(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return __JPH_OffsetCenterOfMassShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
        }

        // See Shape::IsValidScale
        /// Generated from method `JPH::OffsetCenterOfMassShape::IsValidScale`.
        public unsafe bool IsValidScale(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_OffsetCenterOfMassShape_IsValidScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return __JPH_OffsetCenterOfMassShape_IsValidScale(_UnderlyingPtr, inScale._UnderlyingPtr) != 0;
        }

        // See Shape::MakeScaleValid
        /// Generated from method `JPH::OffsetCenterOfMassShape::MakeScaleValid`.
        public unsafe JPH.Vec3 MakeScaleValid(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_OffsetCenterOfMassShape_MakeScaleValid(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_OffsetCenterOfMassShape_MakeScaleValid(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// User data (to be used freely by the application)
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetUserData`.
        public unsafe ulong GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_OffsetCenterOfMassShape_GetUserData(_Underlying *_this);
            return __JPH_OffsetCenterOfMassShape_GetUserData(_UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::OffsetCenterOfMassShape::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShape_SetEmbedded(_Underlying *_this);
            __JPH_OffsetCenterOfMassShape_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::OffsetCenterOfMassShape::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_OffsetCenterOfMassShape_GetRefCount(_Underlying *_this);
            return __JPH_OffsetCenterOfMassShape_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::OffsetCenterOfMassShape::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShape_AddRef(_Underlying *_this);
            __JPH_OffsetCenterOfMassShape_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShape_Release(_Underlying *_this);
            __JPH_OffsetCenterOfMassShape_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::OffsetCenterOfMassShape::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_OffsetCenterOfMassShape_sInternalGetRefCountOffset();
            return __JPH_OffsetCenterOfMassShape_sInternalGetRefCountOffset();
        }
    }

    /// This shape will shift the center of mass of a child shape, it can e.g. be used to lower the center of mass of an unstable object like a boat to make it stable
    /// Generated from class `JPH::OffsetCenterOfMassShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DecoratedShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the non-const half of the class.
    public class OffsetCenterOfMassShape : Const_OffsetCenterOfMassShape
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHShape(OffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.RefTarget_JPHShape ret = new(__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.NonCopyable(OffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Shape(OffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape._Underlying *__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Shape ret = new(__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.DecoratedShape(OffsetCenterOfMassShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DecoratedShape._Underlying *__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape(_Underlying *_this);
            JPH.DecoratedShape ret = new(__JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator OffsetCenterOfMassShape?(JPH.Shape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_Shape(JPH.Shape._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            OffsetCenterOfMassShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator OffsetCenterOfMassShape?(JPH.DecoratedShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_DecoratedShape(JPH.DecoratedShape._Underlying *_this);
            var ptr = __JPH_OffsetCenterOfMassShape_DynamicDowncastFrom_JPH_DecoratedShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            OffsetCenterOfMassShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe OffsetCenterOfMassShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe OffsetCenterOfMassShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShape._Underlying *__JPH_OffsetCenterOfMassShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShape_DefaultConstruct();
        }

        /// Generated from constructor `JPH::OffsetCenterOfMassShape::OffsetCenterOfMassShape`.
        public unsafe OffsetCenterOfMassShape(JPH.Const_Shape? inShape, JPH.Const_Vec3 inOffset) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.OffsetCenterOfMassShape._Underlying *__JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inOffset);
            _UnderlyingPtr = __JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr(inShape is not null ? inShape._UnderlyingPtr : null, inOffset._UnderlyingPtr);
        }

        /// Generated from method `JPH::OffsetCenterOfMassShape::SetUserData`.
        public unsafe void SetUserData(ulong inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_OffsetCenterOfMassShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_OffsetCenterOfMassShape_SetUserData(_Underlying *_this, ulong inUserData);
            __JPH_OffsetCenterOfMassShape_SetUserData(_UnderlyingPtr, inUserData);
        }
    }

    /// This is used as a function parameter when the underlying function receives `OffsetCenterOfMassShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_OffsetCenterOfMassShape
    {
        #pragma warning disable CS0649
        internal readonly Const_OffsetCenterOfMassShape? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_OffsetCenterOfMassShape() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `OffsetCenterOfMassShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_OffsetCenterOfMassShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `OffsetCenterOfMassShape`/`Const_OffsetCenterOfMassShape` directly.
    public class _InOptMut_OffsetCenterOfMassShape
    {
        public OffsetCenterOfMassShape? Opt;

        public _InOptMut_OffsetCenterOfMassShape() {}
        public _InOptMut_OffsetCenterOfMassShape(OffsetCenterOfMassShape value) {Opt = value;}
        public static implicit operator _InOptMut_OffsetCenterOfMassShape(OffsetCenterOfMassShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `OffsetCenterOfMassShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_OffsetCenterOfMassShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `OffsetCenterOfMassShape`/`Const_OffsetCenterOfMassShape` to pass it to the function.
    public class _InOptConst_OffsetCenterOfMassShape
    {
        public Const_OffsetCenterOfMassShape? Opt;

        public _InOptConst_OffsetCenterOfMassShape() {}
        public _InOptConst_OffsetCenterOfMassShape(Const_OffsetCenterOfMassShape value) {Opt = value;}
        public static implicit operator _InOptConst_OffsetCenterOfMassShape(Const_OffsetCenterOfMassShape value) {return new(value);}
    }
}
