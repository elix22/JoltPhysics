// machine generated, do not edit
public static partial class JPH
{
    /// Minimal helpers for Jolt global lifecycle.
    /// These are the only hand-implemented methods; their C/C# bindings are machine-generated.
    /// Generated from class `JoltHelpers`.
    /// This is the const half of the class.
    public class Const_JoltHelpers : JPH.Object<Const_JoltHelpers>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_Destroy(_Underlying *_this);
            __JoltHelpers_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltHelpers() {Dispose(false);}

        internal unsafe Const_JoltHelpers(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltHelpers() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JoltHelpers._Underlying *__JoltHelpers_DefaultConstruct();
            _UnderlyingPtr = __JoltHelpers_DefaultConstruct();
        }

        /// Generated from constructor `JoltHelpers::JoltHelpers`.
        public unsafe Const_JoltHelpers(JPH.Const_JoltHelpers _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JoltHelpers._Underlying *__JoltHelpers_ConstructFromAnother(JPH.JoltHelpers._Underlying *_other);
            _UnderlyingPtr = __JoltHelpers_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltHelpers::JoltHelpers`.
        public Const_JoltHelpers(JoltHelpers _other) : this((Const_JoltHelpers)_other) {}

        /// Initialize Jolt: set Trace, RegisterDefaultAllocator, create Factory, RegisterTypes.
        /// Generated from method `JoltHelpers::Init`.
        public static void Init()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_Init();
            __JoltHelpers_Init();
        }

        /// Generated from method `JoltHelpers::Shutdown`.
        public static void Shutdown()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_Shutdown", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_Shutdown", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_Shutdown();
            __JoltHelpers_Shutdown();
        }

        /// Wrapper for the free function JPH::RayAABox (mrbind only binds named types).
        /// Returns the minimal distance along the ray, or FLT_MAX if no hit.
        /// Note: can return a negative value if the ray starts inside the box.
        /// Generated from method `JoltHelpers::RayAABox`.
        public static unsafe float RayAABox(JPH.Const_Vec3 inOrigin, JPH.Const_RayInvDirection inInvDirection, JPH.Const_Vec3 inBoundsMin, JPH.Const_Vec3 inBoundsMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_RayAABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_RayAABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltHelpers_RayAABox(JPH.Vec3._Underlying *inOrigin, JPH.Const_RayInvDirection._Underlying *inInvDirection, JPH.Vec3._Underlying *inBoundsMin, JPH.Vec3._Underlying *inBoundsMax);
            return __JoltHelpers_RayAABox(inOrigin._UnderlyingPtr, inInvDirection._UnderlyingPtr, inBoundsMin._UnderlyingPtr, inBoundsMax._UnderlyingPtr);
        }

        /// Append a WheelSettingsWV to VehicleConstraintSettings::mWheels.
        /// Generated from method `JoltHelpers::VehicleSettingsAddWheel`.
        public static unsafe void VehicleSettingsAddWheel(JPH.VehicleConstraintSettings settings, JPH.WheelSettingsWV? wheel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_VehicleSettingsAddWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_VehicleSettingsAddWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_VehicleSettingsAddWheel(JPH.VehicleConstraintSettings._Underlying *settings, JPH.WheelSettingsWV._Underlying *wheel);
            __JoltHelpers_VehicleSettingsAddWheel(settings._UnderlyingPtr, wheel is not null ? wheel._UnderlyingPtr : null);
        }

        /// Set VehicleConstraintSettings::mController to a WheeledVehicleControllerSettings.
        /// Generated from method `JoltHelpers::VehicleSettingsSetController`.
        public static unsafe void VehicleSettingsSetController(JPH.VehicleConstraintSettings settings, JPH.WheeledVehicleControllerSettings? ctrl)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_VehicleSettingsSetController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_VehicleSettingsSetController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_VehicleSettingsSetController(JPH.VehicleConstraintSettings._Underlying *settings, JPH.WheeledVehicleControllerSettings._Underlying *ctrl);
            __JoltHelpers_VehicleSettingsSetController(settings._UnderlyingPtr, ctrl is not null ? ctrl._UnderlyingPtr : null);
        }

        /// Append a VehicleAntiRollBar to VehicleConstraintSettings::mAntiRollBars.
        /// Generated from method `JoltHelpers::VehicleSettingsAddAntiRollBar`.
        public static unsafe void VehicleSettingsAddAntiRollBar(JPH.VehicleConstraintSettings settings, JPH.Const_VehicleAntiRollBar bar)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_VehicleSettingsAddAntiRollBar", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_VehicleSettingsAddAntiRollBar", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_VehicleSettingsAddAntiRollBar(JPH.VehicleConstraintSettings._Underlying *settings, JPH.Const_VehicleAntiRollBar._Underlying *bar);
            __JoltHelpers_VehicleSettingsAddAntiRollBar(settings._UnderlyingPtr, bar._UnderlyingPtr);
        }

        /// Append a VehicleDifferentialSettings to WheeledVehicleControllerSettings::mDifferentials.
        /// Generated from method `JoltHelpers::WheeledControllerSettingsAddDifferential`.
        public static unsafe void WheeledControllerSettingsAddDifferential(JPH.WheeledVehicleControllerSettings settings, JPH.Const_VehicleDifferentialSettings diff)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_WheeledControllerSettingsAddDifferential", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_WheeledControllerSettingsAddDifferential", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_WheeledControllerSettingsAddDifferential(JPH.WheeledVehicleControllerSettings._Underlying *settings, JPH.Const_VehicleDifferentialSettings._Underlying *diff);
            __JoltHelpers_WheeledControllerSettingsAddDifferential(settings._UnderlyingPtr, diff._UnderlyingPtr);
        }

        /// Cast the VehicleController on a VehicleConstraint to WheeledVehicleController.
        /// Returns nullptr if the controller is not a WheeledVehicleController.
        /// Generated from method `JoltHelpers::VehicleConstraintGetWheeledController`.
        public static unsafe JPH.WheeledVehicleController? VehicleConstraintGetWheeledController(JPH.VehicleConstraint constraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_VehicleConstraintGetWheeledController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_VehicleConstraintGetWheeledController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleController._Underlying *__JoltHelpers_VehicleConstraintGetWheeledController(JPH.VehicleConstraint._Underlying *constraint);
            var __c_ret = __JoltHelpers_VehicleConstraintGetWheeledController(constraint._UnderlyingPtr);
            return __c_ret is not null ? new JPH.WheeledVehicleController(__c_ret, is_owning: false) : null;
        }
    }

    /// Minimal helpers for Jolt global lifecycle.
    /// These are the only hand-implemented methods; their C/C# bindings are machine-generated.
    /// Generated from class `JoltHelpers`.
    /// This is the non-const half of the class.
    public class JoltHelpers : Const_JoltHelpers
    {
        internal unsafe JoltHelpers(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltHelpers() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JoltHelpers._Underlying *__JoltHelpers_DefaultConstruct();
            _UnderlyingPtr = __JoltHelpers_DefaultConstruct();
        }

        /// Generated from constructor `JoltHelpers::JoltHelpers`.
        public unsafe JoltHelpers(JPH.Const_JoltHelpers _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JoltHelpers._Underlying *__JoltHelpers_ConstructFromAnother(JPH.JoltHelpers._Underlying *_other);
            _UnderlyingPtr = __JoltHelpers_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltHelpers::JoltHelpers`.
        public JoltHelpers(JoltHelpers _other) : this((Const_JoltHelpers)_other) {}

        /// Generated from method `JoltHelpers::operator=`.
        public unsafe JPH.JoltHelpers Assign(JPH.Const_JoltHelpers _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JoltHelpers._Underlying *__JoltHelpers_AssignFromAnother(_Underlying *_this, JPH.JoltHelpers._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltHelpers_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltHelpers` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltHelpers`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltHelpers`/`Const_JoltHelpers` directly.
    public class _InOptMut_JoltHelpers
    {
        public JoltHelpers? Opt;

        public _InOptMut_JoltHelpers() {}
        public _InOptMut_JoltHelpers(JoltHelpers value) {Opt = value;}
        public static implicit operator _InOptMut_JoltHelpers(JoltHelpers value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltHelpers` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltHelpers`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltHelpers`/`Const_JoltHelpers` to pass it to the function.
    public class _InOptConst_JoltHelpers
    {
        public Const_JoltHelpers? Opt;

        public _InOptConst_JoltHelpers() {}
        public _InOptConst_JoltHelpers(Const_JoltHelpers value) {Opt = value;}
        public static implicit operator _InOptConst_JoltHelpers(Const_JoltHelpers value) {return new(value);}
    }
}
