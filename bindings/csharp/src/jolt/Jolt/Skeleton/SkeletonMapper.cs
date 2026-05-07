// machine generated, do not edit
public static partial class JPH
{
    /// Class that is able to map a low detail (ragdoll) skeleton to a high detail (animation) skeleton and vice versa
    /// Generated from class `JPH::SkeletonMapper`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::SkeletonMapper>`
    /// This is the const half of the class.
    public class Const_SkeletonMapper : JPH.Object<Const_SkeletonMapper>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletonMapper_Release(void *_this);
            __JPH_RefTarget_JPH_SkeletonMapper_Release(__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SkeletonMapper() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHSkeletonMapper(Const_SkeletonMapper self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHSkeletonMapper._Underlying *__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_Underlying *_this);
            JPH.Const_RefTarget_JPHSkeletonMapper ret = new(__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_SkeletonMapper(JPH.Const_RefTarget_JPHSkeletonMapper parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper(JPH.Const_RefTarget_JPHSkeletonMapper._Underlying *_this);
            Const_SkeletonMapper ret = new(__JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_SkeletonMapper(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SkeletonMapper() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonMapper._Underlying *__JPH_SkeletonMapper_DefaultConstruct();
            _UnderlyingPtr = __JPH_SkeletonMapper_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletonMapper_AddRef(void *_this);
            __JPH_RefTarget_JPH_SkeletonMapper_AddRef(__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::SkeletonMapper::SkeletonMapper`.
        public unsafe Const_SkeletonMapper(JPH._ByValue_SkeletonMapper _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonMapper._Underlying *__JPH_SkeletonMapper_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletonMapper._Underlying *_other);
            _UnderlyingPtr = __JPH_SkeletonMapper_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletonMapper_AddRef(void *_this);
            __JPH_RefTarget_JPH_SkeletonMapper_AddRef(__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SkeletonMapper::SkeletonMapper`.
        public Const_SkeletonMapper(Const_SkeletonMapper _other) : this(new _ByValue_SkeletonMapper(_other)) {}

        /// Generated from constructor `JPH::SkeletonMapper::SkeletonMapper`.
        public Const_SkeletonMapper(SkeletonMapper _other) : this((Const_SkeletonMapper)_other) {}

        /// Default function that checks if the names of the joints are equal
        /// Generated from method `JPH::SkeletonMapper::sDefaultCanMapJoint`.
        public static unsafe bool SDefaultCanMapJoint(JPH.Const_Skeleton? inSkeleton1, int inIndex1, JPH.Const_Skeleton? inSkeleton2, int inIndex2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_sDefaultCanMapJoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_sDefaultCanMapJoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SkeletonMapper_sDefaultCanMapJoint(JPH.Const_Skeleton._Underlying *inSkeleton1, int inIndex1, JPH.Const_Skeleton._Underlying *inSkeleton2, int inIndex2);
            return __JPH_SkeletonMapper_sDefaultCanMapJoint(inSkeleton1 is not null ? inSkeleton1._UnderlyingPtr : null, inIndex1, inSkeleton2 is not null ? inSkeleton2._UnderlyingPtr : null, inIndex2) != 0;
        }

        /// Map a pose. Joints that were directly mappable will be copied in model space from pose 1 to pose 2. Any joints that are only present in skeleton 2
        /// will get their model space transform calculated through the local space transforms of pose 2. Joints that are part of a joint chain between two
        /// mapped joints will be reoriented towards the next joint in skeleton 1. This means that it is possible for unmapped joints to have some animation,
        /// but very extreme animation poses will show artifacts.
        /// @param inPose1ModelSpace Pose on skeleton 1 in model space
        /// @param inPose2LocalSpace Pose on skeleton 2 in local space (used for the joints that cannot be mapped)
        /// @param outPose2ModelSpace Model space pose on skeleton 2 (the output of the mapping)
        /// Generated from method `JPH::SkeletonMapper::Map`.
        public unsafe void Map(JPH.Const_Mat44? inPose1ModelSpace, JPH.Const_Mat44? inPose2LocalSpace, JPH.Mat44? outPose2ModelSpace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Map", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Map", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonMapper_Map(_Underlying *_this, JPH.Const_Mat44._Underlying *inPose1ModelSpace, JPH.Const_Mat44._Underlying *inPose2LocalSpace, JPH.Mat44._Underlying *outPose2ModelSpace);
            __JPH_SkeletonMapper_Map(_UnderlyingPtr, inPose1ModelSpace is not null ? inPose1ModelSpace._UnderlyingPtr : null, inPose2LocalSpace is not null ? inPose2LocalSpace._UnderlyingPtr : null, outPose2ModelSpace is not null ? outPose2ModelSpace._UnderlyingPtr : null);
        }

        /// Reverse map a pose, this will only use the mappings and not the chains (it assumes that all joints in skeleton 1 are mapped)
        /// @param inPose2ModelSpace Model space pose on skeleton 2
        /// @param outPose1ModelSpace When the function returns this will contain the model space pose for skeleton 1
        /// Generated from method `JPH::SkeletonMapper::MapReverse`.
        public unsafe void MapReverse(JPH.Const_Mat44? inPose2ModelSpace, JPH.Mat44? outPose1ModelSpace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_MapReverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_MapReverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonMapper_MapReverse(_Underlying *_this, JPH.Const_Mat44._Underlying *inPose2ModelSpace, JPH.Mat44._Underlying *outPose1ModelSpace);
            __JPH_SkeletonMapper_MapReverse(_UnderlyingPtr, inPose2ModelSpace is not null ? inPose2ModelSpace._UnderlyingPtr : null, outPose1ModelSpace is not null ? outPose1ModelSpace._UnderlyingPtr : null);
        }

        /// Search through the directly mapped joints (mMappings) and find inJoint1Idx, returns the corresponding Joint2Idx or -1 if not found.
        /// Generated from method `JPH::SkeletonMapper::GetMappedJointIdx`.
        public unsafe int GetMappedJointIdx(int inJoint1Idx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetMappedJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetMappedJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_SkeletonMapper_GetMappedJointIdx(_Underlying *_this, int inJoint1Idx);
            return __JPH_SkeletonMapper_GetMappedJointIdx(_UnderlyingPtr, inJoint1Idx);
        }

        /// Search through the locked translations (mLockedTranslations) and find if joint inJoint2Idx is locked.
        /// Generated from method `JPH::SkeletonMapper::IsJointTranslationLocked`.
        public unsafe bool IsJointTranslationLocked(int inJoint2Idx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_IsJointTranslationLocked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_IsJointTranslationLocked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SkeletonMapper_IsJointTranslationLocked(_Underlying *_this, int inJoint2Idx);
            return __JPH_SkeletonMapper_IsJointTranslationLocked(_UnderlyingPtr, inJoint2Idx) != 0;
        }

        ///@name Access to the mapped joints
        ///@{
        /// Generated from method `JPH::SkeletonMapper::GetMappings`.
        public unsafe JPH.Const_Array_JPHSkeletonMapperMapping GetMappings()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetMappings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetMappings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHSkeletonMapperMapping._Underlying *__JPH_SkeletonMapper_GetMappings(_Underlying *_this);
            return new(__JPH_SkeletonMapper_GetMappings(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonMapper::GetChains`.
        public unsafe JPH.Const_Array_JPHSkeletonMapperChain GetChains()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetChains", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetChains", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHSkeletonMapperChain._Underlying *__JPH_SkeletonMapper_GetChains(_Underlying *_this);
            return new(__JPH_SkeletonMapper_GetChains(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonMapper::GetUnmapped`.
        public unsafe JPH.Const_Array_JPHSkeletonMapperUnmapped GetUnmapped()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetUnmapped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetUnmapped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHSkeletonMapperUnmapped._Underlying *__JPH_SkeletonMapper_GetUnmapped(_Underlying *_this);
            return new(__JPH_SkeletonMapper_GetUnmapped(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonMapper::GetLockedTranslations`.
        public unsafe JPH.Const_Array_JPHSkeletonMapperLocked GetLockedTranslations()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetLockedTranslations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetLockedTranslations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHSkeletonMapperLocked._Underlying *__JPH_SkeletonMapper_GetLockedTranslations(_Underlying *_this);
            return new(__JPH_SkeletonMapper_GetLockedTranslations(_UnderlyingPtr), is_owning: false);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::SkeletonMapper::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonMapper_SetEmbedded(_Underlying *_this);
            __JPH_SkeletonMapper_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::SkeletonMapper::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SkeletonMapper_GetRefCount(_Underlying *_this);
            return __JPH_SkeletonMapper_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::SkeletonMapper::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonMapper_AddRef(_Underlying *_this);
            __JPH_SkeletonMapper_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SkeletonMapper::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonMapper_Release(_Underlying *_this);
            __JPH_SkeletonMapper_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::SkeletonMapper::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_SkeletonMapper_sInternalGetRefCountOffset();
            return __JPH_SkeletonMapper_sInternalGetRefCountOffset();
        }

        /// A joint chain that starts with a 1-on-1 mapped joint and ends with a 1-on-1 mapped joint with intermediate joints that cannot be mapped
        /// Generated from class `JPH::SkeletonMapper::Chain`.
        /// This is the const half of the class.
        public class Const_Chain : JPH.Object<Const_Chain>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletonMapper_Chain_Destroy(_Underlying *_this);
                __JPH_SkeletonMapper_Chain_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Chain() {Dispose(false);}

            ///< Joint chain from skeleton 1
            public unsafe JPH.Const_Array_Int mJointIndices1
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Get_mJointIndices1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Get_mJointIndices1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Array_Int._Underlying *__JPH_SkeletonMapper_Chain_Get_mJointIndices1(_Underlying *_this);
                    JPH.Const_Array_Int __ret;
                    __ret = new(__JPH_SkeletonMapper_Chain_Get_mJointIndices1(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Corresponding joint chain from skeleton 2
            public unsafe JPH.Const_Array_Int mJointIndices2
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Get_mJointIndices2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Get_mJointIndices2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Array_Int._Underlying *__JPH_SkeletonMapper_Chain_Get_mJointIndices2(_Underlying *_this);
                    JPH.Const_Array_Int __ret;
                    __ret = new(__JPH_SkeletonMapper_Chain_Get_mJointIndices2(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_Chain(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Chain() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Chain._Underlying *__JPH_SkeletonMapper_Chain_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonMapper_Chain_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
            public unsafe Const_Chain(JPH.SkeletonMapper._ByValue_Chain _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Chain._Underlying *__JPH_SkeletonMapper_Chain_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletonMapper.Chain._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonMapper_Chain_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
            public Const_Chain(Const_Chain _other) : this(new _ByValue_Chain(_other)) {}

            /// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
            public Const_Chain(Chain _other) : this((Const_Chain)_other) {}

            /// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
            public unsafe Const_Chain(JPH._Moved<JPH.Array_Int> inJointIndices1, JPH._Moved<JPH.Array_Int> inJointIndices2) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Chain._Underlying *__JPH_SkeletonMapper_Chain_Construct(JPH.Array_Int._Underlying *inJointIndices1, JPH.Array_Int._Underlying *inJointIndices2);
                _UnderlyingPtr = __JPH_SkeletonMapper_Chain_Construct(inJointIndices1.Value._UnderlyingPtr, inJointIndices2.Value._UnderlyingPtr);
            }
        }

        /// A joint chain that starts with a 1-on-1 mapped joint and ends with a 1-on-1 mapped joint with intermediate joints that cannot be mapped
        /// Generated from class `JPH::SkeletonMapper::Chain`.
        /// This is the non-const half of the class.
        public class Chain : Const_Chain
        {
            ///< Joint chain from skeleton 1
            public new unsafe JPH.Array_Int mJointIndices1
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_GetMutable_mJointIndices1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_GetMutable_mJointIndices1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Array_Int._Underlying *__JPH_SkeletonMapper_Chain_GetMutable_mJointIndices1(_Underlying *_this);
                    JPH.Array_Int __ret;
                    __ret = new(__JPH_SkeletonMapper_Chain_GetMutable_mJointIndices1(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Corresponding joint chain from skeleton 2
            public new unsafe JPH.Array_Int mJointIndices2
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_GetMutable_mJointIndices2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_GetMutable_mJointIndices2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Array_Int._Underlying *__JPH_SkeletonMapper_Chain_GetMutable_mJointIndices2(_Underlying *_this);
                    JPH.Array_Int __ret;
                    __ret = new(__JPH_SkeletonMapper_Chain_GetMutable_mJointIndices2(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Chain(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Chain() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Chain._Underlying *__JPH_SkeletonMapper_Chain_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonMapper_Chain_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
            public unsafe Chain(JPH.SkeletonMapper._ByValue_Chain _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Chain._Underlying *__JPH_SkeletonMapper_Chain_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletonMapper.Chain._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonMapper_Chain_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
            public Chain(Const_Chain _other) : this(new _ByValue_Chain(_other)) {}

            /// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
            public Chain(Chain _other) : this((Const_Chain)_other) {}

            /// Generated from constructor `JPH::SkeletonMapper::Chain::Chain`.
            public unsafe Chain(JPH._Moved<JPH.Array_Int> inJointIndices1, JPH._Moved<JPH.Array_Int> inJointIndices2) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Chain._Underlying *__JPH_SkeletonMapper_Chain_Construct(JPH.Array_Int._Underlying *inJointIndices1, JPH.Array_Int._Underlying *inJointIndices2);
                _UnderlyingPtr = __JPH_SkeletonMapper_Chain_Construct(inJointIndices1.Value._UnderlyingPtr, inJointIndices2.Value._UnderlyingPtr);
            }

            /// Generated from method `JPH::SkeletonMapper::Chain::operator=`.
            public unsafe JPH.SkeletonMapper.Chain Assign(JPH.SkeletonMapper._ByValue_Chain _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Chain_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Chain._Underlying *__JPH_SkeletonMapper_Chain_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SkeletonMapper.Chain._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_SkeletonMapper_Chain_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `Chain` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `Chain`/`Const_Chain` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_Chain
        {
            #pragma warning disable CS0649
            internal readonly Const_Chain? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_Chain() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_Chain(Const_Chain new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_Chain(Const_Chain arg) {return new(arg);}
            public _ByValue_Chain(JPH._Moved<Chain> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_Chain(JPH._Moved<Chain> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `Chain` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Chain`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Chain`/`Const_Chain` directly.
        public class _InOptMut_Chain
        {
            public Chain? Opt;

            public _InOptMut_Chain() {}
            public _InOptMut_Chain(Chain value) {Opt = value;}
            public static implicit operator _InOptMut_Chain(Chain value) {return new(value);}
        }

        /// This is used for optional parameters of class `Chain` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Chain`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Chain`/`Const_Chain` to pass it to the function.
        public class _InOptConst_Chain
        {
            public Const_Chain? Opt;

            public _InOptConst_Chain() {}
            public _InOptConst_Chain(Const_Chain value) {Opt = value;}
            public static implicit operator _InOptConst_Chain(Const_Chain value) {return new(value);}
        }

        /// Joints that should have their translation locked (fixed)
        /// Generated from class `JPH::SkeletonMapper::Locked`.
        /// This is the const half of the class.
        public class Const_Locked : JPH.Object<Const_Locked>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletonMapper_Locked_Destroy(_Underlying *_this);
                __JPH_SkeletonMapper_Locked_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Locked() {Dispose(false);}

            ///< Joint index of joint with locked translation (in skeleton 2)
            public unsafe int mJointIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_Get_mJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_Get_mJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Locked_Get_mJointIdx(_Underlying *_this);
                    return *__JPH_SkeletonMapper_Locked_Get_mJointIdx(_UnderlyingPtr);
                }
            }

            ///< Parent joint index of joint with locked translation (in skeleton 2)
            public unsafe int mParentJointIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_Get_mParentJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_Get_mParentJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Locked_Get_mParentJointIdx(_Underlying *_this);
                    return *__JPH_SkeletonMapper_Locked_Get_mParentJointIdx(_UnderlyingPtr);
                }
            }

            ///< Translation of neutral pose
            public unsafe JPH.Const_Vec3 mTranslation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_Get_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_Get_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_SkeletonMapper_Locked_Get_mTranslation(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_SkeletonMapper_Locked_Get_mTranslation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_Locked(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Locked() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Locked._Underlying *__JPH_SkeletonMapper_Locked_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonMapper_Locked_DefaultConstruct();
            }

            /// Constructs `JPH::SkeletonMapper::Locked` elementwise.
            public unsafe Const_Locked(int mJointIdx, int mParentJointIdx, JPH.Const_Vec3 mTranslation) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Locked._Underlying *__JPH_SkeletonMapper_Locked_ConstructFrom(int mJointIdx, int mParentJointIdx, JPH.Vec3._Underlying *mTranslation);
                _UnderlyingPtr = __JPH_SkeletonMapper_Locked_ConstructFrom(mJointIdx, mParentJointIdx, mTranslation._UnderlyingPtr);
                _KeepAlive(mTranslation);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Locked::Locked`.
            public unsafe Const_Locked(JPH.SkeletonMapper.Const_Locked _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Locked._Underlying *__JPH_SkeletonMapper_Locked_ConstructFromAnother(JPH.SkeletonMapper.Locked._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonMapper_Locked_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Locked::Locked`.
            public Const_Locked(Locked _other) : this((Const_Locked)_other) {}
        }

        /// Joints that should have their translation locked (fixed)
        /// Generated from class `JPH::SkeletonMapper::Locked`.
        /// This is the non-const half of the class.
        public class Locked : Const_Locked
        {
            ///< Joint index of joint with locked translation (in skeleton 2)
            public new unsafe ref int mJointIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_GetMutable_mJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_GetMutable_mJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Locked_GetMutable_mJointIdx(_Underlying *_this);
                    return ref *__JPH_SkeletonMapper_Locked_GetMutable_mJointIdx(_UnderlyingPtr);
                }
            }

            ///< Parent joint index of joint with locked translation (in skeleton 2)
            public new unsafe ref int mParentJointIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_GetMutable_mParentJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_GetMutable_mParentJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Locked_GetMutable_mParentJointIdx(_Underlying *_this);
                    return ref *__JPH_SkeletonMapper_Locked_GetMutable_mParentJointIdx(_UnderlyingPtr);
                }
            }

            ///< Translation of neutral pose
            public new unsafe JPH.Vec3 mTranslation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_GetMutable_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_GetMutable_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_SkeletonMapper_Locked_GetMutable_mTranslation(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_SkeletonMapper_Locked_GetMutable_mTranslation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Locked(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Locked() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Locked._Underlying *__JPH_SkeletonMapper_Locked_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonMapper_Locked_DefaultConstruct();
            }

            /// Constructs `JPH::SkeletonMapper::Locked` elementwise.
            public unsafe Locked(int mJointIdx, int mParentJointIdx, JPH.Const_Vec3 mTranslation) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Locked._Underlying *__JPH_SkeletonMapper_Locked_ConstructFrom(int mJointIdx, int mParentJointIdx, JPH.Vec3._Underlying *mTranslation);
                _UnderlyingPtr = __JPH_SkeletonMapper_Locked_ConstructFrom(mJointIdx, mParentJointIdx, mTranslation._UnderlyingPtr);
                _KeepAlive(mTranslation);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Locked::Locked`.
            public unsafe Locked(JPH.SkeletonMapper.Const_Locked _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Locked._Underlying *__JPH_SkeletonMapper_Locked_ConstructFromAnother(JPH.SkeletonMapper.Locked._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonMapper_Locked_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Locked::Locked`.
            public Locked(Locked _other) : this((Const_Locked)_other) {}

            /// Generated from method `JPH::SkeletonMapper::Locked::operator=`.
            public unsafe JPH.SkeletonMapper.Locked Assign(JPH.SkeletonMapper.Const_Locked _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Locked_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Locked._Underlying *__JPH_SkeletonMapper_Locked_AssignFromAnother(_Underlying *_this, JPH.SkeletonMapper.Locked._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SkeletonMapper_Locked_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Locked` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Locked`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Locked`/`Const_Locked` directly.
        public class _InOptMut_Locked
        {
            public Locked? Opt;

            public _InOptMut_Locked() {}
            public _InOptMut_Locked(Locked value) {Opt = value;}
            public static implicit operator _InOptMut_Locked(Locked value) {return new(value);}
        }

        /// This is used for optional parameters of class `Locked` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Locked`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Locked`/`Const_Locked` to pass it to the function.
        public class _InOptConst_Locked
        {
            public Const_Locked? Opt;

            public _InOptConst_Locked() {}
            public _InOptConst_Locked(Const_Locked value) {Opt = value;}
            public static implicit operator _InOptConst_Locked(Const_Locked value) {return new(value);}
        }

        /// A joint that maps 1-on-1 to a joint in the other skeleton
        /// Generated from class `JPH::SkeletonMapper::Mapping`.
        /// This is the const half of the class.
        public class Const_Mapping : JPH.Object<Const_Mapping>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletonMapper_Mapping_Destroy(_Underlying *_this);
                __JPH_SkeletonMapper_Mapping_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Mapping() {Dispose(false);}

            ///< Index of joint from skeleton 1
            public unsafe int mJointIdx1
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Get_mJointIdx1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Get_mJointIdx1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Mapping_Get_mJointIdx1(_Underlying *_this);
                    return *__JPH_SkeletonMapper_Mapping_Get_mJointIdx1(_UnderlyingPtr);
                }
            }

            ///< Corresponding index of joint from skeleton 2
            public unsafe int mJointIdx2
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Get_mJointIdx2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Get_mJointIdx2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Mapping_Get_mJointIdx2(_Underlying *_this);
                    return *__JPH_SkeletonMapper_Mapping_Get_mJointIdx2(_UnderlyingPtr);
                }
            }

            ///< Transforms this joint from skeleton 1 to 2
            public unsafe JPH.Const_Mat44 mJoint1To2
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Get_mJoint1To2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Get_mJoint1To2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Mat44._Underlying *__JPH_SkeletonMapper_Mapping_Get_mJoint1To2(_Underlying *_this);
                    JPH.Const_Mat44 __ret;
                    __ret = new(__JPH_SkeletonMapper_Mapping_Get_mJoint1To2(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Inverse of the transform above
            public unsafe JPH.Const_Mat44 mJoint2To1
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Get_mJoint2To1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Get_mJoint2To1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Mat44._Underlying *__JPH_SkeletonMapper_Mapping_Get_mJoint2To1(_Underlying *_this);
                    JPH.Const_Mat44 __ret;
                    __ret = new(__JPH_SkeletonMapper_Mapping_Get_mJoint2To1(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_Mapping(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Mapping() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Mapping._Underlying *__JPH_SkeletonMapper_Mapping_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonMapper_Mapping_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletonMapper::Mapping::Mapping`.
            public unsafe Const_Mapping(JPH.SkeletonMapper.Const_Mapping _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Mapping._Underlying *__JPH_SkeletonMapper_Mapping_ConstructFromAnother(JPH.SkeletonMapper.Mapping._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonMapper_Mapping_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Mapping::Mapping`.
            public Const_Mapping(Mapping _other) : this((Const_Mapping)_other) {}

            /// Generated from constructor `JPH::SkeletonMapper::Mapping::Mapping`.
            public unsafe Const_Mapping(int inJointIdx1, int inJointIdx2, JPH.Const_Mat44 inJoint1To2) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Mapping._Underlying *__JPH_SkeletonMapper_Mapping_Construct(int inJointIdx1, int inJointIdx2, JPH.Const_Mat44._Underlying *inJoint1To2);
                _UnderlyingPtr = __JPH_SkeletonMapper_Mapping_Construct(inJointIdx1, inJointIdx2, inJoint1To2._UnderlyingPtr);
            }
        }

        /// A joint that maps 1-on-1 to a joint in the other skeleton
        /// Generated from class `JPH::SkeletonMapper::Mapping`.
        /// This is the non-const half of the class.
        public class Mapping : Const_Mapping
        {
            ///< Index of joint from skeleton 1
            public new unsafe ref int mJointIdx1
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx1(_Underlying *_this);
                    return ref *__JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx1(_UnderlyingPtr);
                }
            }

            ///< Corresponding index of joint from skeleton 2
            public new unsafe ref int mJointIdx2
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx2(_Underlying *_this);
                    return ref *__JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx2(_UnderlyingPtr);
                }
            }

            ///< Transforms this joint from skeleton 1 to 2
            public new unsafe JPH.Mat44 mJoint1To2
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_GetMutable_mJoint1To2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_GetMutable_mJoint1To2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Mat44._Underlying *__JPH_SkeletonMapper_Mapping_GetMutable_mJoint1To2(_Underlying *_this);
                    JPH.Mat44 __ret;
                    __ret = new(__JPH_SkeletonMapper_Mapping_GetMutable_mJoint1To2(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Inverse of the transform above
            public new unsafe JPH.Mat44 mJoint2To1
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_GetMutable_mJoint2To1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_GetMutable_mJoint2To1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Mat44._Underlying *__JPH_SkeletonMapper_Mapping_GetMutable_mJoint2To1(_Underlying *_this);
                    JPH.Mat44 __ret;
                    __ret = new(__JPH_SkeletonMapper_Mapping_GetMutable_mJoint2To1(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Mapping(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Mapping() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Mapping._Underlying *__JPH_SkeletonMapper_Mapping_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonMapper_Mapping_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletonMapper::Mapping::Mapping`.
            public unsafe Mapping(JPH.SkeletonMapper.Const_Mapping _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Mapping._Underlying *__JPH_SkeletonMapper_Mapping_ConstructFromAnother(JPH.SkeletonMapper.Mapping._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonMapper_Mapping_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Mapping::Mapping`.
            public Mapping(Mapping _other) : this((Const_Mapping)_other) {}

            /// Generated from constructor `JPH::SkeletonMapper::Mapping::Mapping`.
            public unsafe Mapping(int inJointIdx1, int inJointIdx2, JPH.Const_Mat44 inJoint1To2) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Mapping._Underlying *__JPH_SkeletonMapper_Mapping_Construct(int inJointIdx1, int inJointIdx2, JPH.Const_Mat44._Underlying *inJoint1To2);
                _UnderlyingPtr = __JPH_SkeletonMapper_Mapping_Construct(inJointIdx1, inJointIdx2, inJoint1To2._UnderlyingPtr);
            }

            /// Generated from method `JPH::SkeletonMapper::Mapping::operator=`.
            public unsafe JPH.SkeletonMapper.Mapping Assign(JPH.SkeletonMapper.Const_Mapping _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Mapping_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Mapping._Underlying *__JPH_SkeletonMapper_Mapping_AssignFromAnother(_Underlying *_this, JPH.SkeletonMapper.Mapping._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SkeletonMapper_Mapping_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Mapping` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Mapping`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Mapping`/`Const_Mapping` directly.
        public class _InOptMut_Mapping
        {
            public Mapping? Opt;

            public _InOptMut_Mapping() {}
            public _InOptMut_Mapping(Mapping value) {Opt = value;}
            public static implicit operator _InOptMut_Mapping(Mapping value) {return new(value);}
        }

        /// This is used for optional parameters of class `Mapping` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Mapping`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Mapping`/`Const_Mapping` to pass it to the function.
        public class _InOptConst_Mapping
        {
            public Const_Mapping? Opt;

            public _InOptConst_Mapping() {}
            public _InOptConst_Mapping(Const_Mapping value) {Opt = value;}
            public static implicit operator _InOptConst_Mapping(Const_Mapping value) {return new(value);}
        }

        /// Joints that could not be mapped from skeleton 1 to 2
        /// Generated from class `JPH::SkeletonMapper::Unmapped`.
        /// This is the const half of the class.
        public class Const_Unmapped : JPH.Object<Const_Unmapped>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletonMapper_Unmapped_Destroy(_Underlying *_this);
                __JPH_SkeletonMapper_Unmapped_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Unmapped() {Dispose(false);}

            ///< Joint index of unmappable joint
            public unsafe int mJointIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Get_mJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Get_mJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Unmapped_Get_mJointIdx(_Underlying *_this);
                    return *__JPH_SkeletonMapper_Unmapped_Get_mJointIdx(_UnderlyingPtr);
                }
            }

            ///< Parent joint index of unmappable joint
            public unsafe int mParentJointIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Get_mParentJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Get_mParentJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Unmapped_Get_mParentJointIdx(_Underlying *_this);
                    return *__JPH_SkeletonMapper_Unmapped_Get_mParentJointIdx(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Unmapped(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Unmapped() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Unmapped._Underlying *__JPH_SkeletonMapper_Unmapped_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonMapper_Unmapped_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletonMapper::Unmapped::Unmapped`.
            public unsafe Const_Unmapped(JPH.SkeletonMapper.Const_Unmapped _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Unmapped._Underlying *__JPH_SkeletonMapper_Unmapped_ConstructFromAnother(JPH.SkeletonMapper.Unmapped._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonMapper_Unmapped_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Unmapped::Unmapped`.
            public Const_Unmapped(Unmapped _other) : this((Const_Unmapped)_other) {}

            /// Generated from constructor `JPH::SkeletonMapper::Unmapped::Unmapped`.
            public unsafe Const_Unmapped(int inJointIdx, int inParentJointIdx) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Unmapped._Underlying *__JPH_SkeletonMapper_Unmapped_Construct(int inJointIdx, int inParentJointIdx);
                _UnderlyingPtr = __JPH_SkeletonMapper_Unmapped_Construct(inJointIdx, inParentJointIdx);
            }
        }

        /// Joints that could not be mapped from skeleton 1 to 2
        /// Generated from class `JPH::SkeletonMapper::Unmapped`.
        /// This is the non-const half of the class.
        public class Unmapped : Const_Unmapped
        {
            ///< Joint index of unmappable joint
            public new unsafe ref int mJointIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_GetMutable_mJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_GetMutable_mJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Unmapped_GetMutable_mJointIdx(_Underlying *_this);
                    return ref *__JPH_SkeletonMapper_Unmapped_GetMutable_mJointIdx(_UnderlyingPtr);
                }
            }

            ///< Parent joint index of unmappable joint
            public new unsafe ref int mParentJointIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_GetMutable_mParentJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_GetMutable_mParentJointIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_SkeletonMapper_Unmapped_GetMutable_mParentJointIdx(_Underlying *_this);
                    return ref *__JPH_SkeletonMapper_Unmapped_GetMutable_mParentJointIdx(_UnderlyingPtr);
                }
            }

            internal unsafe Unmapped(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Unmapped() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Unmapped._Underlying *__JPH_SkeletonMapper_Unmapped_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonMapper_Unmapped_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletonMapper::Unmapped::Unmapped`.
            public unsafe Unmapped(JPH.SkeletonMapper.Const_Unmapped _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Unmapped._Underlying *__JPH_SkeletonMapper_Unmapped_ConstructFromAnother(JPH.SkeletonMapper.Unmapped._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonMapper_Unmapped_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletonMapper::Unmapped::Unmapped`.
            public Unmapped(Unmapped _other) : this((Const_Unmapped)_other) {}

            /// Generated from constructor `JPH::SkeletonMapper::Unmapped::Unmapped`.
            public unsafe Unmapped(int inJointIdx, int inParentJointIdx) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Unmapped._Underlying *__JPH_SkeletonMapper_Unmapped_Construct(int inJointIdx, int inParentJointIdx);
                _UnderlyingPtr = __JPH_SkeletonMapper_Unmapped_Construct(inJointIdx, inParentJointIdx);
            }

            /// Generated from method `JPH::SkeletonMapper::Unmapped::operator=`.
            public unsafe JPH.SkeletonMapper.Unmapped Assign(JPH.SkeletonMapper.Const_Unmapped _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_Unmapped_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Unmapped._Underlying *__JPH_SkeletonMapper_Unmapped_AssignFromAnother(_Underlying *_this, JPH.SkeletonMapper.Unmapped._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SkeletonMapper_Unmapped_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Unmapped` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Unmapped`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Unmapped`/`Const_Unmapped` directly.
        public class _InOptMut_Unmapped
        {
            public Unmapped? Opt;

            public _InOptMut_Unmapped() {}
            public _InOptMut_Unmapped(Unmapped value) {Opt = value;}
            public static implicit operator _InOptMut_Unmapped(Unmapped value) {return new(value);}
        }

        /// This is used for optional parameters of class `Unmapped` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Unmapped`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Unmapped`/`Const_Unmapped` to pass it to the function.
        public class _InOptConst_Unmapped
        {
            public Const_Unmapped? Opt;

            public _InOptConst_Unmapped() {}
            public _InOptConst_Unmapped(Const_Unmapped value) {Opt = value;}
            public static implicit operator _InOptConst_Unmapped(Const_Unmapped value) {return new(value);}
        }
    }

    /// Class that is able to map a low detail (ragdoll) skeleton to a high detail (animation) skeleton and vice versa
    /// Generated from class `JPH::SkeletonMapper`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::SkeletonMapper>`
    /// This is the non-const half of the class.
    public class SkeletonMapper : Const_SkeletonMapper
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHSkeletonMapper(SkeletonMapper self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletonMapper._Underlying *__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_Underlying *_this);
            JPH.RefTarget_JPHSkeletonMapper ret = new(__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator SkeletonMapper(JPH.RefTarget_JPHSkeletonMapper parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper(JPH.RefTarget_JPHSkeletonMapper._Underlying *_this);
            SkeletonMapper ret = new(__JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe SkeletonMapper(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SkeletonMapper() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonMapper._Underlying *__JPH_SkeletonMapper_DefaultConstruct();
            _UnderlyingPtr = __JPH_SkeletonMapper_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletonMapper_AddRef(void *_this);
            __JPH_RefTarget_JPH_SkeletonMapper_AddRef(__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::SkeletonMapper::SkeletonMapper`.
        public unsafe SkeletonMapper(JPH._ByValue_SkeletonMapper _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonMapper._Underlying *__JPH_SkeletonMapper_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletonMapper._Underlying *_other);
            _UnderlyingPtr = __JPH_SkeletonMapper_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletonMapper_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletonMapper_AddRef(void *_this);
            __JPH_RefTarget_JPH_SkeletonMapper_AddRef(__JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SkeletonMapper::SkeletonMapper`.
        public SkeletonMapper(Const_SkeletonMapper _other) : this(new _ByValue_SkeletonMapper(_other)) {}

        /// Generated from constructor `JPH::SkeletonMapper::SkeletonMapper`.
        public SkeletonMapper(SkeletonMapper _other) : this((Const_SkeletonMapper)_other) {}

        /// Generated from method `JPH::SkeletonMapper::operator=`.
        public unsafe JPH.SkeletonMapper Assign(JPH._ByValue_SkeletonMapper _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonMapper._Underlying *__JPH_SkeletonMapper_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SkeletonMapper._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_SkeletonMapper_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// This can be called so lock the translation of a specified set of joints in skeleton 2.
        /// Because constraints are never 100% rigid, there's always a little bit of stretch in the ragdoll when the ragdoll is under stress.
        /// Locking the translations of the pose will remove the visual stretch from the ragdoll but will introduce a difference between the
        /// physical simulation and the visual representation.
        /// @param inSkeleton2 Target skeleton to map to.
        /// @param inLockedTranslations An array of bools the size of inSkeleton2->GetJointCount(), for each joint indicating if the joint is locked.
        /// @param inNeutralPose2 Neutral pose to take reference translations from
        /// Generated from method `JPH::SkeletonMapper::LockTranslations`.
        public unsafe void LockTranslations(JPH.Const_Skeleton? inSkeleton2, bool? inLockedTranslations, JPH.Const_Mat44? inNeutralPose2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_LockTranslations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_LockTranslations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonMapper_LockTranslations(_Underlying *_this, JPH.Const_Skeleton._Underlying *inSkeleton2, bool *inLockedTranslations, JPH.Const_Mat44._Underlying *inNeutralPose2);
            bool __deref_inLockedTranslations = inLockedTranslations.GetValueOrDefault();
            __JPH_SkeletonMapper_LockTranslations(_UnderlyingPtr, inSkeleton2 is not null ? inSkeleton2._UnderlyingPtr : null, inLockedTranslations.HasValue ? &__deref_inLockedTranslations : null, inNeutralPose2 is not null ? inNeutralPose2._UnderlyingPtr : null);
        }

        /// After Initialize(), this can be called to lock the translation of all joints in skeleton 2 below the first mapped joint to those of the neutral pose.
        /// Because constraints are never 100% rigid, there's always a little bit of stretch in the ragdoll when the ragdoll is under stress.
        /// Locking the translations of the pose will remove the visual stretch from the ragdoll but will introduce a difference between the
        /// physical simulation and the visual representation.
        /// @param inSkeleton2 Target skeleton to map to.
        /// @param inNeutralPose2 Neutral pose to take reference translations from
        /// Generated from method `JPH::SkeletonMapper::LockAllTranslations`.
        public unsafe void LockAllTranslations(JPH.Const_Skeleton? inSkeleton2, JPH.Const_Mat44? inNeutralPose2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_LockAllTranslations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_LockAllTranslations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonMapper_LockAllTranslations(_Underlying *_this, JPH.Const_Skeleton._Underlying *inSkeleton2, JPH.Const_Mat44._Underlying *inNeutralPose2);
            __JPH_SkeletonMapper_LockAllTranslations(_UnderlyingPtr, inSkeleton2 is not null ? inSkeleton2._UnderlyingPtr : null, inNeutralPose2 is not null ? inNeutralPose2._UnderlyingPtr : null);
        }

        /// Generated from method `JPH::SkeletonMapper::GetMappings`.
        public unsafe new JPH.Array_JPHSkeletonMapperMapping GetMappings()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetMappings_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetMappings_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletonMapperMapping._Underlying *__JPH_SkeletonMapper_GetMappings_mut(_Underlying *_this);
            return new(__JPH_SkeletonMapper_GetMappings_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonMapper::GetChains`.
        public unsafe new JPH.Array_JPHSkeletonMapperChain GetChains()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetChains_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetChains_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletonMapperChain._Underlying *__JPH_SkeletonMapper_GetChains_mut(_Underlying *_this);
            return new(__JPH_SkeletonMapper_GetChains_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonMapper::GetUnmapped`.
        public unsafe new JPH.Array_JPHSkeletonMapperUnmapped GetUnmapped()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetUnmapped_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetUnmapped_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletonMapperUnmapped._Underlying *__JPH_SkeletonMapper_GetUnmapped_mut(_Underlying *_this);
            return new(__JPH_SkeletonMapper_GetUnmapped_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonMapper::GetLockedTranslations`.
        public unsafe new JPH.Array_JPHSkeletonMapperLocked GetLockedTranslations()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonMapper_GetLockedTranslations_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonMapper_GetLockedTranslations_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletonMapperLocked._Underlying *__JPH_SkeletonMapper_GetLockedTranslations_mut(_Underlying *_this);
            return new(__JPH_SkeletonMapper_GetLockedTranslations_mut(_UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `SkeletonMapper` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `SkeletonMapper`/`Const_SkeletonMapper` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_SkeletonMapper
    {
        #pragma warning disable CS0649
        internal readonly Const_SkeletonMapper? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_SkeletonMapper() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_SkeletonMapper(Const_SkeletonMapper new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_SkeletonMapper(Const_SkeletonMapper arg) {return new(arg);}
        public _ByValue_SkeletonMapper(JPH._Moved<SkeletonMapper> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_SkeletonMapper(JPH._Moved<SkeletonMapper> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `SkeletonMapper` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SkeletonMapper`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SkeletonMapper`/`Const_SkeletonMapper` directly.
    public class _InOptMut_SkeletonMapper
    {
        public SkeletonMapper? Opt;

        public _InOptMut_SkeletonMapper() {}
        public _InOptMut_SkeletonMapper(SkeletonMapper value) {Opt = value;}
        public static implicit operator _InOptMut_SkeletonMapper(SkeletonMapper value) {return new(value);}
    }

    /// This is used for optional parameters of class `SkeletonMapper` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SkeletonMapper`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SkeletonMapper`/`Const_SkeletonMapper` to pass it to the function.
    public class _InOptConst_SkeletonMapper
    {
        public Const_SkeletonMapper? Opt;

        public _InOptConst_SkeletonMapper() {}
        public _InOptConst_SkeletonMapper(Const_SkeletonMapper value) {Opt = value;}
        public static implicit operator _InOptConst_SkeletonMapper(Const_SkeletonMapper value) {return new(value);}
    }
}
