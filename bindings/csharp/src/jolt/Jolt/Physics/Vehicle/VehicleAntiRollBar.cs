// machine generated, do not edit
public static partial class JPH
{
    /// An anti rollbar is a stiff spring that connects two wheels to reduce the amount of roll the vehicle makes in sharp corners
    /// See: https://en.wikipedia.org/wiki/Anti-roll_bar
    /// Generated from class `JPH::VehicleAntiRollBar`.
    /// This is the const half of the class.
    public class Const_VehicleAntiRollBar : JPH.Object<Const_VehicleAntiRollBar>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleAntiRollBar_Destroy(_Underlying *_this);
            __JPH_VehicleAntiRollBar_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleAntiRollBar() {Dispose(false);}

        ///< Index (in mWheels) that represents the left wheel of this anti-rollbar
        public unsafe int mLeftWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_Get_mLeftWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_Get_mLeftWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_VehicleAntiRollBar_Get_mLeftWheel(_Underlying *_this);
                return *__JPH_VehicleAntiRollBar_Get_mLeftWheel(_UnderlyingPtr);
            }
        }

        ///< Index (in mWheels) that represents the right wheel of this anti-rollbar
        public unsafe int mRightWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_Get_mRightWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_Get_mRightWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_VehicleAntiRollBar_Get_mRightWheel(_Underlying *_this);
                return *__JPH_VehicleAntiRollBar_Get_mRightWheel(_UnderlyingPtr);
            }
        }

        ///< Stiffness (spring constant in N/m) of anti rollbar, can be 0 to disable the anti-rollbar
        public unsafe float mStiffness
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_Get_mStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_Get_mStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleAntiRollBar_Get_mStiffness(_Underlying *_this);
                return *__JPH_VehicleAntiRollBar_Get_mStiffness(_UnderlyingPtr);
            }
        }

        internal unsafe Const_VehicleAntiRollBar(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_VehicleAntiRollBar() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleAntiRollBar._Underlying *__JPH_VehicleAntiRollBar_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleAntiRollBar_DefaultConstruct();
        }

        /// Constructs `JPH::VehicleAntiRollBar` elementwise.
        public unsafe Const_VehicleAntiRollBar(int mLeftWheel, int mRightWheel, float mStiffness) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleAntiRollBar._Underlying *__JPH_VehicleAntiRollBar_ConstructFrom(int mLeftWheel, int mRightWheel, float mStiffness);
            _UnderlyingPtr = __JPH_VehicleAntiRollBar_ConstructFrom(mLeftWheel, mRightWheel, mStiffness);
        }

        /// Generated from constructor `JPH::VehicleAntiRollBar::VehicleAntiRollBar`.
        public unsafe Const_VehicleAntiRollBar(JPH.Const_VehicleAntiRollBar _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleAntiRollBar._Underlying *__JPH_VehicleAntiRollBar_ConstructFromAnother(JPH.VehicleAntiRollBar._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleAntiRollBar_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::VehicleAntiRollBar::VehicleAntiRollBar`.
        public Const_VehicleAntiRollBar(VehicleAntiRollBar _other) : this((Const_VehicleAntiRollBar)_other) {}

        /// Generated from method `JPH::VehicleAntiRollBar::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleAntiRollBar_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleAntiRollBar_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleAntiRollBar_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleAntiRollBar_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleAntiRollBar::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleAntiRollBar_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleAntiRollBar_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleAntiRollBar_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleAntiRollBar_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleAntiRollBar::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleAntiRollBar::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleAntiRollBar_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleAntiRollBar_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleAntiRollBar_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleAntiRollBar_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleAntiRollBar::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleAntiRollBar::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleAntiRollBar::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleAntiRollBar_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleAntiRollBar_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleAntiRollBar_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleAntiRollBar_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleAntiRollBar::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleAntiRollBar::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleAntiRollBar_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleAntiRollBar_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleAntiRollBar_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleAntiRollBar_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleAntiRollBar::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// An anti rollbar is a stiff spring that connects two wheels to reduce the amount of roll the vehicle makes in sharp corners
    /// See: https://en.wikipedia.org/wiki/Anti-roll_bar
    /// Generated from class `JPH::VehicleAntiRollBar`.
    /// This is the non-const half of the class.
    public class VehicleAntiRollBar : Const_VehicleAntiRollBar
    {
        ///< Index (in mWheels) that represents the left wheel of this anti-rollbar
        public new unsafe ref int mLeftWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_GetMutable_mLeftWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_GetMutable_mLeftWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_VehicleAntiRollBar_GetMutable_mLeftWheel(_Underlying *_this);
                return ref *__JPH_VehicleAntiRollBar_GetMutable_mLeftWheel(_UnderlyingPtr);
            }
        }

        ///< Index (in mWheels) that represents the right wheel of this anti-rollbar
        public new unsafe ref int mRightWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_GetMutable_mRightWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_GetMutable_mRightWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_VehicleAntiRollBar_GetMutable_mRightWheel(_Underlying *_this);
                return ref *__JPH_VehicleAntiRollBar_GetMutable_mRightWheel(_UnderlyingPtr);
            }
        }

        ///< Stiffness (spring constant in N/m) of anti rollbar, can be 0 to disable the anti-rollbar
        public new unsafe ref float mStiffness
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_GetMutable_mStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_GetMutable_mStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleAntiRollBar_GetMutable_mStiffness(_Underlying *_this);
                return ref *__JPH_VehicleAntiRollBar_GetMutable_mStiffness(_UnderlyingPtr);
            }
        }

        internal unsafe VehicleAntiRollBar(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe VehicleAntiRollBar() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleAntiRollBar._Underlying *__JPH_VehicleAntiRollBar_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleAntiRollBar_DefaultConstruct();
        }

        /// Constructs `JPH::VehicleAntiRollBar` elementwise.
        public unsafe VehicleAntiRollBar(int mLeftWheel, int mRightWheel, float mStiffness) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleAntiRollBar._Underlying *__JPH_VehicleAntiRollBar_ConstructFrom(int mLeftWheel, int mRightWheel, float mStiffness);
            _UnderlyingPtr = __JPH_VehicleAntiRollBar_ConstructFrom(mLeftWheel, mRightWheel, mStiffness);
        }

        /// Generated from constructor `JPH::VehicleAntiRollBar::VehicleAntiRollBar`.
        public unsafe VehicleAntiRollBar(JPH.Const_VehicleAntiRollBar _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleAntiRollBar._Underlying *__JPH_VehicleAntiRollBar_ConstructFromAnother(JPH.VehicleAntiRollBar._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleAntiRollBar_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::VehicleAntiRollBar::VehicleAntiRollBar`.
        public VehicleAntiRollBar(VehicleAntiRollBar _other) : this((Const_VehicleAntiRollBar)_other) {}

        /// Generated from method `JPH::VehicleAntiRollBar::operator=`.
        public unsafe JPH.VehicleAntiRollBar Assign(JPH.Const_VehicleAntiRollBar _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleAntiRollBar_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleAntiRollBar_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleAntiRollBar._Underlying *__JPH_VehicleAntiRollBar_AssignFromAnother(_Underlying *_this, JPH.VehicleAntiRollBar._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_VehicleAntiRollBar_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `VehicleAntiRollBar` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleAntiRollBar`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleAntiRollBar`/`Const_VehicleAntiRollBar` directly.
    public class _InOptMut_VehicleAntiRollBar
    {
        public VehicleAntiRollBar? Opt;

        public _InOptMut_VehicleAntiRollBar() {}
        public _InOptMut_VehicleAntiRollBar(VehicleAntiRollBar value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleAntiRollBar(VehicleAntiRollBar value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleAntiRollBar` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleAntiRollBar`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleAntiRollBar`/`Const_VehicleAntiRollBar` to pass it to the function.
    public class _InOptConst_VehicleAntiRollBar
    {
        public Const_VehicleAntiRollBar? Opt;

        public _InOptConst_VehicleAntiRollBar() {}
        public _InOptConst_VehicleAntiRollBar(Const_VehicleAntiRollBar value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleAntiRollBar(Const_VehicleAntiRollBar value) {return new(value);}
    }
}
