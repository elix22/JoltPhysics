// machine generated, do not edit
public static partial class JPH
{
    /// Class that constructs a TriangleShape
    /// Generated from class `JPH::TriangleShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the const half of the class.
    public class Const_TriangleShapeSettings : JPH.Object<Const_TriangleShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShapeSettings_Destroy(_Underlying *_this);
            __JPH_TriangleShapeSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TriangleShapeSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_TriangleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_TriangleShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_TriangleShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(Const_TriangleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_TriangleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_TriangleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeSettings(Const_TriangleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeSettings._Underlying *__JPH_TriangleShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_ShapeSettings ret = new(__JPH_TriangleShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConvexShapeSettings(Const_TriangleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ConvexShapeSettings._Underlying *__JPH_TriangleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(_Underlying *_this);
            JPH.Const_ConvexShapeSettings ret = new(__JPH_TriangleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TriangleShapeSettings?(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            var ptr = __JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_TriangleShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TriangleShapeSettings?(JPH.Const_ShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(JPH.Const_ShapeSettings._Underlying *_this);
            var ptr = __JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_TriangleShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TriangleShapeSettings?(JPH.Const_ConvexShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings(JPH.Const_ConvexShapeSettings._Underlying *_this);
            var ptr = __JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_TriangleShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public unsafe JPH.Const_Vec3 mv1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mV1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mV1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_TriangleShapeSettings_Get_mV1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_TriangleShapeSettings_Get_mV1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mv2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mV2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mV2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_TriangleShapeSettings_Get_mV2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_TriangleShapeSettings_Get_mV2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mv3
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mV3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mV3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_TriangleShapeSettings_Get_mV3(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_TriangleShapeSettings_Get_mV3(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe float mConvexRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TriangleShapeSettings_Get_mConvexRadius(_Underlying *_this);
                return *__JPH_TriangleShapeSettings_Get_mConvexRadius(_UnderlyingPtr);
            }
        }

        ///< Uniform density of the interior of the convex object (kg / m^3)
        public unsafe float mDensity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TriangleShapeSettings_Get_mDensity(_Underlying *_this);
                return *__JPH_TriangleShapeSettings_Get_mDensity(_UnderlyingPtr);
            }
        }

        /// User data (to be used freely by the application)
        public unsafe ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_TriangleShapeSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_TriangleShapeSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_TriangleShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_TriangleShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShapeSettings._Underlying *__JPH_TriangleShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_TriangleShapeSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::TriangleShapeSettings::TriangleShapeSettings`.
        public unsafe Const_TriangleShapeSettings(JPH._ByValue_TriangleShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShapeSettings._Underlying *__JPH_TriangleShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.TriangleShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_TriangleShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::TriangleShapeSettings::TriangleShapeSettings`.
        public Const_TriangleShapeSettings(Const_TriangleShapeSettings _other) : this(new _ByValue_TriangleShapeSettings(_other)) {}

        /// Generated from constructor `JPH::TriangleShapeSettings::TriangleShapeSettings`.
        public Const_TriangleShapeSettings(TriangleShapeSettings _other) : this((Const_TriangleShapeSettings)_other) {}

        /// Create a triangle with points (inV1, inV2, inV3) (counter clockwise) and convex radius inConvexRadius.
        /// Note that the convex radius is currently only used for shape vs shape collision, for all other purposes the triangle is infinitely thin.
        /// Generated from constructor `JPH::TriangleShapeSettings::TriangleShapeSettings`.
        /// Parameter `inConvexRadius` defaults to `0.0f`.
        public unsafe Const_TriangleShapeSettings(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, float? inConvexRadius = null, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShapeSettings._Underlying *__JPH_TriangleShapeSettings_Construct(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, float *inConvexRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            float __deref_inConvexRadius = inConvexRadius.GetValueOrDefault();
            _UnderlyingPtr = __JPH_TriangleShapeSettings_Construct(inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inConvexRadius.HasValue ? &__deref_inConvexRadius : null, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TriangleShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TriangleShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TriangleShapeSettings_size_t(ulong inCount);
            return __Jolt_new_JPH_TriangleShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TriangleShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TriangleShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TriangleShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_TriangleShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TriangleShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TriangleShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TriangleShapeSettings_size_t(ulong inCount);
            return __Jolt_new_array_JPH_TriangleShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TriangleShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TriangleShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TriangleShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_TriangleShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TriangleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TriangleShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TriangleShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TriangleShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TriangleShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_TriangleShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::TriangleShapeSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShapeSettings_SetEmbedded(_Underlying *_this);
            __JPH_TriangleShapeSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::TriangleShapeSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_TriangleShapeSettings_GetRefCount(_Underlying *_this);
            return __JPH_TriangleShapeSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::TriangleShapeSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShapeSettings_AddRef(_Underlying *_this);
            __JPH_TriangleShapeSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::TriangleShapeSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShapeSettings_Release(_Underlying *_this);
            __JPH_TriangleShapeSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::TriangleShapeSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_TriangleShapeSettings_sInternalGetRefCountOffset();
            return __JPH_TriangleShapeSettings_sInternalGetRefCountOffset();
        }
    }

    /// Class that constructs a TriangleShape
    /// Generated from class `JPH::TriangleShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the non-const half of the class.
    public class TriangleShapeSettings : Const_TriangleShapeSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(TriangleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_TriangleShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_TriangleShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHShapeSettings(TriangleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_TriangleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.RefTarget_JPHShapeSettings ret = new(__JPH_TriangleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ShapeSettings(TriangleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeSettings._Underlying *__JPH_TriangleShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.ShapeSettings ret = new(__JPH_TriangleShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ConvexShapeSettings(TriangleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexShapeSettings._Underlying *__JPH_TriangleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(_Underlying *_this);
            JPH.ConvexShapeSettings ret = new(__JPH_TriangleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator TriangleShapeSettings?(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            var ptr = __JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
            if (ptr is null) return null;
            TriangleShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TriangleShapeSettings?(JPH.ShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(JPH.ShapeSettings._Underlying *_this);
            var ptr = __JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
            if (ptr is null) return null;
            TriangleShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TriangleShapeSettings?(JPH.ConvexShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings(JPH.ConvexShapeSettings._Underlying *_this);
            var ptr = __JPH_TriangleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings(parent._UnderlyingPtr);
            if (ptr is null) return null;
            TriangleShapeSettings ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public new unsafe JPH.Vec3 mv1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mV1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mV1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_TriangleShapeSettings_GetMutable_mV1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_TriangleShapeSettings_GetMutable_mV1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mv2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mV2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mV2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_TriangleShapeSettings_GetMutable_mV2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_TriangleShapeSettings_GetMutable_mV2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mv3
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mV3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mV3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_TriangleShapeSettings_GetMutable_mV3(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_TriangleShapeSettings_GetMutable_mV3(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe ref float mConvexRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TriangleShapeSettings_GetMutable_mConvexRadius(_Underlying *_this);
                return ref *__JPH_TriangleShapeSettings_GetMutable_mConvexRadius(_UnderlyingPtr);
            }
        }

        ///< Uniform density of the interior of the convex object (kg / m^3)
        public new unsafe ref float mDensity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_TriangleShapeSettings_GetMutable_mDensity(_Underlying *_this);
                return ref *__JPH_TriangleShapeSettings_GetMutable_mDensity(_UnderlyingPtr);
            }
        }

        /// User data (to be used freely by the application)
        public new unsafe ref ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_TriangleShapeSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_TriangleShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe TriangleShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe TriangleShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShapeSettings._Underlying *__JPH_TriangleShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_TriangleShapeSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::TriangleShapeSettings::TriangleShapeSettings`.
        public unsafe TriangleShapeSettings(JPH._ByValue_TriangleShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShapeSettings._Underlying *__JPH_TriangleShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.TriangleShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_TriangleShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::TriangleShapeSettings::TriangleShapeSettings`.
        public TriangleShapeSettings(Const_TriangleShapeSettings _other) : this(new _ByValue_TriangleShapeSettings(_other)) {}

        /// Generated from constructor `JPH::TriangleShapeSettings::TriangleShapeSettings`.
        public TriangleShapeSettings(TriangleShapeSettings _other) : this((Const_TriangleShapeSettings)_other) {}

        /// Create a triangle with points (inV1, inV2, inV3) (counter clockwise) and convex radius inConvexRadius.
        /// Note that the convex radius is currently only used for shape vs shape collision, for all other purposes the triangle is infinitely thin.
        /// Generated from constructor `JPH::TriangleShapeSettings::TriangleShapeSettings`.
        /// Parameter `inConvexRadius` defaults to `0.0f`.
        public unsafe TriangleShapeSettings(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, float? inConvexRadius = null, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShapeSettings._Underlying *__JPH_TriangleShapeSettings_Construct(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, float *inConvexRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            float __deref_inConvexRadius = inConvexRadius.GetValueOrDefault();
            _UnderlyingPtr = __JPH_TriangleShapeSettings_Construct(inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inConvexRadius.HasValue ? &__deref_inConvexRadius : null, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
        }

        /// Generated from method `JPH::TriangleShapeSettings::operator=`.
        public unsafe JPH.TriangleShapeSettings Assign(JPH._ByValue_TriangleShapeSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShapeSettings._Underlying *__JPH_TriangleShapeSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.TriangleShapeSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_TriangleShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Set the density of the object in kg / m^3
        /// Generated from method `JPH::TriangleShapeSettings::SetDensity`.
        public unsafe void SetDensity(float inDensity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShapeSettings_SetDensity(_Underlying *_this, float inDensity);
            __JPH_TriangleShapeSettings_SetDensity(_UnderlyingPtr, inDensity);
        }

        /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
        /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
        /// Generated from method `JPH::TriangleShapeSettings::ClearCachedResult`.
        public unsafe void ClearCachedResult()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShapeSettings_ClearCachedResult(_Underlying *_this);
            __JPH_TriangleShapeSettings_ClearCachedResult(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `TriangleShapeSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `TriangleShapeSettings`/`Const_TriangleShapeSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_TriangleShapeSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_TriangleShapeSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_TriangleShapeSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_TriangleShapeSettings(Const_TriangleShapeSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_TriangleShapeSettings(Const_TriangleShapeSettings arg) {return new(arg);}
        public _ByValue_TriangleShapeSettings(JPH._Moved<TriangleShapeSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_TriangleShapeSettings(JPH._Moved<TriangleShapeSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `TriangleShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TriangleShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TriangleShapeSettings`/`Const_TriangleShapeSettings` directly.
    public class _InOptMut_TriangleShapeSettings
    {
        public TriangleShapeSettings? Opt;

        public _InOptMut_TriangleShapeSettings() {}
        public _InOptMut_TriangleShapeSettings(TriangleShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_TriangleShapeSettings(TriangleShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `TriangleShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TriangleShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TriangleShapeSettings`/`Const_TriangleShapeSettings` to pass it to the function.
    public class _InOptConst_TriangleShapeSettings
    {
        public Const_TriangleShapeSettings? Opt;

        public _InOptConst_TriangleShapeSettings() {}
        public _InOptConst_TriangleShapeSettings(Const_TriangleShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_TriangleShapeSettings(Const_TriangleShapeSettings value) {return new(value);}
    }

    /// A single triangle, not the most efficient way of creating a world filled with triangles but can be used as a query shape for example.
    /// Generated from class `JPH::TriangleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the const half of the class.
    public class Const_TriangleShape : JPH.Object<Const_TriangleShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShape_Destroy(_Underlying *_this);
            __JPH_TriangleShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TriangleShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(Const_TriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShape._Underlying *__JPH_TriangleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.Const_RefTarget_JPHShape ret = new(__JPH_TriangleShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_TriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_TriangleShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_TriangleShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Shape(Const_TriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_TriangleShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Const_Shape ret = new(__JPH_TriangleShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConvexShape(Const_TriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ConvexShape._Underlying *__JPH_TriangleShape_UpcastTo_JPH_ConvexShape(_Underlying *_this);
            JPH.Const_ConvexShape ret = new(__JPH_TriangleShape_UpcastTo_JPH_ConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TriangleShape?(JPH.Const_Shape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShape_DynamicDowncastFrom_JPH_Shape(JPH.Const_Shape._Underlying *_this);
            var ptr = __JPH_TriangleShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_TriangleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TriangleShape?(JPH.Const_ConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_DynamicDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_DynamicDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShape_DynamicDowncastFrom_JPH_ConvexShape(JPH.Const_ConvexShape._Underlying *_this);
            var ptr = __JPH_TriangleShape_DynamicDowncastFrom_JPH_ConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_TriangleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
        public static unsafe int CGetTrianglesMinTrianglesRequested
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_TriangleShape_Get_cGetTrianglesMinTrianglesRequested();
                return *__JPH_TriangleShape_Get_cGetTrianglesMinTrianglesRequested();
            }
        }

        internal unsafe Const_TriangleShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_TriangleShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShape._Underlying *__JPH_TriangleShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_TriangleShape_DefaultConstruct();
        }

        /// Create a triangle with points (inV1, inV2, inV3) (counter clockwise) and convex radius inConvexRadius.
        /// Note that the convex radius is currently only used for shape vs shape collision, for all other purposes the triangle is infinitely thin.
        /// Generated from constructor `JPH::TriangleShape::TriangleShape`.
        /// Parameter `inConvexRadius` defaults to `0.0f`.
        public unsafe Const_TriangleShape(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, float? inConvexRadius = null, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShape._Underlying *__JPH_TriangleShape_Construct_5(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, float *inConvexRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            float __deref_inConvexRadius = inConvexRadius.GetValueOrDefault();
            _UnderlyingPtr = __JPH_TriangleShape_Construct_5(inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inConvexRadius.HasValue ? &__deref_inConvexRadius : null, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
        }

        /// Get world space bounds including convex radius.
        /// Generated from method `JPH::TriangleShape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_DMat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_TriangleShape_GetWorldSpaceBounds_JPH_DMat44(_Underlying *_this, JPH.Const_DMat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_TriangleShape_GetWorldSpaceBounds_JPH_DMat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::TriangleShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TriangleShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TriangleShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TriangleShape_size_t(ulong inCount);
            return __Jolt_new_JPH_TriangleShape_size_t(inCount);
        }

        /// Generated from method `JPH::TriangleShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TriangleShape_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TriangleShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TriangleShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TriangleShape_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_TriangleShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TriangleShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TriangleShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TriangleShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TriangleShape_size_t(ulong inCount);
            return __Jolt_new_array_JPH_TriangleShape_size_t(inCount);
        }

        /// Generated from method `JPH::TriangleShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TriangleShape_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TriangleShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TriangleShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TriangleShape_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_TriangleShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TriangleShape::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TriangleShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TriangleShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TriangleShape_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_TriangleShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TriangleShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TriangleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TriangleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TriangleShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TriangleShape::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TriangleShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TriangleShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TriangleShape_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_TriangleShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TriangleShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TriangleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TriangleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TriangleShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Get the vertices of the triangle
        /// Generated from method `JPH::TriangleShape::GetVertex1`.
        public unsafe JPH.Vec3 GetVertex1()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetVertex1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetVertex1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TriangleShape_GetVertex1(_Underlying *_this);
            return new(__JPH_TriangleShape_GetVertex1(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::TriangleShape::GetVertex2`.
        public unsafe JPH.Vec3 GetVertex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetVertex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetVertex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TriangleShape_GetVertex2(_Underlying *_this);
            return new(__JPH_TriangleShape_GetVertex2(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::TriangleShape::GetVertex3`.
        public unsafe JPH.Vec3 GetVertex3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetVertex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetVertex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TriangleShape_GetVertex3(_Underlying *_this);
            return new(__JPH_TriangleShape_GetVertex3(_UnderlyingPtr), is_owning: true);
        }

        /// Convex radius
        /// Generated from method `JPH::TriangleShape::GetConvexRadius`.
        public unsafe float GetConvexRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TriangleShape_GetConvexRadius(_Underlying *_this);
            return __JPH_TriangleShape_GetConvexRadius(_UnderlyingPtr);
        }

        // See Shape::GetLocalBounds
        /// Generated from method `JPH::TriangleShape::GetLocalBounds`.
        public unsafe JPH.AABox GetLocalBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_TriangleShape_GetLocalBounds(_Underlying *_this);
            return new(__JPH_TriangleShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetWorldSpaceBounds
        /// Generated from method `JPH::TriangleShape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_TriangleShape_GetWorldSpaceBounds_JPH_Mat44(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_TriangleShape_GetWorldSpaceBounds_JPH_Mat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetInnerRadius
        /// Generated from method `JPH::TriangleShape::GetInnerRadius`.
        public unsafe float GetInnerRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TriangleShape_GetInnerRadius(_Underlying *_this);
            return __JPH_TriangleShape_GetInnerRadius(_UnderlyingPtr);
        }

        // See Shape::GetSurfaceNormal
        /// Generated from method `JPH::TriangleShape::GetSurfaceNormal`.
        public unsafe JPH.Vec3 GetSurfaceNormal(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inLocalSurfacePosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TriangleShape_GetSurfaceNormal(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inLocalSurfacePosition);
            return new(__JPH_TriangleShape_GetSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inLocalSurfacePosition._UnderlyingPtr), is_owning: true);
        }

        // See ConvexShape::GetSupportFunction
        /// Generated from method `JPH::TriangleShape::GetSupportFunction`.
        public unsafe JPH.ConvexShape.Const_Support? GetSupportFunction(JPH.ConvexShape.ESupportMode inMode, JPH.ConvexShape.SupportBuffer inBuffer, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexShape.Const_Support._Underlying *__JPH_TriangleShape_GetSupportFunction(_Underlying *_this, JPH.ConvexShape.ESupportMode inMode, JPH.ConvexShape.SupportBuffer._Underlying *inBuffer, JPH.Vec3._Underlying *inScale);
            var __c_ret = __JPH_TriangleShape_GetSupportFunction(_UnderlyingPtr, inMode, inBuffer._UnderlyingPtr, inScale._UnderlyingPtr);
            return __c_ret is not null ? new JPH.ConvexShape.Const_Support(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetTrianglesStart
        /// Generated from method `JPH::TriangleShape::GetTrianglesStart`.
        public unsafe void GetTrianglesStart(JPH.Shape.GetTrianglesContext ioContext, JPH.Const_AABox inBox, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShape_GetTrianglesStart(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, JPH.Const_AABox._Underlying *inBox, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale);
            __JPH_TriangleShape_GetTrianglesStart(_UnderlyingPtr, ioContext._UnderlyingPtr, inBox._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        // See Shape::GetTrianglesNext
        /// Generated from method `JPH::TriangleShape::GetTrianglesNext`.
        public unsafe int GetTrianglesNext(JPH.Shape.GetTrianglesContext ioContext, int inMaxTrianglesRequested, JPH.Float3? outTriangleVertices, void **outMaterials = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_TriangleShape_GetTrianglesNext(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, int inMaxTrianglesRequested, JPH.Float3._Underlying *outTriangleVertices, void **outMaterials);
            return __JPH_TriangleShape_GetTrianglesNext(_UnderlyingPtr, ioContext._UnderlyingPtr, inMaxTrianglesRequested, outTriangleVertices is not null ? outTriangleVertices._UnderlyingPtr : null, outMaterials);
        }

        // See Shape::GetStats
        /// Generated from method `JPH::TriangleShape::GetStats`.
        public unsafe JPH.Shape.Stats GetStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape.Stats._Underlying *__JPH_TriangleShape_GetStats(_Underlying *_this);
            return new(__JPH_TriangleShape_GetStats(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetVolume
        /// Generated from method `JPH::TriangleShape::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TriangleShape_GetVolume(_Underlying *_this);
            return __JPH_TriangleShape_GetVolume(_UnderlyingPtr);
        }

        // See Shape::IsValidScale
        /// Generated from method `JPH::TriangleShape::IsValidScale`.
        public unsafe bool IsValidScale(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_TriangleShape_IsValidScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return __JPH_TriangleShape_IsValidScale(_UnderlyingPtr, inScale._UnderlyingPtr) != 0;
        }

        // See Shape::MakeScaleValid
        /// Generated from method `JPH::TriangleShape::MakeScaleValid`.
        public unsafe JPH.Vec3 MakeScaleValid(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TriangleShape_MakeScaleValid(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_TriangleShape_MakeScaleValid(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        // Register shape functions with the registry
        /// Generated from method `JPH::TriangleShape::sRegister`.
        public static void SRegister()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShape_sRegister();
            __JPH_TriangleShape_sRegister();
        }

        // See Shape::GetSubShapeIDBitsRecursive
        /// Generated from method `JPH::TriangleShape::GetSubShapeIDBitsRecursive`.
        public unsafe uint GetSubShapeIDBitsRecursive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_TriangleShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
            return __JPH_TriangleShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
        }

        /// Get density of the shape (kg / m^3)
        /// Generated from method `JPH::TriangleShape::GetDensity`.
        public unsafe float GetDensity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TriangleShape_GetDensity(_Underlying *_this);
            return __JPH_TriangleShape_GetDensity(_UnderlyingPtr);
        }

        /// User data (to be used freely by the application)
        /// Generated from method `JPH::TriangleShape::GetUserData`.
        public unsafe ulong GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_TriangleShape_GetUserData(_Underlying *_this);
            return __JPH_TriangleShape_GetUserData(_UnderlyingPtr);
        }

        /// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
        /// Generated from method `JPH::TriangleShape::MustBeStatic`.
        public unsafe bool MustBeStatic()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_TriangleShape_MustBeStatic(_Underlying *_this);
            return __JPH_TriangleShape_MustBeStatic(_UnderlyingPtr) != 0;
        }

        /// All shapes are centered around their center of mass. This function returns the center of mass position that needs to be applied to transform the shape to where it was created.
        /// Generated from method `JPH::TriangleShape::GetCenterOfMass`.
        public unsafe JPH.Vec3 GetCenterOfMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TriangleShape_GetCenterOfMass(_Underlying *_this);
            return new(__JPH_TriangleShape_GetCenterOfMass(_UnderlyingPtr), is_owning: true);
        }

        /// Get the leaf shape for a particular sub shape ID.
        /// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
        /// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
        /// @return The shape or null if the sub shape ID is invalid
        /// Generated from method `JPH::TriangleShape::GetLeafShape`.
        public unsafe JPH.Const_Shape? GetLeafShape(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_TriangleShape_GetLeafShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            var __c_ret = __JPH_TriangleShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        /// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
        /// Generated from method `JPH::TriangleShape::GetSubShapeUserData`.
        public unsafe ulong GetSubShapeUserData(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_TriangleShape_GetSubShapeUserData(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return __JPH_TriangleShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::TriangleShape::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShape_SetEmbedded(_Underlying *_this);
            __JPH_TriangleShape_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::TriangleShape::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_TriangleShape_GetRefCount(_Underlying *_this);
            return __JPH_TriangleShape_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::TriangleShape::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShape_AddRef(_Underlying *_this);
            __JPH_TriangleShape_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::TriangleShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShape_Release(_Underlying *_this);
            __JPH_TriangleShape_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::TriangleShape::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_TriangleShape_sInternalGetRefCountOffset();
            return __JPH_TriangleShape_sInternalGetRefCountOffset();
        }
    }

    /// A single triangle, not the most efficient way of creating a world filled with triangles but can be used as a query shape for example.
    /// Generated from class `JPH::TriangleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the non-const half of the class.
    public class TriangleShape : Const_TriangleShape
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHShape(TriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_TriangleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.RefTarget_JPHShape ret = new(__JPH_TriangleShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.NonCopyable(TriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_TriangleShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_TriangleShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Shape(TriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape._Underlying *__JPH_TriangleShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Shape ret = new(__JPH_TriangleShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ConvexShape(TriangleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexShape._Underlying *__JPH_TriangleShape_UpcastTo_JPH_ConvexShape(_Underlying *_this);
            JPH.ConvexShape ret = new(__JPH_TriangleShape_UpcastTo_JPH_ConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator TriangleShape?(JPH.Shape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShape_DynamicDowncastFrom_JPH_Shape(JPH.Shape._Underlying *_this);
            var ptr = __JPH_TriangleShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            TriangleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TriangleShape?(JPH.ConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_DynamicDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_DynamicDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TriangleShape_DynamicDowncastFrom_JPH_ConvexShape(JPH.ConvexShape._Underlying *_this);
            var ptr = __JPH_TriangleShape_DynamicDowncastFrom_JPH_ConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            TriangleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe TriangleShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe TriangleShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShape._Underlying *__JPH_TriangleShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_TriangleShape_DefaultConstruct();
        }

        /// Create a triangle with points (inV1, inV2, inV3) (counter clockwise) and convex radius inConvexRadius.
        /// Note that the convex radius is currently only used for shape vs shape collision, for all other purposes the triangle is infinitely thin.
        /// Generated from constructor `JPH::TriangleShape::TriangleShape`.
        /// Parameter `inConvexRadius` defaults to `0.0f`.
        public unsafe TriangleShape(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, float? inConvexRadius = null, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TriangleShape._Underlying *__JPH_TriangleShape_Construct_5(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, float *inConvexRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            float __deref_inConvexRadius = inConvexRadius.GetValueOrDefault();
            _UnderlyingPtr = __JPH_TriangleShape_Construct_5(inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inConvexRadius.HasValue ? &__deref_inConvexRadius : null, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
        }

        /// Material of the shape
        /// Generated from method `JPH::TriangleShape::SetMaterial`.
        public unsafe void SetMaterial(JPH.Const_PhysicsMaterial? inMaterial)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShape_SetMaterial(_Underlying *_this, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            __JPH_TriangleShape_SetMaterial(_UnderlyingPtr, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
        }

        /// Set density of the shape (kg / m^3)
        /// Generated from method `JPH::TriangleShape::SetDensity`.
        public unsafe void SetDensity(float inDensity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShape_SetDensity(_Underlying *_this, float inDensity);
            __JPH_TriangleShape_SetDensity(_UnderlyingPtr, inDensity);
        }

        /// Generated from method `JPH::TriangleShape::SetUserData`.
        public unsafe void SetUserData(ulong inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TriangleShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TriangleShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TriangleShape_SetUserData(_Underlying *_this, ulong inUserData);
            __JPH_TriangleShape_SetUserData(_UnderlyingPtr, inUserData);
        }
    }

    /// This is used as a function parameter when the underlying function receives `TriangleShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_TriangleShape
    {
        #pragma warning disable CS0649
        internal readonly Const_TriangleShape? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_TriangleShape() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `TriangleShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TriangleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TriangleShape`/`Const_TriangleShape` directly.
    public class _InOptMut_TriangleShape
    {
        public TriangleShape? Opt;

        public _InOptMut_TriangleShape() {}
        public _InOptMut_TriangleShape(TriangleShape value) {Opt = value;}
        public static implicit operator _InOptMut_TriangleShape(TriangleShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `TriangleShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TriangleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TriangleShape`/`Const_TriangleShape` to pass it to the function.
    public class _InOptConst_TriangleShape
    {
        public Const_TriangleShape? Opt;

        public _InOptConst_TriangleShape() {}
        public _InOptConst_TriangleShape(Const_TriangleShape value) {Opt = value;}
        public static implicit operator _InOptConst_TriangleShape(Const_TriangleShape value) {return new(value);}
    }
}
