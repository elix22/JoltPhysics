// machine generated, do not edit
public static partial class JPH
{
    /// An object layer can be mapped to a broadphase layer. Objects with the same broadphase layer will end up in the same sub structure (usually a tree) of the broadphase.
    /// When there are many layers, this reduces the total amount of sub structures the broad phase needs to manage. Usually you want objects that don't collide with each other
    /// in different broad phase layers, but there could be exceptions if objects layers only contain a minor amount of objects so it is not beneficial to give each layer its
    /// own sub structure in the broadphase.
    /// Note: This class requires explicit casting from and to Type to avoid confusion with ObjectLayer
    /// Generated from class `JPH::BroadPhaseLayer`.
    /// This is the const half of the class.
    public class Const_BroadPhaseLayer : JPH.Object<Const_BroadPhaseLayer>, System.IDisposable, System.IEquatable<JPH.Const_BroadPhaseLayer>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BroadPhaseLayer_Destroy(_Underlying *_this);
            __JPH_BroadPhaseLayer_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BroadPhaseLayer() {Dispose(false);}

        internal unsafe Const_BroadPhaseLayer(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BroadPhaseLayer() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayer_DefaultConstruct();
            _UnderlyingPtr = __JPH_BroadPhaseLayer_DefaultConstruct();
        }

        /// Generated from constructor `JPH::BroadPhaseLayer::BroadPhaseLayer`.
        public unsafe Const_BroadPhaseLayer(JPH.Const_BroadPhaseLayer _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayer_ConstructFromAnother(JPH.BroadPhaseLayer._Underlying *_other);
            _UnderlyingPtr = __JPH_BroadPhaseLayer_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::BroadPhaseLayer::BroadPhaseLayer`.
        public Const_BroadPhaseLayer(BroadPhaseLayer _other) : this((Const_BroadPhaseLayer)_other) {}

        /// Generated from constructor `JPH::BroadPhaseLayer::BroadPhaseLayer`.
        public unsafe Const_BroadPhaseLayer(byte inValue) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayer_Construct(byte inValue);
            _UnderlyingPtr = __JPH_BroadPhaseLayer_Construct(inValue);
        }

        /// Generated from conversion operator `JPH::BroadPhaseLayer::operator unsigned char`.
        public static unsafe explicit operator byte(JPH.Const_BroadPhaseLayer _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_ConvertTo_unsigned_char", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_ConvertTo_unsigned_char", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BroadPhaseLayer_ConvertTo_unsigned_char(JPH.Const_BroadPhaseLayer._Underlying *_this);
            return __JPH_BroadPhaseLayer_ConvertTo_unsigned_char(_this._UnderlyingPtr);
        }

        /// Generated from method `JPH::BroadPhaseLayer::operator==`.
        public static unsafe bool operator==(JPH.Const_BroadPhaseLayer _this, JPH.Const_BroadPhaseLayer inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_BroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_BroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_BroadPhaseLayer(JPH.Const_BroadPhaseLayer._Underlying *_this, JPH.Const_BroadPhaseLayer._Underlying *inRHS);
            return __Jolt_equal_JPH_BroadPhaseLayer(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_BroadPhaseLayer _this, JPH.Const_BroadPhaseLayer inRHS)
        {
            return !(_this == inRHS);
        }

        /// Generated from method `JPH::BroadPhaseLayer::operator<`.
        public static unsafe bool operator<(JPH.Const_BroadPhaseLayer _this, JPH.Const_BroadPhaseLayer inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_less_JPH_BroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_less_JPH_BroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_less_JPH_BroadPhaseLayer(JPH.Const_BroadPhaseLayer._Underlying *_this, JPH.Const_BroadPhaseLayer._Underlying *inRHS);
            return __Jolt_less_JPH_BroadPhaseLayer(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator>(JPH.Const_BroadPhaseLayer _this, JPH.Const_BroadPhaseLayer inRHS)
        {
            return inRHS < _this;
        }

        public static unsafe bool operator<=(JPH.Const_BroadPhaseLayer _this, JPH.Const_BroadPhaseLayer inRHS)
        {
            return !(inRHS < _this);
        }

        public static unsafe bool operator>=(JPH.Const_BroadPhaseLayer _this, JPH.Const_BroadPhaseLayer inRHS)
        {
            return !(_this < inRHS);
        }

        /// Generated from method `JPH::BroadPhaseLayer::GetValue`.
        public unsafe byte GetValue()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_GetValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_GetValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BroadPhaseLayer_GetValue(_Underlying *_this);
            return __JPH_BroadPhaseLayer_GetValue(_UnderlyingPtr);
        }

        // IEquatable:

        public bool Equals(JPH.Const_BroadPhaseLayer? inRHS)
        {
            if (inRHS is null)
                return false;
            return this == inRHS;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_BroadPhaseLayer)
                return this == (JPH.Const_BroadPhaseLayer)other;
            return false;
        }
    }

    /// An object layer can be mapped to a broadphase layer. Objects with the same broadphase layer will end up in the same sub structure (usually a tree) of the broadphase.
    /// When there are many layers, this reduces the total amount of sub structures the broad phase needs to manage. Usually you want objects that don't collide with each other
    /// in different broad phase layers, but there could be exceptions if objects layers only contain a minor amount of objects so it is not beneficial to give each layer its
    /// own sub structure in the broadphase.
    /// Note: This class requires explicit casting from and to Type to avoid confusion with ObjectLayer
    /// Generated from class `JPH::BroadPhaseLayer`.
    /// This is the non-const half of the class.
    public class BroadPhaseLayer : Const_BroadPhaseLayer
    {
        internal unsafe BroadPhaseLayer(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BroadPhaseLayer() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayer_DefaultConstruct();
            _UnderlyingPtr = __JPH_BroadPhaseLayer_DefaultConstruct();
        }

        /// Generated from constructor `JPH::BroadPhaseLayer::BroadPhaseLayer`.
        public unsafe BroadPhaseLayer(JPH.Const_BroadPhaseLayer _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayer_ConstructFromAnother(JPH.BroadPhaseLayer._Underlying *_other);
            _UnderlyingPtr = __JPH_BroadPhaseLayer_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::BroadPhaseLayer::BroadPhaseLayer`.
        public BroadPhaseLayer(BroadPhaseLayer _other) : this((Const_BroadPhaseLayer)_other) {}

        /// Generated from constructor `JPH::BroadPhaseLayer::BroadPhaseLayer`.
        public unsafe BroadPhaseLayer(byte inValue) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayer_Construct(byte inValue);
            _UnderlyingPtr = __JPH_BroadPhaseLayer_Construct(inValue);
        }

        /// Generated from method `JPH::BroadPhaseLayer::operator=`.
        public unsafe JPH.BroadPhaseLayer Assign(JPH.Const_BroadPhaseLayer _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayer_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayer_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayer_AssignFromAnother(_Underlying *_this, JPH.BroadPhaseLayer._Underlying *_other);
            JPH.BroadPhaseLayer __ret;
            __ret = new(__JPH_BroadPhaseLayer_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used for optional parameters of class `BroadPhaseLayer` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BroadPhaseLayer`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayer`/`Const_BroadPhaseLayer` directly.
    public class _InOptMut_BroadPhaseLayer
    {
        public BroadPhaseLayer? Opt;

        public _InOptMut_BroadPhaseLayer() {}
        public _InOptMut_BroadPhaseLayer(BroadPhaseLayer value) {Opt = value;}
        public static implicit operator _InOptMut_BroadPhaseLayer(BroadPhaseLayer value) {return new(value);}
    }

    /// This is used for optional parameters of class `BroadPhaseLayer` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BroadPhaseLayer`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayer`/`Const_BroadPhaseLayer` to pass it to the function.
    public class _InOptConst_BroadPhaseLayer
    {
        public Const_BroadPhaseLayer? Opt;

        public _InOptConst_BroadPhaseLayer() {}
        public _InOptConst_BroadPhaseLayer(Const_BroadPhaseLayer value) {Opt = value;}
        public static implicit operator _InOptConst_BroadPhaseLayer(Const_BroadPhaseLayer value) {return new(value);}
    }

    /// Interface that the application should implement to allow mapping object layers to broadphase layers
    /// Generated from class `JPH::BroadPhaseLayerInterface`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerInterfaceTable`
    /// This is the const half of the class.
    public class Const_BroadPhaseLayerInterface : JPH.Object<Const_BroadPhaseLayerInterface>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BroadPhaseLayerInterface_Destroy(_Underlying *_this);
            __JPH_BroadPhaseLayerInterface_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BroadPhaseLayerInterface() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_BroadPhaseLayerInterface self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BroadPhaseLayerInterface(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_BroadPhaseLayerInterface ret = new(__JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BroadPhaseLayerInterface(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Return the number of broadphase layers there are
        /// Generated from method `JPH::BroadPhaseLayerInterface::GetNumBroadPhaseLayers`.
        public unsafe uint GetNumBroadPhaseLayers()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_GetNumBroadPhaseLayers", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_GetNumBroadPhaseLayers", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_BroadPhaseLayerInterface_GetNumBroadPhaseLayers(_Underlying *_this);
            return __JPH_BroadPhaseLayerInterface_GetNumBroadPhaseLayers(_UnderlyingPtr);
        }

        /// Convert an object layer to the corresponding broadphase layer
        /// Generated from method `JPH::BroadPhaseLayerInterface::GetBroadPhaseLayer`.
        public unsafe JPH.BroadPhaseLayer GetBroadPhaseLayer(ushort inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_GetBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_GetBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayerInterface_GetBroadPhaseLayer(_Underlying *_this, ushort inLayer);
            return new(__JPH_BroadPhaseLayerInterface_GetBroadPhaseLayer(_UnderlyingPtr, inLayer), is_owning: true);
        }
    }

    /// Interface that the application should implement to allow mapping object layers to broadphase layers
    /// Generated from class `JPH::BroadPhaseLayerInterface`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerInterfaceTable`
    /// This is the non-const half of the class.
    public class BroadPhaseLayerInterface : Const_BroadPhaseLayerInterface
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(BroadPhaseLayerInterface self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BroadPhaseLayerInterface(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            BroadPhaseLayerInterface ret = new(__JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BroadPhaseLayerInterface(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}
    }

    /// This is used for optional parameters of class `BroadPhaseLayerInterface` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BroadPhaseLayerInterface`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayerInterface`/`Const_BroadPhaseLayerInterface` directly.
    public class _InOptMut_BroadPhaseLayerInterface
    {
        public BroadPhaseLayerInterface? Opt;

        public _InOptMut_BroadPhaseLayerInterface() {}
        public _InOptMut_BroadPhaseLayerInterface(BroadPhaseLayerInterface value) {Opt = value;}
        public static implicit operator _InOptMut_BroadPhaseLayerInterface(BroadPhaseLayerInterface value) {return new(value);}
    }

    /// This is used for optional parameters of class `BroadPhaseLayerInterface` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BroadPhaseLayerInterface`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayerInterface`/`Const_BroadPhaseLayerInterface` to pass it to the function.
    public class _InOptConst_BroadPhaseLayerInterface
    {
        public Const_BroadPhaseLayerInterface? Opt;

        public _InOptConst_BroadPhaseLayerInterface() {}
        public _InOptConst_BroadPhaseLayerInterface(Const_BroadPhaseLayerInterface value) {Opt = value;}
        public static implicit operator _InOptConst_BroadPhaseLayerInterface(Const_BroadPhaseLayerInterface value) {return new(value);}
    }

    /// Class to test if an object can collide with a broadphase layer. Used while finding collision pairs.
    /// Generated from class `JPH::ObjectVsBroadPhaseLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectVsBroadPhaseLayerFilterTable`
    /// This is the const half of the class.
    public class Const_ObjectVsBroadPhaseLayerFilter : JPH.Object<Const_ObjectVsBroadPhaseLayerFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ObjectVsBroadPhaseLayerFilter_Destroy(_Underlying *_this);
            __JPH_ObjectVsBroadPhaseLayerFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ObjectVsBroadPhaseLayerFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_ObjectVsBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ObjectVsBroadPhaseLayerFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_ObjectVsBroadPhaseLayerFilter ret = new(__JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_ObjectVsBroadPhaseLayerFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ObjectVsBroadPhaseLayerFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectVsBroadPhaseLayerFilter._Underlying *__JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct();
        }

        /// Returns true if an object layer should collide with a broadphase layer
        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inLayer1, JPH.Const_BroadPhaseLayer inLayer2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ObjectVsBroadPhaseLayerFilter_ShouldCollide(_Underlying *_this, ushort inLayer1, JPH.BroadPhaseLayer._Underlying *inLayer2);
            return __JPH_ObjectVsBroadPhaseLayerFilter_ShouldCollide(_UnderlyingPtr, inLayer1, inLayer2._UnderlyingPtr) != 0;
        }
    }

    /// Class to test if an object can collide with a broadphase layer. Used while finding collision pairs.
    /// Generated from class `JPH::ObjectVsBroadPhaseLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectVsBroadPhaseLayerFilterTable`
    /// This is the non-const half of the class.
    public class ObjectVsBroadPhaseLayerFilter : Const_ObjectVsBroadPhaseLayerFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(ObjectVsBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator ObjectVsBroadPhaseLayerFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            ObjectVsBroadPhaseLayerFilter ret = new(__JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe ObjectVsBroadPhaseLayerFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ObjectVsBroadPhaseLayerFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectVsBroadPhaseLayerFilter._Underlying *__JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `ObjectVsBroadPhaseLayerFilter` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_ObjectVsBroadPhaseLayerFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_ObjectVsBroadPhaseLayerFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_ObjectVsBroadPhaseLayerFilter() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `ObjectVsBroadPhaseLayerFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ObjectVsBroadPhaseLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectVsBroadPhaseLayerFilter`/`Const_ObjectVsBroadPhaseLayerFilter` directly.
    public class _InOptMut_ObjectVsBroadPhaseLayerFilter
    {
        public ObjectVsBroadPhaseLayerFilter? Opt;

        public _InOptMut_ObjectVsBroadPhaseLayerFilter() {}
        public _InOptMut_ObjectVsBroadPhaseLayerFilter(ObjectVsBroadPhaseLayerFilter value) {Opt = value;}
        public static implicit operator _InOptMut_ObjectVsBroadPhaseLayerFilter(ObjectVsBroadPhaseLayerFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `ObjectVsBroadPhaseLayerFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ObjectVsBroadPhaseLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectVsBroadPhaseLayerFilter`/`Const_ObjectVsBroadPhaseLayerFilter` to pass it to the function.
    public class _InOptConst_ObjectVsBroadPhaseLayerFilter
    {
        public Const_ObjectVsBroadPhaseLayerFilter? Opt;

        public _InOptConst_ObjectVsBroadPhaseLayerFilter() {}
        public _InOptConst_ObjectVsBroadPhaseLayerFilter(Const_ObjectVsBroadPhaseLayerFilter value) {Opt = value;}
        public static implicit operator _InOptConst_ObjectVsBroadPhaseLayerFilter(Const_ObjectVsBroadPhaseLayerFilter value) {return new(value);}
    }

    /// Filter class for broadphase layers
    /// Generated from class `JPH::BroadPhaseLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DefaultBroadPhaseLayerFilter`
    ///     `JPH::SpecifiedBroadPhaseLayerFilter`
    /// This is the const half of the class.
    public class Const_BroadPhaseLayerFilter : JPH.Object<Const_BroadPhaseLayerFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BroadPhaseLayerFilter_Destroy(_Underlying *_this);
            __JPH_BroadPhaseLayerFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BroadPhaseLayerFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_BroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BroadPhaseLayerFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_BroadPhaseLayerFilter ret = new(__JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BroadPhaseLayerFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BroadPhaseLayerFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerFilter._Underlying *__JPH_BroadPhaseLayerFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_BroadPhaseLayerFilter_DefaultConstruct();
        }

        /// Function to filter out broadphase layers when doing collision query test (return true to allow testing against objects with this layer)
        /// Generated from method `JPH::BroadPhaseLayerFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(JPH.Const_BroadPhaseLayer inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BroadPhaseLayerFilter_ShouldCollide(_Underlying *_this, JPH.BroadPhaseLayer._Underlying *inLayer);
            return __JPH_BroadPhaseLayerFilter_ShouldCollide(_UnderlyingPtr, inLayer._UnderlyingPtr) != 0;
        }
    }

    /// Filter class for broadphase layers
    /// Generated from class `JPH::BroadPhaseLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DefaultBroadPhaseLayerFilter`
    ///     `JPH::SpecifiedBroadPhaseLayerFilter`
    /// This is the non-const half of the class.
    public class BroadPhaseLayerFilter : Const_BroadPhaseLayerFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(BroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BroadPhaseLayerFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            BroadPhaseLayerFilter ret = new(__JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BroadPhaseLayerFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BroadPhaseLayerFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerFilter._Underlying *__JPH_BroadPhaseLayerFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_BroadPhaseLayerFilter_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `BroadPhaseLayerFilter` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BroadPhaseLayerFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_BroadPhaseLayerFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_BroadPhaseLayerFilter() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `BroadPhaseLayerFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BroadPhaseLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayerFilter`/`Const_BroadPhaseLayerFilter` directly.
    public class _InOptMut_BroadPhaseLayerFilter
    {
        public BroadPhaseLayerFilter? Opt;

        public _InOptMut_BroadPhaseLayerFilter() {}
        public _InOptMut_BroadPhaseLayerFilter(BroadPhaseLayerFilter value) {Opt = value;}
        public static implicit operator _InOptMut_BroadPhaseLayerFilter(BroadPhaseLayerFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `BroadPhaseLayerFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BroadPhaseLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayerFilter`/`Const_BroadPhaseLayerFilter` to pass it to the function.
    public class _InOptConst_BroadPhaseLayerFilter
    {
        public Const_BroadPhaseLayerFilter? Opt;

        public _InOptConst_BroadPhaseLayerFilter() {}
        public _InOptConst_BroadPhaseLayerFilter(Const_BroadPhaseLayerFilter value) {Opt = value;}
        public static implicit operator _InOptConst_BroadPhaseLayerFilter(Const_BroadPhaseLayerFilter value) {return new(value);}
    }

    /// Default filter class that uses the pair filter in combination with a specified layer to filter layers
    /// Generated from class `JPH::DefaultBroadPhaseLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_DefaultBroadPhaseLayerFilter : JPH.Object<Const_DefaultBroadPhaseLayerFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DefaultBroadPhaseLayerFilter_Destroy(_Underlying *_this);
            __JPH_DefaultBroadPhaseLayerFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_DefaultBroadPhaseLayerFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_DefaultBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BroadPhaseLayerFilter(Const_DefaultBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseLayerFilter._Underlying *__JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(_Underlying *_this);
            JPH.Const_BroadPhaseLayerFilter ret = new(__JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_DefaultBroadPhaseLayerFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_DefaultBroadPhaseLayerFilter ret = new(__JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_DefaultBroadPhaseLayerFilter(JPH.Const_BroadPhaseLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(JPH.Const_BroadPhaseLayerFilter._Underlying *_this);
            Const_DefaultBroadPhaseLayerFilter ret = new(__JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_DefaultBroadPhaseLayerFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::DefaultBroadPhaseLayerFilter::DefaultBroadPhaseLayerFilter`.
        public unsafe Const_DefaultBroadPhaseLayerFilter(JPH.Const_ObjectVsBroadPhaseLayerFilter inObjectVsBroadPhaseLayerFilter, ushort inLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DefaultBroadPhaseLayerFilter._Underlying *__JPH_DefaultBroadPhaseLayerFilter_Construct(JPH.Const_ObjectVsBroadPhaseLayerFilter._Underlying *inObjectVsBroadPhaseLayerFilter, ushort inLayer);
            _UnderlyingPtr = __JPH_DefaultBroadPhaseLayerFilter_Construct(inObjectVsBroadPhaseLayerFilter._UnderlyingPtr, inLayer);
        }

        // See BroadPhaseLayerFilter::ShouldCollide
        /// Generated from method `JPH::DefaultBroadPhaseLayerFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(JPH.Const_BroadPhaseLayer inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_DefaultBroadPhaseLayerFilter_ShouldCollide(_Underlying *_this, JPH.BroadPhaseLayer._Underlying *inLayer);
            return __JPH_DefaultBroadPhaseLayerFilter_ShouldCollide(_UnderlyingPtr, inLayer._UnderlyingPtr) != 0;
        }
    }

    /// Default filter class that uses the pair filter in combination with a specified layer to filter layers
    /// Generated from class `JPH::DefaultBroadPhaseLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class DefaultBroadPhaseLayerFilter : Const_DefaultBroadPhaseLayerFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(DefaultBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.BroadPhaseLayerFilter(DefaultBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerFilter._Underlying *__JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(_Underlying *_this);
            JPH.BroadPhaseLayerFilter ret = new(__JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator DefaultBroadPhaseLayerFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            DefaultBroadPhaseLayerFilter ret = new(__JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator DefaultBroadPhaseLayerFilter(JPH.BroadPhaseLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(JPH.BroadPhaseLayerFilter._Underlying *_this);
            DefaultBroadPhaseLayerFilter ret = new(__JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe DefaultBroadPhaseLayerFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::DefaultBroadPhaseLayerFilter::DefaultBroadPhaseLayerFilter`.
        public unsafe DefaultBroadPhaseLayerFilter(JPH.Const_ObjectVsBroadPhaseLayerFilter inObjectVsBroadPhaseLayerFilter, ushort inLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultBroadPhaseLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DefaultBroadPhaseLayerFilter._Underlying *__JPH_DefaultBroadPhaseLayerFilter_Construct(JPH.Const_ObjectVsBroadPhaseLayerFilter._Underlying *inObjectVsBroadPhaseLayerFilter, ushort inLayer);
            _UnderlyingPtr = __JPH_DefaultBroadPhaseLayerFilter_Construct(inObjectVsBroadPhaseLayerFilter._UnderlyingPtr, inLayer);
        }
    }

    /// This is used for optional parameters of class `DefaultBroadPhaseLayerFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_DefaultBroadPhaseLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DefaultBroadPhaseLayerFilter`/`Const_DefaultBroadPhaseLayerFilter` directly.
    public class _InOptMut_DefaultBroadPhaseLayerFilter
    {
        public DefaultBroadPhaseLayerFilter? Opt;

        public _InOptMut_DefaultBroadPhaseLayerFilter() {}
        public _InOptMut_DefaultBroadPhaseLayerFilter(DefaultBroadPhaseLayerFilter value) {Opt = value;}
        public static implicit operator _InOptMut_DefaultBroadPhaseLayerFilter(DefaultBroadPhaseLayerFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `DefaultBroadPhaseLayerFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_DefaultBroadPhaseLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DefaultBroadPhaseLayerFilter`/`Const_DefaultBroadPhaseLayerFilter` to pass it to the function.
    public class _InOptConst_DefaultBroadPhaseLayerFilter
    {
        public Const_DefaultBroadPhaseLayerFilter? Opt;

        public _InOptConst_DefaultBroadPhaseLayerFilter() {}
        public _InOptConst_DefaultBroadPhaseLayerFilter(Const_DefaultBroadPhaseLayerFilter value) {Opt = value;}
        public static implicit operator _InOptConst_DefaultBroadPhaseLayerFilter(Const_DefaultBroadPhaseLayerFilter value) {return new(value);}
    }

    /// Allows objects from a specific broad phase layer only
    /// Generated from class `JPH::SpecifiedBroadPhaseLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_SpecifiedBroadPhaseLayerFilter : JPH.Object<Const_SpecifiedBroadPhaseLayerFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SpecifiedBroadPhaseLayerFilter_Destroy(_Underlying *_this);
            __JPH_SpecifiedBroadPhaseLayerFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SpecifiedBroadPhaseLayerFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_SpecifiedBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BroadPhaseLayerFilter(Const_SpecifiedBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseLayerFilter._Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(_Underlying *_this);
            JPH.Const_BroadPhaseLayerFilter ret = new(__JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_SpecifiedBroadPhaseLayerFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_SpecifiedBroadPhaseLayerFilter ret = new(__JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_SpecifiedBroadPhaseLayerFilter(JPH.Const_BroadPhaseLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(JPH.Const_BroadPhaseLayerFilter._Underlying *_this);
            Const_SpecifiedBroadPhaseLayerFilter ret = new(__JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_SpecifiedBroadPhaseLayerFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::SpecifiedBroadPhaseLayerFilter::SpecifiedBroadPhaseLayerFilter`.
        public unsafe Const_SpecifiedBroadPhaseLayerFilter(JPH.Const_BroadPhaseLayer inLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpecifiedBroadPhaseLayerFilter._Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_Construct(JPH.BroadPhaseLayer._Underlying *inLayer);
            _UnderlyingPtr = __JPH_SpecifiedBroadPhaseLayerFilter_Construct(inLayer._UnderlyingPtr);
        }

        // See BroadPhaseLayerFilter::ShouldCollide
        /// Generated from method `JPH::SpecifiedBroadPhaseLayerFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(JPH.Const_BroadPhaseLayer inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SpecifiedBroadPhaseLayerFilter_ShouldCollide(_Underlying *_this, JPH.BroadPhaseLayer._Underlying *inLayer);
            return __JPH_SpecifiedBroadPhaseLayerFilter_ShouldCollide(_UnderlyingPtr, inLayer._UnderlyingPtr) != 0;
        }
    }

    /// Allows objects from a specific broad phase layer only
    /// Generated from class `JPH::SpecifiedBroadPhaseLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class SpecifiedBroadPhaseLayerFilter : Const_SpecifiedBroadPhaseLayerFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(SpecifiedBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.BroadPhaseLayerFilter(SpecifiedBroadPhaseLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerFilter._Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(_Underlying *_this);
            JPH.BroadPhaseLayerFilter ret = new(__JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator SpecifiedBroadPhaseLayerFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            SpecifiedBroadPhaseLayerFilter ret = new(__JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator SpecifiedBroadPhaseLayerFilter(JPH.BroadPhaseLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(JPH.BroadPhaseLayerFilter._Underlying *_this);
            SpecifiedBroadPhaseLayerFilter ret = new(__JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe SpecifiedBroadPhaseLayerFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::SpecifiedBroadPhaseLayerFilter::SpecifiedBroadPhaseLayerFilter`.
        public unsafe SpecifiedBroadPhaseLayerFilter(JPH.Const_BroadPhaseLayer inLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedBroadPhaseLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpecifiedBroadPhaseLayerFilter._Underlying *__JPH_SpecifiedBroadPhaseLayerFilter_Construct(JPH.BroadPhaseLayer._Underlying *inLayer);
            _UnderlyingPtr = __JPH_SpecifiedBroadPhaseLayerFilter_Construct(inLayer._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `SpecifiedBroadPhaseLayerFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SpecifiedBroadPhaseLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SpecifiedBroadPhaseLayerFilter`/`Const_SpecifiedBroadPhaseLayerFilter` directly.
    public class _InOptMut_SpecifiedBroadPhaseLayerFilter
    {
        public SpecifiedBroadPhaseLayerFilter? Opt;

        public _InOptMut_SpecifiedBroadPhaseLayerFilter() {}
        public _InOptMut_SpecifiedBroadPhaseLayerFilter(SpecifiedBroadPhaseLayerFilter value) {Opt = value;}
        public static implicit operator _InOptMut_SpecifiedBroadPhaseLayerFilter(SpecifiedBroadPhaseLayerFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `SpecifiedBroadPhaseLayerFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SpecifiedBroadPhaseLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SpecifiedBroadPhaseLayerFilter`/`Const_SpecifiedBroadPhaseLayerFilter` to pass it to the function.
    public class _InOptConst_SpecifiedBroadPhaseLayerFilter
    {
        public Const_SpecifiedBroadPhaseLayerFilter? Opt;

        public _InOptConst_SpecifiedBroadPhaseLayerFilter() {}
        public _InOptConst_SpecifiedBroadPhaseLayerFilter(Const_SpecifiedBroadPhaseLayerFilter value) {Opt = value;}
        public static implicit operator _InOptConst_SpecifiedBroadPhaseLayerFilter(Const_SpecifiedBroadPhaseLayerFilter value) {return new(value);}
    }
}
