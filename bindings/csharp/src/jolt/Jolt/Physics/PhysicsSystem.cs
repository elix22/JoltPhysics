// machine generated, do not edit
public static partial class JPH
{
    /// The main class for the physics system. It contains all rigid bodies and simulates them.
    ///
    /// The main simulation is performed by the Update() call on multiple threads (if the JobSystem is configured to use them). Please refer to the general architecture overview in the Docs folder for more information.
    /// Generated from class `JPH::PhysicsSystem`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_PhysicsSystem : JPH.Object<Const_PhysicsSystem>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_Destroy(_Underlying *_this);
            __JPH_PhysicsSystem_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PhysicsSystem() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_PhysicsSystem self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_PhysicsSystem(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_PhysicsSystem ret = new(__JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// The maximum value that can be passed to Init for inMaxBodies.
        public static unsafe uint CMaxBodiesLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_Get_cMaxBodiesLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_Get_cMaxBodiesLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PhysicsSystem_Get_cMaxBodiesLimit();
                return *__JPH_PhysicsSystem_Get_cMaxBodiesLimit();
            }
        }

        /// The maximum value that can be passed to Init for inMaxBodyPairs.
        /// Note you should really use a lower value, using this value will cost a lot of memory!
        /// On a 32 bit platform, you'll run out of memory way before you reach this limit.
        public static unsafe uint CMaxBodyPairsLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_Get_cMaxBodyPairsLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_Get_cMaxBodyPairsLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PhysicsSystem_Get_cMaxBodyPairsLimit();
                return *__JPH_PhysicsSystem_Get_cMaxBodyPairsLimit();
            }
        }

        /// The maximum value that can be passed to Init for inMaxContactConstraints.
        /// Note you should really use a lower value, using this value will cost a lot of memory!
        /// On a 32 bit platform, you'll run out of memory way before you reach this limit.
        public static unsafe uint CMaxContactConstraintsLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_Get_cMaxContactConstraintsLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_Get_cMaxContactConstraintsLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PhysicsSystem_Get_cMaxContactConstraintsLimit();
                return *__JPH_PhysicsSystem_Get_cMaxContactConstraintsLimit();
            }
        }

        ///< Draw debug info for objects that perform continuous collision detection through the linear cast motion quality
        public static unsafe ref bool SDrawMotionQualityLinearCast
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetMutable_sDrawMotionQualityLinearCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetMutable_sDrawMotionQualityLinearCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSystem_GetMutable_sDrawMotionQualityLinearCast();
                return ref *__JPH_PhysicsSystem_GetMutable_sDrawMotionQualityLinearCast();
            }
        }

        internal unsafe Const_PhysicsSystem(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_PhysicsSystem() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsSystem._Underlying *__JPH_PhysicsSystem_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsSystem_DefaultConstruct();
        }

        /// Generated from method `JPH::PhysicsSystem::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PhysicsSystem_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PhysicsSystem_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PhysicsSystem_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_PhysicsSystem_size_t(inCount);
        }

        /// Generated from method `JPH::PhysicsSystem::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSystem_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSystem_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsSystem_void_ptr(void *inPointer);
            __Jolt_delete_JPH_PhysicsSystem_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PhysicsSystem::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSystem_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSystem_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsSystem_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_PhysicsSystem_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PhysicsSystem::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsSystem_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsSystem_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PhysicsSystem_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_PhysicsSystem_size_t(inCount);
        }

        /// Generated from method `JPH::PhysicsSystem::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSystem_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSystem_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsSystem_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_PhysicsSystem_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PhysicsSystem::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSystem_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSystem_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsSystem_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_PhysicsSystem_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PhysicsSystem::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PhysicsSystem_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PhysicsSystem_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PhysicsSystem_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_PhysicsSystem_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PhysicsSystem::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSystem_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSystem_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsSystem_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_PhysicsSystem_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PhysicsSystem::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsSystem_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsSystem_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PhysicsSystem_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_PhysicsSystem_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PhysicsSystem::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSystem_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSystem_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsSystem_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_PhysicsSystem_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PhysicsSystem::GetBodyActivationListener`.
        public unsafe JPH.BodyActivationListener? GetBodyActivationListener()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyActivationListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyActivationListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyActivationListener._Underlying *__JPH_PhysicsSystem_GetBodyActivationListener(_Underlying *_this);
            var __c_ret = __JPH_PhysicsSystem_GetBodyActivationListener(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.BodyActivationListener(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::PhysicsSystem::GetContactListener`.
        public unsafe JPH.ContactListener? GetContactListener()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListener._Underlying *__JPH_PhysicsSystem_GetContactListener(_Underlying *_this);
            var __c_ret = __JPH_PhysicsSystem_GetContactListener(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.ContactListener(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::PhysicsSystem::GetPhysicsSettings`.
        public unsafe JPH.Const_PhysicsSettings GetPhysicsSettings()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetPhysicsSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetPhysicsSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsSettings._Underlying *__JPH_PhysicsSystem_GetPhysicsSettings(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetPhysicsSettings(_UnderlyingPtr), is_owning: false);
        }

        /// Access to the body interface. This interface allows to to create / remove bodies and to change their properties.
        /// Generated from method `JPH::PhysicsSystem::GetBodyInterface`.
        public unsafe JPH.Const_BodyInterface GetBodyInterface()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BodyInterface._Underlying *__JPH_PhysicsSystem_GetBodyInterface(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetBodyInterface(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::PhysicsSystem::GetBodyInterfaceNoLock`.
        public unsafe JPH.Const_BodyInterface GetBodyInterfaceNoLock()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyInterfaceNoLock", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyInterfaceNoLock", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BodyInterface._Underlying *__JPH_PhysicsSystem_GetBodyInterfaceNoLock(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetBodyInterfaceNoLock(_UnderlyingPtr), is_owning: false);
        }

        /// Access to the broadphase interface that allows coarse collision queries
        /// Generated from method `JPH::PhysicsSystem::GetBroadPhaseQuery`.
        public unsafe JPH.Const_BroadPhaseQuery GetBroadPhaseQuery()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetBroadPhaseQuery", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetBroadPhaseQuery", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseQuery._Underlying *__JPH_PhysicsSystem_GetBroadPhaseQuery(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetBroadPhaseQuery(_UnderlyingPtr), is_owning: false);
        }

        /// Interface that allows fine collision queries against first the broad phase and then the narrow phase.
        /// Generated from method `JPH::PhysicsSystem::GetNarrowPhaseQuery`.
        public unsafe JPH.Const_NarrowPhaseQuery GetNarrowPhaseQuery()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetNarrowPhaseQuery", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetNarrowPhaseQuery", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NarrowPhaseQuery._Underlying *__JPH_PhysicsSystem_GetNarrowPhaseQuery(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetNarrowPhaseQuery(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::PhysicsSystem::GetNarrowPhaseQueryNoLock`.
        public unsafe JPH.Const_NarrowPhaseQuery GetNarrowPhaseQueryNoLock()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetNarrowPhaseQueryNoLock", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetNarrowPhaseQueryNoLock", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NarrowPhaseQuery._Underlying *__JPH_PhysicsSystem_GetNarrowPhaseQueryNoLock(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetNarrowPhaseQueryNoLock(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::PhysicsSystem::GetGravity`.
        public unsafe JPH.Vec3 GetGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_PhysicsSystem_GetGravity(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetGravity(_UnderlyingPtr), is_owning: true);
        }

        /// Broadphase layer filter that decides if two objects can collide, this was passed to the Init function.
        /// Generated from method `JPH::PhysicsSystem::GetObjectVsBroadPhaseLayerFilter`.
        public unsafe JPH.Const_ObjectVsBroadPhaseLayerFilter GetObjectVsBroadPhaseLayerFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectVsBroadPhaseLayerFilter._Underlying *__JPH_PhysicsSystem_GetObjectVsBroadPhaseLayerFilter(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetObjectVsBroadPhaseLayerFilter(_UnderlyingPtr), is_owning: false);
        }

        /// Object layer filter that decides if two objects can collide, this was passed to the Init function.
        /// Generated from method `JPH::PhysicsSystem::GetObjectLayerPairFilter`.
        public unsafe JPH.Const_ObjectLayerPairFilter GetObjectLayerPairFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectLayerPairFilter._Underlying *__JPH_PhysicsSystem_GetObjectLayerPairFilter(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetObjectLayerPairFilter(_UnderlyingPtr), is_owning: false);
        }

        /// Get an broadphase layer filter that uses the default pair filter and a specified object layer to determine if broadphase layers collide
        /// Generated from method `JPH::PhysicsSystem::GetDefaultBroadPhaseLayerFilter`.
        public unsafe JPH.DefaultBroadPhaseLayerFilter GetDefaultBroadPhaseLayerFilter(ushort inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetDefaultBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetDefaultBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DefaultBroadPhaseLayerFilter._Underlying *__JPH_PhysicsSystem_GetDefaultBroadPhaseLayerFilter(_Underlying *_this, ushort inLayer);
            return new(__JPH_PhysicsSystem_GetDefaultBroadPhaseLayerFilter(_UnderlyingPtr, inLayer), is_owning: true);
        }

        /// Get an object layer filter that uses the default pair filter and a specified layer to determine if layers collide
        /// Generated from method `JPH::PhysicsSystem::GetDefaultLayerFilter`.
        public unsafe JPH.DefaultObjectLayerFilter GetDefaultLayerFilter(ushort inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetDefaultLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetDefaultLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DefaultObjectLayerFilter._Underlying *__JPH_PhysicsSystem_GetDefaultLayerFilter(_Underlying *_this, ushort inLayer);
            return new(__JPH_PhysicsSystem_GetDefaultLayerFilter(_UnderlyingPtr, inLayer), is_owning: true);
        }

        /// Gets the current amount of bodies that are in the body manager
        /// Generated from method `JPH::PhysicsSystem::GetNumBodies`.
        public unsafe uint GetNumBodies()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetNumBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetNumBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PhysicsSystem_GetNumBodies(_Underlying *_this);
            return __JPH_PhysicsSystem_GetNumBodies(_UnderlyingPtr);
        }

        /// Get the maximum amount of bodies that this physics system supports
        /// Generated from method `JPH::PhysicsSystem::GetMaxBodies`.
        public unsafe uint GetMaxBodies()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetMaxBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetMaxBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PhysicsSystem_GetMaxBodies(_Underlying *_this);
            return __JPH_PhysicsSystem_GetMaxBodies(_UnderlyingPtr);
        }

        /// Check if 2 bodies were in contact during the last simulation step. Since contacts are only detected between active bodies, so at least one of the bodies must be active in order for this function to work.
        /// It queries the state at the time of the last PhysicsSystem::Update and will return true if the bodies were in contact, even if one of the bodies was moved / removed afterwards.
        /// This function can be called from any thread when the PhysicsSystem::Update is not running. During PhysicsSystem::Update this function is only valid during contact callbacks:
        /// - During the ContactListener::OnContactAdded callback this function can be used to determine if a different contact pair between the bodies was active in the previous simulation step (function returns true) or if this is the first step that the bodies are touching (function returns false).
        /// - During the ContactListener::OnContactRemoved callback this function can be used to determine if this is the last contact pair between the bodies (function returns false) or if there are other contacts still present (function returns true).
        /// Generated from method `JPH::PhysicsSystem::WereBodiesInContact`.
        public unsafe bool WereBodiesInContact(in JPH.BodyID inBody1ID, in JPH.BodyID inBody2ID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_WereBodiesInContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_WereBodiesInContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_PhysicsSystem_WereBodiesInContact(_Underlying *_this, JPH.BodyID *inBody1ID, JPH.BodyID *inBody2ID);
            fixed (JPH.BodyID *__ptr_inBody1ID = &inBody1ID)
            {
                fixed (JPH.BodyID *__ptr_inBody2ID = &inBody2ID)
                {
                    return __JPH_PhysicsSystem_WereBodiesInContact(_UnderlyingPtr, __ptr_inBody1ID, __ptr_inBody2ID) != 0;
                }
            }
        }

        /// Get the bounding box of all bodies in the physics system.
        /// Deprecated: Use GetBroadPhaseQuery().GetBounds() instead.
        /// Generated from method `JPH::PhysicsSystem::GetBounds`.
        public unsafe JPH.AABox GetBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_PhysicsSystem_GetBounds(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetBounds(_UnderlyingPtr), is_owning: true);
        }
    }

    /// The main class for the physics system. It contains all rigid bodies and simulates them.
    ///
    /// The main simulation is performed by the Update() call on multiple threads (if the JobSystem is configured to use them). Please refer to the general architecture overview in the Docs folder for more information.
    /// Generated from class `JPH::PhysicsSystem`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class PhysicsSystem : Const_PhysicsSystem
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(PhysicsSystem self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator PhysicsSystem(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            PhysicsSystem ret = new(__JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe PhysicsSystem(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe PhysicsSystem() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsSystem._Underlying *__JPH_PhysicsSystem_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsSystem_DefaultConstruct();
        }

        /// Initialize the system.
        /// @param inMaxBodies Maximum number of bodies to support.
        /// @param inNumBodyMutexes Number of body mutexes to use. Should be a power of 2 in the range [1, 64], use 0 to auto detect.
        /// @param inMaxBodyPairs Maximum amount of body pairs to process (anything else will fall through the world), this number should generally be much higher than the max amount of contact points as there will be lots of bodies close that are not actually touching.
        /// @param inMaxContactConstraints Maximum amount of contact constraints to process (anything else will fall through the world).
        /// @param inBroadPhaseLayerInterface Information on the mapping of object layers to broad phase layers. Since this is a virtual interface, the instance needs to stay alive during the lifetime of the PhysicsSystem.
        /// @param inObjectVsBroadPhaseLayerFilter Filter callback function that is used to determine if an object layer collides with a broad phase layer. Since this is a virtual interface, the instance needs to stay alive during the lifetime of the PhysicsSystem.
        /// @param inObjectLayerPairFilter Filter callback function that is used to determine if two object layers collide. Since this is a virtual interface, the instance needs to stay alive during the lifetime of the PhysicsSystem.
        /// Generated from method `JPH::PhysicsSystem::Init`.
        public unsafe void Init(uint inMaxBodies, uint inNumBodyMutexes, uint inMaxBodyPairs, uint inMaxContactConstraints, JPH.Const_BroadPhaseLayerInterface inBroadPhaseLayerInterface, JPH.Const_ObjectVsBroadPhaseLayerFilter inObjectVsBroadPhaseLayerFilter, JPH.Const_ObjectLayerPairFilter inObjectLayerPairFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_Init(_Underlying *_this, uint inMaxBodies, uint inNumBodyMutexes, uint inMaxBodyPairs, uint inMaxContactConstraints, JPH.Const_BroadPhaseLayerInterface._Underlying *inBroadPhaseLayerInterface, JPH.Const_ObjectVsBroadPhaseLayerFilter._Underlying *inObjectVsBroadPhaseLayerFilter, JPH.Const_ObjectLayerPairFilter._Underlying *inObjectLayerPairFilter);
            __JPH_PhysicsSystem_Init(_UnderlyingPtr, inMaxBodies, inNumBodyMutexes, inMaxBodyPairs, inMaxContactConstraints, inBroadPhaseLayerInterface._UnderlyingPtr, inObjectVsBroadPhaseLayerFilter._UnderlyingPtr, inObjectLayerPairFilter._UnderlyingPtr);
        }

        /// Listener that is notified whenever a body is activated/deactivated
        /// Generated from method `JPH::PhysicsSystem::SetBodyActivationListener`.
        public unsafe void SetBodyActivationListener(JPH.BodyActivationListener? inListener)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_SetBodyActivationListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_SetBodyActivationListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_SetBodyActivationListener(_Underlying *_this, JPH.BodyActivationListener._Underlying *inListener);
            __JPH_PhysicsSystem_SetBodyActivationListener(_UnderlyingPtr, inListener is not null ? inListener._UnderlyingPtr : null);
        }

        /// Listener that is notified whenever a contact point between two bodies is added/updated/removed.
        /// You can't change contact listener during PhysicsSystem::Update but it can be changed at any other time.
        /// Generated from method `JPH::PhysicsSystem::SetContactListener`.
        public unsafe void SetContactListener(JPH.ContactListener? inListener)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_SetContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_SetContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_SetContactListener(_Underlying *_this, JPH.ContactListener._Underlying *inListener);
            __JPH_PhysicsSystem_SetContactListener(_UnderlyingPtr, inListener is not null ? inListener._UnderlyingPtr : null);
        }

        /// Control the main constants of the physics simulation
        /// Generated from method `JPH::PhysicsSystem::SetPhysicsSettings`.
        public unsafe void SetPhysicsSettings(JPH.Const_PhysicsSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_SetPhysicsSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_SetPhysicsSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_SetPhysicsSettings(_Underlying *_this, JPH.Const_PhysicsSettings._Underlying *inSettings);
            __JPH_PhysicsSystem_SetPhysicsSettings(_UnderlyingPtr, inSettings._UnderlyingPtr);
        }

        /// Generated from method `JPH::PhysicsSystem::GetBodyInterface`.
        public unsafe new JPH.BodyInterface GetBodyInterface()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyInterface_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyInterface_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyInterface._Underlying *__JPH_PhysicsSystem_GetBodyInterface_mut(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetBodyInterface_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::PhysicsSystem::GetBodyInterfaceNoLock`.
        public unsafe new JPH.BodyInterface GetBodyInterfaceNoLock()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyInterfaceNoLock_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_GetBodyInterfaceNoLock_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyInterface._Underlying *__JPH_PhysicsSystem_GetBodyInterfaceNoLock_mut(_Underlying *_this);
            return new(__JPH_PhysicsSystem_GetBodyInterfaceNoLock_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Add constraint to the world
        /// Generated from method `JPH::PhysicsSystem::AddConstraint`.
        public unsafe void AddConstraint(JPH.Constraint? inConstraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_AddConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_AddConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_AddConstraint(_Underlying *_this, JPH.Constraint._Underlying *inConstraint);
            __JPH_PhysicsSystem_AddConstraint(_UnderlyingPtr, inConstraint is not null ? inConstraint._UnderlyingPtr : null);
        }

        /// Remove constraint from the world
        /// Generated from method `JPH::PhysicsSystem::RemoveConstraint`.
        public unsafe void RemoveConstraint(JPH.Constraint? inConstraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_RemoveConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_RemoveConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_RemoveConstraint(_Underlying *_this, JPH.Constraint._Underlying *inConstraint);
            __JPH_PhysicsSystem_RemoveConstraint(_UnderlyingPtr, inConstraint is not null ? inConstraint._UnderlyingPtr : null);
        }

        /// Batch add constraints.
        /// Generated from method `JPH::PhysicsSystem::AddConstraints`.
        public unsafe void AddConstraints(void **inConstraints, int inNumber)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_AddConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_AddConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_AddConstraints(_Underlying *_this, void **inConstraints, int inNumber);
            __JPH_PhysicsSystem_AddConstraints(_UnderlyingPtr, inConstraints, inNumber);
        }

        /// Batch remove constraints.
        /// Generated from method `JPH::PhysicsSystem::RemoveConstraints`.
        public unsafe void RemoveConstraints(void **inConstraints, int inNumber)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_RemoveConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_RemoveConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_RemoveConstraints(_Underlying *_this, void **inConstraints, int inNumber);
            __JPH_PhysicsSystem_RemoveConstraints(_UnderlyingPtr, inConstraints, inNumber);
        }

        /// Optimize the broadphase, needed only if you've added many bodies prior to calling Update() for the first time.
        /// Don't call this every frame as PhysicsSystem::Update spreads out the same work over multiple frames.
        /// If you add many bodies through BodyInterface::AddBodiesPrepare/AddBodiesFinalize and if the bodies in a batch are
        /// in a roughly unoccupied space (e.g. a new level section) then a call to OptimizeBroadPhase is also not needed
        /// as batch adding creates an efficient bounding volume hierarchy.
        /// Don't call this function while bodies are being modified from another thread or use the locking BodyInterface to modify bodies.
        /// Generated from method `JPH::PhysicsSystem::OptimizeBroadPhase`.
        public unsafe void OptimizeBroadPhase()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_OptimizeBroadPhase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_OptimizeBroadPhase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_OptimizeBroadPhase(_Underlying *_this);
            __JPH_PhysicsSystem_OptimizeBroadPhase(_UnderlyingPtr);
        }

        /// Adds a new step listener
        /// Generated from method `JPH::PhysicsSystem::AddStepListener`.
        public unsafe void AddStepListener(JPH.PhysicsStepListener? inListener)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_AddStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_AddStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_AddStepListener(_Underlying *_this, JPH.PhysicsStepListener._Underlying *inListener);
            __JPH_PhysicsSystem_AddStepListener(_UnderlyingPtr, inListener is not null ? inListener._UnderlyingPtr : null);
        }

        /// Removes a step listener
        /// Generated from method `JPH::PhysicsSystem::RemoveStepListener`.
        public unsafe void RemoveStepListener(JPH.PhysicsStepListener? inListener)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_RemoveStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_RemoveStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_RemoveStepListener(_Underlying *_this, JPH.PhysicsStepListener._Underlying *inListener);
            __JPH_PhysicsSystem_RemoveStepListener(_UnderlyingPtr, inListener is not null ? inListener._UnderlyingPtr : null);
        }

        /// Simulate the system.
        /// The world steps for a total of inDeltaTime seconds. This is divided in inCollisionSteps iterations.
        /// Each iteration consists of collision detection followed by an integration step.
        /// This function internally spawns jobs using inJobSystem and waits for them to complete, so no jobs will be running when this function returns.
        /// The temp allocator is used, for example, to store the list of bodies that are in contact, how they form islands together
        /// and data to solve the contacts between bodies. At the end of the Update call, all allocated memory will have been freed.
        /// Generated from method `JPH::PhysicsSystem::Update`.
        public unsafe JPH.EPhysicsUpdateError Update(float inDeltaTime, int inCollisionSteps, JPH.TempAllocator? inTempAllocator, JPH.JobSystem? inJobSystem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EPhysicsUpdateError __JPH_PhysicsSystem_Update(_Underlying *_this, float inDeltaTime, int inCollisionSteps, JPH.TempAllocator._Underlying *inTempAllocator, JPH.JobSystem._Underlying *inJobSystem);
            return __JPH_PhysicsSystem_Update(_UnderlyingPtr, inDeltaTime, inCollisionSteps, inTempAllocator is not null ? inTempAllocator._UnderlyingPtr : null, inJobSystem is not null ? inJobSystem._UnderlyingPtr : null);
        }

        /// Draw the constraints only (debugging purposes)
        /// Generated from method `JPH::PhysicsSystem::DrawConstraints`.
        public unsafe void DrawConstraints(JPH.DebugRenderer? inRenderer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_DrawConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_DrawConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_DrawConstraints(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer);
            __JPH_PhysicsSystem_DrawConstraints(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null);
        }

        /// Draw the constraint limits only (debugging purposes)
        /// Generated from method `JPH::PhysicsSystem::DrawConstraintLimits`.
        public unsafe void DrawConstraintLimits(JPH.DebugRenderer? inRenderer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_DrawConstraintLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_DrawConstraintLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_DrawConstraintLimits(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer);
            __JPH_PhysicsSystem_DrawConstraintLimits(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null);
        }

        /// Draw the constraint reference frames only (debugging purposes)
        /// Generated from method `JPH::PhysicsSystem::DrawConstraintReferenceFrame`.
        public unsafe void DrawConstraintReferenceFrame(JPH.DebugRenderer? inRenderer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_DrawConstraintReferenceFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_DrawConstraintReferenceFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_DrawConstraintReferenceFrame(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer);
            __JPH_PhysicsSystem_DrawConstraintReferenceFrame(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null);
        }

        /// Set gravity value
        /// Generated from method `JPH::PhysicsSystem::SetGravity`.
        public unsafe void SetGravity(JPH.Const_Vec3 inGravity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSystem_SetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSystem_SetGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSystem_SetGravity(_Underlying *_this, JPH.Vec3._Underlying *inGravity);
            __JPH_PhysicsSystem_SetGravity(_UnderlyingPtr, inGravity._UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `PhysicsSystem` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_PhysicsSystem
    {
        #pragma warning disable CS0649
        internal readonly Const_PhysicsSystem? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_PhysicsSystem() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `PhysicsSystem` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PhysicsSystem`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsSystem`/`Const_PhysicsSystem` directly.
    public class _InOptMut_PhysicsSystem
    {
        public PhysicsSystem? Opt;

        public _InOptMut_PhysicsSystem() {}
        public _InOptMut_PhysicsSystem(PhysicsSystem value) {Opt = value;}
        public static implicit operator _InOptMut_PhysicsSystem(PhysicsSystem value) {return new(value);}
    }

    /// This is used for optional parameters of class `PhysicsSystem` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PhysicsSystem`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsSystem`/`Const_PhysicsSystem` to pass it to the function.
    public class _InOptConst_PhysicsSystem
    {
        public Const_PhysicsSystem? Opt;

        public _InOptConst_PhysicsSystem() {}
        public _InOptConst_PhysicsSystem(Const_PhysicsSystem value) {Opt = value;}
        public static implicit operator _InOptConst_PhysicsSystem(Const_PhysicsSystem value) {return new(value);}
    }
}
