// machine generated, do not edit
public static partial class JPH
{
    /// Instance of a skeleton, contains the pose the current skeleton is in
    /// Generated from class `JPH::SkeletonPose`.
    /// This is the const half of the class.
    public class Const_SkeletonPose : JPH.Object<Const_SkeletonPose>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonPose_Destroy(_Underlying *_this);
            __JPH_SkeletonPose_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SkeletonPose() {Dispose(false);}

        internal unsafe Const_SkeletonPose(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SkeletonPose() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonPose._Underlying *__JPH_SkeletonPose_DefaultConstruct();
            _UnderlyingPtr = __JPH_SkeletonPose_DefaultConstruct();
        }

        /// Generated from constructor `JPH::SkeletonPose::SkeletonPose`.
        public unsafe Const_SkeletonPose(JPH._ByValue_SkeletonPose _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonPose._Underlying *__JPH_SkeletonPose_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletonPose._Underlying *_other);
            _UnderlyingPtr = __JPH_SkeletonPose_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SkeletonPose::SkeletonPose`.
        public Const_SkeletonPose(Const_SkeletonPose _other) : this(new _ByValue_SkeletonPose(_other)) {}

        /// Generated from constructor `JPH::SkeletonPose::SkeletonPose`.
        public Const_SkeletonPose(SkeletonPose _other) : this((Const_SkeletonPose)_other) {}

        /// Generated from method `JPH::SkeletonPose::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletonPose_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletonPose_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SkeletonPose_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_SkeletonPose_size_t(inCount);
        }

        /// Generated from method `JPH::SkeletonPose::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletonPose_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletonPose_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SkeletonPose_void_ptr(void *inPointer);
            __Jolt_delete_JPH_SkeletonPose_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SkeletonPose::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletonPose_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletonPose_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SkeletonPose_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_SkeletonPose_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SkeletonPose::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletonPose_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletonPose_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SkeletonPose_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_SkeletonPose_size_t(inCount);
        }

        /// Generated from method `JPH::SkeletonPose::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletonPose_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletonPose_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SkeletonPose_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_SkeletonPose_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SkeletonPose::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletonPose_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletonPose_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SkeletonPose_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_SkeletonPose_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SkeletonPose::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletonPose_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletonPose_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SkeletonPose_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_SkeletonPose_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SkeletonPose::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletonPose_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletonPose_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SkeletonPose_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_SkeletonPose_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SkeletonPose::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletonPose_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletonPose_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SkeletonPose_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_SkeletonPose_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SkeletonPose::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletonPose_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletonPose_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SkeletonPose_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_SkeletonPose_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SkeletonPose::GetSkeleton`.
        public unsafe JPH.Const_Skeleton? GetSkeleton()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Skeleton._Underlying *__JPH_SkeletonPose_GetSkeleton(_Underlying *_this);
            var __c_ret = __JPH_SkeletonPose_GetSkeleton(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Skeleton(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::SkeletonPose::GetRootOffset`.
        public unsafe JPH.Vec3 GetRootOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetRootOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetRootOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SkeletonPose_GetRootOffset(_Underlying *_this);
            return new(__JPH_SkeletonPose_GetRootOffset(_UnderlyingPtr), is_owning: true);
        }

        ///@name Properties of the joints
        ///@{
        /// Generated from method `JPH::SkeletonPose::GetJointCount`.
        public unsafe uint GetJointCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetJointCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetJointCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SkeletonPose_GetJointCount(_Underlying *_this);
            return __JPH_SkeletonPose_GetJointCount(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SkeletonPose::GetJoints`.
        public unsafe JPH.Const_Array_JPHSkeletalAnimationJointState GetJoints()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHSkeletalAnimationJointState._Underlying *__JPH_SkeletonPose_GetJoints(_Underlying *_this);
            return new(__JPH_SkeletonPose_GetJoints(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonPose::GetJoint`.
        public unsafe JPH.SkeletalAnimation.Const_JointState GetJoint(int inJoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetJoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetJoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletalAnimation.Const_JointState._Underlying *__JPH_SkeletonPose_GetJoint(_Underlying *_this, int inJoint);
            return new(__JPH_SkeletonPose_GetJoint(_UnderlyingPtr, inJoint), is_owning: false);
        }

        ///@name Joint matrices
        ///@{
        /// Generated from method `JPH::SkeletonPose::GetJointMatrices`.
        public unsafe JPH.Const_Array_JPHMat44 GetJointMatrices()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetJointMatrices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetJointMatrices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHMat44._Underlying *__JPH_SkeletonPose_GetJointMatrices(_Underlying *_this);
            return new(__JPH_SkeletonPose_GetJointMatrices(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonPose::GetJointMatrix`.
        public unsafe JPH.Const_Mat44 GetJointMatrix(int inJoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetJointMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetJointMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Mat44._Underlying *__JPH_SkeletonPose_GetJointMatrix(_Underlying *_this, int inJoint);
            return new(__JPH_SkeletonPose_GetJointMatrix(_UnderlyingPtr, inJoint), is_owning: false);
        }

        /// Outputs the joint matrices in local space (ensure that outMatrices has GetJointCount() elements, assumes that values in GetJoints() is up to date)
        /// Generated from method `JPH::SkeletonPose::CalculateLocalSpaceJointMatrices`.
        public unsafe void CalculateLocalSpaceJointMatrices(JPH.Mat44? outMatrices)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_CalculateLocalSpaceJointMatrices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_CalculateLocalSpaceJointMatrices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonPose_CalculateLocalSpaceJointMatrices(_Underlying *_this, JPH.Mat44._Underlying *outMatrices);
            __JPH_SkeletonPose_CalculateLocalSpaceJointMatrices(_UnderlyingPtr, outMatrices is not null ? outMatrices._UnderlyingPtr : null);
        }

        /// Draw current pose
        /// Generated from method `JPH::SkeletonPose::Draw`.
        /// Parameter `inOffset` defaults to `JPH::RMat44::sIdentity()`.
        public unsafe void Draw(JPH.SkeletonPose.Const_DrawSettings inDrawSettings, JPH.DebugRenderer? inRenderer, JPH.Const_Mat44? inOffset = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_Draw", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_Draw", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonPose_Draw(_Underlying *_this, JPH.SkeletonPose.Const_DrawSettings._Underlying *inDrawSettings, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inOffset);
            __JPH_SkeletonPose_Draw(_UnderlyingPtr, inDrawSettings._UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inOffset is not null ? inOffset._UnderlyingPtr : null);
        }

        /// Draw settings
        /// Generated from class `JPH::SkeletonPose::DrawSettings`.
        /// This is the const half of the class.
        public class Const_DrawSettings : JPH.Object<Const_DrawSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletonPose_DrawSettings_Destroy(_Underlying *_this);
                __JPH_SkeletonPose_DrawSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_DrawSettings() {Dispose(false);}

            public unsafe bool mDrawJoints
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_Get_mDrawJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_Get_mDrawJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SkeletonPose_DrawSettings_Get_mDrawJoints(_Underlying *_this);
                    return *__JPH_SkeletonPose_DrawSettings_Get_mDrawJoints(_UnderlyingPtr);
                }
            }

            public unsafe bool mDrawJointOrientations
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_Get_mDrawJointOrientations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_Get_mDrawJointOrientations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SkeletonPose_DrawSettings_Get_mDrawJointOrientations(_Underlying *_this);
                    return *__JPH_SkeletonPose_DrawSettings_Get_mDrawJointOrientations(_UnderlyingPtr);
                }
            }

            public unsafe bool mDrawJointNames
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_Get_mDrawJointNames", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_Get_mDrawJointNames", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SkeletonPose_DrawSettings_Get_mDrawJointNames(_Underlying *_this);
                    return *__JPH_SkeletonPose_DrawSettings_Get_mDrawJointNames(_UnderlyingPtr);
                }
            }

            internal unsafe Const_DrawSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_DrawSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonPose.DrawSettings._Underlying *__JPH_SkeletonPose_DrawSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonPose_DrawSettings_DefaultConstruct();
            }

            /// Constructs `JPH::SkeletonPose::DrawSettings` elementwise.
            public unsafe Const_DrawSettings(bool mDrawJoints, bool mDrawJointOrientations, bool mDrawJointNames) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonPose.DrawSettings._Underlying *__JPH_SkeletonPose_DrawSettings_ConstructFrom(byte mDrawJoints, byte mDrawJointOrientations, byte mDrawJointNames);
                _UnderlyingPtr = __JPH_SkeletonPose_DrawSettings_ConstructFrom(mDrawJoints ? (byte)1 : (byte)0, mDrawJointOrientations ? (byte)1 : (byte)0, mDrawJointNames ? (byte)1 : (byte)0);
            }

            /// Generated from constructor `JPH::SkeletonPose::DrawSettings::DrawSettings`.
            public unsafe Const_DrawSettings(JPH.SkeletonPose.Const_DrawSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonPose.DrawSettings._Underlying *__JPH_SkeletonPose_DrawSettings_ConstructFromAnother(JPH.SkeletonPose.DrawSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonPose_DrawSettings_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletonPose::DrawSettings::DrawSettings`.
            public Const_DrawSettings(DrawSettings _other) : this((Const_DrawSettings)_other) {}
        }

        /// Draw settings
        /// Generated from class `JPH::SkeletonPose::DrawSettings`.
        /// This is the non-const half of the class.
        public class DrawSettings : Const_DrawSettings
        {
            public new unsafe ref bool mDrawJoints
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJoints(_Underlying *_this);
                    return ref *__JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJoints(_UnderlyingPtr);
                }
            }

            public new unsafe ref bool mDrawJointOrientations
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointOrientations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointOrientations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointOrientations(_Underlying *_this);
                    return ref *__JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointOrientations(_UnderlyingPtr);
                }
            }

            public new unsafe ref bool mDrawJointNames
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointNames", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointNames", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointNames(_Underlying *_this);
                    return ref *__JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointNames(_UnderlyingPtr);
                }
            }

            internal unsafe DrawSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe DrawSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonPose.DrawSettings._Underlying *__JPH_SkeletonPose_DrawSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletonPose_DrawSettings_DefaultConstruct();
            }

            /// Constructs `JPH::SkeletonPose::DrawSettings` elementwise.
            public unsafe DrawSettings(bool mDrawJoints, bool mDrawJointOrientations, bool mDrawJointNames) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonPose.DrawSettings._Underlying *__JPH_SkeletonPose_DrawSettings_ConstructFrom(byte mDrawJoints, byte mDrawJointOrientations, byte mDrawJointNames);
                _UnderlyingPtr = __JPH_SkeletonPose_DrawSettings_ConstructFrom(mDrawJoints ? (byte)1 : (byte)0, mDrawJointOrientations ? (byte)1 : (byte)0, mDrawJointNames ? (byte)1 : (byte)0);
            }

            /// Generated from constructor `JPH::SkeletonPose::DrawSettings::DrawSettings`.
            public unsafe DrawSettings(JPH.SkeletonPose.Const_DrawSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonPose.DrawSettings._Underlying *__JPH_SkeletonPose_DrawSettings_ConstructFromAnother(JPH.SkeletonPose.DrawSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletonPose_DrawSettings_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletonPose::DrawSettings::DrawSettings`.
            public DrawSettings(DrawSettings _other) : this((Const_DrawSettings)_other) {}

            /// Generated from method `JPH::SkeletonPose::DrawSettings::operator=`.
            public unsafe JPH.SkeletonPose.DrawSettings Assign(JPH.SkeletonPose.Const_DrawSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DrawSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonPose.DrawSettings._Underlying *__JPH_SkeletonPose_DrawSettings_AssignFromAnother(_Underlying *_this, JPH.SkeletonPose.DrawSettings._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SkeletonPose_DrawSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `DrawSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_DrawSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DrawSettings`/`Const_DrawSettings` directly.
        public class _InOptMut_DrawSettings
        {
            public DrawSettings? Opt;

            public _InOptMut_DrawSettings() {}
            public _InOptMut_DrawSettings(DrawSettings value) {Opt = value;}
            public static implicit operator _InOptMut_DrawSettings(DrawSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `DrawSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_DrawSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DrawSettings`/`Const_DrawSettings` to pass it to the function.
        public class _InOptConst_DrawSettings
        {
            public Const_DrawSettings? Opt;

            public _InOptConst_DrawSettings() {}
            public _InOptConst_DrawSettings(Const_DrawSettings value) {Opt = value;}
            public static implicit operator _InOptConst_DrawSettings(Const_DrawSettings value) {return new(value);}
        }
    }

    /// Instance of a skeleton, contains the pose the current skeleton is in
    /// Generated from class `JPH::SkeletonPose`.
    /// This is the non-const half of the class.
    public class SkeletonPose : Const_SkeletonPose
    {
        internal unsafe SkeletonPose(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SkeletonPose() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonPose._Underlying *__JPH_SkeletonPose_DefaultConstruct();
            _UnderlyingPtr = __JPH_SkeletonPose_DefaultConstruct();
        }

        /// Generated from constructor `JPH::SkeletonPose::SkeletonPose`.
        public unsafe SkeletonPose(JPH._ByValue_SkeletonPose _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonPose._Underlying *__JPH_SkeletonPose_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletonPose._Underlying *_other);
            _UnderlyingPtr = __JPH_SkeletonPose_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SkeletonPose::SkeletonPose`.
        public SkeletonPose(Const_SkeletonPose _other) : this(new _ByValue_SkeletonPose(_other)) {}

        /// Generated from constructor `JPH::SkeletonPose::SkeletonPose`.
        public SkeletonPose(SkeletonPose _other) : this((Const_SkeletonPose)_other) {}

        /// Generated from method `JPH::SkeletonPose::operator=`.
        public unsafe JPH.SkeletonPose Assign(JPH._ByValue_SkeletonPose _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonPose._Underlying *__JPH_SkeletonPose_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SkeletonPose._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_SkeletonPose_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        ///@name Skeleton
        ///@{
        /// Generated from method `JPH::SkeletonPose::SetSkeleton`.
        public unsafe void SetSkeleton(JPH.Const_Skeleton? inSkeleton)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_SetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_SetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonPose_SetSkeleton(_Underlying *_this, JPH.Const_Skeleton._Underlying *inSkeleton);
            __JPH_SkeletonPose_SetSkeleton(_UnderlyingPtr, inSkeleton is not null ? inSkeleton._UnderlyingPtr : null);
        }

        /// Extra offset applied to the root (and therefore also to all of its children)
        /// Generated from method `JPH::SkeletonPose::SetRootOffset`.
        public unsafe void SetRootOffset(JPH.Const_Vec3 inOffset)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_SetRootOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_SetRootOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonPose_SetRootOffset(_Underlying *_this, JPH.Vec3._Underlying *inOffset);
            __JPH_SkeletonPose_SetRootOffset(_UnderlyingPtr, inOffset._UnderlyingPtr);
        }

        /// Generated from method `JPH::SkeletonPose::GetJoints`.
        public unsafe new JPH.Array_JPHSkeletalAnimationJointState GetJoints()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetJoints_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetJoints_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletalAnimationJointState._Underlying *__JPH_SkeletonPose_GetJoints_mut(_Underlying *_this);
            return new(__JPH_SkeletonPose_GetJoints_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonPose::GetJoint`.
        public unsafe new JPH.SkeletalAnimation.JointState GetJoint(int inJoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetJoint_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetJoint_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletalAnimation.JointState._Underlying *__JPH_SkeletonPose_GetJoint_mut(_Underlying *_this, int inJoint);
            return new(__JPH_SkeletonPose_GetJoint_mut(_UnderlyingPtr, inJoint), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonPose::GetJointMatrices`.
        public unsafe new JPH.Array_JPHMat44 GetJointMatrices()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetJointMatrices_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetJointMatrices_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHMat44._Underlying *__JPH_SkeletonPose_GetJointMatrices_mut(_Underlying *_this);
            return new(__JPH_SkeletonPose_GetJointMatrices_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::SkeletonPose::GetJointMatrix`.
        public unsafe new JPH.Mat44 GetJointMatrix(int inJoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_GetJointMatrix_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_GetJointMatrix_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_SkeletonPose_GetJointMatrix_mut(_Underlying *_this, int inJoint);
            return new(__JPH_SkeletonPose_GetJointMatrix_mut(_UnderlyingPtr, inJoint), is_owning: false);
        }

        /// Convert the joint states to joint matrices
        /// Generated from method `JPH::SkeletonPose::CalculateJointMatrices`.
        public unsafe void CalculateJointMatrices()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_CalculateJointMatrices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_CalculateJointMatrices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonPose_CalculateJointMatrices(_Underlying *_this);
            __JPH_SkeletonPose_CalculateJointMatrices(_UnderlyingPtr);
        }

        /// Convert joint matrices to joint states
        /// Generated from method `JPH::SkeletonPose::CalculateJointStates`.
        public unsafe void CalculateJointStates()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletonPose_CalculateJointStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletonPose_CalculateJointStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletonPose_CalculateJointStates(_Underlying *_this);
            __JPH_SkeletonPose_CalculateJointStates(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `SkeletonPose` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `SkeletonPose`/`Const_SkeletonPose` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_SkeletonPose
    {
        #pragma warning disable CS0649
        internal readonly Const_SkeletonPose? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_SkeletonPose() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_SkeletonPose(Const_SkeletonPose new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_SkeletonPose(Const_SkeletonPose arg) {return new(arg);}
        public _ByValue_SkeletonPose(JPH._Moved<SkeletonPose> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_SkeletonPose(JPH._Moved<SkeletonPose> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `SkeletonPose` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SkeletonPose`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SkeletonPose`/`Const_SkeletonPose` directly.
    public class _InOptMut_SkeletonPose
    {
        public SkeletonPose? Opt;

        public _InOptMut_SkeletonPose() {}
        public _InOptMut_SkeletonPose(SkeletonPose value) {Opt = value;}
        public static implicit operator _InOptMut_SkeletonPose(SkeletonPose value) {return new(value);}
    }

    /// This is used for optional parameters of class `SkeletonPose` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SkeletonPose`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SkeletonPose`/`Const_SkeletonPose` to pass it to the function.
    public class _InOptConst_SkeletonPose
    {
        public Const_SkeletonPose? Opt;

        public _InOptConst_SkeletonPose() {}
        public _InOptConst_SkeletonPose(Const_SkeletonPose value) {Opt = value;}
        public static implicit operator _InOptConst_SkeletonPose(Const_SkeletonPose value) {return new(value);}
    }
}
