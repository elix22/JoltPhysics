// machine generated, do not edit
public static partial class JPH
{
    /// Class that constructs a TaperedCylinderShape
    /// Generated from class `JPH::TaperedCylinderShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the const half of the class.
    public class Const_TaperedCylinderShapeSettings : JPH.Object<Const_TaperedCylinderShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_Release(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_Release(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TaperedCylinderShapeSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_TaperedCylinderShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(Const_TaperedCylinderShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeSettings(Const_TaperedCylinderShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_ShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConvexShapeSettings(Const_TaperedCylinderShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ConvexShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings(_Underlying *_this);
            JPH.Const_ConvexShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TaperedCylinderShapeSettings(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_TaperedCylinderShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TaperedCylinderShapeSettings(JPH.Const_RefTarget_JPHShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH.Const_RefTarget_JPHShapeSettings._Underlying *_this);
            Const_TaperedCylinderShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TaperedCylinderShapeSettings(JPH.Const_ShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(JPH.Const_ShapeSettings._Underlying *_this);
            Const_TaperedCylinderShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TaperedCylinderShapeSettings(JPH.Const_ConvexShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(JPH.Const_ConvexShapeSettings._Underlying *_this);
            Const_TaperedCylinderShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public unsafe float mHalfHeight
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_Get_mHalfHeight(_Underlying *_this);
                return *__JPH_TaperedCylinderShapeSettings_Get_mHalfHeight(_UnderlyingPtr);
            }
        }

        public unsafe float mTopRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_Get_mTopRadius(_Underlying *_this);
                return *__JPH_TaperedCylinderShapeSettings_Get_mTopRadius(_UnderlyingPtr);
            }
        }

        public unsafe float mBottomRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_Get_mBottomRadius(_Underlying *_this);
                return *__JPH_TaperedCylinderShapeSettings_Get_mBottomRadius(_UnderlyingPtr);
            }
        }

        public unsafe float mConvexRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_Get_mConvexRadius(_Underlying *_this);
                return *__JPH_TaperedCylinderShapeSettings_Get_mConvexRadius(_UnderlyingPtr);
            }
        }

        ///< Uniform density of the interior of the convex object (kg / m^3)
        public unsafe float mDensity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_Get_mDensity(_Underlying *_this);
                return *__JPH_TaperedCylinderShapeSettings_Get_mDensity(_UnderlyingPtr);
            }
        }

        /// User data (to be used freely by the application)
        public unsafe ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_TaperedCylinderShapeSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_TaperedCylinderShapeSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_TaperedCylinderShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_TaperedCylinderShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TaperedCylinderShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_TaperedCylinderShapeSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
        public unsafe Const_TaperedCylinderShapeSettings(JPH._ByValue_TaperedCylinderShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TaperedCylinderShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.TaperedCylinderShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_TaperedCylinderShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
        public Const_TaperedCylinderShapeSettings(Const_TaperedCylinderShapeSettings _other) : this(new _ByValue_TaperedCylinderShapeSettings(_other)) {}

        /// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
        public Const_TaperedCylinderShapeSettings(TaperedCylinderShapeSettings _other) : this((Const_TaperedCylinderShapeSettings)_other) {}

        /// Create a tapered cylinder centered around the origin with bottom at (0, -inHalfHeightOfTaperedCylinder, 0) with radius inBottomRadius and top at (0, inHalfHeightOfTaperedCylinder, 0) with radius inTopRadius
        /// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
        /// Parameter `inConvexRadius` defaults to `cDefaultConvexRadius`.
        public unsafe Const_TaperedCylinderShapeSettings(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, float? inConvexRadius = null, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TaperedCylinderShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_Construct(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, float *inConvexRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            float __deref_inConvexRadius = inConvexRadius.GetValueOrDefault();
            _UnderlyingPtr = __JPH_TaperedCylinderShapeSettings_Construct(inHalfHeightOfTaperedCylinder, inTopRadius, inBottomRadius, inConvexRadius.HasValue ? &__deref_inConvexRadius : null, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TaperedCylinderShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TaperedCylinderShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TaperedCylinderShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_TaperedCylinderShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TaperedCylinderShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TaperedCylinderShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TaperedCylinderShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_TaperedCylinderShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::TaperedCylinderShapeSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShapeSettings_SetEmbedded(_Underlying *_this);
            __JPH_TaperedCylinderShapeSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::TaperedCylinderShapeSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_TaperedCylinderShapeSettings_GetRefCount(_Underlying *_this);
            return __JPH_TaperedCylinderShapeSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::TaperedCylinderShapeSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShapeSettings_AddRef(_Underlying *_this);
            __JPH_TaperedCylinderShapeSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShapeSettings_Release(_Underlying *_this);
            __JPH_TaperedCylinderShapeSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::TaperedCylinderShapeSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_TaperedCylinderShapeSettings_sInternalGetRefCountOffset();
            return __JPH_TaperedCylinderShapeSettings_sInternalGetRefCountOffset();
        }
    }

    /// Class that constructs a TaperedCylinderShape
    /// Generated from class `JPH::TaperedCylinderShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the non-const half of the class.
    public class TaperedCylinderShapeSettings : Const_TaperedCylinderShapeSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(TaperedCylinderShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_SerializableObject(TaperedCylinderShapeSettings self)
            => (JPH.Const_SerializableObject)(JPH.Const_TaperedCylinderShapeSettings)self;
        public static unsafe implicit operator JPH.RefTarget_JPHShapeSettings(TaperedCylinderShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.RefTarget_JPHShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(TaperedCylinderShapeSettings self)
            => (JPH.Const_RefTarget_JPHShapeSettings)(JPH.Const_TaperedCylinderShapeSettings)self;
        public static unsafe implicit operator JPH.ShapeSettings(TaperedCylinderShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.ShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeSettings(TaperedCylinderShapeSettings self)
            => (JPH.Const_ShapeSettings)(JPH.Const_TaperedCylinderShapeSettings)self;
        public static unsafe implicit operator JPH.ConvexShapeSettings(TaperedCylinderShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings(_Underlying *_this);
            JPH.ConvexShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConvexShapeSettings(TaperedCylinderShapeSettings self)
            => (JPH.Const_ConvexShapeSettings)(JPH.Const_TaperedCylinderShapeSettings)self;

        // Downcasts:
        public static unsafe explicit operator TaperedCylinderShapeSettings(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            TaperedCylinderShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TaperedCylinderShapeSettings(JPH.RefTarget_JPHShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH.RefTarget_JPHShapeSettings._Underlying *_this);
            TaperedCylinderShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TaperedCylinderShapeSettings(JPH.ShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(JPH.ShapeSettings._Underlying *_this);
            TaperedCylinderShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TaperedCylinderShapeSettings(JPH.ConvexShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(JPH.ConvexShapeSettings._Underlying *_this);
            TaperedCylinderShapeSettings ret = new(__JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public new unsafe ref float mHalfHeight
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_GetMutable_mHalfHeight(_Underlying *_this);
                return ref *__JPH_TaperedCylinderShapeSettings_GetMutable_mHalfHeight(_UnderlyingPtr);
            }
        }

        public new unsafe ref float mTopRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_GetMutable_mTopRadius(_Underlying *_this);
                return ref *__JPH_TaperedCylinderShapeSettings_GetMutable_mTopRadius(_UnderlyingPtr);
            }
        }

        public new unsafe ref float mBottomRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_GetMutable_mBottomRadius(_Underlying *_this);
                return ref *__JPH_TaperedCylinderShapeSettings_GetMutable_mBottomRadius(_UnderlyingPtr);
            }
        }

        public new unsafe ref float mConvexRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_GetMutable_mConvexRadius(_Underlying *_this);
                return ref *__JPH_TaperedCylinderShapeSettings_GetMutable_mConvexRadius(_UnderlyingPtr);
            }
        }

        ///< Uniform density of the interior of the convex object (kg / m^3)
        public new unsafe ref float mDensity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TaperedCylinderShapeSettings_GetMutable_mDensity(_Underlying *_this);
                return ref *__JPH_TaperedCylinderShapeSettings_GetMutable_mDensity(_UnderlyingPtr);
            }
        }

        /// User data (to be used freely by the application)
        public new unsafe ref ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_TaperedCylinderShapeSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_TaperedCylinderShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe TaperedCylinderShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe TaperedCylinderShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TaperedCylinderShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_TaperedCylinderShapeSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
        public unsafe TaperedCylinderShapeSettings(JPH._ByValue_TaperedCylinderShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TaperedCylinderShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.TaperedCylinderShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_TaperedCylinderShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
        public TaperedCylinderShapeSettings(Const_TaperedCylinderShapeSettings _other) : this(new _ByValue_TaperedCylinderShapeSettings(_other)) {}

        /// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
        public TaperedCylinderShapeSettings(TaperedCylinderShapeSettings _other) : this((Const_TaperedCylinderShapeSettings)_other) {}

        /// Create a tapered cylinder centered around the origin with bottom at (0, -inHalfHeightOfTaperedCylinder, 0) with radius inBottomRadius and top at (0, inHalfHeightOfTaperedCylinder, 0) with radius inTopRadius
        /// Generated from constructor `JPH::TaperedCylinderShapeSettings::TaperedCylinderShapeSettings`.
        /// Parameter `inConvexRadius` defaults to `cDefaultConvexRadius`.
        public unsafe TaperedCylinderShapeSettings(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, float? inConvexRadius = null, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TaperedCylinderShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_Construct(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, float *inConvexRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            float __deref_inConvexRadius = inConvexRadius.GetValueOrDefault();
            _UnderlyingPtr = __JPH_TaperedCylinderShapeSettings_Construct(inHalfHeightOfTaperedCylinder, inTopRadius, inBottomRadius, inConvexRadius.HasValue ? &__deref_inConvexRadius : null, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from method `JPH::TaperedCylinderShapeSettings::operator=`.
        public unsafe JPH.TaperedCylinderShapeSettings Assign(JPH._ByValue_TaperedCylinderShapeSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TaperedCylinderShapeSettings._Underlying *__JPH_TaperedCylinderShapeSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.TaperedCylinderShapeSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_TaperedCylinderShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Set the density of the object in kg / m^3
        /// Generated from method `JPH::TaperedCylinderShapeSettings::SetDensity`.
        public unsafe void SetDensity(float inDensity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShapeSettings_SetDensity(_Underlying *_this, float inDensity);
            __JPH_TaperedCylinderShapeSettings_SetDensity(_UnderlyingPtr, inDensity);
        }

        /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
        /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
        /// Generated from method `JPH::TaperedCylinderShapeSettings::ClearCachedResult`.
        public unsafe void ClearCachedResult()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShapeSettings_ClearCachedResult(_Underlying *_this);
            __JPH_TaperedCylinderShapeSettings_ClearCachedResult(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `TaperedCylinderShapeSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `TaperedCylinderShapeSettings`/`Const_TaperedCylinderShapeSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_TaperedCylinderShapeSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_TaperedCylinderShapeSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_TaperedCylinderShapeSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_TaperedCylinderShapeSettings(Const_TaperedCylinderShapeSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_TaperedCylinderShapeSettings(Const_TaperedCylinderShapeSettings arg) {return new(arg);}
        public _ByValue_TaperedCylinderShapeSettings(JPH._Moved<TaperedCylinderShapeSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_TaperedCylinderShapeSettings(JPH._Moved<TaperedCylinderShapeSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `TaperedCylinderShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TaperedCylinderShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TaperedCylinderShapeSettings`/`Const_TaperedCylinderShapeSettings` directly.
    public class _InOptMut_TaperedCylinderShapeSettings
    {
        public TaperedCylinderShapeSettings? Opt;

        public _InOptMut_TaperedCylinderShapeSettings() {}
        public _InOptMut_TaperedCylinderShapeSettings(TaperedCylinderShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_TaperedCylinderShapeSettings(TaperedCylinderShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `TaperedCylinderShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TaperedCylinderShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TaperedCylinderShapeSettings`/`Const_TaperedCylinderShapeSettings` to pass it to the function.
    public class _InOptConst_TaperedCylinderShapeSettings
    {
        public Const_TaperedCylinderShapeSettings? Opt;

        public _InOptConst_TaperedCylinderShapeSettings() {}
        public _InOptConst_TaperedCylinderShapeSettings(Const_TaperedCylinderShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_TaperedCylinderShapeSettings(Const_TaperedCylinderShapeSettings value) {return new(value);}
    }

    /// A cylinder with different top and bottom radii
    /// Generated from class `JPH::TaperedCylinderShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the const half of the class.
    public class Const_TaperedCylinderShape : JPH.Object<Const_TaperedCylinderShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_Release(void *_this);
            __JPH_RefTarget_JPH_Shape_Release(__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TaperedCylinderShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(Const_TaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShape._Underlying *__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.Const_RefTarget_JPHShape ret = new(__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_TaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Shape(Const_TaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_TaperedCylinderShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Const_Shape ret = new(__JPH_TaperedCylinderShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConvexShape(Const_TaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ConvexShape._Underlying *__JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape(_Underlying *_this);
            JPH.Const_ConvexShape ret = new(__JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TaperedCylinderShape(JPH.Const_RefTarget_JPHShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH.Const_RefTarget_JPHShape._Underlying *_this);
            Const_TaperedCylinderShape ret = new(__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TaperedCylinderShape(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_TaperedCylinderShape ret = new(__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TaperedCylinderShape(JPH.Const_Shape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape(JPH.Const_Shape._Underlying *_this);
            Const_TaperedCylinderShape ret = new(__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TaperedCylinderShape(JPH.Const_ConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape(JPH.Const_ConvexShape._Underlying *_this);
            Const_TaperedCylinderShape ret = new(__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
        public static unsafe int CGetTrianglesMinTrianglesRequested
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_TaperedCylinderShape_Get_cGetTrianglesMinTrianglesRequested();
                return *__JPH_TaperedCylinderShape_Get_cGetTrianglesMinTrianglesRequested();
            }
        }

        /// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
        public static unsafe ref bool SDrawSubmergedVolumes
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetMutable_sDrawSubmergedVolumes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetMutable_sDrawSubmergedVolumes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_TaperedCylinderShape_GetMutable_sDrawSubmergedVolumes();
                return ref *__JPH_TaperedCylinderShape_GetMutable_sDrawSubmergedVolumes();
            }
        }

        internal unsafe Const_TaperedCylinderShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_TaperedCylinderShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TaperedCylinderShape._Underlying *__JPH_TaperedCylinderShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_TaperedCylinderShape_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TaperedCylinderShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TaperedCylinderShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TaperedCylinderShape_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_TaperedCylinderShape_size_t(inCount);
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TaperedCylinderShape_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TaperedCylinderShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TaperedCylinderShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_TaperedCylinderShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCylinderShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCylinderShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TaperedCylinderShape_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_TaperedCylinderShape_size_t(inCount);
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TaperedCylinderShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TaperedCylinderShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TaperedCylinderShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_TaperedCylinderShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCylinderShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TaperedCylinderShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TaperedCylinderShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCylinderShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCylinderShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TaperedCylinderShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_TaperedCylinderShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TaperedCylinderShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Get top radius of the tapered cylinder
        /// Generated from method `JPH::TaperedCylinderShape::GetTopRadius`.
        public unsafe float GetTopRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TaperedCylinderShape_GetTopRadius(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetTopRadius(_UnderlyingPtr);
        }

        /// Get bottom radius of the tapered cylinder
        /// Generated from method `JPH::TaperedCylinderShape::GetBottomRadius`.
        public unsafe float GetBottomRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TaperedCylinderShape_GetBottomRadius(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetBottomRadius(_UnderlyingPtr);
        }

        /// Get convex radius of the tapered cylinder
        /// Generated from method `JPH::TaperedCylinderShape::GetConvexRadius`.
        public unsafe float GetConvexRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TaperedCylinderShape_GetConvexRadius(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetConvexRadius(_UnderlyingPtr);
        }

        /// Get half height of the tapered cylinder
        /// Generated from method `JPH::TaperedCylinderShape::GetHalfHeight`.
        public unsafe float GetHalfHeight()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TaperedCylinderShape_GetHalfHeight(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetHalfHeight(_UnderlyingPtr);
        }

        // See Shape::GetCenterOfMass
        /// Generated from method `JPH::TaperedCylinderShape::GetCenterOfMass`.
        public unsafe JPH.Vec3 GetCenterOfMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TaperedCylinderShape_GetCenterOfMass(_Underlying *_this);
            return new(__JPH_TaperedCylinderShape_GetCenterOfMass(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetLocalBounds
        /// Generated from method `JPH::TaperedCylinderShape::GetLocalBounds`.
        public unsafe JPH.AABox GetLocalBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_TaperedCylinderShape_GetLocalBounds(_Underlying *_this);
            return new(__JPH_TaperedCylinderShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetInnerRadius
        /// Generated from method `JPH::TaperedCylinderShape::GetInnerRadius`.
        public unsafe float GetInnerRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TaperedCylinderShape_GetInnerRadius(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetInnerRadius(_UnderlyingPtr);
        }

        // See Shape::GetSurfaceNormal
        /// Generated from method `JPH::TaperedCylinderShape::GetSurfaceNormal`.
        public unsafe JPH.Vec3 GetSurfaceNormal(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inLocalSurfacePosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TaperedCylinderShape_GetSurfaceNormal(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inLocalSurfacePosition);
            return new(__JPH_TaperedCylinderShape_GetSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inLocalSurfacePosition._UnderlyingPtr), is_owning: true);
        }

        // See ConvexShape::GetSupportFunction
        /// Generated from method `JPH::TaperedCylinderShape::GetSupportFunction`.
        public unsafe JPH.ConvexShape.Const_Support? GetSupportFunction(JPH.ConvexShape.ESupportMode inMode, JPH.ConvexShape.SupportBuffer inBuffer, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexShape.Const_Support._Underlying *__JPH_TaperedCylinderShape_GetSupportFunction(_Underlying *_this, JPH.ConvexShape.ESupportMode inMode, JPH.ConvexShape.SupportBuffer._Underlying *inBuffer, JPH.Vec3._Underlying *inScale);
            var __c_ret = __JPH_TaperedCylinderShape_GetSupportFunction(_UnderlyingPtr, inMode, inBuffer._UnderlyingPtr, inScale._UnderlyingPtr);
            return __c_ret is not null ? new JPH.ConvexShape.Const_Support(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetTrianglesStart
        /// Generated from method `JPH::TaperedCylinderShape::GetTrianglesStart`.
        public unsafe void GetTrianglesStart(JPH.Shape.GetTrianglesContext ioContext, JPH.Const_AABox inBox, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_GetTrianglesStart(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, JPH.Const_AABox._Underlying *inBox, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale);
            __JPH_TaperedCylinderShape_GetTrianglesStart(_UnderlyingPtr, ioContext._UnderlyingPtr, inBox._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        // See Shape::GetTrianglesNext
        /// Generated from method `JPH::TaperedCylinderShape::GetTrianglesNext`.
        public unsafe int GetTrianglesNext(JPH.Shape.GetTrianglesContext ioContext, int inMaxTrianglesRequested, JPH.Float3? outTriangleVertices, void **outMaterials = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_TaperedCylinderShape_GetTrianglesNext(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, int inMaxTrianglesRequested, JPH.Float3._Underlying *outTriangleVertices, void **outMaterials);
            return __JPH_TaperedCylinderShape_GetTrianglesNext(_UnderlyingPtr, ioContext._UnderlyingPtr, inMaxTrianglesRequested, outTriangleVertices is not null ? outTriangleVertices._UnderlyingPtr : null, outMaterials);
        }

        // See Shape::Draw
        /// Generated from method `JPH::TaperedCylinderShape::Draw`.
        public unsafe void Draw(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Color inColor, bool inUseMaterialColors, bool inDrawWireframe)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_Draw", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_Draw", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_Draw(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Color._Underlying *inColor, byte inUseMaterialColors, byte inDrawWireframe);
            __JPH_TaperedCylinderShape_Draw(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inColor._UnderlyingPtr, inUseMaterialColors ? (byte)1 : (byte)0, inDrawWireframe ? (byte)1 : (byte)0);
        }

        // See Shape::GetStats
        /// Generated from method `JPH::TaperedCylinderShape::GetStats`.
        public unsafe JPH.Shape.Stats GetStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape.Stats._Underlying *__JPH_TaperedCylinderShape_GetStats(_Underlying *_this);
            return new(__JPH_TaperedCylinderShape_GetStats(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetVolume
        /// Generated from method `JPH::TaperedCylinderShape::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TaperedCylinderShape_GetVolume(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetVolume(_UnderlyingPtr);
        }

        // See Shape::IsValidScale
        /// Generated from method `JPH::TaperedCylinderShape::IsValidScale`.
        public unsafe bool IsValidScale(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_TaperedCylinderShape_IsValidScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return __JPH_TaperedCylinderShape_IsValidScale(_UnderlyingPtr, inScale._UnderlyingPtr) != 0;
        }

        // See Shape::MakeScaleValid
        /// Generated from method `JPH::TaperedCylinderShape::MakeScaleValid`.
        public unsafe JPH.Vec3 MakeScaleValid(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TaperedCylinderShape_MakeScaleValid(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_TaperedCylinderShape_MakeScaleValid(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        // Register shape functions with the registry
        /// Generated from method `JPH::TaperedCylinderShape::sRegister`.
        public static void SRegister()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_sRegister();
            __JPH_TaperedCylinderShape_sRegister();
        }

        // See Shape::GetSubShapeIDBitsRecursive
        /// Generated from method `JPH::TaperedCylinderShape::GetSubShapeIDBitsRecursive`.
        public unsafe uint GetSubShapeIDBitsRecursive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_TaperedCylinderShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
        }

        // See Shape::GetSubmergedVolume
        /// Generated from method `JPH::TaperedCylinderShape::GetSubmergedVolume`.
        public unsafe void GetSubmergedVolume(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Plane inSurface, ref float outTotalVolume, ref float outSubmergedVolume, JPH.Vec3 outCenterOfBuoyancy, JPH.Const_Vec3 inBaseOffset)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_GetSubmergedVolume(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Const_Plane._Underlying *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH.Vec3._Underlying *outCenterOfBuoyancy, JPH.Vec3._Underlying *inBaseOffset);
            fixed (float *__ptr_outTotalVolume = &outTotalVolume)
            {
                fixed (float *__ptr_outSubmergedVolume = &outSubmergedVolume)
                {
                    __JPH_TaperedCylinderShape_GetSubmergedVolume(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inSurface._UnderlyingPtr, __ptr_outTotalVolume, __ptr_outSubmergedVolume, outCenterOfBuoyancy._UnderlyingPtr, inBaseOffset._UnderlyingPtr);
                }
            }
        }

        /// Get density of the shape (kg / m^3)
        /// Generated from method `JPH::TaperedCylinderShape::GetDensity`.
        public unsafe float GetDensity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TaperedCylinderShape_GetDensity(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetDensity(_UnderlyingPtr);
        }

        // See Shape::DrawGetSupportFunction
        /// Generated from method `JPH::TaperedCylinderShape::DrawGetSupportFunction`.
        public unsafe void DrawGetSupportFunction(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Color inColor, bool inDrawSupportDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_DrawGetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_DrawGetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_DrawGetSupportFunction(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Color._Underlying *inColor, byte inDrawSupportDirection);
            __JPH_TaperedCylinderShape_DrawGetSupportFunction(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inColor._UnderlyingPtr, inDrawSupportDirection ? (byte)1 : (byte)0);
        }

        // See Shape::DrawGetSupportingFace
        /// Generated from method `JPH::TaperedCylinderShape::DrawGetSupportingFace`.
        public unsafe void DrawGetSupportingFace(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_DrawGetSupportingFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_DrawGetSupportingFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_DrawGetSupportingFace(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            __JPH_TaperedCylinderShape_DrawGetSupportingFace(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        /// User data (to be used freely by the application)
        /// Generated from method `JPH::TaperedCylinderShape::GetUserData`.
        public unsafe ulong GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_TaperedCylinderShape_GetUserData(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetUserData(_UnderlyingPtr);
        }

        /// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
        /// Generated from method `JPH::TaperedCylinderShape::MustBeStatic`.
        public unsafe bool MustBeStatic()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_TaperedCylinderShape_MustBeStatic(_Underlying *_this);
            return __JPH_TaperedCylinderShape_MustBeStatic(_UnderlyingPtr) != 0;
        }

        /// Get the leaf shape for a particular sub shape ID.
        /// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
        /// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
        /// @return The shape or null if the sub shape ID is invalid
        /// Generated from method `JPH::TaperedCylinderShape::GetLeafShape`.
        public unsafe JPH.Const_Shape? GetLeafShape(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_TaperedCylinderShape_GetLeafShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            var __c_ret = __JPH_TaperedCylinderShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        /// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
        /// Generated from method `JPH::TaperedCylinderShape::GetSubShapeUserData`.
        public unsafe ulong GetSubShapeUserData(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_TaperedCylinderShape_GetSubShapeUserData(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return __JPH_TaperedCylinderShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
        }

        /// Get the direct child sub shape and its transform for a sub shape ID.
        /// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
        /// @param inPositionCOM The position of the center of mass of this shape
        /// @param inRotation The orientation of this shape
        /// @param inScale Scale in local space of the shape (scales relative to its center of mass)
        /// @param outRemainder The remainder of the sub shape ID after removing the sub shape
        /// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
        /// Generated from method `JPH::TaperedCylinderShape::GetSubShapeTransformedShape`.
        public unsafe JPH.TransformedShape GetSubShapeTransformedShape(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSubShapeTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetSubShapeTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_TaperedCylinderShape_GetSubShapeTransformedShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale, JPH.SubShapeID._Underlying *outRemainder);
            return new(__JPH_TaperedCylinderShape_GetSubShapeTransformedShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr, outRemainder._UnderlyingPtr), is_owning: true);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::TaperedCylinderShape::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_SetEmbedded(_Underlying *_this);
            __JPH_TaperedCylinderShape_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::TaperedCylinderShape::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_TaperedCylinderShape_GetRefCount(_Underlying *_this);
            return __JPH_TaperedCylinderShape_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::TaperedCylinderShape::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_AddRef(_Underlying *_this);
            __JPH_TaperedCylinderShape_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::TaperedCylinderShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_Release(_Underlying *_this);
            __JPH_TaperedCylinderShape_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::TaperedCylinderShape::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_TaperedCylinderShape_sInternalGetRefCountOffset();
            return __JPH_TaperedCylinderShape_sInternalGetRefCountOffset();
        }
    }

    /// A cylinder with different top and bottom radii
    /// Generated from class `JPH::TaperedCylinderShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the non-const half of the class.
    public class TaperedCylinderShape : Const_TaperedCylinderShape
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHShape(TaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.RefTarget_JPHShape ret = new(__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(TaperedCylinderShape self)
            => (JPH.Const_RefTarget_JPHShape)(JPH.Const_TaperedCylinderShape)self;
        public static unsafe implicit operator JPH.NonCopyable(TaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(TaperedCylinderShape self)
            => (JPH.Const_NonCopyable)(JPH.Const_TaperedCylinderShape)self;
        public static unsafe implicit operator JPH.Shape(TaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape._Underlying *__JPH_TaperedCylinderShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Shape ret = new(__JPH_TaperedCylinderShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Shape(TaperedCylinderShape self)
            => (JPH.Const_Shape)(JPH.Const_TaperedCylinderShape)self;
        public static unsafe implicit operator JPH.ConvexShape(TaperedCylinderShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexShape._Underlying *__JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape(_Underlying *_this);
            JPH.ConvexShape ret = new(__JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConvexShape(TaperedCylinderShape self)
            => (JPH.Const_ConvexShape)(JPH.Const_TaperedCylinderShape)self;

        // Downcasts:
        public static unsafe explicit operator TaperedCylinderShape(JPH.RefTarget_JPHShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH.RefTarget_JPHShape._Underlying *_this);
            TaperedCylinderShape ret = new(__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TaperedCylinderShape(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            TaperedCylinderShape ret = new(__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TaperedCylinderShape(JPH.Shape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape(JPH.Shape._Underlying *_this);
            TaperedCylinderShape ret = new(__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TaperedCylinderShape(JPH.ConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape(JPH.ConvexShape._Underlying *_this);
            TaperedCylinderShape ret = new(__JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe TaperedCylinderShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe TaperedCylinderShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TaperedCylinderShape._Underlying *__JPH_TaperedCylinderShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_TaperedCylinderShape_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Material of the shape
        /// Generated from method `JPH::TaperedCylinderShape::SetMaterial`.
        public unsafe void SetMaterial(JPH.Const_PhysicsMaterial? inMaterial)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_SetMaterial(_Underlying *_this, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            __JPH_TaperedCylinderShape_SetMaterial(_UnderlyingPtr, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
        }

        /// Set density of the shape (kg / m^3)
        /// Generated from method `JPH::TaperedCylinderShape::SetDensity`.
        public unsafe void SetDensity(float inDensity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_SetDensity(_Underlying *_this, float inDensity);
            __JPH_TaperedCylinderShape_SetDensity(_UnderlyingPtr, inDensity);
        }

        /// Generated from method `JPH::TaperedCylinderShape::SetUserData`.
        public unsafe void SetUserData(ulong inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCylinderShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCylinderShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TaperedCylinderShape_SetUserData(_Underlying *_this, ulong inUserData);
            __JPH_TaperedCylinderShape_SetUserData(_UnderlyingPtr, inUserData);
        }
    }

    /// This is used as a function parameter when the underlying function receives `TaperedCylinderShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_TaperedCylinderShape
    {
        #pragma warning disable CS0649
        internal readonly Const_TaperedCylinderShape? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_TaperedCylinderShape() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `TaperedCylinderShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TaperedCylinderShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TaperedCylinderShape`/`Const_TaperedCylinderShape` directly.
    public class _InOptMut_TaperedCylinderShape
    {
        public TaperedCylinderShape? Opt;

        public _InOptMut_TaperedCylinderShape() {}
        public _InOptMut_TaperedCylinderShape(TaperedCylinderShape value) {Opt = value;}
        public static implicit operator _InOptMut_TaperedCylinderShape(TaperedCylinderShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `TaperedCylinderShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TaperedCylinderShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TaperedCylinderShape`/`Const_TaperedCylinderShape` to pass it to the function.
    public class _InOptConst_TaperedCylinderShape
    {
        public Const_TaperedCylinderShape? Opt;

        public _InOptConst_TaperedCylinderShape() {}
        public _InOptConst_TaperedCylinderShape(Const_TaperedCylinderShape value) {Opt = value;}
        public static implicit operator _InOptConst_TaperedCylinderShape(Const_TaperedCylinderShape value) {return new(value);}
    }
}
