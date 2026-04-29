// machine generated, do not edit
public static partial class JPH
{
    /// Class that constructs a CapsuleShape
    /// Generated from class `JPH::CapsuleShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the const half of the class.
    public class Const_CapsuleShapeSettings : JPH.Object<Const_CapsuleShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_Release(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_Release(__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CapsuleShapeSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_CapsuleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(Const_CapsuleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeSettings(Const_CapsuleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeSettings._Underlying *__JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_ShapeSettings ret = new(__JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConvexShapeSettings(Const_CapsuleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ConvexShapeSettings._Underlying *__JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(_Underlying *_this);
            JPH.Const_ConvexShapeSettings ret = new(__JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        public unsafe float mRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Get_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Get_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CapsuleShapeSettings_Get_mRadius(_Underlying *_this);
                return *__JPH_CapsuleShapeSettings_Get_mRadius(_UnderlyingPtr);
            }
        }

        public unsafe float mHalfHeightOfCylinder
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Get_mHalfHeightOfCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Get_mHalfHeightOfCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CapsuleShapeSettings_Get_mHalfHeightOfCylinder(_Underlying *_this);
                return *__JPH_CapsuleShapeSettings_Get_mHalfHeightOfCylinder(_UnderlyingPtr);
            }
        }

        ///< Uniform density of the interior of the convex object (kg / m^3)
        public unsafe float mDensity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Get_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Get_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CapsuleShapeSettings_Get_mDensity(_Underlying *_this);
                return *__JPH_CapsuleShapeSettings_Get_mDensity(_UnderlyingPtr);
            }
        }

        /// User data (to be used freely by the application)
        public unsafe UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_CapsuleShapeSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_CapsuleShapeSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_CapsuleShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CapsuleShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShapeSettings._Underlying *__JPH_CapsuleShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_CapsuleShapeSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
        public unsafe Const_CapsuleShapeSettings(JPH._ByValue_CapsuleShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShapeSettings._Underlying *__JPH_CapsuleShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CapsuleShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_CapsuleShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
        public Const_CapsuleShapeSettings(Const_CapsuleShapeSettings _other) : this(new _ByValue_CapsuleShapeSettings(_other)) {}

        /// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
        public Const_CapsuleShapeSettings(CapsuleShapeSettings _other) : this((Const_CapsuleShapeSettings)_other) {}

        /// Create a capsule centered around the origin with one sphere cap at (0, -inHalfHeightOfCylinder, 0) and the other at (0, inHalfHeightOfCylinder, 0)
        /// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
        public unsafe Const_CapsuleShapeSettings(float inHalfHeightOfCylinder, float inRadius, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShapeSettings._Underlying *__JPH_CapsuleShapeSettings_Construct(float inHalfHeightOfCylinder, float inRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            _UnderlyingPtr = __JPH_CapsuleShapeSettings_Construct(inHalfHeightOfCylinder, inRadius, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CapsuleShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CapsuleShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CapsuleShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_CapsuleShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CapsuleShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CapsuleShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CapsuleShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CapsuleShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CapsuleShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_CapsuleShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CapsuleShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CapsuleShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CapsuleShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_CapsuleShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CapsuleShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CapsuleShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CapsuleShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_CapsuleShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Check if this is a valid capsule shape
        /// Generated from method `JPH::CapsuleShapeSettings::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_CapsuleShapeSettings_IsValid(_Underlying *_this);
            return __JPH_CapsuleShapeSettings_IsValid(_UnderlyingPtr) != 0;
        }

        /// Checks if the settings of this capsule make this shape a sphere
        /// Generated from method `JPH::CapsuleShapeSettings::IsSphere`.
        public unsafe bool IsSphere()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_IsSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_IsSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_CapsuleShapeSettings_IsSphere(_Underlying *_this);
            return __JPH_CapsuleShapeSettings_IsSphere(_UnderlyingPtr) != 0;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::CapsuleShapeSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShapeSettings_SetEmbedded(_Underlying *_this);
            __JPH_CapsuleShapeSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::CapsuleShapeSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CapsuleShapeSettings_GetRefCount(_Underlying *_this);
            return __JPH_CapsuleShapeSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::CapsuleShapeSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShapeSettings_AddRef(_Underlying *_this);
            __JPH_CapsuleShapeSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::CapsuleShapeSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShapeSettings_Release(_Underlying *_this);
            __JPH_CapsuleShapeSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::CapsuleShapeSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_CapsuleShapeSettings_sInternalGetRefCountOffset();
            return __JPH_CapsuleShapeSettings_sInternalGetRefCountOffset();
        }
    }

    /// Class that constructs a CapsuleShape
    /// Generated from class `JPH::CapsuleShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the non-const half of the class.
    public class CapsuleShapeSettings : Const_CapsuleShapeSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(CapsuleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHShapeSettings(CapsuleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.RefTarget_JPHShapeSettings ret = new(__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ShapeSettings(CapsuleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeSettings._Underlying *__JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.ShapeSettings ret = new(__JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ConvexShapeSettings(CapsuleShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexShapeSettings._Underlying *__JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(_Underlying *_this);
            JPH.ConvexShapeSettings ret = new(__JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        public new unsafe ref float mRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetMutable_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetMutable_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CapsuleShapeSettings_GetMutable_mRadius(_Underlying *_this);
                return ref *__JPH_CapsuleShapeSettings_GetMutable_mRadius(_UnderlyingPtr);
            }
        }

        public new unsafe ref float mHalfHeightOfCylinder
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetMutable_mHalfHeightOfCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetMutable_mHalfHeightOfCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CapsuleShapeSettings_GetMutable_mHalfHeightOfCylinder(_Underlying *_this);
                return ref *__JPH_CapsuleShapeSettings_GetMutable_mHalfHeightOfCylinder(_UnderlyingPtr);
            }
        }

        ///< Uniform density of the interior of the convex object (kg / m^3)
        public new unsafe ref float mDensity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetMutable_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetMutable_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CapsuleShapeSettings_GetMutable_mDensity(_Underlying *_this);
                return ref *__JPH_CapsuleShapeSettings_GetMutable_mDensity(_UnderlyingPtr);
            }
        }

        /// User data (to be used freely by the application)
        public new unsafe ref UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_CapsuleShapeSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_CapsuleShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe CapsuleShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CapsuleShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShapeSettings._Underlying *__JPH_CapsuleShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_CapsuleShapeSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
        public unsafe CapsuleShapeSettings(JPH._ByValue_CapsuleShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShapeSettings._Underlying *__JPH_CapsuleShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CapsuleShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_CapsuleShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
        public CapsuleShapeSettings(Const_CapsuleShapeSettings _other) : this(new _ByValue_CapsuleShapeSettings(_other)) {}

        /// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
        public CapsuleShapeSettings(CapsuleShapeSettings _other) : this((Const_CapsuleShapeSettings)_other) {}

        /// Create a capsule centered around the origin with one sphere cap at (0, -inHalfHeightOfCylinder, 0) and the other at (0, inHalfHeightOfCylinder, 0)
        /// Generated from constructor `JPH::CapsuleShapeSettings::CapsuleShapeSettings`.
        public unsafe CapsuleShapeSettings(float inHalfHeightOfCylinder, float inRadius, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShapeSettings._Underlying *__JPH_CapsuleShapeSettings_Construct(float inHalfHeightOfCylinder, float inRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            _UnderlyingPtr = __JPH_CapsuleShapeSettings_Construct(inHalfHeightOfCylinder, inRadius, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from method `JPH::CapsuleShapeSettings::operator=`.
        public unsafe JPH.CapsuleShapeSettings Assign(JPH._ByValue_CapsuleShapeSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShapeSettings._Underlying *__JPH_CapsuleShapeSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.CapsuleShapeSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_CapsuleShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Set the density of the object in kg / m^3
        /// Generated from method `JPH::CapsuleShapeSettings::SetDensity`.
        public unsafe void SetDensity(float inDensity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShapeSettings_SetDensity(_Underlying *_this, float inDensity);
            __JPH_CapsuleShapeSettings_SetDensity(_UnderlyingPtr, inDensity);
        }

        /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
        /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
        /// Generated from method `JPH::CapsuleShapeSettings::ClearCachedResult`.
        public unsafe void ClearCachedResult()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShapeSettings_ClearCachedResult(_Underlying *_this);
            __JPH_CapsuleShapeSettings_ClearCachedResult(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `CapsuleShapeSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `CapsuleShapeSettings`/`Const_CapsuleShapeSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_CapsuleShapeSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_CapsuleShapeSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_CapsuleShapeSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_CapsuleShapeSettings(Const_CapsuleShapeSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_CapsuleShapeSettings(Const_CapsuleShapeSettings arg) {return new(arg);}
        public _ByValue_CapsuleShapeSettings(JPH._Moved<CapsuleShapeSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_CapsuleShapeSettings(JPH._Moved<CapsuleShapeSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `CapsuleShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CapsuleShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CapsuleShapeSettings`/`Const_CapsuleShapeSettings` directly.
    public class _InOptMut_CapsuleShapeSettings
    {
        public CapsuleShapeSettings? Opt;

        public _InOptMut_CapsuleShapeSettings() {}
        public _InOptMut_CapsuleShapeSettings(CapsuleShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_CapsuleShapeSettings(CapsuleShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `CapsuleShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CapsuleShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CapsuleShapeSettings`/`Const_CapsuleShapeSettings` to pass it to the function.
    public class _InOptConst_CapsuleShapeSettings
    {
        public Const_CapsuleShapeSettings? Opt;

        public _InOptConst_CapsuleShapeSettings() {}
        public _InOptConst_CapsuleShapeSettings(Const_CapsuleShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_CapsuleShapeSettings(Const_CapsuleShapeSettings value) {return new(value);}
    }

    /// A capsule, implemented as a line segment with convex radius
    /// Generated from class `JPH::CapsuleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the const half of the class.
    public class Const_CapsuleShape : JPH.Object<Const_CapsuleShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_Release(void *_this);
            __JPH_RefTarget_JPH_Shape_Release(__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CapsuleShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(Const_CapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShape._Underlying *__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.Const_RefTarget_JPHShape ret = new(__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_CapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_CapsuleShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_CapsuleShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Shape(Const_CapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_CapsuleShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Const_Shape ret = new(__JPH_CapsuleShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConvexShape(Const_CapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ConvexShape._Underlying *__JPH_CapsuleShape_UpcastTo_JPH_ConvexShape(_Underlying *_this);
            JPH.Const_ConvexShape ret = new(__JPH_CapsuleShape_UpcastTo_JPH_ConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
        public static unsafe int CGetTrianglesMinTrianglesRequested
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_CapsuleShape_Get_cGetTrianglesMinTrianglesRequested();
                return *__JPH_CapsuleShape_Get_cGetTrianglesMinTrianglesRequested();
            }
        }

        internal unsafe Const_CapsuleShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CapsuleShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShape._Underlying *__JPH_CapsuleShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_CapsuleShape_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Create a capsule centered around the origin with one sphere cap at (0, -inHalfHeightOfCylinder, 0) and the other at (0, inHalfHeightOfCylinder, 0)
        /// Generated from constructor `JPH::CapsuleShape::CapsuleShape`.
        public unsafe Const_CapsuleShape(float inHalfHeightOfCylinder, float inRadius, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShape._Underlying *__JPH_CapsuleShape_Construct_3(float inHalfHeightOfCylinder, float inRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            _UnderlyingPtr = __JPH_CapsuleShape_Construct_3(inHalfHeightOfCylinder, inRadius, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Get world space bounds including convex radius.
        /// Generated from method `JPH::CapsuleShape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_DMat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_CapsuleShape_GetWorldSpaceBounds_JPH_DMat44(_Underlying *_this, JPH.Const_DMat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_CapsuleShape_GetWorldSpaceBounds_JPH_DMat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::CapsuleShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CapsuleShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CapsuleShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CapsuleShape_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_CapsuleShape_size_t(inCount);
        }

        /// Generated from method `JPH::CapsuleShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CapsuleShape_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CapsuleShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CapsuleShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CapsuleShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_CapsuleShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CapsuleShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CapsuleShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CapsuleShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CapsuleShape_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_CapsuleShape_size_t(inCount);
        }

        /// Generated from method `JPH::CapsuleShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CapsuleShape_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CapsuleShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CapsuleShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CapsuleShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_CapsuleShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CapsuleShape::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CapsuleShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CapsuleShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CapsuleShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_CapsuleShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CapsuleShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CapsuleShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CapsuleShape::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CapsuleShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CapsuleShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CapsuleShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_CapsuleShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CapsuleShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CapsuleShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Radius of the cylinder
        /// Generated from method `JPH::CapsuleShape::GetRadius`.
        public unsafe float GetRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_CapsuleShape_GetRadius(_Underlying *_this);
            return __JPH_CapsuleShape_GetRadius(_UnderlyingPtr);
        }

        /// Get half of the height of the cylinder
        /// Generated from method `JPH::CapsuleShape::GetHalfHeightOfCylinder`.
        public unsafe float GetHalfHeightOfCylinder()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetHalfHeightOfCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetHalfHeightOfCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_CapsuleShape_GetHalfHeightOfCylinder(_Underlying *_this);
            return __JPH_CapsuleShape_GetHalfHeightOfCylinder(_UnderlyingPtr);
        }

        // See Shape::GetLocalBounds
        /// Generated from method `JPH::CapsuleShape::GetLocalBounds`.
        public unsafe JPH.AABox GetLocalBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_CapsuleShape_GetLocalBounds(_Underlying *_this);
            return new(__JPH_CapsuleShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetWorldSpaceBounds
        /// Generated from method `JPH::CapsuleShape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_CapsuleShape_GetWorldSpaceBounds_JPH_Mat44(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_CapsuleShape_GetWorldSpaceBounds_JPH_Mat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetInnerRadius
        /// Generated from method `JPH::CapsuleShape::GetInnerRadius`.
        public unsafe float GetInnerRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_CapsuleShape_GetInnerRadius(_Underlying *_this);
            return __JPH_CapsuleShape_GetInnerRadius(_UnderlyingPtr);
        }

        // See Shape::GetSurfaceNormal
        /// Generated from method `JPH::CapsuleShape::GetSurfaceNormal`.
        public unsafe JPH.Vec3 GetSurfaceNormal(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inLocalSurfacePosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_CapsuleShape_GetSurfaceNormal(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inLocalSurfacePosition);
            return new(__JPH_CapsuleShape_GetSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inLocalSurfacePosition._UnderlyingPtr), is_owning: true);
        }

        // See ConvexShape::GetSupportFunction
        /// Generated from method `JPH::CapsuleShape::GetSupportFunction`.
        public unsafe JPH.ConvexShape.Const_Support? GetSupportFunction(JPH.ConvexShape.ESupportMode inMode, JPH.ConvexShape.SupportBuffer inBuffer, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexShape.Const_Support._Underlying *__JPH_CapsuleShape_GetSupportFunction(_Underlying *_this, JPH.ConvexShape.ESupportMode inMode, JPH.ConvexShape.SupportBuffer._Underlying *inBuffer, JPH.Vec3._Underlying *inScale);
            var __c_ret = __JPH_CapsuleShape_GetSupportFunction(_UnderlyingPtr, inMode, inBuffer._UnderlyingPtr, inScale._UnderlyingPtr);
            return __c_ret is not null ? new JPH.ConvexShape.Const_Support(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetTrianglesStart
        /// Generated from method `JPH::CapsuleShape::GetTrianglesStart`.
        public unsafe void GetTrianglesStart(JPH.Shape.GetTrianglesContext ioContext, JPH.Const_AABox inBox, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShape_GetTrianglesStart(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, JPH.Const_AABox._Underlying *inBox, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale);
            __JPH_CapsuleShape_GetTrianglesStart(_UnderlyingPtr, ioContext._UnderlyingPtr, inBox._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        // See Shape::GetTrianglesNext
        /// Generated from method `JPH::CapsuleShape::GetTrianglesNext`.
        public unsafe int GetTrianglesNext(JPH.Shape.GetTrianglesContext ioContext, int inMaxTrianglesRequested, JPH.Float3? outTriangleVertices, void **outMaterials = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_CapsuleShape_GetTrianglesNext(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, int inMaxTrianglesRequested, JPH.Float3._Underlying *outTriangleVertices, void **outMaterials);
            return __JPH_CapsuleShape_GetTrianglesNext(_UnderlyingPtr, ioContext._UnderlyingPtr, inMaxTrianglesRequested, outTriangleVertices is not null ? outTriangleVertices._UnderlyingPtr : null, outMaterials);
        }

        // See Shape::GetStats
        /// Generated from method `JPH::CapsuleShape::GetStats`.
        public unsafe JPH.Shape.Stats GetStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape.Stats._Underlying *__JPH_CapsuleShape_GetStats(_Underlying *_this);
            return new(__JPH_CapsuleShape_GetStats(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetVolume
        /// Generated from method `JPH::CapsuleShape::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_CapsuleShape_GetVolume(_Underlying *_this);
            return __JPH_CapsuleShape_GetVolume(_UnderlyingPtr);
        }

        // See Shape::IsValidScale
        /// Generated from method `JPH::CapsuleShape::IsValidScale`.
        public unsafe bool IsValidScale(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_CapsuleShape_IsValidScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return __JPH_CapsuleShape_IsValidScale(_UnderlyingPtr, inScale._UnderlyingPtr) != 0;
        }

        // See Shape::MakeScaleValid
        /// Generated from method `JPH::CapsuleShape::MakeScaleValid`.
        public unsafe JPH.Vec3 MakeScaleValid(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_CapsuleShape_MakeScaleValid(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_CapsuleShape_MakeScaleValid(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        // Register shape functions with the registry
        /// Generated from method `JPH::CapsuleShape::sRegister`.
        public static void SRegister()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShape_sRegister();
            __JPH_CapsuleShape_sRegister();
        }

        // See Shape::GetSubShapeIDBitsRecursive
        /// Generated from method `JPH::CapsuleShape::GetSubShapeIDBitsRecursive`.
        public unsafe uint GetSubShapeIDBitsRecursive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CapsuleShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
            return __JPH_CapsuleShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
        }

        // See Shape::GetSubmergedVolume
        /// Generated from method `JPH::CapsuleShape::GetSubmergedVolume`.
        public unsafe void GetSubmergedVolume(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Plane inSurface, ref float outTotalVolume, ref float outSubmergedVolume, JPH.Vec3 outCenterOfBuoyancy)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShape_GetSubmergedVolume(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Const_Plane._Underlying *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH.Vec3._Underlying *outCenterOfBuoyancy);
            fixed (float *__ptr_outTotalVolume = &outTotalVolume)
            {
                fixed (float *__ptr_outSubmergedVolume = &outSubmergedVolume)
                {
                    __JPH_CapsuleShape_GetSubmergedVolume(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inSurface._UnderlyingPtr, __ptr_outTotalVolume, __ptr_outSubmergedVolume, outCenterOfBuoyancy._UnderlyingPtr);
                }
            }
        }

        /// Get density of the shape (kg / m^3)
        /// Generated from method `JPH::CapsuleShape::GetDensity`.
        public unsafe float GetDensity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_CapsuleShape_GetDensity(_Underlying *_this);
            return __JPH_CapsuleShape_GetDensity(_UnderlyingPtr);
        }

        /// User data (to be used freely by the application)
        /// Generated from method `JPH::CapsuleShape::GetUserData`.
        public unsafe UIntPtr GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_CapsuleShape_GetUserData(_Underlying *_this);
            return __JPH_CapsuleShape_GetUserData(_UnderlyingPtr);
        }

        /// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
        /// Generated from method `JPH::CapsuleShape::MustBeStatic`.
        public unsafe bool MustBeStatic()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_CapsuleShape_MustBeStatic(_Underlying *_this);
            return __JPH_CapsuleShape_MustBeStatic(_UnderlyingPtr) != 0;
        }

        /// All shapes are centered around their center of mass. This function returns the center of mass position that needs to be applied to transform the shape to where it was created.
        /// Generated from method `JPH::CapsuleShape::GetCenterOfMass`.
        public unsafe JPH.Vec3 GetCenterOfMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_CapsuleShape_GetCenterOfMass(_Underlying *_this);
            return new(__JPH_CapsuleShape_GetCenterOfMass(_UnderlyingPtr), is_owning: true);
        }

        /// Get the leaf shape for a particular sub shape ID.
        /// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
        /// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
        /// @return The shape or null if the sub shape ID is invalid
        /// Generated from method `JPH::CapsuleShape::GetLeafShape`.
        public unsafe JPH.Const_Shape? GetLeafShape(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_CapsuleShape_GetLeafShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            var __c_ret = __JPH_CapsuleShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        /// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
        /// Generated from method `JPH::CapsuleShape::GetSubShapeUserData`.
        public unsafe UIntPtr GetSubShapeUserData(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_CapsuleShape_GetSubShapeUserData(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return __JPH_CapsuleShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::CapsuleShape::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShape_SetEmbedded(_Underlying *_this);
            __JPH_CapsuleShape_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::CapsuleShape::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CapsuleShape_GetRefCount(_Underlying *_this);
            return __JPH_CapsuleShape_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::CapsuleShape::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShape_AddRef(_Underlying *_this);
            __JPH_CapsuleShape_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::CapsuleShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShape_Release(_Underlying *_this);
            __JPH_CapsuleShape_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::CapsuleShape::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_CapsuleShape_sInternalGetRefCountOffset();
            return __JPH_CapsuleShape_sInternalGetRefCountOffset();
        }
    }

    /// A capsule, implemented as a line segment with convex radius
    /// Generated from class `JPH::CapsuleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConvexShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the non-const half of the class.
    public class CapsuleShape : Const_CapsuleShape
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHShape(CapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.RefTarget_JPHShape ret = new(__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.NonCopyable(CapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_CapsuleShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_CapsuleShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Shape(CapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape._Underlying *__JPH_CapsuleShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Shape ret = new(__JPH_CapsuleShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ConvexShape(CapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexShape._Underlying *__JPH_CapsuleShape_UpcastTo_JPH_ConvexShape(_Underlying *_this);
            JPH.ConvexShape ret = new(__JPH_CapsuleShape_UpcastTo_JPH_ConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe CapsuleShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CapsuleShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShape._Underlying *__JPH_CapsuleShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_CapsuleShape_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Create a capsule centered around the origin with one sphere cap at (0, -inHalfHeightOfCylinder, 0) and the other at (0, inHalfHeightOfCylinder, 0)
        /// Generated from constructor `JPH::CapsuleShape::CapsuleShape`.
        public unsafe CapsuleShape(float inHalfHeightOfCylinder, float inRadius, JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CapsuleShape._Underlying *__JPH_CapsuleShape_Construct_3(float inHalfHeightOfCylinder, float inRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            _UnderlyingPtr = __JPH_CapsuleShape_Construct_3(inHalfHeightOfCylinder, inRadius, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Material of the shape
        /// Generated from method `JPH::CapsuleShape::SetMaterial`.
        public unsafe void SetMaterial(JPH.Const_PhysicsMaterial? inMaterial)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShape_SetMaterial(_Underlying *_this, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            __JPH_CapsuleShape_SetMaterial(_UnderlyingPtr, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
        }

        /// Set density of the shape (kg / m^3)
        /// Generated from method `JPH::CapsuleShape::SetDensity`.
        public unsafe void SetDensity(float inDensity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShape_SetDensity(_Underlying *_this, float inDensity);
            __JPH_CapsuleShape_SetDensity(_UnderlyingPtr, inDensity);
        }

        /// Generated from method `JPH::CapsuleShape::SetUserData`.
        public unsafe void SetUserData(UIntPtr inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CapsuleShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CapsuleShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CapsuleShape_SetUserData(_Underlying *_this, UIntPtr inUserData);
            __JPH_CapsuleShape_SetUserData(_UnderlyingPtr, inUserData);
        }
    }

    /// This is used as a function parameter when the underlying function receives `CapsuleShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_CapsuleShape
    {
        #pragma warning disable CS0649
        internal readonly Const_CapsuleShape? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_CapsuleShape() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `CapsuleShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CapsuleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CapsuleShape`/`Const_CapsuleShape` directly.
    public class _InOptMut_CapsuleShape
    {
        public CapsuleShape? Opt;

        public _InOptMut_CapsuleShape() {}
        public _InOptMut_CapsuleShape(CapsuleShape value) {Opt = value;}
        public static implicit operator _InOptMut_CapsuleShape(CapsuleShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `CapsuleShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CapsuleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CapsuleShape`/`Const_CapsuleShape` to pass it to the function.
    public class _InOptConst_CapsuleShape
    {
        public Const_CapsuleShape? Opt;

        public _InOptConst_CapsuleShape() {}
        public _InOptConst_CapsuleShape(Const_CapsuleShape value) {Opt = value;}
        public static implicit operator _InOptConst_CapsuleShape(Const_CapsuleShape value) {return new(value);}
    }
}
