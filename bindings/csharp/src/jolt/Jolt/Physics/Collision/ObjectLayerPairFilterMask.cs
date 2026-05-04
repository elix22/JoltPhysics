// machine generated, do not edit
public static partial class JPH
{
    /// Filter class to test if two objects can collide based on their object layer. Used while finding collision pairs.
    /// Uses group bits and mask bits. Two layers can collide if Object1.Group & Object2.Mask is non-zero and Object2.Group & Object1.Mask is non-zero.
    /// The behavior is similar to that in e.g. Bullet.
    /// This implementation works together with BroadPhaseLayerInterfaceMask and ObjectVsBroadPhaseLayerFilterMask
    /// Generated from class `JPH::ObjectLayerPairFilterMask`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerPairFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_ObjectLayerPairFilterMask : JPH.Object<Const_ObjectLayerPairFilterMask>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ObjectLayerPairFilterMask_Destroy(_Underlying *_this);
            __JPH_ObjectLayerPairFilterMask_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ObjectLayerPairFilterMask() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_ObjectLayerPairFilterMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ObjectLayerPairFilter(Const_ObjectLayerPairFilterMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectLayerPairFilter._Underlying *__JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter(_Underlying *_this);
            JPH.Const_ObjectLayerPairFilter ret = new(__JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ObjectLayerPairFilterMask(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_ObjectLayerPairFilterMask ret = new(__JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_ObjectLayerPairFilterMask(JPH.Const_ObjectLayerPairFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter(JPH.Const_ObjectLayerPairFilter._Underlying *_this);
            Const_ObjectLayerPairFilterMask ret = new(__JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// Number of bits for the group and mask bits
        public static unsafe uint CNumBits
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_Get_cNumBits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_Get_cNumBits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_ObjectLayerPairFilterMask_Get_cNumBits();
                return *__JPH_ObjectLayerPairFilterMask_Get_cNumBits();
            }
        }

        public static unsafe uint CMask
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_Get_cMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_Get_cMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_ObjectLayerPairFilterMask_Get_cMask();
                return *__JPH_ObjectLayerPairFilterMask_Get_cMask();
            }
        }

        internal unsafe Const_ObjectLayerPairFilterMask(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ObjectLayerPairFilterMask() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerPairFilterMask._Underlying *__JPH_ObjectLayerPairFilterMask_DefaultConstruct();
            _UnderlyingPtr = __JPH_ObjectLayerPairFilterMask_DefaultConstruct();
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ObjectLayerPairFilterMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ObjectLayerPairFilterMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ObjectLayerPairFilterMask_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_ObjectLayerPairFilterMask_size_t(inCount);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr(void *inPointer);
            __Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t(inCount);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ObjectLayerPairFilterMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ObjectLayerPairFilterMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ObjectLayerPairFilterMask_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_ObjectLayerPairFilterMask_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_ObjectLayerPairFilterMask_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterMask::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_ObjectLayerPairFilterMask_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Construct an ObjectLayer from a group and mask bits
        /// Generated from method `JPH::ObjectLayerPairFilterMask::sGetObjectLayer`.
        /// Parameter `inMask` defaults to `cMask`.
        public static unsafe ushort SGetObjectLayer(uint inGroup, uint? inMask = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_sGetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_sGetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ushort __JPH_ObjectLayerPairFilterMask_sGetObjectLayer(uint inGroup, uint *inMask);
            uint __deref_inMask = inMask.GetValueOrDefault();
            return __JPH_ObjectLayerPairFilterMask_sGetObjectLayer(inGroup, inMask.HasValue ? &__deref_inMask : null);
        }

        /// Get the group bits from an ObjectLayer
        /// Generated from method `JPH::ObjectLayerPairFilterMask::sGetGroup`.
        public static uint SGetGroup(ushort inObjectLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_sGetGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_sGetGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_ObjectLayerPairFilterMask_sGetGroup(ushort inObjectLayer);
            return __JPH_ObjectLayerPairFilterMask_sGetGroup(inObjectLayer);
        }

        /// Get the mask bits from an ObjectLayer
        /// Generated from method `JPH::ObjectLayerPairFilterMask::sGetMask`.
        public static uint SGetMask(ushort inObjectLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_sGetMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_sGetMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_ObjectLayerPairFilterMask_sGetMask(ushort inObjectLayer);
            return __JPH_ObjectLayerPairFilterMask_sGetMask(inObjectLayer);
        }

        /// Returns true if two layers can collide
        /// Generated from method `JPH::ObjectLayerPairFilterMask::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inObject1, ushort inObject2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ObjectLayerPairFilterMask_ShouldCollide(_Underlying *_this, ushort inObject1, ushort inObject2);
            return __JPH_ObjectLayerPairFilterMask_ShouldCollide(_UnderlyingPtr, inObject1, inObject2) != 0;
        }
    }

    /// Filter class to test if two objects can collide based on their object layer. Used while finding collision pairs.
    /// Uses group bits and mask bits. Two layers can collide if Object1.Group & Object2.Mask is non-zero and Object2.Group & Object1.Mask is non-zero.
    /// The behavior is similar to that in e.g. Bullet.
    /// This implementation works together with BroadPhaseLayerInterfaceMask and ObjectVsBroadPhaseLayerFilterMask
    /// Generated from class `JPH::ObjectLayerPairFilterMask`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerPairFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class ObjectLayerPairFilterMask : Const_ObjectLayerPairFilterMask
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(ObjectLayerPairFilterMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ObjectLayerPairFilter(ObjectLayerPairFilterMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerPairFilter._Underlying *__JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter(_Underlying *_this);
            JPH.ObjectLayerPairFilter ret = new(__JPH_ObjectLayerPairFilterMask_UpcastTo_JPH_ObjectLayerPairFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator ObjectLayerPairFilterMask(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            ObjectLayerPairFilterMask ret = new(__JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator ObjectLayerPairFilterMask(JPH.ObjectLayerPairFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter(JPH.ObjectLayerPairFilter._Underlying *_this);
            ObjectLayerPairFilterMask ret = new(__JPH_ObjectLayerPairFilterMask_StaticDowncastFrom_JPH_ObjectLayerPairFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe ObjectLayerPairFilterMask(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ObjectLayerPairFilterMask() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterMask_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerPairFilterMask._Underlying *__JPH_ObjectLayerPairFilterMask_DefaultConstruct();
            _UnderlyingPtr = __JPH_ObjectLayerPairFilterMask_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `ObjectLayerPairFilterMask` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_ObjectLayerPairFilterMask
    {
        #pragma warning disable CS0649
        internal readonly Const_ObjectLayerPairFilterMask? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_ObjectLayerPairFilterMask() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `ObjectLayerPairFilterMask` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ObjectLayerPairFilterMask`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectLayerPairFilterMask`/`Const_ObjectLayerPairFilterMask` directly.
    public class _InOptMut_ObjectLayerPairFilterMask
    {
        public ObjectLayerPairFilterMask? Opt;

        public _InOptMut_ObjectLayerPairFilterMask() {}
        public _InOptMut_ObjectLayerPairFilterMask(ObjectLayerPairFilterMask value) {Opt = value;}
        public static implicit operator _InOptMut_ObjectLayerPairFilterMask(ObjectLayerPairFilterMask value) {return new(value);}
    }

    /// This is used for optional parameters of class `ObjectLayerPairFilterMask` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ObjectLayerPairFilterMask`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectLayerPairFilterMask`/`Const_ObjectLayerPairFilterMask` to pass it to the function.
    public class _InOptConst_ObjectLayerPairFilterMask
    {
        public Const_ObjectLayerPairFilterMask? Opt;

        public _InOptConst_ObjectLayerPairFilterMask() {}
        public _InOptConst_ObjectLayerPairFilterMask(Const_ObjectLayerPairFilterMask value) {Opt = value;}
        public static implicit operator _InOptConst_ObjectLayerPairFilterMask(Const_ObjectLayerPairFilterMask value) {return new(value);}
    }
}
