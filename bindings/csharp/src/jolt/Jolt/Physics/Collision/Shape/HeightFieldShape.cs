// machine generated, do not edit
public static partial class JPH
{
    /// Class that constructs a HeightFieldShape
    /// Generated from class `JPH::HeightFieldShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    /// This is the const half of the class.
    public class Const_HeightFieldShapeSettings : JPH.Object<Const_HeightFieldShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_Release(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_Release(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_HeightFieldShapeSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_HeightFieldShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(Const_HeightFieldShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeSettings(Const_HeightFieldShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_ShapeSettings ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// The height field is a surface defined by: mOffset + mScale * (x, mHeightSamples[y * mSampleCount + x], y).
        /// where x and y are integers in the range x and y e [0, mSampleCount - 1].
        public unsafe JPH.Const_Vec3 mOffset
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_HeightFieldShapeSettings_Get_mOffset(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_HeightFieldShapeSettings_Get_mOffset(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mScale
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_HeightFieldShapeSettings_Get_mScale(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_HeightFieldShapeSettings_Get_mScale(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe uint mSampleCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mSampleCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mSampleCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_HeightFieldShapeSettings_Get_mSampleCount(_Underlying *_this);
                return *__JPH_HeightFieldShapeSettings_Get_mSampleCount(_UnderlyingPtr);
            }
        }

        /// Artificial minimal value of mHeightSamples, used for compression and can be used to update the terrain after creating with lower height values. If there are any lower values in mHeightSamples, this value will be ignored.
        public unsafe float mMinHeightValue
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mMinHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mMinHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_HeightFieldShapeSettings_Get_mMinHeightValue(_Underlying *_this);
                return *__JPH_HeightFieldShapeSettings_Get_mMinHeightValue(_UnderlyingPtr);
            }
        }

        /// Artificial maximum value of mHeightSamples, used for compression and can be used to update the terrain after creating with higher height values. If there are any higher values in mHeightSamples, this value will be ignored.
        public unsafe float mMaxHeightValue
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mMaxHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mMaxHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_HeightFieldShapeSettings_Get_mMaxHeightValue(_Underlying *_this);
                return *__JPH_HeightFieldShapeSettings_Get_mMaxHeightValue(_UnderlyingPtr);
            }
        }

        /// When bigger than mMaterials.size() the internal material list will be preallocated to support this number of materials.
        /// This avoids reallocations when calling HeightFieldShape::SetMaterials with new materials later.
        public unsafe uint mMaterialsCapacity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mMaterialsCapacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mMaterialsCapacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_HeightFieldShapeSettings_Get_mMaterialsCapacity(_Underlying *_this);
                return *__JPH_HeightFieldShapeSettings_Get_mMaterialsCapacity(_UnderlyingPtr);
            }
        }

        /// The heightfield is divided in blocks of mBlockSize * mBlockSize * 2 triangles and the acceleration structure culls blocks only,
        /// bigger block sizes reduce memory consumption but also reduce query performance. Sensible values are [2, 8], does not need to be
        /// a power of 2. Note that at run-time we'll perform one more grid subdivision, so the effective block size is half of what is provided here.
        public unsafe uint mBlockSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mBlockSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mBlockSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_HeightFieldShapeSettings_Get_mBlockSize(_Underlying *_this);
                return *__JPH_HeightFieldShapeSettings_Get_mBlockSize(_UnderlyingPtr);
            }
        }

        /// How many bits per sample to use to compress the height field. Can be in the range [1, 8].
        /// Note that each sample is compressed relative to the min/max value of its block of mBlockSize * mBlockSize pixels so the effective precision is higher.
        /// Also note that increasing mBlockSize saves more memory than reducing the amount of bits per sample.
        public unsafe uint mBitsPerSample
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mBitsPerSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mBitsPerSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_HeightFieldShapeSettings_Get_mBitsPerSample(_Underlying *_this);
                return *__JPH_HeightFieldShapeSettings_Get_mBitsPerSample(_UnderlyingPtr);
            }
        }

        // cos(5 degrees)
        public unsafe float mActiveEdgeCosThresholdAngle
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mActiveEdgeCosThresholdAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mActiveEdgeCosThresholdAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_HeightFieldShapeSettings_Get_mActiveEdgeCosThresholdAngle(_Underlying *_this);
                return *__JPH_HeightFieldShapeSettings_Get_mActiveEdgeCosThresholdAngle(_UnderlyingPtr);
            }
        }

        /// User data (to be used freely by the application)
        public unsafe UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_HeightFieldShapeSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_HeightFieldShapeSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_HeightFieldShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_HeightFieldShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_HeightFieldShapeSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
        public unsafe Const_HeightFieldShapeSettings(JPH._ByValue_HeightFieldShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.HeightFieldShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_HeightFieldShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
        public Const_HeightFieldShapeSettings(Const_HeightFieldShapeSettings _other) : this(new _ByValue_HeightFieldShapeSettings(_other)) {}

        /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
        public Const_HeightFieldShapeSettings(HeightFieldShapeSettings _other) : this((Const_HeightFieldShapeSettings)_other) {}

        /// Generated from method `JPH::HeightFieldShapeSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_HeightFieldShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_HeightFieldShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_HeightFieldShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_HeightFieldShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_HeightFieldShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_HeightFieldShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_HeightFieldShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_HeightFieldShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Determine the minimal and maximal value of mHeightSamples (will ignore cNoCollisionValue)
        /// @param outMinValue The minimal value of mHeightSamples or FLT_MAX if no samples have collision
        /// @param outMaxValue The maximal value of mHeightSamples or -FLT_MAX if no samples have collision
        /// @param outQuantizationScale (value - outMinValue) * outQuantizationScale quantizes a height sample to 16 bits
        /// Generated from method `JPH::HeightFieldShapeSettings::DetermineMinAndMaxSample`.
        public unsafe void DetermineMinAndMaxSample(ref float outMinValue, ref float outMaxValue, ref float outQuantizationScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DetermineMinAndMaxSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DetermineMinAndMaxSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShapeSettings_DetermineMinAndMaxSample(_Underlying *_this, float *outMinValue, float *outMaxValue, float *outQuantizationScale);
            fixed (float *__ptr_outMinValue = &outMinValue)
            {
                fixed (float *__ptr_outMaxValue = &outMaxValue)
                {
                    fixed (float *__ptr_outQuantizationScale = &outQuantizationScale)
                    {
                        __JPH_HeightFieldShapeSettings_DetermineMinAndMaxSample(_UnderlyingPtr, __ptr_outMinValue, __ptr_outMaxValue, __ptr_outQuantizationScale);
                    }
                }
            }
        }

        /// Given mBlockSize, mSampleCount and mHeightSamples, calculate the amount of bits needed to stay below absolute error inMaxError
        /// @param inMaxError Maximum allowed error in mHeightSamples after compression (note that this does not take mScale.Y into account)
        /// @return Needed bits per sample in the range [1, 8].
        /// Generated from method `JPH::HeightFieldShapeSettings::CalculateBitsPerSampleForError`.
        public unsafe uint CalculateBitsPerSampleForError(float inMaxError)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_CalculateBitsPerSampleForError", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_CalculateBitsPerSampleForError", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_HeightFieldShapeSettings_CalculateBitsPerSampleForError(_Underlying *_this, float inMaxError);
            return __JPH_HeightFieldShapeSettings_CalculateBitsPerSampleForError(_UnderlyingPtr, inMaxError);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::HeightFieldShapeSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShapeSettings_SetEmbedded(_Underlying *_this);
            __JPH_HeightFieldShapeSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::HeightFieldShapeSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_HeightFieldShapeSettings_GetRefCount(_Underlying *_this);
            return __JPH_HeightFieldShapeSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::HeightFieldShapeSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShapeSettings_AddRef(_Underlying *_this);
            __JPH_HeightFieldShapeSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::HeightFieldShapeSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShapeSettings_Release(_Underlying *_this);
            __JPH_HeightFieldShapeSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::HeightFieldShapeSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_HeightFieldShapeSettings_sInternalGetRefCountOffset();
            return __JPH_HeightFieldShapeSettings_sInternalGetRefCountOffset();
        }
    }

    /// Class that constructs a HeightFieldShape
    /// Generated from class `JPH::HeightFieldShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    /// This is the non-const half of the class.
    public class HeightFieldShapeSettings : Const_HeightFieldShapeSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(HeightFieldShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHShapeSettings(HeightFieldShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.RefTarget_JPHShapeSettings ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ShapeSettings(HeightFieldShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.ShapeSettings ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// The height field is a surface defined by: mOffset + mScale * (x, mHeightSamples[y * mSampleCount + x], y).
        /// where x and y are integers in the range x and y e [0, mSampleCount - 1].
        public new unsafe JPH.Vec3 mOffset
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_HeightFieldShapeSettings_GetMutable_mOffset(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_HeightFieldShapeSettings_GetMutable_mOffset(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mScale
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_HeightFieldShapeSettings_GetMutable_mScale(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_HeightFieldShapeSettings_GetMutable_mScale(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe ref uint mSampleCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mSampleCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mSampleCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_HeightFieldShapeSettings_GetMutable_mSampleCount(_Underlying *_this);
                return ref *__JPH_HeightFieldShapeSettings_GetMutable_mSampleCount(_UnderlyingPtr);
            }
        }

        /// Artificial minimal value of mHeightSamples, used for compression and can be used to update the terrain after creating with lower height values. If there are any lower values in mHeightSamples, this value will be ignored.
        public new unsafe ref float mMinHeightValue
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mMinHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mMinHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_HeightFieldShapeSettings_GetMutable_mMinHeightValue(_Underlying *_this);
                return ref *__JPH_HeightFieldShapeSettings_GetMutable_mMinHeightValue(_UnderlyingPtr);
            }
        }

        /// Artificial maximum value of mHeightSamples, used for compression and can be used to update the terrain after creating with higher height values. If there are any higher values in mHeightSamples, this value will be ignored.
        public new unsafe ref float mMaxHeightValue
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mMaxHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mMaxHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_HeightFieldShapeSettings_GetMutable_mMaxHeightValue(_Underlying *_this);
                return ref *__JPH_HeightFieldShapeSettings_GetMutable_mMaxHeightValue(_UnderlyingPtr);
            }
        }

        /// When bigger than mMaterials.size() the internal material list will be preallocated to support this number of materials.
        /// This avoids reallocations when calling HeightFieldShape::SetMaterials with new materials later.
        public new unsafe ref uint mMaterialsCapacity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mMaterialsCapacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mMaterialsCapacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_HeightFieldShapeSettings_GetMutable_mMaterialsCapacity(_Underlying *_this);
                return ref *__JPH_HeightFieldShapeSettings_GetMutable_mMaterialsCapacity(_UnderlyingPtr);
            }
        }

        /// The heightfield is divided in blocks of mBlockSize * mBlockSize * 2 triangles and the acceleration structure culls blocks only,
        /// bigger block sizes reduce memory consumption but also reduce query performance. Sensible values are [2, 8], does not need to be
        /// a power of 2. Note that at run-time we'll perform one more grid subdivision, so the effective block size is half of what is provided here.
        public new unsafe ref uint mBlockSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mBlockSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mBlockSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_HeightFieldShapeSettings_GetMutable_mBlockSize(_Underlying *_this);
                return ref *__JPH_HeightFieldShapeSettings_GetMutable_mBlockSize(_UnderlyingPtr);
            }
        }

        /// How many bits per sample to use to compress the height field. Can be in the range [1, 8].
        /// Note that each sample is compressed relative to the min/max value of its block of mBlockSize * mBlockSize pixels so the effective precision is higher.
        /// Also note that increasing mBlockSize saves more memory than reducing the amount of bits per sample.
        public new unsafe ref uint mBitsPerSample
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mBitsPerSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mBitsPerSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_HeightFieldShapeSettings_GetMutable_mBitsPerSample(_Underlying *_this);
                return ref *__JPH_HeightFieldShapeSettings_GetMutable_mBitsPerSample(_UnderlyingPtr);
            }
        }

        // cos(5 degrees)
        public new unsafe ref float mActiveEdgeCosThresholdAngle
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mActiveEdgeCosThresholdAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mActiveEdgeCosThresholdAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_HeightFieldShapeSettings_GetMutable_mActiveEdgeCosThresholdAngle(_Underlying *_this);
                return ref *__JPH_HeightFieldShapeSettings_GetMutable_mActiveEdgeCosThresholdAngle(_UnderlyingPtr);
            }
        }

        /// User data (to be used freely by the application)
        public new unsafe ref UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_HeightFieldShapeSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_HeightFieldShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe HeightFieldShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe HeightFieldShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_HeightFieldShapeSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
        public unsafe HeightFieldShapeSettings(JPH._ByValue_HeightFieldShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.HeightFieldShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_HeightFieldShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
        public HeightFieldShapeSettings(Const_HeightFieldShapeSettings _other) : this(new _ByValue_HeightFieldShapeSettings(_other)) {}

        /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
        public HeightFieldShapeSettings(HeightFieldShapeSettings _other) : this((Const_HeightFieldShapeSettings)_other) {}

        /// Generated from method `JPH::HeightFieldShapeSettings::operator=`.
        public unsafe JPH.HeightFieldShapeSettings Assign(JPH._ByValue_HeightFieldShapeSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.HeightFieldShapeSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_HeightFieldShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
        /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
        /// Generated from method `JPH::HeightFieldShapeSettings::ClearCachedResult`.
        public unsafe void ClearCachedResult()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShapeSettings_ClearCachedResult(_Underlying *_this);
            __JPH_HeightFieldShapeSettings_ClearCachedResult(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `HeightFieldShapeSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `HeightFieldShapeSettings`/`Const_HeightFieldShapeSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_HeightFieldShapeSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_HeightFieldShapeSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_HeightFieldShapeSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_HeightFieldShapeSettings(Const_HeightFieldShapeSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_HeightFieldShapeSettings(Const_HeightFieldShapeSettings arg) {return new(arg);}
        public _ByValue_HeightFieldShapeSettings(JPH._Moved<HeightFieldShapeSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_HeightFieldShapeSettings(JPH._Moved<HeightFieldShapeSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `HeightFieldShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_HeightFieldShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `HeightFieldShapeSettings`/`Const_HeightFieldShapeSettings` directly.
    public class _InOptMut_HeightFieldShapeSettings
    {
        public HeightFieldShapeSettings? Opt;

        public _InOptMut_HeightFieldShapeSettings() {}
        public _InOptMut_HeightFieldShapeSettings(HeightFieldShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_HeightFieldShapeSettings(HeightFieldShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `HeightFieldShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_HeightFieldShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `HeightFieldShapeSettings`/`Const_HeightFieldShapeSettings` to pass it to the function.
    public class _InOptConst_HeightFieldShapeSettings
    {
        public Const_HeightFieldShapeSettings? Opt;

        public _InOptConst_HeightFieldShapeSettings() {}
        public _InOptConst_HeightFieldShapeSettings(Const_HeightFieldShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_HeightFieldShapeSettings(Const_HeightFieldShapeSettings value) {return new(value);}
    }

    /// A height field shape. Cannot be used as a dynamic object.
    ///
    /// Note: If you're using HeightFieldShape and are querying data while modifying the shape you'll have a race condition.
    /// In this case it is best to create a new HeightFieldShape using the Clone function. You replace the shape on a body using BodyInterface::SetShape.
    /// If a query is still working on the old shape, it will have taken a reference and keep the old shape alive until the query finishes.
    /// Generated from class `JPH::HeightFieldShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Shape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_HeightFieldShape : JPH.Object<Const_HeightFieldShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_Release(void *_this);
            __JPH_RefTarget_JPH_Shape_Release(__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_HeightFieldShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(Const_HeightFieldShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShape._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.Const_RefTarget_JPHShape ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_HeightFieldShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Shape(Const_HeightFieldShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Const_Shape ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
        public static unsafe int CGetTrianglesMinTrianglesRequested
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_HeightFieldShape_Get_cGetTrianglesMinTrianglesRequested();
                return *__JPH_HeightFieldShape_Get_cGetTrianglesMinTrianglesRequested();
            }
        }

        internal unsafe Const_HeightFieldShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_HeightFieldShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.HeightFieldShape._Underlying *__JPH_HeightFieldShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_HeightFieldShape_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Generated from method `JPH::HeightFieldShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_HeightFieldShape_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_HeightFieldShape_size_t(inCount);
        }

        /// Generated from method `JPH::HeightFieldShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_HeightFieldShape_void_ptr(void *inPointer);
            __Jolt_delete_JPH_HeightFieldShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::HeightFieldShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_HeightFieldShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_HeightFieldShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::HeightFieldShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_HeightFieldShape_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_HeightFieldShape_size_t(inCount);
        }

        /// Generated from method `JPH::HeightFieldShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_HeightFieldShape_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_HeightFieldShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::HeightFieldShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_HeightFieldShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_HeightFieldShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::HeightFieldShape::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_HeightFieldShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_HeightFieldShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::HeightFieldShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_HeightFieldShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_HeightFieldShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::HeightFieldShape::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_HeightFieldShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_HeightFieldShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::HeightFieldShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_HeightFieldShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_HeightFieldShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See Shape::MustBeStatic
        /// Generated from method `JPH::HeightFieldShape::MustBeStatic`.
        public unsafe bool MustBeStatic()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_HeightFieldShape_MustBeStatic(_Underlying *_this);
            return __JPH_HeightFieldShape_MustBeStatic(_UnderlyingPtr) != 0;
        }

        /// Get the size of the height field. Note that this will always be rounded up to the nearest multiple of GetBlockSize().
        /// Generated from method `JPH::HeightFieldShape::GetSampleCount`.
        public unsafe uint GetSampleCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetSampleCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetSampleCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_HeightFieldShape_GetSampleCount(_Underlying *_this);
            return __JPH_HeightFieldShape_GetSampleCount(_UnderlyingPtr);
        }

        /// Get the size of a block
        /// Generated from method `JPH::HeightFieldShape::GetBlockSize`.
        public unsafe uint GetBlockSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetBlockSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetBlockSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_HeightFieldShape_GetBlockSize(_Underlying *_this);
            return __JPH_HeightFieldShape_GetBlockSize(_UnderlyingPtr);
        }

        // See Shape::GetLocalBounds
        /// Generated from method `JPH::HeightFieldShape::GetLocalBounds`.
        public unsafe JPH.AABox GetLocalBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_HeightFieldShape_GetLocalBounds(_Underlying *_this);
            return new(__JPH_HeightFieldShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetSubShapeIDBitsRecursive
        /// Generated from method `JPH::HeightFieldShape::GetSubShapeIDBitsRecursive`.
        public unsafe uint GetSubShapeIDBitsRecursive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_HeightFieldShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
            return __JPH_HeightFieldShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
        }

        // See Shape::GetInnerRadius
        /// Generated from method `JPH::HeightFieldShape::GetInnerRadius`.
        public unsafe float GetInnerRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_HeightFieldShape_GetInnerRadius(_Underlying *_this);
            return __JPH_HeightFieldShape_GetInnerRadius(_UnderlyingPtr);
        }

        // See Shape::GetMaterial
        /// Generated from method `JPH::HeightFieldShape::GetMaterial`.
        public unsafe JPH.Const_PhysicsMaterial? GetMaterial(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterial_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterial_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_HeightFieldShape_GetMaterial_1(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            var __c_ret = __JPH_HeightFieldShape_GetMaterial_1(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
        }

        /// Overload to get the material at a particular location
        /// Generated from method `JPH::HeightFieldShape::GetMaterial`.
        public unsafe JPH.Const_PhysicsMaterial? GetMaterial(uint inX, uint inY)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterial_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterial_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_HeightFieldShape_GetMaterial_2(_Underlying *_this, uint inX, uint inY);
            var __c_ret = __JPH_HeightFieldShape_GetMaterial_2(_UnderlyingPtr, inX, inY);
            return __c_ret is not null ? new JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetSurfaceNormal
        /// Generated from method `JPH::HeightFieldShape::GetSurfaceNormal`.
        public unsafe JPH.Vec3 GetSurfaceNormal(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inLocalSurfacePosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_HeightFieldShape_GetSurfaceNormal(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inLocalSurfacePosition);
            return new(__JPH_HeightFieldShape_GetSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inLocalSurfacePosition._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetSubmergedVolume
        /// Generated from method `JPH::HeightFieldShape::GetSubmergedVolume`.
        public unsafe void GetSubmergedVolume(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Plane inSurface, ref float outTotalVolume, ref float outSubmergedVolume, JPH.Vec3 outCenterOfBuoyancy)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShape_GetSubmergedVolume(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Const_Plane._Underlying *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH.Vec3._Underlying *outCenterOfBuoyancy);
            fixed (float *__ptr_outTotalVolume = &outTotalVolume)
            {
                fixed (float *__ptr_outSubmergedVolume = &outSubmergedVolume)
                {
                    __JPH_HeightFieldShape_GetSubmergedVolume(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inSurface._UnderlyingPtr, __ptr_outTotalVolume, __ptr_outSubmergedVolume, outCenterOfBuoyancy._UnderlyingPtr);
                }
            }
        }

        // See Shape::GetTrianglesStart
        /// Generated from method `JPH::HeightFieldShape::GetTrianglesStart`.
        public unsafe void GetTrianglesStart(JPH.Shape.GetTrianglesContext ioContext, JPH.Const_AABox inBox, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShape_GetTrianglesStart(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, JPH.Const_AABox._Underlying *inBox, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale);
            __JPH_HeightFieldShape_GetTrianglesStart(_UnderlyingPtr, ioContext._UnderlyingPtr, inBox._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        // See Shape::GetTrianglesNext
        /// Generated from method `JPH::HeightFieldShape::GetTrianglesNext`.
        public unsafe int GetTrianglesNext(JPH.Shape.GetTrianglesContext ioContext, int inMaxTrianglesRequested, JPH.Float3? outTriangleVertices, void **outMaterials = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_HeightFieldShape_GetTrianglesNext(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, int inMaxTrianglesRequested, JPH.Float3._Underlying *outTriangleVertices, void **outMaterials);
            return __JPH_HeightFieldShape_GetTrianglesNext(_UnderlyingPtr, ioContext._UnderlyingPtr, inMaxTrianglesRequested, outTriangleVertices is not null ? outTriangleVertices._UnderlyingPtr : null, outMaterials);
        }

        /// Get height field position at sampled location (inX, inY).
        /// where inX and inY are integers in the range inX e [0, mSampleCount - 1] and inY e [0, mSampleCount - 1].
        /// Generated from method `JPH::HeightFieldShape::GetPosition`.
        public unsafe JPH.Vec3 GetPosition(uint inX, uint inY)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_HeightFieldShape_GetPosition(_Underlying *_this, uint inX, uint inY);
            return new(__JPH_HeightFieldShape_GetPosition(_UnderlyingPtr, inX, inY), is_owning: true);
        }

        /// Check if height field at sampled location (inX, inY) has collision (has a hole or not)
        /// Generated from method `JPH::HeightFieldShape::IsNoCollision`.
        public unsafe bool IsNoCollision(uint inX, uint inY)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_IsNoCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_IsNoCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_HeightFieldShape_IsNoCollision(_Underlying *_this, uint inX, uint inY);
            return __JPH_HeightFieldShape_IsNoCollision(_UnderlyingPtr, inX, inY) != 0;
        }

        /// Projects inLocalPosition (a point in the space of the shape) along the Y axis onto the surface and returns it in outSurfacePosition.
        /// When there is no surface position (because of a hole or because the point is outside the heightfield) the function will return false.
        /// Generated from method `JPH::HeightFieldShape::ProjectOntoSurface`.
        public unsafe bool ProjectOntoSurface(JPH.Const_Vec3 inLocalPosition, JPH.Vec3 outSurfacePosition, JPH.SubShapeID outSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_ProjectOntoSurface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_ProjectOntoSurface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_HeightFieldShape_ProjectOntoSurface(_Underlying *_this, JPH.Vec3._Underlying *inLocalPosition, JPH.Vec3._Underlying *outSurfacePosition, JPH.SubShapeID._Underlying *outSubShapeID);
            return __JPH_HeightFieldShape_ProjectOntoSurface(_UnderlyingPtr, inLocalPosition._UnderlyingPtr, outSurfacePosition._UnderlyingPtr, outSubShapeID._UnderlyingPtr) != 0;
        }

        /// Returns the coordinates of the triangle that a sub shape ID represents
        /// @param inSubShapeID The sub shape ID to decode
        /// @param outX X coordinate of the triangle (in the range [0, mSampleCount - 2])
        /// @param outY Y coordinate of the triangle (in the range [0, mSampleCount - 2])
        /// @param outTriangleIndex Triangle within the quad (0 = lower triangle or 1 = upper triangle)
        /// Generated from method `JPH::HeightFieldShape::GetSubShapeCoordinates`.
        public unsafe void GetSubShapeCoordinates(JPH.Const_SubShapeID inSubShapeID, ref uint outX, ref uint outY, ref uint outTriangleIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeCoordinates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeCoordinates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShape_GetSubShapeCoordinates(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, uint *outX, uint *outY, uint *outTriangleIndex);
            fixed (uint *__ptr_outX = &outX)
            {
                fixed (uint *__ptr_outY = &outY)
                {
                    fixed (uint *__ptr_outTriangleIndex = &outTriangleIndex)
                    {
                        __JPH_HeightFieldShape_GetSubShapeCoordinates(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, __ptr_outX, __ptr_outY, __ptr_outTriangleIndex);
                    }
                }
            }
        }

        /// Get the range of height values that this height field can encode. Can be used to determine the allowed range when setting the height values with SetHeights.
        /// Generated from method `JPH::HeightFieldShape::GetMinHeightValue`.
        public unsafe float GetMinHeightValue()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetMinHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetMinHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_HeightFieldShape_GetMinHeightValue(_Underlying *_this);
            return __JPH_HeightFieldShape_GetMinHeightValue(_UnderlyingPtr);
        }

        /// Generated from method `JPH::HeightFieldShape::GetMaxHeightValue`.
        public unsafe float GetMaxHeightValue()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaxHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaxHeightValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_HeightFieldShape_GetMaxHeightValue(_Underlying *_this);
            return __JPH_HeightFieldShape_GetMaxHeightValue(_UnderlyingPtr);
        }

        // See Shape::GetStats
        /// Generated from method `JPH::HeightFieldShape::GetStats`.
        public unsafe JPH.Shape.Stats GetStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape.Stats._Underlying *__JPH_HeightFieldShape_GetStats(_Underlying *_this);
            return new(__JPH_HeightFieldShape_GetStats(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetVolume
        /// Generated from method `JPH::HeightFieldShape::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_HeightFieldShape_GetVolume(_Underlying *_this);
            return __JPH_HeightFieldShape_GetVolume(_UnderlyingPtr);
        }

        // Register shape functions with the registry
        /// Generated from method `JPH::HeightFieldShape::sRegister`.
        public static void SRegister()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShape_sRegister();
            __JPH_HeightFieldShape_sRegister();
        }

        /// User data (to be used freely by the application)
        /// Generated from method `JPH::HeightFieldShape::GetUserData`.
        public unsafe UIntPtr GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_HeightFieldShape_GetUserData(_Underlying *_this);
            return __JPH_HeightFieldShape_GetUserData(_UnderlyingPtr);
        }

        /// All shapes are centered around their center of mass. This function returns the center of mass position that needs to be applied to transform the shape to where it was created.
        /// Generated from method `JPH::HeightFieldShape::GetCenterOfMass`.
        public unsafe JPH.Vec3 GetCenterOfMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_HeightFieldShape_GetCenterOfMass(_Underlying *_this);
            return new(__JPH_HeightFieldShape_GetCenterOfMass(_UnderlyingPtr), is_owning: true);
        }

        /// Get the leaf shape for a particular sub shape ID.
        /// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
        /// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
        /// @return The shape or null if the sub shape ID is invalid
        /// Generated from method `JPH::HeightFieldShape::GetLeafShape`.
        public unsafe JPH.Const_Shape? GetLeafShape(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_HeightFieldShape_GetLeafShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            var __c_ret = __JPH_HeightFieldShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        /// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
        /// Generated from method `JPH::HeightFieldShape::GetSubShapeUserData`.
        public unsafe UIntPtr GetSubShapeUserData(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_HeightFieldShape_GetSubShapeUserData(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return __JPH_HeightFieldShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
        }

        /// Test if inScale is a valid scale for this shape. Some shapes can only be scaled uniformly, compound shapes cannot handle shapes
        /// being rotated and scaled (this would cause shearing), scale can never be zero. When the scale is invalid, the function will return false.
        ///
        /// Here's a list of supported scales:
        /// * SphereShape: Scale must be uniform (signs of scale are ignored).
        /// * BoxShape: Any scale supported (signs of scale are ignored).
        /// * TriangleShape: Any scale supported when convex radius is zero, otherwise only uniform scale supported.
        /// * CapsuleShape: Scale must be uniform (signs of scale are ignored).
        /// * TaperedCapsuleShape: Scale must be uniform (sign of Y scale can be used to flip the capsule).
        /// * CylinderShape: Scale must be uniform in XZ plane, Y can scale independently (signs of scale are ignored).
        /// * RotatedTranslatedShape: Scale must not cause shear in the child shape.
        /// * CompoundShape: Scale must not cause shear in any of the child shapes.
        /// Generated from method `JPH::HeightFieldShape::IsValidScale`.
        public unsafe bool IsValidScale(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_HeightFieldShape_IsValidScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return __JPH_HeightFieldShape_IsValidScale(_UnderlyingPtr, inScale._UnderlyingPtr) != 0;
        }

        /// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
        /// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
        /// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
        /// @param inScale Local space scale for this shape.
        /// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
        /// Generated from method `JPH::HeightFieldShape::MakeScaleValid`.
        public unsafe JPH.Vec3 MakeScaleValid(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_HeightFieldShape_MakeScaleValid(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_HeightFieldShape_MakeScaleValid(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::HeightFieldShape::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShape_SetEmbedded(_Underlying *_this);
            __JPH_HeightFieldShape_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::HeightFieldShape::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_HeightFieldShape_GetRefCount(_Underlying *_this);
            return __JPH_HeightFieldShape_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::HeightFieldShape::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShape_AddRef(_Underlying *_this);
            __JPH_HeightFieldShape_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::HeightFieldShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShape_Release(_Underlying *_this);
            __JPH_HeightFieldShape_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::HeightFieldShape::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_HeightFieldShape_sInternalGetRefCountOffset();
            return __JPH_HeightFieldShape_sInternalGetRefCountOffset();
        }
    }

    /// A height field shape. Cannot be used as a dynamic object.
    ///
    /// Note: If you're using HeightFieldShape and are querying data while modifying the shape you'll have a race condition.
    /// In this case it is best to create a new HeightFieldShape using the Clone function. You replace the shape on a body using BodyInterface::SetShape.
    /// If a query is still working on the old shape, it will have taken a reference and keep the old shape alive until the query finishes.
    /// Generated from class `JPH::HeightFieldShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Shape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class HeightFieldShape : Const_HeightFieldShape
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHShape(HeightFieldShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.RefTarget_JPHShape ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.NonCopyable(HeightFieldShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Shape(HeightFieldShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Shape ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe HeightFieldShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe HeightFieldShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.HeightFieldShape._Underlying *__JPH_HeightFieldShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_HeightFieldShape_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Generated from method `JPH::HeightFieldShape::SetUserData`.
        public unsafe void SetUserData(UIntPtr inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_HeightFieldShape_SetUserData(_Underlying *_this, UIntPtr inUserData);
            __JPH_HeightFieldShape_SetUserData(_UnderlyingPtr, inUserData);
        }
    }

    /// This is used as a function parameter when the underlying function receives `HeightFieldShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_HeightFieldShape
    {
        #pragma warning disable CS0649
        internal readonly Const_HeightFieldShape? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_HeightFieldShape() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `HeightFieldShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_HeightFieldShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `HeightFieldShape`/`Const_HeightFieldShape` directly.
    public class _InOptMut_HeightFieldShape
    {
        public HeightFieldShape? Opt;

        public _InOptMut_HeightFieldShape() {}
        public _InOptMut_HeightFieldShape(HeightFieldShape value) {Opt = value;}
        public static implicit operator _InOptMut_HeightFieldShape(HeightFieldShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `HeightFieldShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_HeightFieldShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `HeightFieldShape`/`Const_HeightFieldShape` to pass it to the function.
    public class _InOptConst_HeightFieldShape
    {
        public Const_HeightFieldShape? Opt;

        public _InOptConst_HeightFieldShape() {}
        public _InOptConst_HeightFieldShape(Const_HeightFieldShape value) {Opt = value;}
        public static implicit operator _InOptConst_HeightFieldShape(Const_HeightFieldShape value) {return new(value);}
    }
}
