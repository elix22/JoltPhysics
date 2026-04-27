// machine generated, do not edit
public static partial class Jolt
{
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
        public class Const_HeightFieldShapeSettings : Jolt.Object<Const_HeightFieldShapeSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HeightFieldShapeSettings_Destroy(_Underlying *_this);
                __JPH_HeightFieldShapeSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_HeightFieldShapeSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_SerializableObject(Const_HeightFieldShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_SerializableObject._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.Const_SerializableObject ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShapeSettings(Const_HeightFieldShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ShapeSettings(Const_HeightFieldShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_ShapeSettings ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_HeightFieldShapeSettings?(Jolt.JPH.Const_SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.Const_SerializableObject._Underlying *_this);
                var ptr = __JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_HeightFieldShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_HeightFieldShapeSettings?(Jolt.JPH.Const_ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.Const_ShapeSettings._Underlying *_this);
                var ptr = __JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_HeightFieldShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
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
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_HeightFieldShapeSettings_Get_mUserData(_Underlying *_this);
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
                extern static Jolt.JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_HeightFieldShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
            public unsafe Const_HeightFieldShapeSettings(Jolt.JPH._ByValue_HeightFieldShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.HeightFieldShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_HeightFieldShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
            public Const_HeightFieldShapeSettings(Const_HeightFieldShapeSettings _other) : this(new _ByValue_HeightFieldShapeSettings(_other)) {}

            /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
            public Const_HeightFieldShapeSettings(HeightFieldShapeSettings _other) : this((Const_HeightFieldShapeSettings)_other) {}

            /// Generated from method `JPH::HeightFieldShapeSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long(inCount);
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
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::HeightFieldShapeSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long(inCount);
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
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::HeightFieldShapeSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr(inCount, inPointer);
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
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_HeightFieldShapeSettings_unsigned_long_void_ptr(inCount, inPointer);
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
            public static unsafe implicit operator Jolt.JPH.SerializableObject(HeightFieldShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SerializableObject._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.SerializableObject ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShapeSettings(HeightFieldShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShapeSettings ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ShapeSettings(HeightFieldShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.ShapeSettings ret = new(__JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator HeightFieldShapeSettings?(Jolt.JPH.SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.SerializableObject._Underlying *_this);
                var ptr = __JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                HeightFieldShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator HeightFieldShapeSettings?(Jolt.JPH.ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.ShapeSettings._Underlying *_this);
                var ptr = __JPH_HeightFieldShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                HeightFieldShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
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
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_HeightFieldShapeSettings_GetMutable_mUserData(_Underlying *_this);
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
                extern static Jolt.JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_HeightFieldShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
            public unsafe HeightFieldShapeSettings(Jolt.JPH._ByValue_HeightFieldShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.HeightFieldShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_HeightFieldShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
            public HeightFieldShapeSettings(Const_HeightFieldShapeSettings _other) : this(new _ByValue_HeightFieldShapeSettings(_other)) {}

            /// Generated from constructor `JPH::HeightFieldShapeSettings::HeightFieldShapeSettings`.
            public HeightFieldShapeSettings(HeightFieldShapeSettings _other) : this((Const_HeightFieldShapeSettings)_other) {}

            /// Generated from method `JPH::HeightFieldShapeSettings::operator=`.
            public unsafe Jolt.JPH.HeightFieldShapeSettings Assign(Jolt.JPH._ByValue_HeightFieldShapeSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HeightFieldShapeSettings._Underlying *__JPH_HeightFieldShapeSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.HeightFieldShapeSettings._Underlying *_other);
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
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_HeightFieldShapeSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_HeightFieldShapeSettings(Const_HeightFieldShapeSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_HeightFieldShapeSettings(Const_HeightFieldShapeSettings arg) {return new(arg);}
            public _ByValue_HeightFieldShapeSettings(Jolt._Moved<HeightFieldShapeSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
            public static implicit operator _ByValue_HeightFieldShapeSettings(Jolt._Moved<HeightFieldShapeSettings> arg) {return new(arg);}
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
        public class Const_HeightFieldShape : Jolt.Object<Const_HeightFieldShape>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HeightFieldShape_Destroy(_Underlying *_this);
                __JPH_HeightFieldShape_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_HeightFieldShape() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShape(Const_HeightFieldShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShape._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShape ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_HeightFieldShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_Shape(Const_HeightFieldShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_Shape ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_HeightFieldShape?(Jolt.JPH.Const_Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HeightFieldShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Const_Shape._Underlying *_this);
                var ptr = __JPH_HeightFieldShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_HeightFieldShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
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
                extern static Jolt.JPH.HeightFieldShape._Underlying *__JPH_HeightFieldShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_HeightFieldShape_DefaultConstruct();
            }

            /// Generated from method `JPH::HeightFieldShape::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_HeightFieldShape_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_HeightFieldShape_unsigned_long(inCount);
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
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HeightFieldShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_HeightFieldShape_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_HeightFieldShape_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::HeightFieldShape::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_HeightFieldShape_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_HeightFieldShape_unsigned_long(inCount);
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
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HeightFieldShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_HeightFieldShape_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_HeightFieldShape_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::HeightFieldShape::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HeightFieldShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_HeightFieldShape_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_HeightFieldShape_unsigned_long_void_ptr(inCount, inPointer);
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
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HeightFieldShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_HeightFieldShape_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_HeightFieldShape_unsigned_long_void_ptr(inCount, inPointer);
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
            public unsafe Jolt.JPH.AABox GetLocalBounds()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_HeightFieldShape_GetLocalBounds(_Underlying *_this);
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
            public unsafe Jolt.JPH.Const_PhysicsMaterial? GetMaterial(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterial_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterial_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_PhysicsMaterial._Underlying *__JPH_HeightFieldShape_GetMaterial_1(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                var __c_ret = __JPH_HeightFieldShape_GetMaterial_1(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
            }

            /// Overload to get the material at a particular location
            /// Generated from method `JPH::HeightFieldShape::GetMaterial`.
            public unsafe Jolt.JPH.Const_PhysicsMaterial? GetMaterial(uint inX, uint inY)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterial_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterial_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_PhysicsMaterial._Underlying *__JPH_HeightFieldShape_GetMaterial_2(_Underlying *_this, uint inX, uint inY);
                var __c_ret = __JPH_HeightFieldShape_GetMaterial_2(_UnderlyingPtr, inX, inY);
                return __c_ret is not null ? new Jolt.JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
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

            /// Returns the coordinates of the triangle that a sub shape ID represents
            /// @param inSubShapeID The sub shape ID to decode
            /// @param outX X coordinate of the triangle (in the range [0, mSampleCount - 2])
            /// @param outY Y coordinate of the triangle (in the range [0, mSampleCount - 2])
            /// @param outTriangleIndex Triangle within the quad (0 = lower triangle or 1 = upper triangle)
            /// Generated from method `JPH::HeightFieldShape::GetSubShapeCoordinates`.
            public unsafe void GetSubShapeCoordinates(Jolt.JPH.Const_SubShapeID inSubShapeID, ref uint outX, ref uint outY, ref uint outTriangleIndex)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeCoordinates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeCoordinates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HeightFieldShape_GetSubShapeCoordinates(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID, uint *outX, uint *outY, uint *outTriangleIndex);
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

            /// Get the height values of a block of data.
            /// Note that the height values are decompressed so will be slightly different from what the shape was originally created with.
            /// @param inX Start X position, must be a multiple of mBlockSize and in the range [0, mSampleCount - 1]
            /// @param inY Start Y position, must be a multiple of mBlockSize and in the range [0, mSampleCount - 1]
            /// @param inSizeX Number of samples in X direction, must be a multiple of mBlockSize and in the range [0, mSampleCount - inX]
            /// @param inSizeY Number of samples in Y direction, must be a multiple of mBlockSize and in the range [0, mSampleCount - inY]
            /// @param outHeights Returned height values, must be at least inSizeX * inSizeY floats. Values are returned in x-major order and can be cNoCollisionValue.
            /// @param inHeightsStride Stride in floats between two consecutive rows of outHeights (can be negative if the data is upside down).
            /// Generated from method `JPH::HeightFieldShape::GetHeights`.
            public unsafe void GetHeights(uint inX, uint inY, uint inSizeX, uint inSizeY, Jolt.InOut<float>? outHeights, long inHeightsStride)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetHeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetHeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HeightFieldShape_GetHeights(_Underlying *_this, uint inX, uint inY, uint inSizeX, uint inSizeY, float *outHeights, long inHeightsStride);
                float __value_outHeights = outHeights is not null ? outHeights.Value : default(float);
                if (outHeights is not null) outHeights.Value = __value_outHeights;
                __JPH_HeightFieldShape_GetHeights(_UnderlyingPtr, inX, inY, inSizeX, inSizeY, outHeights is not null ? &__value_outHeights : null, inHeightsStride);
            }

            /// Get the material indices of a block of data.
            /// @param inX Start X position, must in the range [0, mSampleCount - 1]
            /// @param inY Start Y position, must in the range [0, mSampleCount - 1]
            /// @param inSizeX Number of samples in X direction
            /// @param inSizeY Number of samples in Y direction
            /// @param outMaterials Returned material indices, must be at least inSizeX * inSizeY uint8s. Values are returned in x-major order.
            /// @param inMaterialsStride Stride in uint8s between two consecutive rows of outMaterials (can be negative if the data is upside down).
            /// Generated from method `JPH::HeightFieldShape::GetMaterials`.
            public unsafe void GetMaterials(uint inX, uint inY, uint inSizeX, uint inSizeY, Jolt.InOut<byte>? outMaterials, long inMaterialsStride)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetMaterials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HeightFieldShape_GetMaterials(_Underlying *_this, uint inX, uint inY, uint inSizeX, uint inSizeY, byte *outMaterials, long inMaterialsStride);
                byte __value_outMaterials = outMaterials is not null ? outMaterials.Value : default(byte);
                if (outMaterials is not null) outMaterials.Value = __value_outMaterials;
                __JPH_HeightFieldShape_GetMaterials(_UnderlyingPtr, inX, inY, inSizeX, inSizeY, outMaterials is not null ? &__value_outMaterials : null, inMaterialsStride);
            }

            // See Shape::GetStats
            /// Generated from method `JPH::HeightFieldShape::GetStats`.
            public unsafe Jolt.JPH.Shape.Stats GetStats()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape.Stats._Underlying *__JPH_HeightFieldShape_GetStats(_Underlying *_this);
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
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_HeightFieldShape_GetUserData(_Underlying *_this);
                return __JPH_HeightFieldShape_GetUserData(_UnderlyingPtr);
            }

            /// Get the leaf shape for a particular sub shape ID.
            /// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
            /// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
            /// @return The shape or null if the sub shape ID is invalid
            /// Generated from method `JPH::HeightFieldShape::GetLeafShape`.
            public unsafe Jolt.JPH.Const_Shape? GetLeafShape(Jolt.JPH.Const_SubShapeID inSubShapeID, Jolt.JPH.SubShapeID outRemainder)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_HeightFieldShape_GetLeafShape(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID, Jolt.JPH.SubShapeID._Underlying *outRemainder);
                var __c_ret = __JPH_HeightFieldShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            /// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
            /// Generated from method `JPH::HeightFieldShape::GetSubShapeUserData`.
            public unsafe ulong GetSubShapeUserData(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_HeightFieldShape_GetSubShapeUserData(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                return __JPH_HeightFieldShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
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
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShape(HeightFieldShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShape._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShape ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(HeightFieldShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Shape(HeightFieldShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape._Underlying *__JPH_HeightFieldShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Shape ret = new(__JPH_HeightFieldShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator HeightFieldShape?(Jolt.JPH.Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HeightFieldShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Shape._Underlying *_this);
                var ptr = __JPH_HeightFieldShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                HeightFieldShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
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
                extern static Jolt.JPH.HeightFieldShape._Underlying *__JPH_HeightFieldShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_HeightFieldShape_DefaultConstruct();
            }

            /// Set the height values of a block of data.
            /// Note that this requires decompressing and recompressing a border of size mBlockSize in the negative x/y direction so will cause some precision loss.
            /// Beware this can create a race condition if you're running collision queries in parallel. See class documentation for more information.
            /// @param inX Start X position, must be a multiple of mBlockSize and in the range [0, mSampleCount - 1]
            /// @param inY Start Y position, must be a multiple of mBlockSize and in the range [0, mSampleCount - 1]
            /// @param inSizeX Number of samples in X direction, must be a multiple of mBlockSize and in the range [0, mSampleCount - inX]
            /// @param inSizeY Number of samples in Y direction, must be a multiple of mBlockSize and in the range [0, mSampleCount - inY]
            /// @param inHeights The new height values to set, must be an array of inSizeX * inSizeY floats, can be cNoCollisionValue. Values outside of the range [GetMinHeightValue(), GetMaxHeightValue()] will be clamped.
            /// @param inHeightsStride Stride in floats between two consecutive rows of inHeights (can be negative if the data is upside down).
            /// @param inAllocator Allocator to use for temporary memory
            /// @param inActiveEdgeCosThresholdAngle Cosine of the threshold angle (if the angle between the two triangles is bigger than this, the edge is active, note that a concave edge is always inactive).
            /// Generated from method `JPH::HeightFieldShape::SetHeights`.
            /// Parameter `inActiveEdgeCosThresholdAngle` defaults to ``.
            public unsafe void SetHeights(uint inX, uint inY, uint inSizeX, uint inSizeY, float? inHeights, long inHeightsStride, Jolt.JPH.TempAllocator inAllocator, float? inActiveEdgeCosThresholdAngle = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_SetHeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_SetHeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HeightFieldShape_SetHeights(_Underlying *_this, uint inX, uint inY, uint inSizeX, uint inSizeY, float *inHeights, long inHeightsStride, Jolt.JPH.TempAllocator._Underlying *inAllocator, float *inActiveEdgeCosThresholdAngle);
                float __deref_inHeights = inHeights.GetValueOrDefault();
                float __deref_inActiveEdgeCosThresholdAngle = inActiveEdgeCosThresholdAngle.GetValueOrDefault();
                __JPH_HeightFieldShape_SetHeights(_UnderlyingPtr, inX, inY, inSizeX, inSizeY, inHeights.HasValue ? &__deref_inHeights : null, inHeightsStride, inAllocator._UnderlyingPtr, inActiveEdgeCosThresholdAngle.HasValue ? &__deref_inActiveEdgeCosThresholdAngle : null);
            }

            /// Generated from method `JPH::HeightFieldShape::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HeightFieldShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HeightFieldShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HeightFieldShape_SetUserData(_Underlying *_this, ulong inUserData);
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
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_HeightFieldShape() {PassByMode = Jolt._PassBy.default_construct;}
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
}
