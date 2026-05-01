// machine generated, do not edit
public static partial class JPH
{
    /// Resource for a skinned animation
    /// Generated from class `JPH::SkeletalAnimation`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::SkeletalAnimation>`
    /// This is the const half of the class.
    public class Const_SkeletalAnimation : JPH.Object<Const_SkeletalAnimation>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletalAnimation_Release(void *_this);
            __JPH_RefTarget_JPH_SkeletalAnimation_Release(__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SkeletalAnimation() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHSkeletalAnimation(Const_SkeletalAnimation self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHSkeletalAnimation._Underlying *__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_Underlying *_this);
            JPH.Const_RefTarget_JPHSkeletalAnimation ret = new(__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe Const_SkeletalAnimation(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SkeletalAnimation() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletalAnimation._Underlying *__JPH_SkeletalAnimation_DefaultConstruct();
            _UnderlyingPtr = __JPH_SkeletalAnimation_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(void *_this);
            __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::SkeletalAnimation::SkeletalAnimation`.
        public unsafe Const_SkeletalAnimation(JPH._ByValue_SkeletalAnimation _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletalAnimation._Underlying *__JPH_SkeletalAnimation_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletalAnimation._Underlying *_other);
            _UnderlyingPtr = __JPH_SkeletalAnimation_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(void *_this);
            __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SkeletalAnimation::SkeletalAnimation`.
        public Const_SkeletalAnimation(Const_SkeletalAnimation _other) : this(new _ByValue_SkeletalAnimation(_other)) {}

        /// Generated from constructor `JPH::SkeletalAnimation::SkeletalAnimation`.
        public Const_SkeletalAnimation(SkeletalAnimation _other) : this((Const_SkeletalAnimation)_other) {}

        /// Generated from method `JPH::SkeletalAnimation::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SkeletalAnimation_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_SkeletalAnimation_size_t(inCount);
        }

        /// Generated from method `JPH::SkeletalAnimation::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SkeletalAnimation_void_ptr(void *inPointer);
            __Jolt_delete_JPH_SkeletalAnimation_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SkeletalAnimation::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SkeletalAnimation_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_SkeletalAnimation_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SkeletalAnimation::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SkeletalAnimation_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_SkeletalAnimation_size_t(inCount);
        }

        /// Generated from method `JPH::SkeletalAnimation::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SkeletalAnimation_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_SkeletalAnimation_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SkeletalAnimation::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SkeletalAnimation::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SkeletalAnimation_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_SkeletalAnimation_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SkeletalAnimation::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SkeletalAnimation_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_SkeletalAnimation_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SkeletalAnimation::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SkeletalAnimation_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_SkeletalAnimation_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SkeletalAnimation::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Get the length (in seconds) of this animation
        /// Generated from method `JPH::SkeletalAnimation::GetDuration`.
        public unsafe float GetDuration()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_GetDuration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_GetDuration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SkeletalAnimation_GetDuration(_Underlying *_this);
            return __JPH_SkeletalAnimation_GetDuration(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SkeletalAnimation::IsLooping`.
        public unsafe bool IsLooping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_IsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_IsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SkeletalAnimation_IsLooping(_Underlying *_this);
            return __JPH_SkeletalAnimation_IsLooping(_UnderlyingPtr) != 0;
        }

        /// Get the (interpolated) joint transforms at time inTime
        /// Generated from method `JPH::SkeletalAnimation::Sample`.
        public unsafe void Sample(float inTime, JPH.SkeletonPose ioPose)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Sample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Sample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletalAnimation_Sample(_Underlying *_this, float inTime, JPH.SkeletonPose._Underlying *ioPose);
            __JPH_SkeletalAnimation_Sample(_UnderlyingPtr, inTime, ioPose._UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::SkeletalAnimation::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletalAnimation_SetEmbedded(_Underlying *_this);
            __JPH_SkeletalAnimation_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::SkeletalAnimation::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SkeletalAnimation_GetRefCount(_Underlying *_this);
            return __JPH_SkeletalAnimation_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::SkeletalAnimation::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletalAnimation_AddRef(_Underlying *_this);
            __JPH_SkeletalAnimation_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SkeletalAnimation::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletalAnimation_Release(_Underlying *_this);
            __JPH_SkeletalAnimation_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::SkeletalAnimation::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_SkeletalAnimation_sInternalGetRefCountOffset();
            return __JPH_SkeletalAnimation_sInternalGetRefCountOffset();
        }

        /// Contains the animation for a single joint
        /// Generated from class `JPH::SkeletalAnimation::AnimatedJoint`.
        /// This is the const half of the class.
        public class Const_AnimatedJoint : JPH.Object<Const_AnimatedJoint>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletalAnimation_AnimatedJoint_Destroy(_Underlying *_this);
                __JPH_SkeletalAnimation_AnimatedJoint_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_AnimatedJoint() {Dispose(false);}

            internal unsafe Const_AnimatedJoint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_AnimatedJoint() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.AnimatedJoint._Underlying *__JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletalAnimation::AnimatedJoint::AnimatedJoint`.
            public unsafe Const_AnimatedJoint(JPH.SkeletalAnimation._ByValue_AnimatedJoint _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.AnimatedJoint._Underlying *__JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletalAnimation.AnimatedJoint._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::SkeletalAnimation::AnimatedJoint::AnimatedJoint`.
            public Const_AnimatedJoint(Const_AnimatedJoint _other) : this(new _ByValue_AnimatedJoint(_other)) {}

            /// Generated from constructor `JPH::SkeletalAnimation::AnimatedJoint::AnimatedJoint`.
            public Const_AnimatedJoint(AnimatedJoint _other) : this((Const_AnimatedJoint)_other) {}

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t(inCount);
            }

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t(inCount);
            }

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// Contains the animation for a single joint
        /// Generated from class `JPH::SkeletalAnimation::AnimatedJoint`.
        /// This is the non-const half of the class.
        public class AnimatedJoint : Const_AnimatedJoint
        {
            internal unsafe AnimatedJoint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe AnimatedJoint() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.AnimatedJoint._Underlying *__JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletalAnimation::AnimatedJoint::AnimatedJoint`.
            public unsafe AnimatedJoint(JPH.SkeletalAnimation._ByValue_AnimatedJoint _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.AnimatedJoint._Underlying *__JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletalAnimation.AnimatedJoint._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::SkeletalAnimation::AnimatedJoint::AnimatedJoint`.
            public AnimatedJoint(Const_AnimatedJoint _other) : this(new _ByValue_AnimatedJoint(_other)) {}

            /// Generated from constructor `JPH::SkeletalAnimation::AnimatedJoint::AnimatedJoint`.
            public AnimatedJoint(AnimatedJoint _other) : this((Const_AnimatedJoint)_other) {}

            /// Generated from method `JPH::SkeletalAnimation::AnimatedJoint::operator=`.
            public unsafe JPH.SkeletalAnimation.AnimatedJoint Assign(JPH.SkeletalAnimation._ByValue_AnimatedJoint _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_AnimatedJoint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.AnimatedJoint._Underlying *__JPH_SkeletalAnimation_AnimatedJoint_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SkeletalAnimation.AnimatedJoint._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_SkeletalAnimation_AnimatedJoint_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `AnimatedJoint` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `AnimatedJoint`/`Const_AnimatedJoint` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_AnimatedJoint
        {
            #pragma warning disable CS0649
            internal readonly Const_AnimatedJoint? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_AnimatedJoint() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_AnimatedJoint(Const_AnimatedJoint new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_AnimatedJoint(Const_AnimatedJoint arg) {return new(arg);}
            public _ByValue_AnimatedJoint(JPH._Moved<AnimatedJoint> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_AnimatedJoint(JPH._Moved<AnimatedJoint> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `AnimatedJoint` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_AnimatedJoint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `AnimatedJoint`/`Const_AnimatedJoint` directly.
        public class _InOptMut_AnimatedJoint
        {
            public AnimatedJoint? Opt;

            public _InOptMut_AnimatedJoint() {}
            public _InOptMut_AnimatedJoint(AnimatedJoint value) {Opt = value;}
            public static implicit operator _InOptMut_AnimatedJoint(AnimatedJoint value) {return new(value);}
        }

        /// This is used for optional parameters of class `AnimatedJoint` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_AnimatedJoint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `AnimatedJoint`/`Const_AnimatedJoint` to pass it to the function.
        public class _InOptConst_AnimatedJoint
        {
            public Const_AnimatedJoint? Opt;

            public _InOptConst_AnimatedJoint() {}
            public _InOptConst_AnimatedJoint(Const_AnimatedJoint value) {Opt = value;}
            public static implicit operator _InOptConst_AnimatedJoint(Const_AnimatedJoint value) {return new(value);}
        }

        /// Contains the current state of a joint, a local space transformation relative to its parent joint
        /// Generated from class `JPH::SkeletalAnimation::JointState`.
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::SkeletalAnimation::Keyframe`
        /// This is the const half of the class.
        public class Const_JointState : JPH.Object<Const_JointState>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletalAnimation_JointState_Destroy(_Underlying *_this);
                __JPH_SkeletalAnimation_JointState_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_JointState() {Dispose(false);}

            ///< Local space rotation of the joint
            public unsafe JPH.Const_Quat mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Quat._Underlying *__JPH_SkeletalAnimation_JointState_Get_mRotation(_Underlying *_this);
                    JPH.Const_Quat __ret;
                    __ret = new(__JPH_SkeletalAnimation_JointState_Get_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Local space translation of the joint
            public unsafe JPH.Const_Vec3 mTranslation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_Get_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_Get_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_SkeletalAnimation_JointState_Get_mTranslation(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_SkeletalAnimation_JointState_Get_mTranslation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_JointState(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_JointState() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.JointState._Underlying *__JPH_SkeletalAnimation_JointState_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletalAnimation_JointState_DefaultConstruct();
            }

            /// Constructs `JPH::SkeletalAnimation::JointState` elementwise.
            public unsafe Const_JointState(JPH.Const_Quat mRotation, JPH.Const_Vec3 mTranslation) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.JointState._Underlying *__JPH_SkeletalAnimation_JointState_ConstructFrom(JPH.Quat._Underlying *mRotation, JPH.Vec3._Underlying *mTranslation);
                _UnderlyingPtr = __JPH_SkeletalAnimation_JointState_ConstructFrom(mRotation._UnderlyingPtr, mTranslation._UnderlyingPtr);
                _KeepAlive(mRotation);
                _KeepAlive(mTranslation);
            }

            /// Generated from constructor `JPH::SkeletalAnimation::JointState::JointState`.
            public unsafe Const_JointState(JPH.SkeletalAnimation.Const_JointState _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.JointState._Underlying *__JPH_SkeletalAnimation_JointState_ConstructFromAnother(JPH.SkeletalAnimation.JointState._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletalAnimation_JointState_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletalAnimation::JointState::JointState`.
            public Const_JointState(JointState _other) : this((Const_JointState)_other) {}

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_JointState_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_JointState_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SkeletalAnimation_JointState_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SkeletalAnimation_JointState_size_t(inCount);
            }

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t(inCount);
            }

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_JointState_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_JointState_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SkeletalAnimation_JointState_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SkeletalAnimation_JointState_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Convert to matrix representation
            /// Generated from method `JPH::SkeletalAnimation::JointState::ToMatrix`.
            public unsafe JPH.Mat44 ToMatrix()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ToMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ToMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Mat44._Underlying *__JPH_SkeletalAnimation_JointState_ToMatrix(_Underlying *_this);
                return new(__JPH_SkeletalAnimation_JointState_ToMatrix(_UnderlyingPtr), is_owning: true);
            }
        }

        /// Contains the current state of a joint, a local space transformation relative to its parent joint
        /// Generated from class `JPH::SkeletalAnimation::JointState`.
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::SkeletalAnimation::Keyframe`
        /// This is the non-const half of the class.
        public class JointState : Const_JointState
        {
            ///< Local space rotation of the joint
            public new unsafe JPH.Quat mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Quat._Underlying *__JPH_SkeletalAnimation_JointState_GetMutable_mRotation(_Underlying *_this);
                    JPH.Quat __ret;
                    __ret = new(__JPH_SkeletalAnimation_JointState_GetMutable_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Local space translation of the joint
            public new unsafe JPH.Vec3 mTranslation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_GetMutable_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_GetMutable_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_SkeletalAnimation_JointState_GetMutable_mTranslation(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_SkeletalAnimation_JointState_GetMutable_mTranslation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe JointState(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe JointState() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.JointState._Underlying *__JPH_SkeletalAnimation_JointState_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletalAnimation_JointState_DefaultConstruct();
            }

            /// Constructs `JPH::SkeletalAnimation::JointState` elementwise.
            public unsafe JointState(JPH.Const_Quat mRotation, JPH.Const_Vec3 mTranslation) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.JointState._Underlying *__JPH_SkeletalAnimation_JointState_ConstructFrom(JPH.Quat._Underlying *mRotation, JPH.Vec3._Underlying *mTranslation);
                _UnderlyingPtr = __JPH_SkeletalAnimation_JointState_ConstructFrom(mRotation._UnderlyingPtr, mTranslation._UnderlyingPtr);
                _KeepAlive(mRotation);
                _KeepAlive(mTranslation);
            }

            /// Generated from constructor `JPH::SkeletalAnimation::JointState::JointState`.
            public unsafe JointState(JPH.SkeletalAnimation.Const_JointState _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.JointState._Underlying *__JPH_SkeletalAnimation_JointState_ConstructFromAnother(JPH.SkeletalAnimation.JointState._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletalAnimation_JointState_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletalAnimation::JointState::JointState`.
            public JointState(JointState _other) : this((Const_JointState)_other) {}

            /// Generated from method `JPH::SkeletalAnimation::JointState::operator=`.
            public unsafe JPH.SkeletalAnimation.JointState Assign(JPH.SkeletalAnimation.Const_JointState _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.JointState._Underlying *__JPH_SkeletalAnimation_JointState_AssignFromAnother(_Underlying *_this, JPH.SkeletalAnimation.JointState._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SkeletalAnimation_JointState_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }

            /// Convert from a local space matrix
            /// Generated from method `JPH::SkeletalAnimation::JointState::FromMatrix`.
            public unsafe void FromMatrix(JPH.Const_Mat44 inMatrix)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_FromMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_JointState_FromMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletalAnimation_JointState_FromMatrix(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix);
                __JPH_SkeletalAnimation_JointState_FromMatrix(_UnderlyingPtr, inMatrix._UnderlyingPtr);
            }
        }

        /// This is used for optional parameters of class `JointState` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_JointState`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `JointState`/`Const_JointState` directly.
        public class _InOptMut_JointState
        {
            public JointState? Opt;

            public _InOptMut_JointState() {}
            public _InOptMut_JointState(JointState value) {Opt = value;}
            public static implicit operator _InOptMut_JointState(JointState value) {return new(value);}
        }

        /// This is used for optional parameters of class `JointState` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_JointState`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `JointState`/`Const_JointState` to pass it to the function.
        public class _InOptConst_JointState
        {
            public Const_JointState? Opt;

            public _InOptConst_JointState() {}
            public _InOptConst_JointState(Const_JointState value) {Opt = value;}
            public static implicit operator _InOptConst_JointState(Const_JointState value) {return new(value);}
        }

        /// Contains the state of a single joint at a particular time
        /// Generated from class `JPH::SkeletalAnimation::Keyframe`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::SkeletalAnimation::JointState`
        /// This is the const half of the class.
        public class Const_Keyframe : JPH.Object<Const_Keyframe>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletalAnimation_Keyframe_Destroy(_Underlying *_this);
                __JPH_SkeletalAnimation_Keyframe_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Keyframe() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator JPH.SkeletalAnimation.Const_JointState(Const_Keyframe self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.Const_JointState._Underlying *__JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState(_Underlying *_this);
                JPH.SkeletalAnimation.Const_JointState ret = new(__JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            ///< Time of keyframe in seconds
            public unsafe float mTime
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_Get_mTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_Get_mTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SkeletalAnimation_Keyframe_Get_mTime(_Underlying *_this);
                    return *__JPH_SkeletalAnimation_Keyframe_Get_mTime(_UnderlyingPtr);
                }
            }

            ///< Local space rotation of the joint
            public unsafe JPH.Const_Quat mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Quat._Underlying *__JPH_SkeletalAnimation_Keyframe_Get_mRotation(_Underlying *_this);
                    JPH.Const_Quat __ret;
                    __ret = new(__JPH_SkeletalAnimation_Keyframe_Get_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Local space translation of the joint
            public unsafe JPH.Const_Vec3 mTranslation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_Get_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_Get_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_SkeletalAnimation_Keyframe_Get_mTranslation(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_SkeletalAnimation_Keyframe_Get_mTranslation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_Keyframe(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Keyframe() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.Keyframe._Underlying *__JPH_SkeletalAnimation_Keyframe_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletalAnimation_Keyframe_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletalAnimation::Keyframe::Keyframe`.
            public unsafe Const_Keyframe(JPH.SkeletalAnimation.Const_Keyframe _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.Keyframe._Underlying *__JPH_SkeletalAnimation_Keyframe_ConstructFromAnother(JPH.SkeletalAnimation.Keyframe._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletalAnimation_Keyframe_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletalAnimation::Keyframe::Keyframe`.
            public Const_Keyframe(Keyframe _other) : this((Const_Keyframe)_other) {}

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t(inCount);
            }

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t(inCount);
            }

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Convert to matrix representation
            /// Generated from method `JPH::SkeletalAnimation::Keyframe::ToMatrix`.
            public unsafe JPH.Mat44 ToMatrix()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_ToMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_ToMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Mat44._Underlying *__JPH_SkeletalAnimation_Keyframe_ToMatrix(_Underlying *_this);
                return new(__JPH_SkeletalAnimation_Keyframe_ToMatrix(_UnderlyingPtr), is_owning: true);
            }
        }

        /// Contains the state of a single joint at a particular time
        /// Generated from class `JPH::SkeletalAnimation::Keyframe`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::SkeletalAnimation::JointState`
        /// This is the non-const half of the class.
        public class Keyframe : Const_Keyframe
        {
            // Upcasts:
            public static unsafe implicit operator JPH.SkeletalAnimation.JointState(Keyframe self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.JointState._Underlying *__JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState(_Underlying *_this);
                JPH.SkeletalAnimation.JointState ret = new(__JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            ///< Time of keyframe in seconds
            public new unsafe ref float mTime
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_GetMutable_mTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_GetMutable_mTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SkeletalAnimation_Keyframe_GetMutable_mTime(_Underlying *_this);
                    return ref *__JPH_SkeletalAnimation_Keyframe_GetMutable_mTime(_UnderlyingPtr);
                }
            }

            ///< Local space rotation of the joint
            public new unsafe JPH.Quat mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Quat._Underlying *__JPH_SkeletalAnimation_Keyframe_GetMutable_mRotation(_Underlying *_this);
                    JPH.Quat __ret;
                    __ret = new(__JPH_SkeletalAnimation_Keyframe_GetMutable_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Local space translation of the joint
            public new unsafe JPH.Vec3 mTranslation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_GetMutable_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_GetMutable_mTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_SkeletalAnimation_Keyframe_GetMutable_mTranslation(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_SkeletalAnimation_Keyframe_GetMutable_mTranslation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Keyframe(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Keyframe() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.Keyframe._Underlying *__JPH_SkeletalAnimation_Keyframe_DefaultConstruct();
                _UnderlyingPtr = __JPH_SkeletalAnimation_Keyframe_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SkeletalAnimation::Keyframe::Keyframe`.
            public unsafe Keyframe(JPH.SkeletalAnimation.Const_Keyframe _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.Keyframe._Underlying *__JPH_SkeletalAnimation_Keyframe_ConstructFromAnother(JPH.SkeletalAnimation.Keyframe._Underlying *_other);
                _UnderlyingPtr = __JPH_SkeletalAnimation_Keyframe_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SkeletalAnimation::Keyframe::Keyframe`.
            public Keyframe(Keyframe _other) : this((Const_Keyframe)_other) {}

            /// Generated from method `JPH::SkeletalAnimation::Keyframe::operator=`.
            public unsafe JPH.SkeletalAnimation.Keyframe Assign(JPH.SkeletalAnimation.Const_Keyframe _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletalAnimation.Keyframe._Underlying *__JPH_SkeletalAnimation_Keyframe_AssignFromAnother(_Underlying *_this, JPH.SkeletalAnimation.Keyframe._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SkeletalAnimation_Keyframe_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }

            /// Convert from a local space matrix
            /// Generated from method `JPH::SkeletalAnimation::Keyframe::FromMatrix`.
            public unsafe void FromMatrix(JPH.Const_Mat44 inMatrix)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_FromMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_Keyframe_FromMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SkeletalAnimation_Keyframe_FromMatrix(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix);
                __JPH_SkeletalAnimation_Keyframe_FromMatrix(_UnderlyingPtr, inMatrix._UnderlyingPtr);
            }
        }

        /// This is used for optional parameters of class `Keyframe` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Keyframe`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Keyframe`/`Const_Keyframe` directly.
        public class _InOptMut_Keyframe
        {
            public Keyframe? Opt;

            public _InOptMut_Keyframe() {}
            public _InOptMut_Keyframe(Keyframe value) {Opt = value;}
            public static implicit operator _InOptMut_Keyframe(Keyframe value) {return new(value);}
        }

        /// This is used for optional parameters of class `Keyframe` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Keyframe`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Keyframe`/`Const_Keyframe` to pass it to the function.
        public class _InOptConst_Keyframe
        {
            public Const_Keyframe? Opt;

            public _InOptConst_Keyframe() {}
            public _InOptConst_Keyframe(Const_Keyframe value) {Opt = value;}
            public static implicit operator _InOptConst_Keyframe(Const_Keyframe value) {return new(value);}
        }
    }

    /// Resource for a skinned animation
    /// Generated from class `JPH::SkeletalAnimation`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::SkeletalAnimation>`
    /// This is the non-const half of the class.
    public class SkeletalAnimation : Const_SkeletalAnimation
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHSkeletalAnimation(SkeletalAnimation self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSkeletalAnimation._Underlying *__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_Underlying *_this);
            JPH.RefTarget_JPHSkeletalAnimation ret = new(__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe SkeletalAnimation(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SkeletalAnimation() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletalAnimation._Underlying *__JPH_SkeletalAnimation_DefaultConstruct();
            _UnderlyingPtr = __JPH_SkeletalAnimation_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(void *_this);
            __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::SkeletalAnimation::SkeletalAnimation`.
        public unsafe SkeletalAnimation(JPH._ByValue_SkeletalAnimation _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletalAnimation._Underlying *__JPH_SkeletalAnimation_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SkeletalAnimation._Underlying *_other);
            _UnderlyingPtr = __JPH_SkeletalAnimation_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SkeletalAnimation_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(void *_this);
            __JPH_RefTarget_JPH_SkeletalAnimation_AddRef(__JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SkeletalAnimation::SkeletalAnimation`.
        public SkeletalAnimation(Const_SkeletalAnimation _other) : this(new _ByValue_SkeletalAnimation(_other)) {}

        /// Generated from constructor `JPH::SkeletalAnimation::SkeletalAnimation`.
        public SkeletalAnimation(SkeletalAnimation _other) : this((Const_SkeletalAnimation)_other) {}

        /// Generated from method `JPH::SkeletalAnimation::operator=`.
        public unsafe JPH.SkeletalAnimation Assign(JPH._ByValue_SkeletalAnimation _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletalAnimation._Underlying *__JPH_SkeletalAnimation_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SkeletalAnimation._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_SkeletalAnimation_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Scale the size of all joints by inScale
        /// Generated from method `JPH::SkeletalAnimation::ScaleJoints`.
        public unsafe void ScaleJoints(float inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_ScaleJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_ScaleJoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletalAnimation_ScaleJoints(_Underlying *_this, float inScale);
            __JPH_SkeletalAnimation_ScaleJoints(_UnderlyingPtr, inScale);
        }

        /// If the animation is looping or not. If an animation is looping, the animation will continue playing after completion
        /// Generated from method `JPH::SkeletalAnimation::SetIsLooping`.
        public unsafe void SetIsLooping(bool inIsLooping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SkeletalAnimation_SetIsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SkeletalAnimation_SetIsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SkeletalAnimation_SetIsLooping(_Underlying *_this, byte inIsLooping);
            __JPH_SkeletalAnimation_SetIsLooping(_UnderlyingPtr, inIsLooping ? (byte)1 : (byte)0);
        }
    }

    /// This is used as a function parameter when the underlying function receives `SkeletalAnimation` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `SkeletalAnimation`/`Const_SkeletalAnimation` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_SkeletalAnimation
    {
        #pragma warning disable CS0649
        internal readonly Const_SkeletalAnimation? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_SkeletalAnimation() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_SkeletalAnimation(Const_SkeletalAnimation new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_SkeletalAnimation(Const_SkeletalAnimation arg) {return new(arg);}
        public _ByValue_SkeletalAnimation(JPH._Moved<SkeletalAnimation> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_SkeletalAnimation(JPH._Moved<SkeletalAnimation> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `SkeletalAnimation` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SkeletalAnimation`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SkeletalAnimation`/`Const_SkeletalAnimation` directly.
    public class _InOptMut_SkeletalAnimation
    {
        public SkeletalAnimation? Opt;

        public _InOptMut_SkeletalAnimation() {}
        public _InOptMut_SkeletalAnimation(SkeletalAnimation value) {Opt = value;}
        public static implicit operator _InOptMut_SkeletalAnimation(SkeletalAnimation value) {return new(value);}
    }

    /// This is used for optional parameters of class `SkeletalAnimation` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SkeletalAnimation`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SkeletalAnimation`/`Const_SkeletalAnimation` to pass it to the function.
    public class _InOptConst_SkeletalAnimation
    {
        public Const_SkeletalAnimation? Opt;

        public _InOptConst_SkeletalAnimation() {}
        public _InOptConst_SkeletalAnimation(Const_SkeletalAnimation value) {Opt = value;}
        public static implicit operator _InOptConst_SkeletalAnimation(Const_SkeletalAnimation value) {return new(value);}
    }
}
