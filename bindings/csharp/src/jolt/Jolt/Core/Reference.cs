// machine generated, do not edit
public static partial class JPH
{
    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::ShapeSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::BoxShapeSettings`
    ///     `JPH::CapsuleShapeSettings`
    ///     `JPH::CompoundShapeSettings`
    ///     `JPH::ConvexHullShapeSettings`
    ///     `JPH::ConvexShapeSettings`
    ///     `JPH::CylinderShapeSettings`
    ///     `JPH::DecoratedShapeSettings`
    ///     `JPH::EmptyShapeSettings`
    ///     `JPH::HeightFieldShapeSettings`
    ///     `JPH::MeshShapeSettings`
    ///     `JPH::MutableCompoundShapeSettings`
    ///     `JPH::OffsetCenterOfMassShapeSettings`
    ///     `JPH::PlaneShapeSettings`
    ///     `JPH::RotatedTranslatedShapeSettings`
    ///     `JPH::ScaledShapeSettings`
    ///     `JPH::SphereShapeSettings`
    ///     `JPH::StaticCompoundShapeSettings`
    ///     `JPH::TaperedCapsuleShapeSettings`
    ///     `JPH::TaperedCylinderShapeSettings`
    ///     `JPH::TriangleShapeSettings`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHShapeSettings : JPH.Object<Const_RefTarget_JPHShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_ShapeSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHShapeSettings() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::ShapeSettings>::RefTarget`.
        public unsafe Const_RefTarget_JPHShapeSettings(JPH._ByValue_RefTarget_JPHShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::ShapeSettings>::RefTarget`.
        public Const_RefTarget_JPHShapeSettings(Const_RefTarget_JPHShapeSettings _other) : this(new _ByValue_RefTarget_JPHShapeSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::ShapeSettings>::RefTarget`.
        public Const_RefTarget_JPHShapeSettings(RefTarget_JPHShapeSettings _other) : this((Const_RefTarget_JPHShapeSettings)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_ShapeSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_ShapeSettings_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_ShapeSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_ShapeSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_ShapeSettings_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_ShapeSettings_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::ShapeSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::BoxShapeSettings`
    ///     `JPH::CapsuleShapeSettings`
    ///     `JPH::CompoundShapeSettings`
    ///     `JPH::ConvexHullShapeSettings`
    ///     `JPH::ConvexShapeSettings`
    ///     `JPH::CylinderShapeSettings`
    ///     `JPH::DecoratedShapeSettings`
    ///     `JPH::EmptyShapeSettings`
    ///     `JPH::HeightFieldShapeSettings`
    ///     `JPH::MeshShapeSettings`
    ///     `JPH::MutableCompoundShapeSettings`
    ///     `JPH::OffsetCenterOfMassShapeSettings`
    ///     `JPH::PlaneShapeSettings`
    ///     `JPH::RotatedTranslatedShapeSettings`
    ///     `JPH::ScaledShapeSettings`
    ///     `JPH::SphereShapeSettings`
    ///     `JPH::StaticCompoundShapeSettings`
    ///     `JPH::TaperedCapsuleShapeSettings`
    ///     `JPH::TaperedCylinderShapeSettings`
    ///     `JPH::TriangleShapeSettings`
    /// This is the non-const half of the class.
    public class RefTarget_JPHShapeSettings : Const_RefTarget_JPHShapeSettings
    {
        internal unsafe RefTarget_JPHShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::ShapeSettings>::RefTarget`.
        public unsafe RefTarget_JPHShapeSettings(JPH._ByValue_RefTarget_JPHShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::ShapeSettings>::RefTarget`.
        public RefTarget_JPHShapeSettings(Const_RefTarget_JPHShapeSettings _other) : this(new _ByValue_RefTarget_JPHShapeSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::ShapeSettings>::RefTarget`.
        public RefTarget_JPHShapeSettings(RefTarget_JPHShapeSettings _other) : this((Const_RefTarget_JPHShapeSettings)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::operator=`.
        public unsafe JPH.RefTarget_JPHShapeSettings Assign(JPH._ByValue_RefTarget_JPHShapeSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_RefTarget_JPH_ShapeSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHShapeSettings._Underlying *_other);
            JPH.RefTarget_JPHShapeSettings __ret;
            __ret = new(__JPH_RefTarget_JPH_ShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHShapeSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHShapeSettings`/`Const_RefTarget_JPHShapeSettings` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHShapeSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHShapeSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHShapeSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHShapeSettings(Const_RefTarget_JPHShapeSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHShapeSettings(Const_RefTarget_JPHShapeSettings arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHShapeSettings`/`Const_RefTarget_JPHShapeSettings` directly.
    public class _InOptMut_RefTarget_JPHShapeSettings
    {
        public RefTarget_JPHShapeSettings? Opt;

        public _InOptMut_RefTarget_JPHShapeSettings() {}
        public _InOptMut_RefTarget_JPHShapeSettings(RefTarget_JPHShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHShapeSettings(RefTarget_JPHShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHShapeSettings`/`Const_RefTarget_JPHShapeSettings` to pass it to the function.
    public class _InOptConst_RefTarget_JPHShapeSettings
    {
        public Const_RefTarget_JPHShapeSettings? Opt;

        public _InOptConst_RefTarget_JPHShapeSettings() {}
        public _InOptConst_RefTarget_JPHShapeSettings(Const_RefTarget_JPHShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHShapeSettings(Const_RefTarget_JPHShapeSettings value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::Shape>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Shape`
    ///   Indirect: (non-virtual)
    ///     `JPH::BoxShape`
    ///     `JPH::CapsuleShape`
    ///     `JPH::CompoundShape`
    ///     `JPH::ConvexHullShape`
    ///     `JPH::ConvexShape`
    ///     `JPH::CylinderShape`
    ///     `JPH::DecoratedShape`
    ///     `JPH::EmptyShape`
    ///     `JPH::HeightFieldShape`
    ///     `JPH::MeshShape`
    ///     `JPH::MutableCompoundShape`
    ///     `JPH::OffsetCenterOfMassShape`
    ///     `JPH::PlaneShape`
    ///     `JPH::RotatedTranslatedShape`
    ///     `JPH::ScaledShape`
    ///     `JPH::SphereShape`
    ///     `JPH::StaticCompoundShape`
    ///     `JPH::TaperedCapsuleShape`
    ///     `JPH::TaperedCylinderShape`
    ///     `JPH::TriangleShape`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHShape : JPH.Object<Const_RefTarget_JPHShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_Shape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHShape() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_RefTarget_JPH_Shape_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_Shape_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Shape>::RefTarget`.
        public unsafe Const_RefTarget_JPHShape(JPH._ByValue_RefTarget_JPHShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_RefTarget_JPH_Shape_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHShape._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_Shape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Shape>::RefTarget`.
        public Const_RefTarget_JPHShape(Const_RefTarget_JPHShape _other) : this(new _ByValue_RefTarget_JPHShape(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::Shape>::RefTarget`.
        public Const_RefTarget_JPHShape(RefTarget_JPHShape _other) : this((Const_RefTarget_JPHShape)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::Shape>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_Shape_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::Shape>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_Shape_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_Shape_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::Shape>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::Shape>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_Shape_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::Shape>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_Shape_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_Shape_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::Shape>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Shape`
    ///   Indirect: (non-virtual)
    ///     `JPH::BoxShape`
    ///     `JPH::CapsuleShape`
    ///     `JPH::CompoundShape`
    ///     `JPH::ConvexHullShape`
    ///     `JPH::ConvexShape`
    ///     `JPH::CylinderShape`
    ///     `JPH::DecoratedShape`
    ///     `JPH::EmptyShape`
    ///     `JPH::HeightFieldShape`
    ///     `JPH::MeshShape`
    ///     `JPH::MutableCompoundShape`
    ///     `JPH::OffsetCenterOfMassShape`
    ///     `JPH::PlaneShape`
    ///     `JPH::RotatedTranslatedShape`
    ///     `JPH::ScaledShape`
    ///     `JPH::SphereShape`
    ///     `JPH::StaticCompoundShape`
    ///     `JPH::TaperedCapsuleShape`
    ///     `JPH::TaperedCylinderShape`
    ///     `JPH::TriangleShape`
    /// This is the non-const half of the class.
    public class RefTarget_JPHShape : Const_RefTarget_JPHShape
    {
        internal unsafe RefTarget_JPHShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_RefTarget_JPH_Shape_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_Shape_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Shape>::RefTarget`.
        public unsafe RefTarget_JPHShape(JPH._ByValue_RefTarget_JPHShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_RefTarget_JPH_Shape_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHShape._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_Shape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Shape>::RefTarget`.
        public RefTarget_JPHShape(Const_RefTarget_JPHShape _other) : this(new _ByValue_RefTarget_JPHShape(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::Shape>::RefTarget`.
        public RefTarget_JPHShape(RefTarget_JPHShape _other) : this((Const_RefTarget_JPHShape)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::Shape>::operator=`.
        public unsafe JPH.RefTarget_JPHShape Assign(JPH._ByValue_RefTarget_JPHShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_RefTarget_JPH_Shape_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHShape._Underlying *_other);
            JPH.RefTarget_JPHShape __ret;
            __ret = new(__JPH_RefTarget_JPH_Shape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHShape`/`Const_RefTarget_JPHShape` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHShape
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHShape? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHShape() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHShape(Const_RefTarget_JPHShape new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHShape(Const_RefTarget_JPHShape arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHShape`/`Const_RefTarget_JPHShape` directly.
    public class _InOptMut_RefTarget_JPHShape
    {
        public RefTarget_JPHShape? Opt;

        public _InOptMut_RefTarget_JPHShape() {}
        public _InOptMut_RefTarget_JPHShape(RefTarget_JPHShape value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHShape(RefTarget_JPHShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHShape`/`Const_RefTarget_JPHShape` to pass it to the function.
    public class _InOptConst_RefTarget_JPHShape
    {
        public Const_RefTarget_JPHShape? Opt;

        public _InOptConst_RefTarget_JPHShape() {}
        public _InOptConst_RefTarget_JPHShape(Const_RefTarget_JPHShape value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHShape(Const_RefTarget_JPHShape value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::PhysicsMaterial>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PhysicsMaterial`
    ///   Indirect: (non-virtual)
    ///     `JPH::PhysicsMaterialSimple`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHPhysicsMaterial : JPH.Object<Const_RefTarget_JPHPhysicsMaterial>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PhysicsMaterial_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_PhysicsMaterial_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHPhysicsMaterial() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHPhysicsMaterial(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHPhysicsMaterial() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPhysicsMaterial._Underlying *__JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::PhysicsMaterial>::RefTarget`.
        public unsafe Const_RefTarget_JPHPhysicsMaterial(JPH._ByValue_RefTarget_JPHPhysicsMaterial _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPhysicsMaterial._Underlying *__JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHPhysicsMaterial._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::PhysicsMaterial>::RefTarget`.
        public Const_RefTarget_JPHPhysicsMaterial(Const_RefTarget_JPHPhysicsMaterial _other) : this(new _ByValue_RefTarget_JPHPhysicsMaterial(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::PhysicsMaterial>::RefTarget`.
        public Const_RefTarget_JPHPhysicsMaterial(RefTarget_JPHPhysicsMaterial _other) : this((Const_RefTarget_JPHPhysicsMaterial)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PhysicsMaterial_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_PhysicsMaterial_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_PhysicsMaterial_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_PhysicsMaterial_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_PhysicsMaterial_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PhysicsMaterial_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_PhysicsMaterial_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_PhysicsMaterial_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_PhysicsMaterial_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::PhysicsMaterial>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PhysicsMaterial`
    ///   Indirect: (non-virtual)
    ///     `JPH::PhysicsMaterialSimple`
    /// This is the non-const half of the class.
    public class RefTarget_JPHPhysicsMaterial : Const_RefTarget_JPHPhysicsMaterial
    {
        internal unsafe RefTarget_JPHPhysicsMaterial(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHPhysicsMaterial() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPhysicsMaterial._Underlying *__JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::PhysicsMaterial>::RefTarget`.
        public unsafe RefTarget_JPHPhysicsMaterial(JPH._ByValue_RefTarget_JPHPhysicsMaterial _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPhysicsMaterial._Underlying *__JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHPhysicsMaterial._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::PhysicsMaterial>::RefTarget`.
        public RefTarget_JPHPhysicsMaterial(Const_RefTarget_JPHPhysicsMaterial _other) : this(new _ByValue_RefTarget_JPHPhysicsMaterial(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::PhysicsMaterial>::RefTarget`.
        public RefTarget_JPHPhysicsMaterial(RefTarget_JPHPhysicsMaterial _other) : this((Const_RefTarget_JPHPhysicsMaterial)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::operator=`.
        public unsafe JPH.RefTarget_JPHPhysicsMaterial Assign(JPH._ByValue_RefTarget_JPHPhysicsMaterial _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PhysicsMaterial_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPhysicsMaterial._Underlying *__JPH_RefTarget_JPH_PhysicsMaterial_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHPhysicsMaterial._Underlying *_other);
            JPH.RefTarget_JPHPhysicsMaterial __ret;
            __ret = new(__JPH_RefTarget_JPH_PhysicsMaterial_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHPhysicsMaterial` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHPhysicsMaterial`/`Const_RefTarget_JPHPhysicsMaterial` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHPhysicsMaterial
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHPhysicsMaterial? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHPhysicsMaterial() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHPhysicsMaterial(Const_RefTarget_JPHPhysicsMaterial new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHPhysicsMaterial(Const_RefTarget_JPHPhysicsMaterial arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHPhysicsMaterial` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHPhysicsMaterial`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHPhysicsMaterial`/`Const_RefTarget_JPHPhysicsMaterial` directly.
    public class _InOptMut_RefTarget_JPHPhysicsMaterial
    {
        public RefTarget_JPHPhysicsMaterial? Opt;

        public _InOptMut_RefTarget_JPHPhysicsMaterial() {}
        public _InOptMut_RefTarget_JPHPhysicsMaterial(RefTarget_JPHPhysicsMaterial value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHPhysicsMaterial(RefTarget_JPHPhysicsMaterial value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHPhysicsMaterial` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHPhysicsMaterial`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHPhysicsMaterial`/`Const_RefTarget_JPHPhysicsMaterial` to pass it to the function.
    public class _InOptConst_RefTarget_JPHPhysicsMaterial
    {
        public Const_RefTarget_JPHPhysicsMaterial? Opt;

        public _InOptConst_RefTarget_JPHPhysicsMaterial() {}
        public _InOptConst_RefTarget_JPHPhysicsMaterial(Const_RefTarget_JPHPhysicsMaterial value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHPhysicsMaterial(Const_RefTarget_JPHPhysicsMaterial value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::CharacterBaseSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CharacterBaseSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::CharacterSettings`
    ///     `JPH::CharacterVirtualSettings`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHCharacterBaseSettings : JPH.Object<Const_RefTarget_JPHCharacterBaseSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBaseSettings_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_CharacterBaseSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHCharacterBaseSettings() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHCharacterBaseSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHCharacterBaseSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBaseSettings>::RefTarget`.
        public unsafe Const_RefTarget_JPHCharacterBaseSettings(JPH._ByValue_RefTarget_JPHCharacterBaseSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHCharacterBaseSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBaseSettings>::RefTarget`.
        public Const_RefTarget_JPHCharacterBaseSettings(Const_RefTarget_JPHCharacterBaseSettings _other) : this(new _ByValue_RefTarget_JPHCharacterBaseSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBaseSettings>::RefTarget`.
        public Const_RefTarget_JPHCharacterBaseSettings(RefTarget_JPHCharacterBaseSettings _other) : this((Const_RefTarget_JPHCharacterBaseSettings)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBaseSettings_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_CharacterBaseSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_CharacterBaseSettings_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_CharacterBaseSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBaseSettings_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_CharacterBaseSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_CharacterBaseSettings_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_CharacterBaseSettings_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::CharacterBaseSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CharacterBaseSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::CharacterSettings`
    ///     `JPH::CharacterVirtualSettings`
    /// This is the non-const half of the class.
    public class RefTarget_JPHCharacterBaseSettings : Const_RefTarget_JPHCharacterBaseSettings
    {
        internal unsafe RefTarget_JPHCharacterBaseSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHCharacterBaseSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBaseSettings>::RefTarget`.
        public unsafe RefTarget_JPHCharacterBaseSettings(JPH._ByValue_RefTarget_JPHCharacterBaseSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHCharacterBaseSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBaseSettings>::RefTarget`.
        public RefTarget_JPHCharacterBaseSettings(Const_RefTarget_JPHCharacterBaseSettings _other) : this(new _ByValue_RefTarget_JPHCharacterBaseSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBaseSettings>::RefTarget`.
        public RefTarget_JPHCharacterBaseSettings(RefTarget_JPHCharacterBaseSettings _other) : this((Const_RefTarget_JPHCharacterBaseSettings)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::operator=`.
        public unsafe JPH.RefTarget_JPHCharacterBaseSettings Assign(JPH._ByValue_RefTarget_JPHCharacterBaseSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_RefTarget_JPH_CharacterBaseSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHCharacterBaseSettings._Underlying *_other);
            JPH.RefTarget_JPHCharacterBaseSettings __ret;
            __ret = new(__JPH_RefTarget_JPH_CharacterBaseSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHCharacterBaseSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHCharacterBaseSettings`/`Const_RefTarget_JPHCharacterBaseSettings` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHCharacterBaseSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHCharacterBaseSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHCharacterBaseSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHCharacterBaseSettings(Const_RefTarget_JPHCharacterBaseSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHCharacterBaseSettings(Const_RefTarget_JPHCharacterBaseSettings arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHCharacterBaseSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHCharacterBaseSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHCharacterBaseSettings`/`Const_RefTarget_JPHCharacterBaseSettings` directly.
    public class _InOptMut_RefTarget_JPHCharacterBaseSettings
    {
        public RefTarget_JPHCharacterBaseSettings? Opt;

        public _InOptMut_RefTarget_JPHCharacterBaseSettings() {}
        public _InOptMut_RefTarget_JPHCharacterBaseSettings(RefTarget_JPHCharacterBaseSettings value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHCharacterBaseSettings(RefTarget_JPHCharacterBaseSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHCharacterBaseSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHCharacterBaseSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHCharacterBaseSettings`/`Const_RefTarget_JPHCharacterBaseSettings` to pass it to the function.
    public class _InOptConst_RefTarget_JPHCharacterBaseSettings
    {
        public Const_RefTarget_JPHCharacterBaseSettings? Opt;

        public _InOptConst_RefTarget_JPHCharacterBaseSettings() {}
        public _InOptConst_RefTarget_JPHCharacterBaseSettings(Const_RefTarget_JPHCharacterBaseSettings value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHCharacterBaseSettings(Const_RefTarget_JPHCharacterBaseSettings value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::CharacterBase>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CharacterBase`
    ///   Indirect: (non-virtual)
    ///     `JPH::Character`
    ///     `JPH::CharacterVirtual`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHCharacterBase : JPH.Object<Const_RefTarget_JPHCharacterBase>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBase_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_CharacterBase_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHCharacterBase() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHCharacterBase(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHCharacterBase() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBase._Underlying *__JPH_RefTarget_JPH_CharacterBase_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_CharacterBase_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBase>::RefTarget`.
        public unsafe Const_RefTarget_JPHCharacterBase(JPH._ByValue_RefTarget_JPHCharacterBase _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBase._Underlying *__JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHCharacterBase._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBase>::RefTarget`.
        public Const_RefTarget_JPHCharacterBase(Const_RefTarget_JPHCharacterBase _other) : this(new _ByValue_RefTarget_JPHCharacterBase(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBase>::RefTarget`.
        public Const_RefTarget_JPHCharacterBase(RefTarget_JPHCharacterBase _other) : this((Const_RefTarget_JPHCharacterBase)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::CharacterBase>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBase_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_CharacterBase_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::CharacterBase>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_CharacterBase_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_CharacterBase_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::CharacterBase>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBase_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_CharacterBase_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::CharacterBase>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBase_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_CharacterBase_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::CharacterBase>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_CharacterBase_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_CharacterBase_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::CharacterBase>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CharacterBase`
    ///   Indirect: (non-virtual)
    ///     `JPH::Character`
    ///     `JPH::CharacterVirtual`
    /// This is the non-const half of the class.
    public class RefTarget_JPHCharacterBase : Const_RefTarget_JPHCharacterBase
    {
        internal unsafe RefTarget_JPHCharacterBase(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHCharacterBase() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBase._Underlying *__JPH_RefTarget_JPH_CharacterBase_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_CharacterBase_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBase>::RefTarget`.
        public unsafe RefTarget_JPHCharacterBase(JPH._ByValue_RefTarget_JPHCharacterBase _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBase._Underlying *__JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHCharacterBase._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBase>::RefTarget`.
        public RefTarget_JPHCharacterBase(Const_RefTarget_JPHCharacterBase _other) : this(new _ByValue_RefTarget_JPHCharacterBase(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::CharacterBase>::RefTarget`.
        public RefTarget_JPHCharacterBase(RefTarget_JPHCharacterBase _other) : this((Const_RefTarget_JPHCharacterBase)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::CharacterBase>::operator=`.
        public unsafe JPH.RefTarget_JPHCharacterBase Assign(JPH._ByValue_RefTarget_JPHCharacterBase _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBase._Underlying *__JPH_RefTarget_JPH_CharacterBase_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHCharacterBase._Underlying *_other);
            JPH.RefTarget_JPHCharacterBase __ret;
            __ret = new(__JPH_RefTarget_JPH_CharacterBase_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHCharacterBase` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHCharacterBase`/`Const_RefTarget_JPHCharacterBase` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHCharacterBase
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHCharacterBase? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHCharacterBase() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHCharacterBase(Const_RefTarget_JPHCharacterBase new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHCharacterBase(Const_RefTarget_JPHCharacterBase arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHCharacterBase` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHCharacterBase`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHCharacterBase`/`Const_RefTarget_JPHCharacterBase` directly.
    public class _InOptMut_RefTarget_JPHCharacterBase
    {
        public RefTarget_JPHCharacterBase? Opt;

        public _InOptMut_RefTarget_JPHCharacterBase() {}
        public _InOptMut_RefTarget_JPHCharacterBase(RefTarget_JPHCharacterBase value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHCharacterBase(RefTarget_JPHCharacterBase value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHCharacterBase` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHCharacterBase`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHCharacterBase`/`Const_RefTarget_JPHCharacterBase` to pass it to the function.
    public class _InOptConst_RefTarget_JPHCharacterBase
    {
        public Const_RefTarget_JPHCharacterBase? Opt;

        public _InOptConst_RefTarget_JPHCharacterBase() {}
        public _InOptConst_RefTarget_JPHCharacterBase(Const_RefTarget_JPHCharacterBase value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHCharacterBase(Const_RefTarget_JPHCharacterBase value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::ConstraintSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConstraintSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::ConeConstraintSettings`
    ///     `JPH::DistanceConstraintSettings`
    ///     `JPH::FixedConstraintSettings`
    ///     `JPH::GearConstraintSettings`
    ///     `JPH::HingeConstraintSettings`
    ///     `JPH::PointConstraintSettings`
    ///     `JPH::PulleyConstraintSettings`
    ///     `JPH::RackAndPinionConstraintSettings`
    ///     `JPH::SixDOFConstraintSettings`
    ///     `JPH::SliderConstraintSettings`
    ///     `JPH::SwingTwistConstraintSettings`
    ///     `JPH::TwoBodyConstraintSettings`
    ///     `JPH::VehicleConstraintSettings`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHConstraintSettings : JPH.Object<Const_RefTarget_JPHConstraintSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHConstraintSettings() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHConstraintSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHConstraintSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::ConstraintSettings>::RefTarget`.
        public unsafe Const_RefTarget_JPHConstraintSettings(JPH._ByValue_RefTarget_JPHConstraintSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHConstraintSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::ConstraintSettings>::RefTarget`.
        public Const_RefTarget_JPHConstraintSettings(Const_RefTarget_JPHConstraintSettings _other) : this(new _ByValue_RefTarget_JPHConstraintSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::ConstraintSettings>::RefTarget`.
        public Const_RefTarget_JPHConstraintSettings(RefTarget_JPHConstraintSettings _other) : this((Const_RefTarget_JPHConstraintSettings)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_ConstraintSettings_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_ConstraintSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_ConstraintSettings_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_ConstraintSettings_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::ConstraintSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConstraintSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::ConeConstraintSettings`
    ///     `JPH::DistanceConstraintSettings`
    ///     `JPH::FixedConstraintSettings`
    ///     `JPH::GearConstraintSettings`
    ///     `JPH::HingeConstraintSettings`
    ///     `JPH::PointConstraintSettings`
    ///     `JPH::PulleyConstraintSettings`
    ///     `JPH::RackAndPinionConstraintSettings`
    ///     `JPH::SixDOFConstraintSettings`
    ///     `JPH::SliderConstraintSettings`
    ///     `JPH::SwingTwistConstraintSettings`
    ///     `JPH::TwoBodyConstraintSettings`
    ///     `JPH::VehicleConstraintSettings`
    /// This is the non-const half of the class.
    public class RefTarget_JPHConstraintSettings : Const_RefTarget_JPHConstraintSettings
    {
        internal unsafe RefTarget_JPHConstraintSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHConstraintSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::ConstraintSettings>::RefTarget`.
        public unsafe RefTarget_JPHConstraintSettings(JPH._ByValue_RefTarget_JPHConstraintSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHConstraintSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::ConstraintSettings>::RefTarget`.
        public RefTarget_JPHConstraintSettings(Const_RefTarget_JPHConstraintSettings _other) : this(new _ByValue_RefTarget_JPHConstraintSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::ConstraintSettings>::RefTarget`.
        public RefTarget_JPHConstraintSettings(RefTarget_JPHConstraintSettings _other) : this((Const_RefTarget_JPHConstraintSettings)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::operator=`.
        public unsafe JPH.RefTarget_JPHConstraintSettings Assign(JPH._ByValue_RefTarget_JPHConstraintSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_RefTarget_JPH_ConstraintSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHConstraintSettings._Underlying *_other);
            JPH.RefTarget_JPHConstraintSettings __ret;
            __ret = new(__JPH_RefTarget_JPH_ConstraintSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHConstraintSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHConstraintSettings`/`Const_RefTarget_JPHConstraintSettings` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHConstraintSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHConstraintSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHConstraintSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHConstraintSettings(Const_RefTarget_JPHConstraintSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHConstraintSettings(Const_RefTarget_JPHConstraintSettings arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHConstraintSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHConstraintSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHConstraintSettings`/`Const_RefTarget_JPHConstraintSettings` directly.
    public class _InOptMut_RefTarget_JPHConstraintSettings
    {
        public RefTarget_JPHConstraintSettings? Opt;

        public _InOptMut_RefTarget_JPHConstraintSettings() {}
        public _InOptMut_RefTarget_JPHConstraintSettings(RefTarget_JPHConstraintSettings value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHConstraintSettings(RefTarget_JPHConstraintSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHConstraintSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHConstraintSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHConstraintSettings`/`Const_RefTarget_JPHConstraintSettings` to pass it to the function.
    public class _InOptConst_RefTarget_JPHConstraintSettings
    {
        public Const_RefTarget_JPHConstraintSettings? Opt;

        public _InOptConst_RefTarget_JPHConstraintSettings() {}
        public _InOptConst_RefTarget_JPHConstraintSettings(Const_RefTarget_JPHConstraintSettings value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHConstraintSettings(Const_RefTarget_JPHConstraintSettings value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::Constraint>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Constraint`
    ///   Indirect: (non-virtual)
    ///     `JPH::ConeConstraint`
    ///     `JPH::DistanceConstraint`
    ///     `JPH::FixedConstraint`
    ///     `JPH::GearConstraint`
    ///     `JPH::HingeConstraint`
    ///     `JPH::PointConstraint`
    ///     `JPH::PulleyConstraint`
    ///     `JPH::RackAndPinionConstraint`
    ///     `JPH::SixDOFConstraint`
    ///     `JPH::SliderConstraint`
    ///     `JPH::SwingTwistConstraint`
    ///     `JPH::TwoBodyConstraint`
    ///     `JPH::VehicleConstraint`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHConstraint : JPH.Object<Const_RefTarget_JPHConstraint>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_Constraint_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHConstraint() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHConstraint() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraint._Underlying *__JPH_RefTarget_JPH_Constraint_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_Constraint_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Constraint>::RefTarget`.
        public unsafe Const_RefTarget_JPHConstraint(JPH._ByValue_RefTarget_JPHConstraint _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraint._Underlying *__JPH_RefTarget_JPH_Constraint_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHConstraint._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_Constraint_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Constraint>::RefTarget`.
        public Const_RefTarget_JPHConstraint(Const_RefTarget_JPHConstraint _other) : this(new _ByValue_RefTarget_JPHConstraint(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::Constraint>::RefTarget`.
        public Const_RefTarget_JPHConstraint(RefTarget_JPHConstraint _other) : this((Const_RefTarget_JPHConstraint)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::Constraint>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_Constraint_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::Constraint>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_Constraint_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_Constraint_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::Constraint>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_Constraint_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::Constraint>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_Constraint_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::Constraint>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_Constraint_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_Constraint_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::Constraint>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Constraint`
    ///   Indirect: (non-virtual)
    ///     `JPH::ConeConstraint`
    ///     `JPH::DistanceConstraint`
    ///     `JPH::FixedConstraint`
    ///     `JPH::GearConstraint`
    ///     `JPH::HingeConstraint`
    ///     `JPH::PointConstraint`
    ///     `JPH::PulleyConstraint`
    ///     `JPH::RackAndPinionConstraint`
    ///     `JPH::SixDOFConstraint`
    ///     `JPH::SliderConstraint`
    ///     `JPH::SwingTwistConstraint`
    ///     `JPH::TwoBodyConstraint`
    ///     `JPH::VehicleConstraint`
    /// This is the non-const half of the class.
    public class RefTarget_JPHConstraint : Const_RefTarget_JPHConstraint
    {
        internal unsafe RefTarget_JPHConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHConstraint() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraint._Underlying *__JPH_RefTarget_JPH_Constraint_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_Constraint_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Constraint>::RefTarget`.
        public unsafe RefTarget_JPHConstraint(JPH._ByValue_RefTarget_JPHConstraint _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraint._Underlying *__JPH_RefTarget_JPH_Constraint_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHConstraint._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_Constraint_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Constraint>::RefTarget`.
        public RefTarget_JPHConstraint(Const_RefTarget_JPHConstraint _other) : this(new _ByValue_RefTarget_JPHConstraint(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::Constraint>::RefTarget`.
        public RefTarget_JPHConstraint(RefTarget_JPHConstraint _other) : this((Const_RefTarget_JPHConstraint)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::Constraint>::operator=`.
        public unsafe JPH.RefTarget_JPHConstraint Assign(JPH._ByValue_RefTarget_JPHConstraint _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraint._Underlying *__JPH_RefTarget_JPH_Constraint_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHConstraint._Underlying *_other);
            JPH.RefTarget_JPHConstraint __ret;
            __ret = new(__JPH_RefTarget_JPH_Constraint_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHConstraint` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHConstraint`/`Const_RefTarget_JPHConstraint` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHConstraint
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHConstraint? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHConstraint() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHConstraint(Const_RefTarget_JPHConstraint new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHConstraint(Const_RefTarget_JPHConstraint arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHConstraint` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHConstraint`/`Const_RefTarget_JPHConstraint` directly.
    public class _InOptMut_RefTarget_JPHConstraint
    {
        public RefTarget_JPHConstraint? Opt;

        public _InOptMut_RefTarget_JPHConstraint() {}
        public _InOptMut_RefTarget_JPHConstraint(RefTarget_JPHConstraint value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHConstraint(RefTarget_JPHConstraint value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHConstraint` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHConstraint`/`Const_RefTarget_JPHConstraint` to pass it to the function.
    public class _InOptConst_RefTarget_JPHConstraint
    {
        public Const_RefTarget_JPHConstraint? Opt;

        public _InOptConst_RefTarget_JPHConstraint() {}
        public _InOptConst_RefTarget_JPHConstraint(Const_RefTarget_JPHConstraint value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHConstraint(Const_RefTarget_JPHConstraint value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::GroupFilter>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::GroupFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::GroupFilterTable`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHGroupFilter : JPH.Object<Const_RefTarget_JPHGroupFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_GroupFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHGroupFilter() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHGroupFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHGroupFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHGroupFilter._Underlying *__JPH_RefTarget_JPH_GroupFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_GroupFilter_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::GroupFilter>::RefTarget`.
        public unsafe Const_RefTarget_JPHGroupFilter(JPH._ByValue_RefTarget_JPHGroupFilter _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHGroupFilter._Underlying *__JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHGroupFilter._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::GroupFilter>::RefTarget`.
        public Const_RefTarget_JPHGroupFilter(Const_RefTarget_JPHGroupFilter _other) : this(new _ByValue_RefTarget_JPHGroupFilter(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::GroupFilter>::RefTarget`.
        public Const_RefTarget_JPHGroupFilter(RefTarget_JPHGroupFilter _other) : this((Const_RefTarget_JPHGroupFilter)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::GroupFilter>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_GroupFilter_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::GroupFilter>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_GroupFilter_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_GroupFilter_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::GroupFilter>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_GroupFilter_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::GroupFilter>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_GroupFilter_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::GroupFilter>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_GroupFilter_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_GroupFilter_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::GroupFilter>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::GroupFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::GroupFilterTable`
    /// This is the non-const half of the class.
    public class RefTarget_JPHGroupFilter : Const_RefTarget_JPHGroupFilter
    {
        internal unsafe RefTarget_JPHGroupFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHGroupFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHGroupFilter._Underlying *__JPH_RefTarget_JPH_GroupFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_GroupFilter_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::GroupFilter>::RefTarget`.
        public unsafe RefTarget_JPHGroupFilter(JPH._ByValue_RefTarget_JPHGroupFilter _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHGroupFilter._Underlying *__JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHGroupFilter._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::GroupFilter>::RefTarget`.
        public RefTarget_JPHGroupFilter(Const_RefTarget_JPHGroupFilter _other) : this(new _ByValue_RefTarget_JPHGroupFilter(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::GroupFilter>::RefTarget`.
        public RefTarget_JPHGroupFilter(RefTarget_JPHGroupFilter _other) : this((Const_RefTarget_JPHGroupFilter)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::GroupFilter>::operator=`.
        public unsafe JPH.RefTarget_JPHGroupFilter Assign(JPH._ByValue_RefTarget_JPHGroupFilter _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHGroupFilter._Underlying *__JPH_RefTarget_JPH_GroupFilter_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHGroupFilter._Underlying *_other);
            JPH.RefTarget_JPHGroupFilter __ret;
            __ret = new(__JPH_RefTarget_JPH_GroupFilter_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHGroupFilter` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHGroupFilter`/`Const_RefTarget_JPHGroupFilter` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHGroupFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHGroupFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHGroupFilter() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHGroupFilter(Const_RefTarget_JPHGroupFilter new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHGroupFilter(Const_RefTarget_JPHGroupFilter arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHGroupFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHGroupFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHGroupFilter`/`Const_RefTarget_JPHGroupFilter` directly.
    public class _InOptMut_RefTarget_JPHGroupFilter
    {
        public RefTarget_JPHGroupFilter? Opt;

        public _InOptMut_RefTarget_JPHGroupFilter() {}
        public _InOptMut_RefTarget_JPHGroupFilter(RefTarget_JPHGroupFilter value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHGroupFilter(RefTarget_JPHGroupFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHGroupFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHGroupFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHGroupFilter`/`Const_RefTarget_JPHGroupFilter` to pass it to the function.
    public class _InOptConst_RefTarget_JPHGroupFilter
    {
        public Const_RefTarget_JPHGroupFilter? Opt;

        public _InOptConst_RefTarget_JPHGroupFilter() {}
        public _InOptConst_RefTarget_JPHGroupFilter(Const_RefTarget_JPHGroupFilter value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHGroupFilter(Const_RefTarget_JPHGroupFilter value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTester`
    ///   Indirect: (non-virtual)
    ///     `JPH::VehicleCollisionTesterCastCylinder`
    ///     `JPH::VehicleCollisionTesterCastSphere`
    ///     `JPH::VehicleCollisionTesterRay`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHVehicleCollisionTester : JPH.Object<Const_RefTarget_JPHVehicleCollisionTester>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHVehicleCollisionTester() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHVehicleCollisionTester(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHVehicleCollisionTester() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleCollisionTester>::RefTarget`.
        public unsafe Const_RefTarget_JPHVehicleCollisionTester(JPH._ByValue_RefTarget_JPHVehicleCollisionTester _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHVehicleCollisionTester._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleCollisionTester>::RefTarget`.
        public Const_RefTarget_JPHVehicleCollisionTester(Const_RefTarget_JPHVehicleCollisionTester _other) : this(new _ByValue_RefTarget_JPHVehicleCollisionTester(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleCollisionTester>::RefTarget`.
        public Const_RefTarget_JPHVehicleCollisionTester(RefTarget_JPHVehicleCollisionTester _other) : this((Const_RefTarget_JPHVehicleCollisionTester)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_VehicleCollisionTester_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_VehicleCollisionTester_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_VehicleCollisionTester_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_VehicleCollisionTester_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTester`
    ///   Indirect: (non-virtual)
    ///     `JPH::VehicleCollisionTesterCastCylinder`
    ///     `JPH::VehicleCollisionTesterCastSphere`
    ///     `JPH::VehicleCollisionTesterRay`
    /// This is the non-const half of the class.
    public class RefTarget_JPHVehicleCollisionTester : Const_RefTarget_JPHVehicleCollisionTester
    {
        internal unsafe RefTarget_JPHVehicleCollisionTester(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHVehicleCollisionTester() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleCollisionTester>::RefTarget`.
        public unsafe RefTarget_JPHVehicleCollisionTester(JPH._ByValue_RefTarget_JPHVehicleCollisionTester _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHVehicleCollisionTester._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleCollisionTester>::RefTarget`.
        public RefTarget_JPHVehicleCollisionTester(Const_RefTarget_JPHVehicleCollisionTester _other) : this(new _ByValue_RefTarget_JPHVehicleCollisionTester(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleCollisionTester>::RefTarget`.
        public RefTarget_JPHVehicleCollisionTester(RefTarget_JPHVehicleCollisionTester _other) : this((Const_RefTarget_JPHVehicleCollisionTester)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::operator=`.
        public unsafe JPH.RefTarget_JPHVehicleCollisionTester Assign(JPH._ByValue_RefTarget_JPHVehicleCollisionTester _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_RefTarget_JPH_VehicleCollisionTester_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHVehicleCollisionTester._Underlying *_other);
            JPH.RefTarget_JPHVehicleCollisionTester __ret;
            __ret = new(__JPH_RefTarget_JPH_VehicleCollisionTester_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHVehicleCollisionTester` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHVehicleCollisionTester`/`Const_RefTarget_JPHVehicleCollisionTester` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHVehicleCollisionTester
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHVehicleCollisionTester? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHVehicleCollisionTester() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHVehicleCollisionTester(Const_RefTarget_JPHVehicleCollisionTester new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHVehicleCollisionTester(Const_RefTarget_JPHVehicleCollisionTester arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHVehicleCollisionTester` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHVehicleCollisionTester`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHVehicleCollisionTester`/`Const_RefTarget_JPHVehicleCollisionTester` directly.
    public class _InOptMut_RefTarget_JPHVehicleCollisionTester
    {
        public RefTarget_JPHVehicleCollisionTester? Opt;

        public _InOptMut_RefTarget_JPHVehicleCollisionTester() {}
        public _InOptMut_RefTarget_JPHVehicleCollisionTester(RefTarget_JPHVehicleCollisionTester value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHVehicleCollisionTester(RefTarget_JPHVehicleCollisionTester value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHVehicleCollisionTester` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHVehicleCollisionTester`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHVehicleCollisionTester`/`Const_RefTarget_JPHVehicleCollisionTester` to pass it to the function.
    public class _InOptConst_RefTarget_JPHVehicleCollisionTester
    {
        public Const_RefTarget_JPHVehicleCollisionTester? Opt;

        public _InOptConst_RefTarget_JPHVehicleCollisionTester() {}
        public _InOptConst_RefTarget_JPHVehicleCollisionTester(Const_RefTarget_JPHVehicleCollisionTester value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHVehicleCollisionTester(Const_RefTarget_JPHVehicleCollisionTester value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::WheelSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::WheelSettingsWV`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHWheelSettings : JPH.Object<Const_RefTarget_JPHWheelSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_WheelSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHWheelSettings() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHWheelSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHWheelSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHWheelSettings._Underlying *__JPH_RefTarget_JPH_WheelSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_WheelSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::WheelSettings>::RefTarget`.
        public unsafe Const_RefTarget_JPHWheelSettings(JPH._ByValue_RefTarget_JPHWheelSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHWheelSettings._Underlying *__JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHWheelSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::WheelSettings>::RefTarget`.
        public Const_RefTarget_JPHWheelSettings(Const_RefTarget_JPHWheelSettings _other) : this(new _ByValue_RefTarget_JPHWheelSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::WheelSettings>::RefTarget`.
        public Const_RefTarget_JPHWheelSettings(RefTarget_JPHWheelSettings _other) : this((Const_RefTarget_JPHWheelSettings)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::WheelSettings>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_WheelSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::WheelSettings>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_WheelSettings_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_WheelSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::WheelSettings>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::WheelSettings>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_WheelSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::WheelSettings>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_WheelSettings_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_WheelSettings_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::WheelSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::WheelSettingsWV`
    /// This is the non-const half of the class.
    public class RefTarget_JPHWheelSettings : Const_RefTarget_JPHWheelSettings
    {
        internal unsafe RefTarget_JPHWheelSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHWheelSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHWheelSettings._Underlying *__JPH_RefTarget_JPH_WheelSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_WheelSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::WheelSettings>::RefTarget`.
        public unsafe RefTarget_JPHWheelSettings(JPH._ByValue_RefTarget_JPHWheelSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHWheelSettings._Underlying *__JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHWheelSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::WheelSettings>::RefTarget`.
        public RefTarget_JPHWheelSettings(Const_RefTarget_JPHWheelSettings _other) : this(new _ByValue_RefTarget_JPHWheelSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::WheelSettings>::RefTarget`.
        public RefTarget_JPHWheelSettings(RefTarget_JPHWheelSettings _other) : this((Const_RefTarget_JPHWheelSettings)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::WheelSettings>::operator=`.
        public unsafe JPH.RefTarget_JPHWheelSettings Assign(JPH._ByValue_RefTarget_JPHWheelSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHWheelSettings._Underlying *__JPH_RefTarget_JPH_WheelSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHWheelSettings._Underlying *_other);
            JPH.RefTarget_JPHWheelSettings __ret;
            __ret = new(__JPH_RefTarget_JPH_WheelSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHWheelSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHWheelSettings`/`Const_RefTarget_JPHWheelSettings` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHWheelSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHWheelSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHWheelSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHWheelSettings(Const_RefTarget_JPHWheelSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHWheelSettings(Const_RefTarget_JPHWheelSettings arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHWheelSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHWheelSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHWheelSettings`/`Const_RefTarget_JPHWheelSettings` directly.
    public class _InOptMut_RefTarget_JPHWheelSettings
    {
        public RefTarget_JPHWheelSettings? Opt;

        public _InOptMut_RefTarget_JPHWheelSettings() {}
        public _InOptMut_RefTarget_JPHWheelSettings(RefTarget_JPHWheelSettings value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHWheelSettings(RefTarget_JPHWheelSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHWheelSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHWheelSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHWheelSettings`/`Const_RefTarget_JPHWheelSettings` to pass it to the function.
    public class _InOptConst_RefTarget_JPHWheelSettings
    {
        public Const_RefTarget_JPHWheelSettings? Opt;

        public _InOptConst_RefTarget_JPHWheelSettings() {}
        public _InOptConst_RefTarget_JPHWheelSettings(Const_RefTarget_JPHWheelSettings value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHWheelSettings(Const_RefTarget_JPHWheelSettings value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::DebugRenderer::Geometry>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DebugRenderer::Geometry`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHDebugRendererGeometry : JPH.Object<Const_RefTarget_JPHDebugRendererGeometry>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_DebugRenderer_Geometry_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_DebugRenderer_Geometry_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHDebugRendererGeometry() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHDebugRendererGeometry(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHDebugRendererGeometry() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHDebugRendererGeometry._Underlying *__JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::DebugRenderer::Geometry>::RefTarget`.
        public unsafe Const_RefTarget_JPHDebugRendererGeometry(JPH._ByValue_RefTarget_JPHDebugRendererGeometry _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHDebugRendererGeometry._Underlying *__JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHDebugRendererGeometry._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::DebugRenderer::Geometry>::RefTarget`.
        public Const_RefTarget_JPHDebugRendererGeometry(Const_RefTarget_JPHDebugRendererGeometry _other) : this(new _ByValue_RefTarget_JPHDebugRendererGeometry(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::DebugRenderer::Geometry>::RefTarget`.
        public Const_RefTarget_JPHDebugRendererGeometry(RefTarget_JPHDebugRendererGeometry _other) : this((Const_RefTarget_JPHDebugRendererGeometry)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_DebugRenderer_Geometry_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_DebugRenderer_Geometry_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_DebugRenderer_Geometry_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_DebugRenderer_Geometry_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_DebugRenderer_Geometry_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_DebugRenderer_Geometry_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::DebugRenderer::Geometry>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DebugRenderer::Geometry`
    /// This is the non-const half of the class.
    public class RefTarget_JPHDebugRendererGeometry : Const_RefTarget_JPHDebugRendererGeometry
    {
        internal unsafe RefTarget_JPHDebugRendererGeometry(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHDebugRendererGeometry() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHDebugRendererGeometry._Underlying *__JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::DebugRenderer::Geometry>::RefTarget`.
        public unsafe RefTarget_JPHDebugRendererGeometry(JPH._ByValue_RefTarget_JPHDebugRendererGeometry _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHDebugRendererGeometry._Underlying *__JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHDebugRendererGeometry._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::DebugRenderer::Geometry>::RefTarget`.
        public RefTarget_JPHDebugRendererGeometry(Const_RefTarget_JPHDebugRendererGeometry _other) : this(new _ByValue_RefTarget_JPHDebugRendererGeometry(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::DebugRenderer::Geometry>::RefTarget`.
        public RefTarget_JPHDebugRendererGeometry(RefTarget_JPHDebugRendererGeometry _other) : this((Const_RefTarget_JPHDebugRendererGeometry)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::operator=`.
        public unsafe JPH.RefTarget_JPHDebugRendererGeometry Assign(JPH._ByValue_RefTarget_JPHDebugRendererGeometry _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHDebugRendererGeometry._Underlying *__JPH_RefTarget_JPH_DebugRenderer_Geometry_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHDebugRendererGeometry._Underlying *_other);
            JPH.RefTarget_JPHDebugRendererGeometry __ret;
            __ret = new(__JPH_RefTarget_JPH_DebugRenderer_Geometry_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHDebugRendererGeometry` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHDebugRendererGeometry`/`Const_RefTarget_JPHDebugRendererGeometry` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHDebugRendererGeometry
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHDebugRendererGeometry? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHDebugRendererGeometry() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHDebugRendererGeometry(Const_RefTarget_JPHDebugRendererGeometry new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHDebugRendererGeometry(Const_RefTarget_JPHDebugRendererGeometry arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHDebugRendererGeometry` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHDebugRendererGeometry`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHDebugRendererGeometry`/`Const_RefTarget_JPHDebugRendererGeometry` directly.
    public class _InOptMut_RefTarget_JPHDebugRendererGeometry
    {
        public RefTarget_JPHDebugRendererGeometry? Opt;

        public _InOptMut_RefTarget_JPHDebugRendererGeometry() {}
        public _InOptMut_RefTarget_JPHDebugRendererGeometry(RefTarget_JPHDebugRendererGeometry value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHDebugRendererGeometry(RefTarget_JPHDebugRendererGeometry value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHDebugRendererGeometry` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHDebugRendererGeometry`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHDebugRendererGeometry`/`Const_RefTarget_JPHDebugRendererGeometry` to pass it to the function.
    public class _InOptConst_RefTarget_JPHDebugRendererGeometry
    {
        public Const_RefTarget_JPHDebugRendererGeometry? Opt;

        public _InOptConst_RefTarget_JPHDebugRendererGeometry() {}
        public _InOptConst_RefTarget_JPHDebugRendererGeometry(Const_RefTarget_JPHDebugRendererGeometry value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHDebugRendererGeometry(Const_RefTarget_JPHDebugRendererGeometry value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleControllerSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::WheeledVehicleControllerSettings`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHVehicleControllerSettings : JPH.Object<Const_RefTarget_JPHVehicleControllerSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHVehicleControllerSettings() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHVehicleControllerSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHVehicleControllerSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleControllerSettings>::RefTarget`.
        public unsafe Const_RefTarget_JPHVehicleControllerSettings(JPH._ByValue_RefTarget_JPHVehicleControllerSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHVehicleControllerSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleControllerSettings>::RefTarget`.
        public Const_RefTarget_JPHVehicleControllerSettings(Const_RefTarget_JPHVehicleControllerSettings _other) : this(new _ByValue_RefTarget_JPHVehicleControllerSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleControllerSettings>::RefTarget`.
        public Const_RefTarget_JPHVehicleControllerSettings(RefTarget_JPHVehicleControllerSettings _other) : this((Const_RefTarget_JPHVehicleControllerSettings)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_VehicleControllerSettings_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_VehicleControllerSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_VehicleControllerSettings_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_VehicleControllerSettings_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleControllerSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::WheeledVehicleControllerSettings`
    /// This is the non-const half of the class.
    public class RefTarget_JPHVehicleControllerSettings : Const_RefTarget_JPHVehicleControllerSettings
    {
        internal unsafe RefTarget_JPHVehicleControllerSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHVehicleControllerSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleControllerSettings>::RefTarget`.
        public unsafe RefTarget_JPHVehicleControllerSettings(JPH._ByValue_RefTarget_JPHVehicleControllerSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHVehicleControllerSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleControllerSettings>::RefTarget`.
        public RefTarget_JPHVehicleControllerSettings(Const_RefTarget_JPHVehicleControllerSettings _other) : this(new _ByValue_RefTarget_JPHVehicleControllerSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::VehicleControllerSettings>::RefTarget`.
        public RefTarget_JPHVehicleControllerSettings(RefTarget_JPHVehicleControllerSettings _other) : this((Const_RefTarget_JPHVehicleControllerSettings)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::operator=`.
        public unsafe JPH.RefTarget_JPHVehicleControllerSettings Assign(JPH._ByValue_RefTarget_JPHVehicleControllerSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_RefTarget_JPH_VehicleControllerSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHVehicleControllerSettings._Underlying *_other);
            JPH.RefTarget_JPHVehicleControllerSettings __ret;
            __ret = new(__JPH_RefTarget_JPH_VehicleControllerSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHVehicleControllerSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHVehicleControllerSettings`/`Const_RefTarget_JPHVehicleControllerSettings` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHVehicleControllerSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHVehicleControllerSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHVehicleControllerSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHVehicleControllerSettings(Const_RefTarget_JPHVehicleControllerSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHVehicleControllerSettings(Const_RefTarget_JPHVehicleControllerSettings arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHVehicleControllerSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHVehicleControllerSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHVehicleControllerSettings`/`Const_RefTarget_JPHVehicleControllerSettings` directly.
    public class _InOptMut_RefTarget_JPHVehicleControllerSettings
    {
        public RefTarget_JPHVehicleControllerSettings? Opt;

        public _InOptMut_RefTarget_JPHVehicleControllerSettings() {}
        public _InOptMut_RefTarget_JPHVehicleControllerSettings(RefTarget_JPHVehicleControllerSettings value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHVehicleControllerSettings(RefTarget_JPHVehicleControllerSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHVehicleControllerSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHVehicleControllerSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHVehicleControllerSettings`/`Const_RefTarget_JPHVehicleControllerSettings` to pass it to the function.
    public class _InOptConst_RefTarget_JPHVehicleControllerSettings
    {
        public Const_RefTarget_JPHVehicleControllerSettings? Opt;

        public _InOptConst_RefTarget_JPHVehicleControllerSettings() {}
        public _InOptConst_RefTarget_JPHVehicleControllerSettings(Const_RefTarget_JPHVehicleControllerSettings value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHVehicleControllerSettings(Const_RefTarget_JPHVehicleControllerSettings value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::SoftBodySharedSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SoftBodySharedSettings`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHSoftBodySharedSettings : JPH.Object<Const_RefTarget_JPHSoftBodySharedSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SoftBodySharedSettings_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_SoftBodySharedSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHSoftBodySharedSettings() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHSoftBodySharedSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHSoftBodySharedSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *__JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SoftBodySharedSettings>::RefTarget`.
        public unsafe Const_RefTarget_JPHSoftBodySharedSettings(JPH._ByValue_RefTarget_JPHSoftBodySharedSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *__JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SoftBodySharedSettings>::RefTarget`.
        public Const_RefTarget_JPHSoftBodySharedSettings(Const_RefTarget_JPHSoftBodySharedSettings _other) : this(new _ByValue_RefTarget_JPHSoftBodySharedSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::SoftBodySharedSettings>::RefTarget`.
        public Const_RefTarget_JPHSoftBodySharedSettings(RefTarget_JPHSoftBodySharedSettings _other) : this((Const_RefTarget_JPHSoftBodySharedSettings)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SoftBodySharedSettings_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_SoftBodySharedSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_SoftBodySharedSettings_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_SoftBodySharedSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SoftBodySharedSettings_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_SoftBodySharedSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_SoftBodySharedSettings_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_SoftBodySharedSettings_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::SoftBodySharedSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SoftBodySharedSettings`
    /// This is the non-const half of the class.
    public class RefTarget_JPHSoftBodySharedSettings : Const_RefTarget_JPHSoftBodySharedSettings
    {
        internal unsafe RefTarget_JPHSoftBodySharedSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHSoftBodySharedSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *__JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SoftBodySharedSettings>::RefTarget`.
        public unsafe RefTarget_JPHSoftBodySharedSettings(JPH._ByValue_RefTarget_JPHSoftBodySharedSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *__JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SoftBodySharedSettings>::RefTarget`.
        public RefTarget_JPHSoftBodySharedSettings(Const_RefTarget_JPHSoftBodySharedSettings _other) : this(new _ByValue_RefTarget_JPHSoftBodySharedSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::SoftBodySharedSettings>::RefTarget`.
        public RefTarget_JPHSoftBodySharedSettings(RefTarget_JPHSoftBodySharedSettings _other) : this((Const_RefTarget_JPHSoftBodySharedSettings)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::operator=`.
        public unsafe JPH.RefTarget_JPHSoftBodySharedSettings Assign(JPH._ByValue_RefTarget_JPHSoftBodySharedSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *__JPH_RefTarget_JPH_SoftBodySharedSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *_other);
            JPH.RefTarget_JPHSoftBodySharedSettings __ret;
            __ret = new(__JPH_RefTarget_JPH_SoftBodySharedSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHSoftBodySharedSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHSoftBodySharedSettings`/`Const_RefTarget_JPHSoftBodySharedSettings` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHSoftBodySharedSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHSoftBodySharedSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHSoftBodySharedSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHSoftBodySharedSettings(Const_RefTarget_JPHSoftBodySharedSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHSoftBodySharedSettings(Const_RefTarget_JPHSoftBodySharedSettings arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHSoftBodySharedSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHSoftBodySharedSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHSoftBodySharedSettings`/`Const_RefTarget_JPHSoftBodySharedSettings` directly.
    public class _InOptMut_RefTarget_JPHSoftBodySharedSettings
    {
        public RefTarget_JPHSoftBodySharedSettings? Opt;

        public _InOptMut_RefTarget_JPHSoftBodySharedSettings() {}
        public _InOptMut_RefTarget_JPHSoftBodySharedSettings(RefTarget_JPHSoftBodySharedSettings value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHSoftBodySharedSettings(RefTarget_JPHSoftBodySharedSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHSoftBodySharedSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHSoftBodySharedSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHSoftBodySharedSettings`/`Const_RefTarget_JPHSoftBodySharedSettings` to pass it to the function.
    public class _InOptConst_RefTarget_JPHSoftBodySharedSettings
    {
        public Const_RefTarget_JPHSoftBodySharedSettings? Opt;

        public _InOptConst_RefTarget_JPHSoftBodySharedSettings() {}
        public _InOptConst_RefTarget_JPHSoftBodySharedSettings(Const_RefTarget_JPHSoftBodySharedSettings value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHSoftBodySharedSettings(Const_RefTarget_JPHSoftBodySharedSettings value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::Skeleton>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Skeleton`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHSkeleton : JPH.Object<Const_RefTarget_JPHSkeleton>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Skeleton_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_Skeleton_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHSkeleton() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHSkeleton(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHSkeleton() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeleton._Underlying *__JPH_RefTarget_JPH_Skeleton_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_Skeleton_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Skeleton>::RefTarget`.
        public unsafe Const_RefTarget_JPHSkeleton(JPH._ByValue_RefTarget_JPHSkeleton _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeleton._Underlying *__JPH_RefTarget_JPH_Skeleton_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSkeleton._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_Skeleton_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Skeleton>::RefTarget`.
        public Const_RefTarget_JPHSkeleton(Const_RefTarget_JPHSkeleton _other) : this(new _ByValue_RefTarget_JPHSkeleton(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::Skeleton>::RefTarget`.
        public Const_RefTarget_JPHSkeleton(RefTarget_JPHSkeleton _other) : this((Const_RefTarget_JPHSkeleton)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::Skeleton>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Skeleton_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_Skeleton_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::Skeleton>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_Skeleton_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_Skeleton_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::Skeleton>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Skeleton_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_Skeleton_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::Skeleton>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Skeleton_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_Skeleton_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::Skeleton>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_Skeleton_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_Skeleton_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::Skeleton>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Skeleton`
    /// This is the non-const half of the class.
    public class RefTarget_JPHSkeleton : Const_RefTarget_JPHSkeleton
    {
        internal unsafe RefTarget_JPHSkeleton(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHSkeleton() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeleton._Underlying *__JPH_RefTarget_JPH_Skeleton_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_Skeleton_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Skeleton>::RefTarget`.
        public unsafe RefTarget_JPHSkeleton(JPH._ByValue_RefTarget_JPHSkeleton _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeleton._Underlying *__JPH_RefTarget_JPH_Skeleton_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSkeleton._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_Skeleton_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Skeleton>::RefTarget`.
        public RefTarget_JPHSkeleton(Const_RefTarget_JPHSkeleton _other) : this(new _ByValue_RefTarget_JPHSkeleton(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::Skeleton>::RefTarget`.
        public RefTarget_JPHSkeleton(RefTarget_JPHSkeleton _other) : this((Const_RefTarget_JPHSkeleton)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::Skeleton>::operator=`.
        public unsafe JPH.RefTarget_JPHSkeleton Assign(JPH._ByValue_RefTarget_JPHSkeleton _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeleton._Underlying *__JPH_RefTarget_JPH_Skeleton_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSkeleton._Underlying *_other);
            JPH.RefTarget_JPHSkeleton __ret;
            __ret = new(__JPH_RefTarget_JPH_Skeleton_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHSkeleton` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHSkeleton`/`Const_RefTarget_JPHSkeleton` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHSkeleton
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHSkeleton? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHSkeleton() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHSkeleton(Const_RefTarget_JPHSkeleton new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHSkeleton(Const_RefTarget_JPHSkeleton arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHSkeleton` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHSkeleton`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHSkeleton`/`Const_RefTarget_JPHSkeleton` directly.
    public class _InOptMut_RefTarget_JPHSkeleton
    {
        public RefTarget_JPHSkeleton? Opt;

        public _InOptMut_RefTarget_JPHSkeleton() {}
        public _InOptMut_RefTarget_JPHSkeleton(RefTarget_JPHSkeleton value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHSkeleton(RefTarget_JPHSkeleton value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHSkeleton` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHSkeleton`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHSkeleton`/`Const_RefTarget_JPHSkeleton` to pass it to the function.
    public class _InOptConst_RefTarget_JPHSkeleton
    {
        public Const_RefTarget_JPHSkeleton? Opt;

        public _InOptConst_RefTarget_JPHSkeleton() {}
        public _InOptConst_RefTarget_JPHSkeleton(Const_RefTarget_JPHSkeleton value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHSkeleton(Const_RefTarget_JPHSkeleton value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::SkeletalAnimation>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SkeletalAnimation`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHSkeletalAnimation : JPH.Object<Const_RefTarget_JPHSkeletalAnimation>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletalAnimation_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_SkeletalAnimation_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHSkeletalAnimation() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHSkeletalAnimation(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHSkeletalAnimation() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletalAnimation._Underlying *__JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletalAnimation>::RefTarget`.
        public unsafe Const_RefTarget_JPHSkeletalAnimation(JPH._ByValue_RefTarget_JPHSkeletalAnimation _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletalAnimation._Underlying *__JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSkeletalAnimation._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletalAnimation>::RefTarget`.
        public Const_RefTarget_JPHSkeletalAnimation(Const_RefTarget_JPHSkeletalAnimation _other) : this(new _ByValue_RefTarget_JPHSkeletalAnimation(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletalAnimation>::RefTarget`.
        public Const_RefTarget_JPHSkeletalAnimation(RefTarget_JPHSkeletalAnimation _other) : this((Const_RefTarget_JPHSkeletalAnimation)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletalAnimation_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_SkeletalAnimation_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_SkeletalAnimation_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_SkeletalAnimation_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletalAnimation_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_SkeletalAnimation_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_SkeletalAnimation_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_SkeletalAnimation_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::SkeletalAnimation>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SkeletalAnimation`
    /// This is the non-const half of the class.
    public class RefTarget_JPHSkeletalAnimation : Const_RefTarget_JPHSkeletalAnimation
    {
        internal unsafe RefTarget_JPHSkeletalAnimation(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHSkeletalAnimation() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletalAnimation._Underlying *__JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletalAnimation>::RefTarget`.
        public unsafe RefTarget_JPHSkeletalAnimation(JPH._ByValue_RefTarget_JPHSkeletalAnimation _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletalAnimation._Underlying *__JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSkeletalAnimation._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletalAnimation>::RefTarget`.
        public RefTarget_JPHSkeletalAnimation(Const_RefTarget_JPHSkeletalAnimation _other) : this(new _ByValue_RefTarget_JPHSkeletalAnimation(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletalAnimation>::RefTarget`.
        public RefTarget_JPHSkeletalAnimation(RefTarget_JPHSkeletalAnimation _other) : this((Const_RefTarget_JPHSkeletalAnimation)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::operator=`.
        public unsafe JPH.RefTarget_JPHSkeletalAnimation Assign(JPH._ByValue_RefTarget_JPHSkeletalAnimation _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletalAnimation._Underlying *__JPH_RefTarget_JPH_SkeletalAnimation_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSkeletalAnimation._Underlying *_other);
            JPH.RefTarget_JPHSkeletalAnimation __ret;
            __ret = new(__JPH_RefTarget_JPH_SkeletalAnimation_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHSkeletalAnimation` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHSkeletalAnimation`/`Const_RefTarget_JPHSkeletalAnimation` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHSkeletalAnimation
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHSkeletalAnimation? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHSkeletalAnimation() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHSkeletalAnimation(Const_RefTarget_JPHSkeletalAnimation new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHSkeletalAnimation(Const_RefTarget_JPHSkeletalAnimation arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHSkeletalAnimation` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHSkeletalAnimation`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHSkeletalAnimation`/`Const_RefTarget_JPHSkeletalAnimation` directly.
    public class _InOptMut_RefTarget_JPHSkeletalAnimation
    {
        public RefTarget_JPHSkeletalAnimation? Opt;

        public _InOptMut_RefTarget_JPHSkeletalAnimation() {}
        public _InOptMut_RefTarget_JPHSkeletalAnimation(RefTarget_JPHSkeletalAnimation value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHSkeletalAnimation(RefTarget_JPHSkeletalAnimation value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHSkeletalAnimation` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHSkeletalAnimation`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHSkeletalAnimation`/`Const_RefTarget_JPHSkeletalAnimation` to pass it to the function.
    public class _InOptConst_RefTarget_JPHSkeletalAnimation
    {
        public Const_RefTarget_JPHSkeletalAnimation? Opt;

        public _InOptConst_RefTarget_JPHSkeletalAnimation() {}
        public _InOptConst_RefTarget_JPHSkeletalAnimation(Const_RefTarget_JPHSkeletalAnimation value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHSkeletalAnimation(Const_RefTarget_JPHSkeletalAnimation value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::RagdollSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RagdollSettings`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHRagdollSettings : JPH.Object<Const_RefTarget_JPHRagdollSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_RagdollSettings_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_RagdollSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHRagdollSettings() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHRagdollSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHRagdollSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdollSettings._Underlying *__JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::RagdollSettings>::RefTarget`.
        public unsafe Const_RefTarget_JPHRagdollSettings(JPH._ByValue_RefTarget_JPHRagdollSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdollSettings._Underlying *__JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHRagdollSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::RagdollSettings>::RefTarget`.
        public Const_RefTarget_JPHRagdollSettings(Const_RefTarget_JPHRagdollSettings _other) : this(new _ByValue_RefTarget_JPHRagdollSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::RagdollSettings>::RefTarget`.
        public Const_RefTarget_JPHRagdollSettings(RefTarget_JPHRagdollSettings _other) : this((Const_RefTarget_JPHRagdollSettings)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_RagdollSettings_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_RagdollSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_RagdollSettings_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_RagdollSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_RagdollSettings_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_RagdollSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_RagdollSettings_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_RagdollSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_RagdollSettings_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_RagdollSettings_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::RagdollSettings>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RagdollSettings`
    /// This is the non-const half of the class.
    public class RefTarget_JPHRagdollSettings : Const_RefTarget_JPHRagdollSettings
    {
        internal unsafe RefTarget_JPHRagdollSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHRagdollSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdollSettings._Underlying *__JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::RagdollSettings>::RefTarget`.
        public unsafe RefTarget_JPHRagdollSettings(JPH._ByValue_RefTarget_JPHRagdollSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdollSettings._Underlying *__JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHRagdollSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::RagdollSettings>::RefTarget`.
        public RefTarget_JPHRagdollSettings(Const_RefTarget_JPHRagdollSettings _other) : this(new _ByValue_RefTarget_JPHRagdollSettings(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::RagdollSettings>::RefTarget`.
        public RefTarget_JPHRagdollSettings(RefTarget_JPHRagdollSettings _other) : this((Const_RefTarget_JPHRagdollSettings)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::operator=`.
        public unsafe JPH.RefTarget_JPHRagdollSettings Assign(JPH._ByValue_RefTarget_JPHRagdollSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdollSettings._Underlying *__JPH_RefTarget_JPH_RagdollSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHRagdollSettings._Underlying *_other);
            JPH.RefTarget_JPHRagdollSettings __ret;
            __ret = new(__JPH_RefTarget_JPH_RagdollSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHRagdollSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHRagdollSettings`/`Const_RefTarget_JPHRagdollSettings` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHRagdollSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHRagdollSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHRagdollSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHRagdollSettings(Const_RefTarget_JPHRagdollSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHRagdollSettings(Const_RefTarget_JPHRagdollSettings arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHRagdollSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHRagdollSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHRagdollSettings`/`Const_RefTarget_JPHRagdollSettings` directly.
    public class _InOptMut_RefTarget_JPHRagdollSettings
    {
        public RefTarget_JPHRagdollSettings? Opt;

        public _InOptMut_RefTarget_JPHRagdollSettings() {}
        public _InOptMut_RefTarget_JPHRagdollSettings(RefTarget_JPHRagdollSettings value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHRagdollSettings(RefTarget_JPHRagdollSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHRagdollSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHRagdollSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHRagdollSettings`/`Const_RefTarget_JPHRagdollSettings` to pass it to the function.
    public class _InOptConst_RefTarget_JPHRagdollSettings
    {
        public Const_RefTarget_JPHRagdollSettings? Opt;

        public _InOptConst_RefTarget_JPHRagdollSettings() {}
        public _InOptConst_RefTarget_JPHRagdollSettings(Const_RefTarget_JPHRagdollSettings value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHRagdollSettings(Const_RefTarget_JPHRagdollSettings value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::Ragdoll>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Ragdoll`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHRagdoll : JPH.Object<Const_RefTarget_JPHRagdoll>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Ragdoll_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_Ragdoll_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHRagdoll() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHRagdoll(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHRagdoll() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdoll._Underlying *__JPH_RefTarget_JPH_Ragdoll_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_Ragdoll_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Ragdoll>::RefTarget`.
        public unsafe Const_RefTarget_JPHRagdoll(JPH._ByValue_RefTarget_JPHRagdoll _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdoll._Underlying *__JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHRagdoll._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Ragdoll>::RefTarget`.
        public Const_RefTarget_JPHRagdoll(Const_RefTarget_JPHRagdoll _other) : this(new _ByValue_RefTarget_JPHRagdoll(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::Ragdoll>::RefTarget`.
        public Const_RefTarget_JPHRagdoll(RefTarget_JPHRagdoll _other) : this((Const_RefTarget_JPHRagdoll)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::Ragdoll>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Ragdoll_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_Ragdoll_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::Ragdoll>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_Ragdoll_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_Ragdoll_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::Ragdoll>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Ragdoll_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_Ragdoll_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::Ragdoll>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Ragdoll_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_Ragdoll_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::Ragdoll>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_Ragdoll_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_Ragdoll_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::Ragdoll>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Ragdoll`
    /// This is the non-const half of the class.
    public class RefTarget_JPHRagdoll : Const_RefTarget_JPHRagdoll
    {
        internal unsafe RefTarget_JPHRagdoll(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHRagdoll() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdoll._Underlying *__JPH_RefTarget_JPH_Ragdoll_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_Ragdoll_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Ragdoll>::RefTarget`.
        public unsafe RefTarget_JPHRagdoll(JPH._ByValue_RefTarget_JPHRagdoll _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdoll._Underlying *__JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHRagdoll._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::Ragdoll>::RefTarget`.
        public RefTarget_JPHRagdoll(Const_RefTarget_JPHRagdoll _other) : this(new _ByValue_RefTarget_JPHRagdoll(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::Ragdoll>::RefTarget`.
        public RefTarget_JPHRagdoll(RefTarget_JPHRagdoll _other) : this((Const_RefTarget_JPHRagdoll)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::Ragdoll>::operator=`.
        public unsafe JPH.RefTarget_JPHRagdoll Assign(JPH._ByValue_RefTarget_JPHRagdoll _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdoll._Underlying *__JPH_RefTarget_JPH_Ragdoll_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHRagdoll._Underlying *_other);
            JPH.RefTarget_JPHRagdoll __ret;
            __ret = new(__JPH_RefTarget_JPH_Ragdoll_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHRagdoll` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHRagdoll`/`Const_RefTarget_JPHRagdoll` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHRagdoll
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHRagdoll? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHRagdoll() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHRagdoll(Const_RefTarget_JPHRagdoll new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHRagdoll(Const_RefTarget_JPHRagdoll arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHRagdoll` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHRagdoll`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHRagdoll`/`Const_RefTarget_JPHRagdoll` directly.
    public class _InOptMut_RefTarget_JPHRagdoll
    {
        public RefTarget_JPHRagdoll? Opt;

        public _InOptMut_RefTarget_JPHRagdoll() {}
        public _InOptMut_RefTarget_JPHRagdoll(RefTarget_JPHRagdoll value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHRagdoll(RefTarget_JPHRagdoll value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHRagdoll` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHRagdoll`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHRagdoll`/`Const_RefTarget_JPHRagdoll` to pass it to the function.
    public class _InOptConst_RefTarget_JPHRagdoll
    {
        public Const_RefTarget_JPHRagdoll? Opt;

        public _InOptConst_RefTarget_JPHRagdoll() {}
        public _InOptConst_RefTarget_JPHRagdoll(Const_RefTarget_JPHRagdoll value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHRagdoll(Const_RefTarget_JPHRagdoll value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::PathConstraintPath>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PathConstraintPath`
    ///   Indirect: (non-virtual)
    ///     `JPH::PathConstraintPathHermite`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHPathConstraintPath : JPH.Object<Const_RefTarget_JPHPathConstraintPath>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHPathConstraintPath() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHPathConstraintPath(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHPathConstraintPath() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPathConstraintPath._Underlying *__JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::PathConstraintPath>::RefTarget`.
        public unsafe Const_RefTarget_JPHPathConstraintPath(JPH._ByValue_RefTarget_JPHPathConstraintPath _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPathConstraintPath._Underlying *__JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHPathConstraintPath._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::PathConstraintPath>::RefTarget`.
        public Const_RefTarget_JPHPathConstraintPath(Const_RefTarget_JPHPathConstraintPath _other) : this(new _ByValue_RefTarget_JPHPathConstraintPath(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::PathConstraintPath>::RefTarget`.
        public Const_RefTarget_JPHPathConstraintPath(RefTarget_JPHPathConstraintPath _other) : this((Const_RefTarget_JPHPathConstraintPath)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_PathConstraintPath_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_PathConstraintPath_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_PathConstraintPath_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_PathConstraintPath_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::PathConstraintPath>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PathConstraintPath`
    ///   Indirect: (non-virtual)
    ///     `JPH::PathConstraintPathHermite`
    /// This is the non-const half of the class.
    public class RefTarget_JPHPathConstraintPath : Const_RefTarget_JPHPathConstraintPath
    {
        internal unsafe RefTarget_JPHPathConstraintPath(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHPathConstraintPath() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPathConstraintPath._Underlying *__JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::PathConstraintPath>::RefTarget`.
        public unsafe RefTarget_JPHPathConstraintPath(JPH._ByValue_RefTarget_JPHPathConstraintPath _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPathConstraintPath._Underlying *__JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHPathConstraintPath._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::PathConstraintPath>::RefTarget`.
        public RefTarget_JPHPathConstraintPath(Const_RefTarget_JPHPathConstraintPath _other) : this(new _ByValue_RefTarget_JPHPathConstraintPath(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::PathConstraintPath>::RefTarget`.
        public RefTarget_JPHPathConstraintPath(RefTarget_JPHPathConstraintPath _other) : this((Const_RefTarget_JPHPathConstraintPath)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::operator=`.
        public unsafe JPH.RefTarget_JPHPathConstraintPath Assign(JPH._ByValue_RefTarget_JPHPathConstraintPath _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPathConstraintPath._Underlying *__JPH_RefTarget_JPH_PathConstraintPath_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHPathConstraintPath._Underlying *_other);
            JPH.RefTarget_JPHPathConstraintPath __ret;
            __ret = new(__JPH_RefTarget_JPH_PathConstraintPath_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHPathConstraintPath` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHPathConstraintPath`/`Const_RefTarget_JPHPathConstraintPath` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHPathConstraintPath
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHPathConstraintPath? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHPathConstraintPath() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHPathConstraintPath(Const_RefTarget_JPHPathConstraintPath new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHPathConstraintPath(Const_RefTarget_JPHPathConstraintPath arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHPathConstraintPath` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHPathConstraintPath`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHPathConstraintPath`/`Const_RefTarget_JPHPathConstraintPath` directly.
    public class _InOptMut_RefTarget_JPHPathConstraintPath
    {
        public RefTarget_JPHPathConstraintPath? Opt;

        public _InOptMut_RefTarget_JPHPathConstraintPath() {}
        public _InOptMut_RefTarget_JPHPathConstraintPath(RefTarget_JPHPathConstraintPath value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHPathConstraintPath(RefTarget_JPHPathConstraintPath value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHPathConstraintPath` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHPathConstraintPath`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHPathConstraintPath`/`Const_RefTarget_JPHPathConstraintPath` to pass it to the function.
    public class _InOptConst_RefTarget_JPHPathConstraintPath
    {
        public Const_RefTarget_JPHPathConstraintPath? Opt;

        public _InOptConst_RefTarget_JPHPathConstraintPath() {}
        public _InOptConst_RefTarget_JPHPathConstraintPath(Const_RefTarget_JPHPathConstraintPath value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHPathConstraintPath(Const_RefTarget_JPHPathConstraintPath value) {return new(value);}
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::SkeletonMapper>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SkeletonMapper`
    /// This is the const half of the class.
    public class Const_RefTarget_JPHSkeletonMapper : JPH.Object<Const_RefTarget_JPHSkeletonMapper>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletonMapper_Destroy(_Underlying *_this);
            __JPH_RefTarget_JPH_SkeletonMapper_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RefTarget_JPHSkeletonMapper() {Dispose(false);}

        internal unsafe Const_RefTarget_JPHSkeletonMapper(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RefTarget_JPHSkeletonMapper() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletonMapper._Underlying *__JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletonMapper>::RefTarget`.
        public unsafe Const_RefTarget_JPHSkeletonMapper(JPH._ByValue_RefTarget_JPHSkeletonMapper _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletonMapper._Underlying *__JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSkeletonMapper._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletonMapper>::RefTarget`.
        public Const_RefTarget_JPHSkeletonMapper(Const_RefTarget_JPHSkeletonMapper _other) : this(new _ByValue_RefTarget_JPHSkeletonMapper(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletonMapper>::RefTarget`.
        public Const_RefTarget_JPHSkeletonMapper(RefTarget_JPHSkeletonMapper _other) : this((Const_RefTarget_JPHSkeletonMapper)_other) {}

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletonMapper_SetEmbedded(_Underlying *_this);
            __JPH_RefTarget_JPH_SkeletonMapper_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RefTarget_JPH_SkeletonMapper_GetRefCount(_Underlying *_this);
            return __JPH_RefTarget_JPH_SkeletonMapper_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletonMapper_AddRef(_Underlying *_this);
            __JPH_RefTarget_JPH_SkeletonMapper_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletonMapper_Release(_Underlying *_this);
            __JPH_RefTarget_JPH_SkeletonMapper_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RefTarget_JPH_SkeletonMapper_sInternalGetRefCountOffset();
            return __JPH_RefTarget_JPH_SkeletonMapper_sInternalGetRefCountOffset();
        }
    }

    /// Simple class to facilitate reference counting / releasing
    /// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
    ///
    /// Reference counting classes keep an integer which indicates how many references
    /// to the object are active. Reference counting objects are derived from RefTarget
    /// and staT & their life with a reference count of zero. They can then be assigned
    /// to equivalents of pointers (Ref) which will increase the reference count immediately.
    /// If the destructor of Ref is called or another object is assigned to the reference
    /// counting pointer it will decrease the reference count of the object again. If this
    /// reference count becomes zero, the object is destroyed.
    ///
    /// This provides a very powerful mechanism to prevent memory leaks, but also gives
    /// some responsibility to the programmer. The most notable point is that you cannot
    /// have one object reference another and have the other reference the first one
    /// back, because this way the reference count of both objects will never become
    /// lower than 1, resulting in a memory leak. By carefully designing your classes
    /// (and particularly identifying who owns who in the class hierarchy) you can avoid
    /// these problems.
    /// Generated from class `JPH::RefTarget<JPH::SkeletonMapper>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SkeletonMapper`
    /// This is the non-const half of the class.
    public class RefTarget_JPHSkeletonMapper : Const_RefTarget_JPHSkeletonMapper
    {
        internal unsafe RefTarget_JPHSkeletonMapper(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RefTarget_JPHSkeletonMapper() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletonMapper._Underlying *__JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct();
            _UnderlyingPtr = __JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletonMapper>::RefTarget`.
        public unsafe RefTarget_JPHSkeletonMapper(JPH._ByValue_RefTarget_JPHSkeletonMapper _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletonMapper._Underlying *__JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSkeletonMapper._Underlying *_other);
            _UnderlyingPtr = __JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletonMapper>::RefTarget`.
        public RefTarget_JPHSkeletonMapper(Const_RefTarget_JPHSkeletonMapper _other) : this(new _ByValue_RefTarget_JPHSkeletonMapper(_other)) {}

        /// Generated from constructor `JPH::RefTarget<JPH::SkeletonMapper>::RefTarget`.
        public RefTarget_JPHSkeletonMapper(RefTarget_JPHSkeletonMapper _other) : this((Const_RefTarget_JPHSkeletonMapper)_other) {}

        /// Assignment operator
        /// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::operator=`.
        public unsafe JPH.RefTarget_JPHSkeletonMapper Assign(JPH._ByValue_RefTarget_JPHSkeletonMapper _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletonMapper._Underlying *__JPH_RefTarget_JPH_SkeletonMapper_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RefTarget_JPHSkeletonMapper._Underlying *_other);
            JPH.RefTarget_JPHSkeletonMapper __ret;
            __ret = new(__JPH_RefTarget_JPH_SkeletonMapper_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `RefTarget_JPHSkeletonMapper` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RefTarget_JPHSkeletonMapper`/`Const_RefTarget_JPHSkeletonMapper` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RefTarget_JPHSkeletonMapper
    {
        #pragma warning disable CS0649
        internal readonly Const_RefTarget_JPHSkeletonMapper? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RefTarget_JPHSkeletonMapper() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RefTarget_JPHSkeletonMapper(Const_RefTarget_JPHSkeletonMapper new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RefTarget_JPHSkeletonMapper(Const_RefTarget_JPHSkeletonMapper arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHSkeletonMapper` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RefTarget_JPHSkeletonMapper`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHSkeletonMapper`/`Const_RefTarget_JPHSkeletonMapper` directly.
    public class _InOptMut_RefTarget_JPHSkeletonMapper
    {
        public RefTarget_JPHSkeletonMapper? Opt;

        public _InOptMut_RefTarget_JPHSkeletonMapper() {}
        public _InOptMut_RefTarget_JPHSkeletonMapper(RefTarget_JPHSkeletonMapper value) {Opt = value;}
        public static implicit operator _InOptMut_RefTarget_JPHSkeletonMapper(RefTarget_JPHSkeletonMapper value) {return new(value);}
    }

    /// This is used for optional parameters of class `RefTarget_JPHSkeletonMapper` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RefTarget_JPHSkeletonMapper`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RefTarget_JPHSkeletonMapper`/`Const_RefTarget_JPHSkeletonMapper` to pass it to the function.
    public class _InOptConst_RefTarget_JPHSkeletonMapper
    {
        public Const_RefTarget_JPHSkeletonMapper? Opt;

        public _InOptConst_RefTarget_JPHSkeletonMapper() {}
        public _InOptConst_RefTarget_JPHSkeletonMapper(Const_RefTarget_JPHSkeletonMapper value) {Opt = value;}
        public static implicit operator _InOptConst_RefTarget_JPHSkeletonMapper(Const_RefTarget_JPHSkeletonMapper value) {return new(value);}
    }
}
