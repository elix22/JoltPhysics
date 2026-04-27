// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Class that constructs a TaperedCapsuleShape
        /// Generated from class `JPH::TaperedCapsuleShapeSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::ConvexShapeSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ShapeSettings>`
        ///     `JPH::ShapeSettings`
        /// This is the const half of the class.
        public class Const_TaperedCapsuleShapeSettings : Jolt.Object<Const_TaperedCapsuleShapeSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShapeSettings_Destroy(_Underlying *_this);
                __JPH_TaperedCapsuleShapeSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_TaperedCapsuleShapeSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_SerializableObject(Const_TaperedCapsuleShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_SerializableObject._Underlying *__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.Const_SerializableObject ret = new(__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShapeSettings(Const_TaperedCapsuleShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ShapeSettings(Const_TaperedCapsuleShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_ShapeSettings ret = new(__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ConvexShapeSettings(Const_TaperedCapsuleShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ConvexShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_ConvexShapeSettings ret = new(__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_TaperedCapsuleShapeSettings?(Jolt.JPH.Const_SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.Const_SerializableObject._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_TaperedCapsuleShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_TaperedCapsuleShapeSettings?(Jolt.JPH.Const_ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.Const_ShapeSettings._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_TaperedCapsuleShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_TaperedCapsuleShapeSettings?(Jolt.JPH.Const_ConvexShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings(Jolt.JPH.Const_ConvexShapeSettings._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_TaperedCapsuleShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            public unsafe float mHalfHeightOfTaperedCylinder
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mHalfHeightOfTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mHalfHeightOfTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_TaperedCapsuleShapeSettings_Get_mHalfHeightOfTaperedCylinder(_Underlying *_this);
                    return *__JPH_TaperedCapsuleShapeSettings_Get_mHalfHeightOfTaperedCylinder(_UnderlyingPtr);
                }
            }

            public unsafe float mTopRadius
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_TaperedCapsuleShapeSettings_Get_mTopRadius(_Underlying *_this);
                    return *__JPH_TaperedCapsuleShapeSettings_Get_mTopRadius(_UnderlyingPtr);
                }
            }

            public unsafe float mBottomRadius
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_TaperedCapsuleShapeSettings_Get_mBottomRadius(_Underlying *_this);
                    return *__JPH_TaperedCapsuleShapeSettings_Get_mBottomRadius(_UnderlyingPtr);
                }
            }

            ///< Uniform density of the interior of the convex object (kg / m^3)
            public unsafe float mDensity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_TaperedCapsuleShapeSettings_Get_mDensity(_Underlying *_this);
                    return *__JPH_TaperedCapsuleShapeSettings_Get_mDensity(_UnderlyingPtr);
                }
            }

            /// User data (to be used freely by the application)
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_TaperedCapsuleShapeSettings_Get_mUserData(_Underlying *_this);
                    return *__JPH_TaperedCapsuleShapeSettings_Get_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe Const_TaperedCapsuleShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_TaperedCapsuleShapeSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_TaperedCapsuleShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
            public unsafe Const_TaperedCapsuleShapeSettings(Jolt.JPH._ByValue_TaperedCapsuleShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_TaperedCapsuleShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
            public Const_TaperedCapsuleShapeSettings(Const_TaperedCapsuleShapeSettings _other) : this(new _ByValue_TaperedCapsuleShapeSettings(_other)) {}

            /// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
            public Const_TaperedCapsuleShapeSettings(TaperedCapsuleShapeSettings _other) : this((Const_TaperedCapsuleShapeSettings)_other) {}

            /// Create a tapered capsule centered around the origin with one sphere cap at (0, -inHalfHeightOfTaperedCylinder, 0) with radius inBottomRadius and the other at (0, inHalfHeightOfTaperedCylinder, 0) with radius inTopRadius
            /// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
            public unsafe Const_TaperedCapsuleShapeSettings(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, Jolt.JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_Construct(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, Jolt.JPH.Const_PhysicsMaterial._Underlying *inMaterial);
                _UnderlyingPtr = __JPH_TaperedCapsuleShapeSettings_Construct(inHalfHeightOfTaperedCylinder, inTopRadius, inBottomRadius, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TaperedCapsuleShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TaperedCapsuleShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_TaperedCapsuleShapeSettings_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_TaperedCapsuleShapeSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCapsuleShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCapsuleShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_TaperedCapsuleShapeSettings_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_TaperedCapsuleShapeSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TaperedCapsuleShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TaperedCapsuleShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_TaperedCapsuleShapeSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_TaperedCapsuleShapeSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCapsuleShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCapsuleShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_TaperedCapsuleShapeSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_TaperedCapsuleShapeSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Check if the settings are valid
            /// Generated from method `JPH::TaperedCapsuleShapeSettings::IsValid`.
            public unsafe bool IsValid()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_TaperedCapsuleShapeSettings_IsValid(_Underlying *_this);
                return __JPH_TaperedCapsuleShapeSettings_IsValid(_UnderlyingPtr) != 0;
            }

            /// Checks if the settings of this tapered capsule make this shape a sphere
            /// Generated from method `JPH::TaperedCapsuleShapeSettings::IsSphere`.
            public unsafe bool IsSphere()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_IsSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_IsSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_TaperedCapsuleShapeSettings_IsSphere(_Underlying *_this);
                return __JPH_TaperedCapsuleShapeSettings_IsSphere(_UnderlyingPtr) != 0;
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::TaperedCapsuleShapeSettings::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShapeSettings_SetEmbedded(_Underlying *_this);
                __JPH_TaperedCapsuleShapeSettings_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::TaperedCapsuleShapeSettings::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_TaperedCapsuleShapeSettings_GetRefCount(_Underlying *_this);
                return __JPH_TaperedCapsuleShapeSettings_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::TaperedCapsuleShapeSettings::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShapeSettings_AddRef(_Underlying *_this);
                __JPH_TaperedCapsuleShapeSettings_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShapeSettings_Release(_Underlying *_this);
                __JPH_TaperedCapsuleShapeSettings_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::TaperedCapsuleShapeSettings::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_TaperedCapsuleShapeSettings_sInternalGetRefCountOffset();
                return __JPH_TaperedCapsuleShapeSettings_sInternalGetRefCountOffset();
            }
        }

        /// Class that constructs a TaperedCapsuleShape
        /// Generated from class `JPH::TaperedCapsuleShapeSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::ConvexShapeSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ShapeSettings>`
        ///     `JPH::ShapeSettings`
        /// This is the non-const half of the class.
        public class TaperedCapsuleShapeSettings : Const_TaperedCapsuleShapeSettings
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.SerializableObject(TaperedCapsuleShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SerializableObject._Underlying *__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.SerializableObject ret = new(__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShapeSettings(TaperedCapsuleShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShapeSettings ret = new(__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ShapeSettings(TaperedCapsuleShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.ShapeSettings ret = new(__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ConvexShapeSettings(TaperedCapsuleShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ConvexShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(_Underlying *_this);
                Jolt.JPH.ConvexShapeSettings ret = new(__JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator TaperedCapsuleShapeSettings?(Jolt.JPH.SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.SerializableObject._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                TaperedCapsuleShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator TaperedCapsuleShapeSettings?(Jolt.JPH.ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.ShapeSettings._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                TaperedCapsuleShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator TaperedCapsuleShapeSettings?(Jolt.JPH.ConvexShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings(Jolt.JPH.ConvexShapeSettings._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShapeSettings_DynamicDowncastFrom_JPH_ConvexShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                TaperedCapsuleShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            public new unsafe ref float mHalfHeightOfTaperedCylinder
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mHalfHeightOfTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mHalfHeightOfTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_TaperedCapsuleShapeSettings_GetMutable_mHalfHeightOfTaperedCylinder(_Underlying *_this);
                    return ref *__JPH_TaperedCapsuleShapeSettings_GetMutable_mHalfHeightOfTaperedCylinder(_UnderlyingPtr);
                }
            }

            public new unsafe ref float mTopRadius
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_TaperedCapsuleShapeSettings_GetMutable_mTopRadius(_Underlying *_this);
                    return ref *__JPH_TaperedCapsuleShapeSettings_GetMutable_mTopRadius(_UnderlyingPtr);
                }
            }

            public new unsafe ref float mBottomRadius
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_TaperedCapsuleShapeSettings_GetMutable_mBottomRadius(_Underlying *_this);
                    return ref *__JPH_TaperedCapsuleShapeSettings_GetMutable_mBottomRadius(_UnderlyingPtr);
                }
            }

            ///< Uniform density of the interior of the convex object (kg / m^3)
            public new unsafe ref float mDensity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_TaperedCapsuleShapeSettings_GetMutable_mDensity(_Underlying *_this);
                    return ref *__JPH_TaperedCapsuleShapeSettings_GetMutable_mDensity(_UnderlyingPtr);
                }
            }

            /// User data (to be used freely by the application)
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_TaperedCapsuleShapeSettings_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_TaperedCapsuleShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe TaperedCapsuleShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe TaperedCapsuleShapeSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_TaperedCapsuleShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
            public unsafe TaperedCapsuleShapeSettings(Jolt.JPH._ByValue_TaperedCapsuleShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_TaperedCapsuleShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
            public TaperedCapsuleShapeSettings(Const_TaperedCapsuleShapeSettings _other) : this(new _ByValue_TaperedCapsuleShapeSettings(_other)) {}

            /// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
            public TaperedCapsuleShapeSettings(TaperedCapsuleShapeSettings _other) : this((Const_TaperedCapsuleShapeSettings)_other) {}

            /// Create a tapered capsule centered around the origin with one sphere cap at (0, -inHalfHeightOfTaperedCylinder, 0) with radius inBottomRadius and the other at (0, inHalfHeightOfTaperedCylinder, 0) with radius inTopRadius
            /// Generated from constructor `JPH::TaperedCapsuleShapeSettings::TaperedCapsuleShapeSettings`.
            public unsafe TaperedCapsuleShapeSettings(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, Jolt.JPH.Const_PhysicsMaterial? inMaterial = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_Construct(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, Jolt.JPH.Const_PhysicsMaterial._Underlying *inMaterial);
                _UnderlyingPtr = __JPH_TaperedCapsuleShapeSettings_Construct(inHalfHeightOfTaperedCylinder, inTopRadius, inBottomRadius, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::TaperedCapsuleShapeSettings::operator=`.
            public unsafe Jolt.JPH.TaperedCapsuleShapeSettings Assign(Jolt.JPH._ByValue_TaperedCapsuleShapeSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *__JPH_TaperedCapsuleShapeSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.TaperedCapsuleShapeSettings._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_TaperedCapsuleShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }

            /// Set the density of the object in kg / m^3
            /// Generated from method `JPH::TaperedCapsuleShapeSettings::SetDensity`.
            public unsafe void SetDensity(float inDensity)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShapeSettings_SetDensity(_Underlying *_this, float inDensity);
                __JPH_TaperedCapsuleShapeSettings_SetDensity(_UnderlyingPtr, inDensity);
            }

            /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
            /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
            /// Generated from method `JPH::TaperedCapsuleShapeSettings::ClearCachedResult`.
            public unsafe void ClearCachedResult()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShapeSettings_ClearCachedResult(_Underlying *_this);
                __JPH_TaperedCapsuleShapeSettings_ClearCachedResult(_UnderlyingPtr);
            }
        }

        /// This is used as a function parameter when the underlying function receives `TaperedCapsuleShapeSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `TaperedCapsuleShapeSettings`/`Const_TaperedCapsuleShapeSettings` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_TaperedCapsuleShapeSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_TaperedCapsuleShapeSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_TaperedCapsuleShapeSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_TaperedCapsuleShapeSettings(Const_TaperedCapsuleShapeSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_TaperedCapsuleShapeSettings(Const_TaperedCapsuleShapeSettings arg) {return new(arg);}
            public _ByValue_TaperedCapsuleShapeSettings(Jolt._Moved<TaperedCapsuleShapeSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
            public static implicit operator _ByValue_TaperedCapsuleShapeSettings(Jolt._Moved<TaperedCapsuleShapeSettings> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `TaperedCapsuleShapeSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_TaperedCapsuleShapeSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `TaperedCapsuleShapeSettings`/`Const_TaperedCapsuleShapeSettings` directly.
        public class _InOptMut_TaperedCapsuleShapeSettings
        {
            public TaperedCapsuleShapeSettings? Opt;

            public _InOptMut_TaperedCapsuleShapeSettings() {}
            public _InOptMut_TaperedCapsuleShapeSettings(TaperedCapsuleShapeSettings value) {Opt = value;}
            public static implicit operator _InOptMut_TaperedCapsuleShapeSettings(TaperedCapsuleShapeSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `TaperedCapsuleShapeSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_TaperedCapsuleShapeSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `TaperedCapsuleShapeSettings`/`Const_TaperedCapsuleShapeSettings` to pass it to the function.
        public class _InOptConst_TaperedCapsuleShapeSettings
        {
            public Const_TaperedCapsuleShapeSettings? Opt;

            public _InOptConst_TaperedCapsuleShapeSettings() {}
            public _InOptConst_TaperedCapsuleShapeSettings(Const_TaperedCapsuleShapeSettings value) {Opt = value;}
            public static implicit operator _InOptConst_TaperedCapsuleShapeSettings(Const_TaperedCapsuleShapeSettings value) {return new(value);}
        }

        /// A capsule with different top and bottom radii
        /// Generated from class `JPH::TaperedCapsuleShape`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::ConvexShape`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Shape>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Shape`
        /// This is the const half of the class.
        public class Const_TaperedCapsuleShape : Jolt.Object<Const_TaperedCapsuleShape>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShape_Destroy(_Underlying *_this);
                __JPH_TaperedCapsuleShape_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_TaperedCapsuleShape() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShape(Const_TaperedCapsuleShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShape._Underlying *__JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShape ret = new(__JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_TaperedCapsuleShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_Shape(Const_TaperedCapsuleShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_Shape ret = new(__JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ConvexShape(Const_TaperedCapsuleShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ConvexShape._Underlying *__JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape(_Underlying *_this);
                Jolt.JPH.Const_ConvexShape ret = new(__JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_TaperedCapsuleShape?(Jolt.JPH.Const_Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Const_Shape._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_TaperedCapsuleShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_TaperedCapsuleShape?(Jolt.JPH.Const_ConvexShape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_ConvexShape(Jolt.JPH.Const_ConvexShape._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_ConvexShape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_TaperedCapsuleShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
            public static unsafe int CGetTrianglesMinTrianglesRequested
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_TaperedCapsuleShape_Get_cGetTrianglesMinTrianglesRequested();
                    return *__JPH_TaperedCapsuleShape_Get_cGetTrianglesMinTrianglesRequested();
                }
            }

            internal unsafe Const_TaperedCapsuleShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_TaperedCapsuleShape() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TaperedCapsuleShape._Underlying *__JPH_TaperedCapsuleShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_TaperedCapsuleShape_DefaultConstruct();
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TaperedCapsuleShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TaperedCapsuleShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_TaperedCapsuleShape_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_TaperedCapsuleShape_unsigned_long(inCount);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_TaperedCapsuleShape_void_ptr(void *inPointer);
                __Jolt_delete_JPH_TaperedCapsuleShape_void_ptr(inPointer);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCapsuleShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCapsuleShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_TaperedCapsuleShape_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_TaperedCapsuleShape_unsigned_long(inCount);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr(inPointer);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TaperedCapsuleShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TaperedCapsuleShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_TaperedCapsuleShape_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_TaperedCapsuleShape_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCapsuleShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TaperedCapsuleShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_TaperedCapsuleShape_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_TaperedCapsuleShape_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Get top radius of the tapered capsule
            /// Generated from method `JPH::TaperedCapsuleShape::GetTopRadius`.
            public unsafe float GetTopRadius()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetTopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_TaperedCapsuleShape_GetTopRadius(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_GetTopRadius(_UnderlyingPtr);
            }

            /// Get bottom radius of the tapered capsule
            /// Generated from method `JPH::TaperedCapsuleShape::GetBottomRadius`.
            public unsafe float GetBottomRadius()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetBottomRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_TaperedCapsuleShape_GetBottomRadius(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_GetBottomRadius(_UnderlyingPtr);
            }

            /// Get half height between the top and bottom sphere center
            /// Generated from method `JPH::TaperedCapsuleShape::GetHalfHeight`.
            public unsafe float GetHalfHeight()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_TaperedCapsuleShape_GetHalfHeight(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_GetHalfHeight(_UnderlyingPtr);
            }

            // See Shape::GetLocalBounds
            /// Generated from method `JPH::TaperedCapsuleShape::GetLocalBounds`.
            public unsafe Jolt.JPH.AABox GetLocalBounds()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_TaperedCapsuleShape_GetLocalBounds(_Underlying *_this);
                return new(__JPH_TaperedCapsuleShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
            }

            // See Shape::GetInnerRadius
            /// Generated from method `JPH::TaperedCapsuleShape::GetInnerRadius`.
            public unsafe float GetInnerRadius()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_TaperedCapsuleShape_GetInnerRadius(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_GetInnerRadius(_UnderlyingPtr);
            }

            // See Shape::GetStats
            /// Generated from method `JPH::TaperedCapsuleShape::GetStats`.
            public unsafe Jolt.JPH.Shape.Stats GetStats()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape.Stats._Underlying *__JPH_TaperedCapsuleShape_GetStats(_Underlying *_this);
                return new(__JPH_TaperedCapsuleShape_GetStats(_UnderlyingPtr), is_owning: true);
            }

            // See Shape::GetVolume
            /// Generated from method `JPH::TaperedCapsuleShape::GetVolume`.
            public unsafe float GetVolume()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_TaperedCapsuleShape_GetVolume(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_GetVolume(_UnderlyingPtr);
            }

            // Register shape functions with the registry
            /// Generated from method `JPH::TaperedCapsuleShape::sRegister`.
            public static void SRegister()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShape_sRegister();
                __JPH_TaperedCapsuleShape_sRegister();
            }

            // See Shape::GetSubShapeIDBitsRecursive
            /// Generated from method `JPH::TaperedCapsuleShape::GetSubShapeIDBitsRecursive`.
            public unsafe uint GetSubShapeIDBitsRecursive()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_TaperedCapsuleShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
            }

            /// Get density of the shape (kg / m^3)
            /// Generated from method `JPH::TaperedCapsuleShape::GetDensity`.
            public unsafe float GetDensity()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_TaperedCapsuleShape_GetDensity(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_GetDensity(_UnderlyingPtr);
            }

            /// User data (to be used freely by the application)
            /// Generated from method `JPH::TaperedCapsuleShape::GetUserData`.
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_TaperedCapsuleShape_GetUserData(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_GetUserData(_UnderlyingPtr);
            }

            /// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
            /// Generated from method `JPH::TaperedCapsuleShape::MustBeStatic`.
            public unsafe bool MustBeStatic()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_TaperedCapsuleShape_MustBeStatic(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_MustBeStatic(_UnderlyingPtr) != 0;
            }

            /// Get the leaf shape for a particular sub shape ID.
            /// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
            /// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
            /// @return The shape or null if the sub shape ID is invalid
            /// Generated from method `JPH::TaperedCapsuleShape::GetLeafShape`.
            public unsafe Jolt.JPH.Const_Shape? GetLeafShape(Jolt.JPH.Const_SubShapeID inSubShapeID, Jolt.JPH.SubShapeID outRemainder)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_TaperedCapsuleShape_GetLeafShape(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID, Jolt.JPH.SubShapeID._Underlying *outRemainder);
                var __c_ret = __JPH_TaperedCapsuleShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            /// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
            /// Generated from method `JPH::TaperedCapsuleShape::GetSubShapeUserData`.
            public unsafe ulong GetSubShapeUserData(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_TaperedCapsuleShape_GetSubShapeUserData(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                return __JPH_TaperedCapsuleShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::TaperedCapsuleShape::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShape_SetEmbedded(_Underlying *_this);
                __JPH_TaperedCapsuleShape_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::TaperedCapsuleShape::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_TaperedCapsuleShape_GetRefCount(_Underlying *_this);
                return __JPH_TaperedCapsuleShape_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::TaperedCapsuleShape::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShape_AddRef(_Underlying *_this);
                __JPH_TaperedCapsuleShape_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShape_Release(_Underlying *_this);
                __JPH_TaperedCapsuleShape_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::TaperedCapsuleShape::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_TaperedCapsuleShape_sInternalGetRefCountOffset();
                return __JPH_TaperedCapsuleShape_sInternalGetRefCountOffset();
            }
        }

        /// A capsule with different top and bottom radii
        /// Generated from class `JPH::TaperedCapsuleShape`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::ConvexShape`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Shape>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Shape`
        /// This is the non-const half of the class.
        public class TaperedCapsuleShape : Const_TaperedCapsuleShape
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShape(TaperedCapsuleShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShape._Underlying *__JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShape ret = new(__JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(TaperedCapsuleShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Shape(TaperedCapsuleShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape._Underlying *__JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Shape ret = new(__JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ConvexShape(TaperedCapsuleShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ConvexShape._Underlying *__JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape(_Underlying *_this);
                Jolt.JPH.ConvexShape ret = new(__JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator TaperedCapsuleShape?(Jolt.JPH.Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Shape._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                TaperedCapsuleShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator TaperedCapsuleShape?(Jolt.JPH.ConvexShape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_ConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_ConvexShape(Jolt.JPH.ConvexShape._Underlying *_this);
                var ptr = __JPH_TaperedCapsuleShape_DynamicDowncastFrom_JPH_ConvexShape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                TaperedCapsuleShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe TaperedCapsuleShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe TaperedCapsuleShape() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TaperedCapsuleShape._Underlying *__JPH_TaperedCapsuleShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_TaperedCapsuleShape_DefaultConstruct();
            }

            /// Material of the shape
            /// Generated from method `JPH::TaperedCapsuleShape::SetMaterial`.
            public unsafe void SetMaterial(Jolt.JPH.Const_PhysicsMaterial? inMaterial)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShape_SetMaterial(_Underlying *_this, Jolt.JPH.Const_PhysicsMaterial._Underlying *inMaterial);
                __JPH_TaperedCapsuleShape_SetMaterial(_UnderlyingPtr, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            }

            /// Set density of the shape (kg / m^3)
            /// Generated from method `JPH::TaperedCapsuleShape::SetDensity`.
            public unsafe void SetDensity(float inDensity)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_SetDensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShape_SetDensity(_Underlying *_this, float inDensity);
                __JPH_TaperedCapsuleShape_SetDensity(_UnderlyingPtr, inDensity);
            }

            /// Generated from method `JPH::TaperedCapsuleShape::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TaperedCapsuleShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TaperedCapsuleShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_TaperedCapsuleShape_SetUserData(_Underlying *_this, ulong inUserData);
                __JPH_TaperedCapsuleShape_SetUserData(_UnderlyingPtr, inUserData);
            }
        }

        /// This is used as a function parameter when the underlying function receives `TaperedCapsuleShape` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_TaperedCapsuleShape
        {
            #pragma warning disable CS0649
            internal readonly Const_TaperedCapsuleShape? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_TaperedCapsuleShape() {PassByMode = Jolt._PassBy.default_construct;}
        }

        /// This is used for optional parameters of class `TaperedCapsuleShape` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_TaperedCapsuleShape`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `TaperedCapsuleShape`/`Const_TaperedCapsuleShape` directly.
        public class _InOptMut_TaperedCapsuleShape
        {
            public TaperedCapsuleShape? Opt;

            public _InOptMut_TaperedCapsuleShape() {}
            public _InOptMut_TaperedCapsuleShape(TaperedCapsuleShape value) {Opt = value;}
            public static implicit operator _InOptMut_TaperedCapsuleShape(TaperedCapsuleShape value) {return new(value);}
        }

        /// This is used for optional parameters of class `TaperedCapsuleShape` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_TaperedCapsuleShape`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `TaperedCapsuleShape`/`Const_TaperedCapsuleShape` to pass it to the function.
        public class _InOptConst_TaperedCapsuleShape
        {
            public Const_TaperedCapsuleShape? Opt;

            public _InOptConst_TaperedCapsuleShape() {}
            public _InOptConst_TaperedCapsuleShape(Const_TaperedCapsuleShape value) {Opt = value;}
            public static implicit operator _InOptConst_TaperedCapsuleShape(Const_TaperedCapsuleShape value) {return new(value);}
        }
    }
}
