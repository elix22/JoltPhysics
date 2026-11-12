// machine generated, do not edit
public static partial class JPH
{
    /// Resource that contains the joint hierarchy for a skeleton
    /// Generated from class `JPH::Skeleton`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::Skeleton>`
    /// This is the const half of the class.
    public class Const_Skeleton : JPH.Object<Const_Skeleton>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Skeleton_Release(void *_this);
            __JPH_RefTarget_JPH_Skeleton_Release(__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Skeleton() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHSkeleton(Const_Skeleton self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHSkeleton._Underlying *__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_Underlying *_this);
            JPH.Const_RefTarget_JPHSkeleton ret = new(__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_Skeleton(JPH.Const_RefTarget_JPHSkeleton parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton(JPH.Const_RefTarget_JPHSkeleton._Underlying *_this);
            Const_Skeleton ret = new(__JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_Skeleton(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Skeleton() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Skeleton._Underlying *__JPH_Skeleton_DefaultConstruct();
            _UnderlyingPtr = __JPH_Skeleton_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Skeleton_AddRef(void *_this);
            __JPH_RefTarget_JPH_Skeleton_AddRef(__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::Skeleton::Skeleton`.
        public unsafe Const_Skeleton(JPH._ByValue_Skeleton _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Skeleton._Underlying *__JPH_Skeleton_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.Skeleton._Underlying *_other);
            _UnderlyingPtr = __JPH_Skeleton_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Skeleton_AddRef(void *_this);
            __JPH_RefTarget_JPH_Skeleton_AddRef(__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::Skeleton::Skeleton`.
        public Const_Skeleton(Const_Skeleton _other) : this(new _ByValue_Skeleton(_other)) {}

        /// Generated from constructor `JPH::Skeleton::Skeleton`.
        public Const_Skeleton(Skeleton _other) : this((Const_Skeleton)_other) {}

        /// Generated from method `JPH::Skeleton::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Skeleton_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Skeleton_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Skeleton_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_Skeleton_size_t(inCount);
        }

        /// Generated from method `JPH::Skeleton::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Skeleton_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Skeleton_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Skeleton::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Skeleton_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_Skeleton_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Skeleton::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Skeleton_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Skeleton_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Skeleton_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_Skeleton_size_t(inCount);
        }

        /// Generated from method `JPH::Skeleton::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Skeleton_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Skeleton_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Skeleton::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Skeleton_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_Skeleton_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Skeleton::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Skeleton_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Skeleton_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Skeleton_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_Skeleton_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Skeleton::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Skeleton_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Skeleton_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Skeleton::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Skeleton_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Skeleton_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Skeleton_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_Skeleton_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Skeleton::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Skeleton_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Skeleton_void_ptr_void_ptr(inPointer, inPlace);
        }

        ///@name Access to the joints
        ///@{
        /// Generated from method `JPH::Skeleton::GetJoints`.
        public unsafe JPH.Const_Array_JPHSkeletonJoint GetJoints()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_GetJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_GetJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHSkeletonJoint._Underlying *__JPH_Skeleton_GetJoints(_Underlying *_this);
            return new(__JPH_Skeleton_GetJoints(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::Skeleton::GetJointCount`.
        public unsafe int GetJointCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_GetJointCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_GetJointCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_Skeleton_GetJointCount(_Underlying *_this);
            return __JPH_Skeleton_GetJointCount(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Skeleton::GetJoint`.
        public unsafe JPH.Skeleton.Const_Joint GetJoint(int inJoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_GetJoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_GetJoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Skeleton.Const_Joint._Underlying *__JPH_Skeleton_GetJoint(_Underlying *_this, int inJoint);
            return new(__JPH_Skeleton_GetJoint(_UnderlyingPtr, inJoint), is_owning: false);
        }

        /// Many of the algorithms that use the Skeleton class require that parent joints are in the mJoints array before their children.
        /// This function returns true if this is the case, false if not.
        /// Generated from method `JPH::Skeleton::AreJointsCorrectlyOrdered`.
        public unsafe bool AreJointsCorrectlyOrdered()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_AreJointsCorrectlyOrdered", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_AreJointsCorrectlyOrdered", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Skeleton_AreJointsCorrectlyOrdered(_Underlying *_this);
            return __JPH_Skeleton_AreJointsCorrectlyOrdered(_UnderlyingPtr) != 0;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::Skeleton::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Skeleton_SetEmbedded(_Underlying *_this);
            __JPH_Skeleton_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::Skeleton::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Skeleton_GetRefCount(_Underlying *_this);
            return __JPH_Skeleton_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::Skeleton::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Skeleton_AddRef(_Underlying *_this);
            __JPH_Skeleton_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Skeleton::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Skeleton_Release(_Underlying *_this);
            __JPH_Skeleton_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::Skeleton::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_Skeleton_sInternalGetRefCountOffset();
            return __JPH_Skeleton_sInternalGetRefCountOffset();
        }

        /// Declare internal structure for a joint
        /// Generated from class `JPH::Skeleton::Joint`.
        /// This is the const half of the class.
        public class Const_Joint : JPH.Object<Const_Joint>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_Joint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_Joint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Skeleton_Joint_Destroy(_Underlying *_this);
                __JPH_Skeleton_Joint_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Joint() {Dispose(false);}

            ///< Index of parent joint (in mJoints) or -1 if it has no parent
            public unsafe int mParentJointIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_Joint_Get_mParentJointIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_Joint_Get_mParentJointIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_Skeleton_Joint_Get_mParentJointIndex(_Underlying *_this);
                    return *__JPH_Skeleton_Joint_Get_mParentJointIndex(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Joint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Joint() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_Joint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_Joint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Skeleton.Joint._Underlying *__JPH_Skeleton_Joint_DefaultConstruct();
                _UnderlyingPtr = __JPH_Skeleton_Joint_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Skeleton::Joint::Joint`.
            public unsafe Const_Joint(JPH.Skeleton._ByValue_Joint _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_Joint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_Joint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Skeleton.Joint._Underlying *__JPH_Skeleton_Joint_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.Skeleton.Joint._Underlying *_other);
                _UnderlyingPtr = __JPH_Skeleton_Joint_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::Skeleton::Joint::Joint`.
            public Const_Joint(Const_Joint _other) : this(new _ByValue_Joint(_other)) {}

            /// Generated from constructor `JPH::Skeleton::Joint::Joint`.
            public Const_Joint(Joint _other) : this((Const_Joint)_other) {}

            /// Generated from method `JPH::Skeleton::Joint::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Skeleton_Joint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Skeleton_Joint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Skeleton_Joint_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_Skeleton_Joint_size_t(inCount);
            }

            /// Generated from method `JPH::Skeleton::Joint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_Joint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_Joint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Skeleton_Joint_void_ptr(void *inPointer);
                __Jolt_delete_JPH_Skeleton_Joint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Skeleton::Joint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_Joint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_Joint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Skeleton_Joint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_Skeleton_Joint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Skeleton::Joint::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Skeleton_Joint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Skeleton_Joint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Skeleton_Joint_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_Skeleton_Joint_size_t(inCount);
            }

            /// Generated from method `JPH::Skeleton::Joint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_Joint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_Joint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Skeleton_Joint_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_Skeleton_Joint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Skeleton::Joint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Skeleton::Joint::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Skeleton_Joint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Skeleton_Joint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Skeleton_Joint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_Skeleton_Joint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Skeleton::Joint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_Joint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Skeleton_Joint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Skeleton_Joint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_Skeleton_Joint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::Skeleton::Joint::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Skeleton_Joint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Skeleton_Joint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Skeleton_Joint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_Skeleton_Joint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Skeleton::Joint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// Declare internal structure for a joint
        /// Generated from class `JPH::Skeleton::Joint`.
        /// This is the non-const half of the class.
        public class Joint : Const_Joint
        {
            ///< Index of parent joint (in mJoints) or -1 if it has no parent
            public new unsafe ref int mParentJointIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_Joint_GetMutable_mParentJointIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_Joint_GetMutable_mParentJointIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_Skeleton_Joint_GetMutable_mParentJointIndex(_Underlying *_this);
                    return ref *__JPH_Skeleton_Joint_GetMutable_mParentJointIndex(_UnderlyingPtr);
                }
            }

            internal unsafe Joint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Joint() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_Joint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_Joint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Skeleton.Joint._Underlying *__JPH_Skeleton_Joint_DefaultConstruct();
                _UnderlyingPtr = __JPH_Skeleton_Joint_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Skeleton::Joint::Joint`.
            public unsafe Joint(JPH.Skeleton._ByValue_Joint _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_Joint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_Joint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Skeleton.Joint._Underlying *__JPH_Skeleton_Joint_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.Skeleton.Joint._Underlying *_other);
                _UnderlyingPtr = __JPH_Skeleton_Joint_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::Skeleton::Joint::Joint`.
            public Joint(Const_Joint _other) : this(new _ByValue_Joint(_other)) {}

            /// Generated from constructor `JPH::Skeleton::Joint::Joint`.
            public Joint(Joint _other) : this((Const_Joint)_other) {}

            /// Generated from method `JPH::Skeleton::Joint::operator=`.
            public unsafe JPH.Skeleton.Joint Assign(JPH.Skeleton._ByValue_Joint _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_Joint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_Joint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Skeleton.Joint._Underlying *__JPH_Skeleton_Joint_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.Skeleton.Joint._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_Skeleton_Joint_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `Joint` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `Joint`/`Const_Joint` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_Joint
        {
            #pragma warning disable CS0649
            internal readonly Const_Joint? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_Joint() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_Joint(Const_Joint new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_Joint(Const_Joint arg) {return new(arg);}
            public _ByValue_Joint(JPH._Moved<Joint> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_Joint(JPH._Moved<Joint> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `Joint` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Joint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Joint`/`Const_Joint` directly.
        public class _InOptMut_Joint
        {
            public Joint? Opt;

            public _InOptMut_Joint() {}
            public _InOptMut_Joint(Joint value) {Opt = value;}
            public static implicit operator _InOptMut_Joint(Joint value) {return new(value);}
        }

        /// This is used for optional parameters of class `Joint` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Joint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Joint`/`Const_Joint` to pass it to the function.
        public class _InOptConst_Joint
        {
            public Const_Joint? Opt;

            public _InOptConst_Joint() {}
            public _InOptConst_Joint(Const_Joint value) {Opt = value;}
            public static implicit operator _InOptConst_Joint(Const_Joint value) {return new(value);}
        }
    }

    /// Resource that contains the joint hierarchy for a skeleton
    /// Generated from class `JPH::Skeleton`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::Skeleton>`
    /// This is the non-const half of the class.
    public class Skeleton : Const_Skeleton
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHSkeleton(Skeleton self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeleton._Underlying *__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_Underlying *_this);
            JPH.RefTarget_JPHSkeleton ret = new(__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHSkeleton(Skeleton self)
            => (JPH.Const_RefTarget_JPHSkeleton)(JPH.Const_Skeleton)self;

        // Downcasts:
        public static unsafe explicit operator Skeleton(JPH.RefTarget_JPHSkeleton parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton(JPH.RefTarget_JPHSkeleton._Underlying *_this);
            Skeleton ret = new(__JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Skeleton(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Skeleton() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Skeleton._Underlying *__JPH_Skeleton_DefaultConstruct();
            _UnderlyingPtr = __JPH_Skeleton_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Skeleton_AddRef(void *_this);
            __JPH_RefTarget_JPH_Skeleton_AddRef(__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::Skeleton::Skeleton`.
        public unsafe Skeleton(JPH._ByValue_Skeleton _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Skeleton._Underlying *__JPH_Skeleton_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.Skeleton._Underlying *_other);
            _UnderlyingPtr = __JPH_Skeleton_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Skeleton_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Skeleton_AddRef(void *_this);
            __JPH_RefTarget_JPH_Skeleton_AddRef(__JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::Skeleton::Skeleton`.
        public Skeleton(Const_Skeleton _other) : this(new _ByValue_Skeleton(_other)) {}

        /// Generated from constructor `JPH::Skeleton::Skeleton`.
        public Skeleton(Skeleton _other) : this((Const_Skeleton)_other) {}

        /// Generated from method `JPH::Skeleton::operator=`.
        public unsafe JPH.Skeleton Assign(JPH._ByValue_Skeleton _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Skeleton._Underlying *__JPH_Skeleton_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.Skeleton._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_Skeleton_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JPH::Skeleton::GetJoints`.
        public unsafe new JPH.Array_JPHSkeletonJoint GetJoints()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_GetJoints_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_GetJoints_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletonJoint._Underlying *__JPH_Skeleton_GetJoints_mut(_Underlying *_this);
            return new(__JPH_Skeleton_GetJoints_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::Skeleton::GetJoint`.
        public unsafe new JPH.Skeleton.Joint GetJoint(int inJoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_GetJoint_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_GetJoint_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Skeleton.Joint._Underlying *__JPH_Skeleton_GetJoint_mut(_Underlying *_this, int inJoint);
            return new(__JPH_Skeleton_GetJoint_mut(_UnderlyingPtr, inJoint), is_owning: false);
        }

        /// Fill in parent joint indices based on name
        /// Generated from method `JPH::Skeleton::CalculateParentJointIndices`.
        public unsafe void CalculateParentJointIndices()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Skeleton_CalculateParentJointIndices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Skeleton_CalculateParentJointIndices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Skeleton_CalculateParentJointIndices(_Underlying *_this);
            __JPH_Skeleton_CalculateParentJointIndices(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `Skeleton` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `Skeleton`/`Const_Skeleton` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_Skeleton
    {
        #pragma warning disable CS0649
        internal readonly Const_Skeleton? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_Skeleton() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_Skeleton(Const_Skeleton new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_Skeleton(Const_Skeleton arg) {return new(arg);}
        public _ByValue_Skeleton(JPH._Moved<Skeleton> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_Skeleton(JPH._Moved<Skeleton> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `Skeleton` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Skeleton`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Skeleton`/`Const_Skeleton` directly.
    public class _InOptMut_Skeleton
    {
        public Skeleton? Opt;

        public _InOptMut_Skeleton() {}
        public _InOptMut_Skeleton(Skeleton value) {Opt = value;}
        public static implicit operator _InOptMut_Skeleton(Skeleton value) {return new(value);}
    }

    /// This is used for optional parameters of class `Skeleton` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Skeleton`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Skeleton`/`Const_Skeleton` to pass it to the function.
    public class _InOptConst_Skeleton
    {
        public Const_Skeleton? Opt;

        public _InOptConst_Skeleton() {}
        public _InOptConst_Skeleton(Const_Skeleton value) {Opt = value;}
        public static implicit operator _InOptConst_Skeleton(Const_Skeleton value) {return new(value);}
    }
}
