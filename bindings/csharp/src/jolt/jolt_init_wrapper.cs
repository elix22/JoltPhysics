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

        /// Assign the height samples array (replaces existing content).
        /// Generated from method `JoltHelpers::HeightFieldSettingsSetHeightSamples`.
        public static unsafe void HeightFieldSettingsSetHeightSamples(JPH.HeightFieldShapeSettings inSettings, float? inSamples, uint inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsSetHeightSamples", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsSetHeightSamples", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_HeightFieldSettingsSetHeightSamples(JPH.HeightFieldShapeSettings._Underlying *inSettings, float *inSamples, uint inCount);
            float __deref_inSamples = inSamples.GetValueOrDefault();
            __JoltHelpers_HeightFieldSettingsSetHeightSamples(inSettings._UnderlyingPtr, inSamples.HasValue ? &__deref_inSamples : null, inCount);
        }

        /// Resize the height samples array to inCount elements, filling with inFillValue.
        /// Generated from method `JoltHelpers::HeightFieldSettingsResizeHeightSamples`.
        public static unsafe void HeightFieldSettingsResizeHeightSamples(JPH.HeightFieldShapeSettings inSettings, uint inCount, float inFillValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsResizeHeightSamples", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsResizeHeightSamples", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_HeightFieldSettingsResizeHeightSamples(JPH.HeightFieldShapeSettings._Underlying *inSettings, uint inCount, float inFillValue);
            __JoltHelpers_HeightFieldSettingsResizeHeightSamples(inSettings._UnderlyingPtr, inCount, inFillValue);
        }

        /// Set the height sample at a specific index.
        /// Generated from method `JoltHelpers::HeightFieldSettingsSetHeightSampleAt`.
        public static unsafe void HeightFieldSettingsSetHeightSampleAt(JPH.HeightFieldShapeSettings inSettings, uint inIndex, float inValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsSetHeightSampleAt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsSetHeightSampleAt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_HeightFieldSettingsSetHeightSampleAt(JPH.HeightFieldShapeSettings._Underlying *inSettings, uint inIndex, float inValue);
            __JoltHelpers_HeightFieldSettingsSetHeightSampleAt(inSettings._UnderlyingPtr, inIndex, inValue);
        }

        /// Return the number of height samples currently stored.
        /// Generated from method `JoltHelpers::HeightFieldSettingsGetHeightSamplesCount`.
        public static unsafe uint HeightFieldSettingsGetHeightSamplesCount(JPH.Const_HeightFieldShapeSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsGetHeightSamplesCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsGetHeightSamplesCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltHelpers_HeightFieldSettingsGetHeightSamplesCount(JPH.Const_HeightFieldShapeSettings._Underlying *inSettings);
            return __JoltHelpers_HeightFieldSettingsGetHeightSamplesCount(inSettings._UnderlyingPtr);
        }

        /// Return a single height sample by index.
        /// Generated from method `JoltHelpers::HeightFieldSettingsGetHeightSample`.
        public static unsafe float HeightFieldSettingsGetHeightSample(JPH.Const_HeightFieldShapeSettings inSettings, uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsGetHeightSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_HeightFieldSettingsGetHeightSample", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltHelpers_HeightFieldSettingsGetHeightSample(JPH.Const_HeightFieldShapeSettings._Underlying *inSettings, uint inIndex);
            return __JoltHelpers_HeightFieldSettingsGetHeightSample(inSettings._UnderlyingPtr, inIndex);
        }

        /// Return HeightFieldShapeConstants::cNoCollisionValue (sentinel height = no-collision).
        /// Generated from method `JoltHelpers::HeightFieldShapeConstantsNoCollisionValue`.
        public static float HeightFieldShapeConstantsNoCollisionValue()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_HeightFieldShapeConstantsNoCollisionValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_HeightFieldShapeConstantsNoCollisionValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltHelpers_HeightFieldShapeConstantsNoCollisionValue();
            return __JoltHelpers_HeightFieldShapeConstantsNoCollisionValue();
        }

        /// Return the world-space position of a HeightFieldShape sample at (inX, inY).
        /// (Wraps HeightFieldShape::GetPosition; accepts base Shape& to avoid requiring a downcast in C#.)
        /// Generated from method `JoltHelpers::HeightFieldShapeGetPosition`.
        public static unsafe JPH.Vec3 HeightFieldShapeGetPosition(JPH.Const_Shape inShape, uint inX, uint inY)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_HeightFieldShapeGetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_HeightFieldShapeGetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JoltHelpers_HeightFieldShapeGetPosition(JPH.Const_Shape._Underlying *inShape, uint inX, uint inY);
            return new(__JoltHelpers_HeightFieldShapeGetPosition(inShape._UnderlyingPtr, inX, inY), is_owning: true);
        }

        /// Return true if the sample at (inX, inY) has no collision (is a "hole").
        /// Generated from method `JoltHelpers::HeightFieldShapeIsNoCollision`.
        public static unsafe bool HeightFieldShapeIsNoCollision(JPH.Const_Shape inShape, uint inX, uint inY)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_HeightFieldShapeIsNoCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_HeightFieldShapeIsNoCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JoltHelpers_HeightFieldShapeIsNoCollision(JPH.Const_Shape._Underlying *inShape, uint inX, uint inY);
            return __JoltHelpers_HeightFieldShapeIsNoCollision(inShape._UnderlyingPtr, inX, inY) != 0;
        }

        /// Append a vertex to SoftBodySharedSettings::mVertices.
        /// Generated from method `JoltHelpers::SoftBodySettingsAddVertex`.
        public static unsafe void SoftBodySettingsAddVertex(JPH.SoftBodySharedSettings inSettings, JPH.SoftBodySharedSettings.Const_Vertex inVertex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SoftBodySettingsAddVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_SoftBodySettingsAddVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_SoftBodySettingsAddVertex(JPH.SoftBodySharedSettings._Underlying *inSettings, JPH.SoftBodySharedSettings.Const_Vertex._Underlying *inVertex);
            __JoltHelpers_SoftBodySettingsAddVertex(inSettings._UnderlyingPtr, inVertex._UnderlyingPtr);
        }

        /// Return the number of vertices in SoftBodySharedSettings::mVertices.
        /// Generated from method `JoltHelpers::SoftBodySettingsGetVertexCount`.
        public static unsafe uint SoftBodySettingsGetVertexCount(JPH.Const_SoftBodySharedSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SoftBodySettingsGetVertexCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_SoftBodySettingsGetVertexCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltHelpers_SoftBodySettingsGetVertexCount(JPH.Const_SoftBodySharedSettings._Underlying *inSettings);
            return __JoltHelpers_SoftBodySettingsGetVertexCount(inSettings._UnderlyingPtr);
        }

        /// Create a cube soft body and return an owning pointer (caller must eventually Release() it).
        /// Generated from method `JoltHelpers::SoftBodySettingsCreateCube`.
        public static unsafe JPH.SoftBodySharedSettings? SoftBodySettingsCreateCube(uint inGridSize, float inGridSpacing)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SoftBodySettingsCreateCube", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_SoftBodySettingsCreateCube", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings._Underlying *__JoltHelpers_SoftBodySettingsCreateCube(uint inGridSize, float inGridSpacing);
            var __c_ret = __JoltHelpers_SoftBodySettingsCreateCube(inGridSize, inGridSpacing);
            return __c_ret is not null ? new JPH.SoftBodySharedSettings(__c_ret, is_owning: false) : null;
        }

        /// Return the number of runtime vertices in a soft body (via SoftBodyMotionProperties).
        /// Generated from method `JoltHelpers::BodyGetSoftBodyVertexCount`.
        public static unsafe uint BodyGetSoftBodyVertexCount(JPH.Const_Body inBody)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_BodyGetSoftBodyVertexCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_BodyGetSoftBodyVertexCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltHelpers_BodyGetSoftBodyVertexCount(JPH.Const_Body._Underlying *inBody);
            return __JoltHelpers_BodyGetSoftBodyVertexCount(inBody._UnderlyingPtr);
        }

        /// Return the position of a runtime soft body vertex.
        /// Generated from method `JoltHelpers::BodyGetSoftBodyVertexPosition`.
        public static unsafe JPH.Vec3 BodyGetSoftBodyVertexPosition(JPH.Const_Body inBody, uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_BodyGetSoftBodyVertexPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_BodyGetSoftBodyVertexPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JoltHelpers_BodyGetSoftBodyVertexPosition(JPH.Const_Body._Underlying *inBody, uint inIndex);
            return new(__JoltHelpers_BodyGetSoftBodyVertexPosition(inBody._UnderlyingPtr, inIndex), is_owning: true);
        }

        /// Set the position of a runtime soft body vertex.
        /// Generated from method `JoltHelpers::BodySetSoftBodyVertexPosition`.
        public static unsafe void BodySetSoftBodyVertexPosition(JPH.Body inBody, uint inIndex, JPH.Const_Vec3 inPosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_BodySetSoftBodyVertexPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_BodySetSoftBodyVertexPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_BodySetSoftBodyVertexPosition(JPH.Body._Underlying *inBody, uint inIndex, JPH.Vec3._Underlying *inPosition);
            __JoltHelpers_BodySetSoftBodyVertexPosition(inBody._UnderlyingPtr, inIndex, inPosition._UnderlyingPtr);
        }

        /// Return the inverse mass of the body (soft or rigid) via MotionProperties.
        /// Generated from method `JoltHelpers::BodyGetInverseMass`.
        public static unsafe float BodyGetInverseMass(JPH.Const_Body inBody)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_BodyGetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_BodyGetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JoltHelpers_BodyGetInverseMass(JPH.Const_Body._Underlying *inBody);
            return __JoltHelpers_BodyGetInverseMass(inBody._UnderlyingPtr);
        }

        /// Get the number of soft-body vertices for the body with the given ID.
        /// Must be called with the physics system locked (outside of simulation step).
        /// Generated from method `JoltHelpers::PhysicsSystemGetSoftBodyVertexCount`.
        public static unsafe uint PhysicsSystemGetSoftBodyVertexCount(JPH.Const_PhysicsSystem inSystem, in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_PhysicsSystemGetSoftBodyVertexCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_PhysicsSystemGetSoftBodyVertexCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltHelpers_PhysicsSystemGetSoftBodyVertexCount(JPH.Const_PhysicsSystem._Underlying *inSystem, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JoltHelpers_PhysicsSystemGetSoftBodyVertexCount(inSystem._UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Get the position of a soft-body vertex by body ID and vertex index.
        /// Must be called with the physics system locked (outside of simulation step).
        /// Generated from method `JoltHelpers::PhysicsSystemGetSoftBodyVertexPosition`.
        public static unsafe JPH.Vec3 PhysicsSystemGetSoftBodyVertexPosition(JPH.Const_PhysicsSystem inSystem, in JPH.BodyID inBodyID, uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_PhysicsSystemGetSoftBodyVertexPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_PhysicsSystemGetSoftBodyVertexPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JoltHelpers_PhysicsSystemGetSoftBodyVertexPosition(JPH.Const_PhysicsSystem._Underlying *inSystem, JPH.BodyID *inBodyID, uint inIndex);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JoltHelpers_PhysicsSystemGetSoftBodyVertexPosition(inSystem._UnderlyingPtr, __ptr_inBodyID, inIndex), is_owning: true);
            }
        }

        /// Set the shape on a CharacterBaseSettings (mShape is a RefConst<Shape> not directly bindable).
        /// Generated from method `JoltHelpers::CharacterBaseSettingsSetShape`.
        public static unsafe void CharacterBaseSettingsSetShape(JPH.CharacterBaseSettings inSettings, JPH.Const_Shape? inShape)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_CharacterBaseSettingsSetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_CharacterBaseSettingsSetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_CharacterBaseSettingsSetShape(JPH.CharacterBaseSettings._Underlying *inSettings, JPH.Const_Shape._Underlying *inShape);
            __JoltHelpers_CharacterBaseSettingsSetShape(inSettings._UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
        }

        /// Set the skeleton on a RagdollSettings (mSkeleton is Ref<Skeleton>).
        /// Generated from method `JoltHelpers::RagdollSettingsSetSkeleton`.
        public static unsafe void RagdollSettingsSetSkeleton(JPH.RagdollSettings inSettings, JPH.Skeleton? inSkeleton)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_RagdollSettingsSetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_RagdollSettingsSetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_RagdollSettingsSetSkeleton(JPH.RagdollSettings._Underlying *inSettings, JPH.Skeleton._Underlying *inSkeleton);
            __JoltHelpers_RagdollSettingsSetSkeleton(inSettings._UnderlyingPtr, inSkeleton is not null ? inSkeleton._UnderlyingPtr : null);
        }

        /// Get the skeleton from a RagdollSettings (returns raw pointer, not Ref).
        /// Generated from method `JoltHelpers::RagdollSettingsGetSkeleton`.
        public static unsafe JPH.Skeleton? RagdollSettingsGetSkeleton(JPH.Const_RagdollSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_RagdollSettingsGetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_RagdollSettingsGetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Skeleton._Underlying *__JoltHelpers_RagdollSettingsGetSkeleton(JPH.Const_RagdollSettings._Underlying *inSettings);
            var __c_ret = __JoltHelpers_RagdollSettingsGetSkeleton(inSettings._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Skeleton(__c_ret, is_owning: false) : null;
        }

        /// Append a Part to RagdollSettings::mParts.
        /// Generated from method `JoltHelpers::RagdollSettingsAddPart`.
        public static unsafe void RagdollSettingsAddPart(JPH.RagdollSettings inSettings, JPH.RagdollSettings.Const_Part inPart)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_RagdollSettingsAddPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_RagdollSettingsAddPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_RagdollSettingsAddPart(JPH.RagdollSettings._Underlying *inSettings, JPH.RagdollSettings.Const_Part._Underlying *inPart);
            __JoltHelpers_RagdollSettingsAddPart(inSettings._UnderlyingPtr, inPart._UnderlyingPtr);
        }

        /// Return the number of parts in RagdollSettings::mParts.
        /// Generated from method `JoltHelpers::RagdollSettingsGetPartCount`.
        public static unsafe uint RagdollSettingsGetPartCount(JPH.Const_RagdollSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_RagdollSettingsGetPartCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_RagdollSettingsGetPartCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltHelpers_RagdollSettingsGetPartCount(JPH.Const_RagdollSettings._Underlying *inSettings);
            return __JoltHelpers_RagdollSettingsGetPartCount(inSettings._UnderlyingPtr);
        }

        /// Return a reference to a Part by index.
        /// Generated from method `JoltHelpers::RagdollSettingsGetPart`.
        public static unsafe JPH.RagdollSettings.Const_Part RagdollSettingsGetPart(JPH.Const_RagdollSettings inSettings, uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_RagdollSettingsGetPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_RagdollSettingsGetPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RagdollSettings.Const_Part._Underlying *__JoltHelpers_RagdollSettingsGetPart(JPH.Const_RagdollSettings._Underlying *inSettings, uint inIndex);
            return new(__JoltHelpers_RagdollSettingsGetPart(inSettings._UnderlyingPtr, inIndex), is_owning: false);
        }

        /// Add a root joint (no parent) to a Skeleton. Returns the joint index.
        /// Generated from method `JoltHelpers::SkeletonAddJoint`.
        public static unsafe uint SkeletonAddJoint(JPH.Skeleton inSkeleton, byte? inName)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SkeletonAddJoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_SkeletonAddJoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltHelpers_SkeletonAddJoint(JPH.Skeleton._Underlying *inSkeleton, byte *inName);
            byte __deref_inName = inName.GetValueOrDefault();
            return __JoltHelpers_SkeletonAddJoint(inSkeleton._UnderlyingPtr, inName.HasValue ? &__deref_inName : null);
        }

        /// Add a joint with a named parent. Returns the joint index.
        /// Generated from method `JoltHelpers::SkeletonAddJointWithParentName`.
        public static unsafe uint SkeletonAddJointWithParentName(JPH.Skeleton inSkeleton, byte? inName, byte? inParentName)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SkeletonAddJointWithParentName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_SkeletonAddJointWithParentName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltHelpers_SkeletonAddJointWithParentName(JPH.Skeleton._Underlying *inSkeleton, byte *inName, byte *inParentName);
            byte __deref_inName = inName.GetValueOrDefault();
            byte __deref_inParentName = inParentName.GetValueOrDefault();
            return __JoltHelpers_SkeletonAddJointWithParentName(inSkeleton._UnderlyingPtr, inName.HasValue ? &__deref_inName : null, inParentName.HasValue ? &__deref_inParentName : null);
        }

        /// Add a joint with a parent index. Returns the joint index.
        /// Generated from method `JoltHelpers::SkeletonAddJointWithParentIndex`.
        public static unsafe uint SkeletonAddJointWithParentIndex(JPH.Skeleton inSkeleton, byte? inName, int inParentIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SkeletonAddJointWithParentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_SkeletonAddJointWithParentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JoltHelpers_SkeletonAddJointWithParentIndex(JPH.Skeleton._Underlying *inSkeleton, byte *inName, int inParentIndex);
            byte __deref_inName = inName.GetValueOrDefault();
            return __JoltHelpers_SkeletonAddJointWithParentIndex(inSkeleton._UnderlyingPtr, inName.HasValue ? &__deref_inName : null, inParentIndex);
        }

        /// Create a ConvexHullShapeSettings from an array of Float3 points.
        /// Generated from method `JoltHelpers::ConvexHullShapeSettingsFromFloat3Array`.
        public static unsafe JPH.ConvexHullShapeSettings? ConvexHullShapeSettingsFromFloat3Array(JPH.Const_Float3? inPoints, int inNumPoints, float inMaxConvexRadius, JPH.Const_PhysicsMaterial? inMaterial)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_ConvexHullShapeSettingsFromFloat3Array", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_ConvexHullShapeSettingsFromFloat3Array", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConvexHullShapeSettings._Underlying *__JoltHelpers_ConvexHullShapeSettingsFromFloat3Array(JPH.Const_Float3._Underlying *inPoints, int inNumPoints, float inMaxConvexRadius, JPH.Const_PhysicsMaterial._Underlying *inMaterial);
            var __c_ret = __JoltHelpers_ConvexHullShapeSettingsFromFloat3Array(inPoints is not null ? inPoints._UnderlyingPtr : null, inNumPoints, inMaxConvexRadius, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            return __c_ret is not null ? new JPH.ConvexHullShapeSettings(__c_ret, is_owning: false) : null;
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

    // ---------------------------------------------------------------------------
    // CountingPhysicsStepListener — concrete PhysicsStepListener for C# tests.
    // Counts how many times OnStep was called and stores the last context values.
    // ---------------------------------------------------------------------------
    /// Generated from class `CountingPhysicsStepListener`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PhysicsStepListener`
    /// This is the const half of the class.
    public class Const_CountingPhysicsStepListener : JPH.Object<Const_CountingPhysicsStepListener>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __CountingPhysicsStepListener_Destroy(_Underlying *_this);
            __CountingPhysicsStepListener_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CountingPhysicsStepListener() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_PhysicsStepListener(Const_CountingPhysicsStepListener self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsStepListener._Underlying *__CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener(_Underlying *_this);
            JPH.Const_PhysicsStepListener ret = new(__CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_CountingPhysicsStepListener(JPH.Const_PhysicsStepListener parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener(JPH.Const_PhysicsStepListener._Underlying *_this);
            Const_CountingPhysicsStepListener ret = new(__CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public unsafe int mCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_Get_mCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_Get_mCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__CountingPhysicsStepListener_Get_mCount(_Underlying *_this);
                return *__CountingPhysicsStepListener_Get_mCount(_UnderlyingPtr);
            }
        }

        public unsafe float mLastDeltaTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_Get_mLastDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_Get_mLastDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__CountingPhysicsStepListener_Get_mLastDeltaTime(_Underlying *_this);
                return *__CountingPhysicsStepListener_Get_mLastDeltaTime(_UnderlyingPtr);
            }
        }

        public unsafe bool mLastIsFirst
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_Get_mLastIsFirst", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_Get_mLastIsFirst", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__CountingPhysicsStepListener_Get_mLastIsFirst(_Underlying *_this);
                return *__CountingPhysicsStepListener_Get_mLastIsFirst(_UnderlyingPtr);
            }
        }

        public unsafe bool mLastIsLast
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_Get_mLastIsLast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_Get_mLastIsLast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__CountingPhysicsStepListener_Get_mLastIsLast(_Underlying *_this);
                return *__CountingPhysicsStepListener_Get_mLastIsLast(_UnderlyingPtr);
            }
        }

        internal unsafe Const_CountingPhysicsStepListener(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CountingPhysicsStepListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CountingPhysicsStepListener._Underlying *__CountingPhysicsStepListener_DefaultConstruct();
            _UnderlyingPtr = __CountingPhysicsStepListener_DefaultConstruct();
        }

        /// Generated from constructor `CountingPhysicsStepListener::CountingPhysicsStepListener`.
        public unsafe Const_CountingPhysicsStepListener(JPH._ByValue_CountingPhysicsStepListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CountingPhysicsStepListener._Underlying *__CountingPhysicsStepListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CountingPhysicsStepListener._Underlying *_other);
            _UnderlyingPtr = __CountingPhysicsStepListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `CountingPhysicsStepListener::CountingPhysicsStepListener`.
        public Const_CountingPhysicsStepListener(Const_CountingPhysicsStepListener _other) : this(new _ByValue_CountingPhysicsStepListener(_other)) {}

        /// Generated from constructor `CountingPhysicsStepListener::CountingPhysicsStepListener`.
        public Const_CountingPhysicsStepListener(CountingPhysicsStepListener _other) : this((Const_CountingPhysicsStepListener)_other) {}

        /// Generated from method `CountingPhysicsStepListener::GetCount`.
        public unsafe int GetCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_GetCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_GetCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __CountingPhysicsStepListener_GetCount(_Underlying *_this);
            return __CountingPhysicsStepListener_GetCount(_UnderlyingPtr);
        }

        /// Generated from method `CountingPhysicsStepListener::GetLastDeltaTime`.
        public unsafe float GetLastDeltaTime()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_GetLastDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_GetLastDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __CountingPhysicsStepListener_GetLastDeltaTime(_Underlying *_this);
            return __CountingPhysicsStepListener_GetLastDeltaTime(_UnderlyingPtr);
        }

        /// Generated from method `CountingPhysicsStepListener::GetLastIsFirst`.
        public unsafe bool GetLastIsFirst()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_GetLastIsFirst", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_GetLastIsFirst", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __CountingPhysicsStepListener_GetLastIsFirst(_Underlying *_this);
            return __CountingPhysicsStepListener_GetLastIsFirst(_UnderlyingPtr) != 0;
        }

        /// Generated from method `CountingPhysicsStepListener::GetLastIsLast`.
        public unsafe bool GetLastIsLast()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_GetLastIsLast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_GetLastIsLast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __CountingPhysicsStepListener_GetLastIsLast(_Underlying *_this);
            return __CountingPhysicsStepListener_GetLastIsLast(_UnderlyingPtr) != 0;
        }
    }

    // ---------------------------------------------------------------------------
    // CountingPhysicsStepListener — concrete PhysicsStepListener for C# tests.
    // Counts how many times OnStep was called and stores the last context values.
    // ---------------------------------------------------------------------------
    /// Generated from class `CountingPhysicsStepListener`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PhysicsStepListener`
    /// This is the non-const half of the class.
    public class CountingPhysicsStepListener : Const_CountingPhysicsStepListener
    {
        // Upcasts:
        public static unsafe implicit operator JPH.PhysicsStepListener(CountingPhysicsStepListener self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsStepListener._Underlying *__CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener(_Underlying *_this);
            JPH.PhysicsStepListener ret = new(__CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator CountingPhysicsStepListener(JPH.PhysicsStepListener parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener(JPH.PhysicsStepListener._Underlying *_this);
            CountingPhysicsStepListener ret = new(__CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public new unsafe ref int mCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_GetMutable_mCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_GetMutable_mCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__CountingPhysicsStepListener_GetMutable_mCount(_Underlying *_this);
                return ref *__CountingPhysicsStepListener_GetMutable_mCount(_UnderlyingPtr);
            }
        }

        public new unsafe ref float mLastDeltaTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_GetMutable_mLastDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_GetMutable_mLastDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__CountingPhysicsStepListener_GetMutable_mLastDeltaTime(_Underlying *_this);
                return ref *__CountingPhysicsStepListener_GetMutable_mLastDeltaTime(_UnderlyingPtr);
            }
        }

        public new unsafe ref bool mLastIsFirst
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_GetMutable_mLastIsFirst", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_GetMutable_mLastIsFirst", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__CountingPhysicsStepListener_GetMutable_mLastIsFirst(_Underlying *_this);
                return ref *__CountingPhysicsStepListener_GetMutable_mLastIsFirst(_UnderlyingPtr);
            }
        }

        public new unsafe ref bool mLastIsLast
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_GetMutable_mLastIsLast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_GetMutable_mLastIsLast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__CountingPhysicsStepListener_GetMutable_mLastIsLast(_Underlying *_this);
                return ref *__CountingPhysicsStepListener_GetMutable_mLastIsLast(_UnderlyingPtr);
            }
        }

        internal unsafe CountingPhysicsStepListener(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CountingPhysicsStepListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CountingPhysicsStepListener._Underlying *__CountingPhysicsStepListener_DefaultConstruct();
            _UnderlyingPtr = __CountingPhysicsStepListener_DefaultConstruct();
        }

        /// Generated from constructor `CountingPhysicsStepListener::CountingPhysicsStepListener`.
        public unsafe CountingPhysicsStepListener(JPH._ByValue_CountingPhysicsStepListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CountingPhysicsStepListener._Underlying *__CountingPhysicsStepListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CountingPhysicsStepListener._Underlying *_other);
            _UnderlyingPtr = __CountingPhysicsStepListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `CountingPhysicsStepListener::CountingPhysicsStepListener`.
        public CountingPhysicsStepListener(Const_CountingPhysicsStepListener _other) : this(new _ByValue_CountingPhysicsStepListener(_other)) {}

        /// Generated from constructor `CountingPhysicsStepListener::CountingPhysicsStepListener`.
        public CountingPhysicsStepListener(CountingPhysicsStepListener _other) : this((Const_CountingPhysicsStepListener)_other) {}

        /// Generated from method `CountingPhysicsStepListener::operator=`.
        public unsafe JPH.CountingPhysicsStepListener Assign(JPH._ByValue_CountingPhysicsStepListener _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CountingPhysicsStepListener._Underlying *__CountingPhysicsStepListener_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.CountingPhysicsStepListener._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__CountingPhysicsStepListener_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `CountingPhysicsStepListener::Reset`.
        public unsafe void Reset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "CountingPhysicsStepListener_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "CountingPhysicsStepListener_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __CountingPhysicsStepListener_Reset(_Underlying *_this);
            __CountingPhysicsStepListener_Reset(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `CountingPhysicsStepListener` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `CountingPhysicsStepListener`/`Const_CountingPhysicsStepListener` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_CountingPhysicsStepListener
    {
        #pragma warning disable CS0649
        internal readonly Const_CountingPhysicsStepListener? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_CountingPhysicsStepListener() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_CountingPhysicsStepListener(Const_CountingPhysicsStepListener new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_CountingPhysicsStepListener(Const_CountingPhysicsStepListener arg) {return new(arg);}
        public _ByValue_CountingPhysicsStepListener(JPH._Moved<CountingPhysicsStepListener> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_CountingPhysicsStepListener(JPH._Moved<CountingPhysicsStepListener> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `CountingPhysicsStepListener` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CountingPhysicsStepListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CountingPhysicsStepListener`/`Const_CountingPhysicsStepListener` directly.
    public class _InOptMut_CountingPhysicsStepListener
    {
        public CountingPhysicsStepListener? Opt;

        public _InOptMut_CountingPhysicsStepListener() {}
        public _InOptMut_CountingPhysicsStepListener(CountingPhysicsStepListener value) {Opt = value;}
        public static implicit operator _InOptMut_CountingPhysicsStepListener(CountingPhysicsStepListener value) {return new(value);}
    }

    /// This is used for optional parameters of class `CountingPhysicsStepListener` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CountingPhysicsStepListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CountingPhysicsStepListener`/`Const_CountingPhysicsStepListener` to pass it to the function.
    public class _InOptConst_CountingPhysicsStepListener
    {
        public Const_CountingPhysicsStepListener? Opt;

        public _InOptConst_CountingPhysicsStepListener() {}
        public _InOptConst_CountingPhysicsStepListener(Const_CountingPhysicsStepListener value) {Opt = value;}
        public static implicit operator _InOptConst_CountingPhysicsStepListener(Const_CountingPhysicsStepListener value) {return new(value);}
    }

    // ---------------------------------------------------------------------------
    // SimpleContactEventListener — concrete ContactListener for C# tests.
    // Counts contact events and records the last added body pair.
    // ---------------------------------------------------------------------------
    /// Generated from class `SimpleContactEventListener`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ContactListener`
    /// This is the const half of the class.
    public class Const_SimpleContactEventListener : JPH.Object<Const_SimpleContactEventListener>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __SimpleContactEventListener_Destroy(_Underlying *_this);
            __SimpleContactEventListener_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SimpleContactEventListener() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_ContactListener(Const_SimpleContactEventListener self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ContactListener._Underlying *__SimpleContactEventListener_UpcastTo_JPH_ContactListener(_Underlying *_this);
            JPH.Const_ContactListener ret = new(__SimpleContactEventListener_UpcastTo_JPH_ContactListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_SimpleContactEventListener(JPH.Const_ContactListener parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener(JPH.Const_ContactListener._Underlying *_this);
            Const_SimpleContactEventListener ret = new(__SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public unsafe int mValidateCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_Get_mValidateCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_Get_mValidateCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__SimpleContactEventListener_Get_mValidateCount(_Underlying *_this);
                return *__SimpleContactEventListener_Get_mValidateCount(_UnderlyingPtr);
            }
        }

        public unsafe int mAddedCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_Get_mAddedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_Get_mAddedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__SimpleContactEventListener_Get_mAddedCount(_Underlying *_this);
                return *__SimpleContactEventListener_Get_mAddedCount(_UnderlyingPtr);
            }
        }

        public unsafe int mPersistedCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_Get_mPersistedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_Get_mPersistedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__SimpleContactEventListener_Get_mPersistedCount(_Underlying *_this);
                return *__SimpleContactEventListener_Get_mPersistedCount(_UnderlyingPtr);
            }
        }

        public unsafe int mRemovedCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_Get_mRemovedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_Get_mRemovedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__SimpleContactEventListener_Get_mRemovedCount(_Underlying *_this);
                return *__SimpleContactEventListener_Get_mRemovedCount(_UnderlyingPtr);
            }
        }

        public unsafe ref readonly JPH.BodyID mLastAddedBody1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_Get_mLastAddedBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_Get_mLastAddedBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__SimpleContactEventListener_Get_mLastAddedBody1(_Underlying *_this);
                return ref *__SimpleContactEventListener_Get_mLastAddedBody1(_UnderlyingPtr);
            }
        }

        public unsafe ref readonly JPH.BodyID mLastAddedBody2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_Get_mLastAddedBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_Get_mLastAddedBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__SimpleContactEventListener_Get_mLastAddedBody2(_Underlying *_this);
                return ref *__SimpleContactEventListener_Get_mLastAddedBody2(_UnderlyingPtr);
            }
        }

        internal unsafe Const_SimpleContactEventListener(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SimpleContactEventListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SimpleContactEventListener._Underlying *__SimpleContactEventListener_DefaultConstruct();
            _UnderlyingPtr = __SimpleContactEventListener_DefaultConstruct();
        }

        /// Generated from constructor `SimpleContactEventListener::SimpleContactEventListener`.
        public unsafe Const_SimpleContactEventListener(JPH._ByValue_SimpleContactEventListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SimpleContactEventListener._Underlying *__SimpleContactEventListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SimpleContactEventListener._Underlying *_other);
            _UnderlyingPtr = __SimpleContactEventListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `SimpleContactEventListener::SimpleContactEventListener`.
        public Const_SimpleContactEventListener(Const_SimpleContactEventListener _other) : this(new _ByValue_SimpleContactEventListener(_other)) {}

        /// Generated from constructor `SimpleContactEventListener::SimpleContactEventListener`.
        public Const_SimpleContactEventListener(SimpleContactEventListener _other) : this((Const_SimpleContactEventListener)_other) {}

        /// Generated from method `SimpleContactEventListener::GetValidateCount`.
        public unsafe int GetValidateCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetValidateCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetValidateCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __SimpleContactEventListener_GetValidateCount(_Underlying *_this);
            return __SimpleContactEventListener_GetValidateCount(_UnderlyingPtr);
        }

        /// Generated from method `SimpleContactEventListener::GetAddedCount`.
        public unsafe int GetAddedCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetAddedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetAddedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __SimpleContactEventListener_GetAddedCount(_Underlying *_this);
            return __SimpleContactEventListener_GetAddedCount(_UnderlyingPtr);
        }

        /// Generated from method `SimpleContactEventListener::GetPersistedCount`.
        public unsafe int GetPersistedCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetPersistedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetPersistedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __SimpleContactEventListener_GetPersistedCount(_Underlying *_this);
            return __SimpleContactEventListener_GetPersistedCount(_UnderlyingPtr);
        }

        /// Generated from method `SimpleContactEventListener::GetRemovedCount`.
        public unsafe int GetRemovedCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetRemovedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetRemovedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __SimpleContactEventListener_GetRemovedCount(_Underlying *_this);
            return __SimpleContactEventListener_GetRemovedCount(_UnderlyingPtr);
        }

        /// Generated from method `SimpleContactEventListener::GetLastAddedBody1`.
        public unsafe ref readonly JPH.BodyID GetLastAddedBody1()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetLastAddedBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetLastAddedBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__SimpleContactEventListener_GetLastAddedBody1(_Underlying *_this);
            return ref *__SimpleContactEventListener_GetLastAddedBody1(_UnderlyingPtr);
        }

        /// Generated from method `SimpleContactEventListener::GetLastAddedBody2`.
        public unsafe ref readonly JPH.BodyID GetLastAddedBody2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetLastAddedBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetLastAddedBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__SimpleContactEventListener_GetLastAddedBody2(_Underlying *_this);
            return ref *__SimpleContactEventListener_GetLastAddedBody2(_UnderlyingPtr);
        }
    }

    // ---------------------------------------------------------------------------
    // SimpleContactEventListener — concrete ContactListener for C# tests.
    // Counts contact events and records the last added body pair.
    // ---------------------------------------------------------------------------
    /// Generated from class `SimpleContactEventListener`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ContactListener`
    /// This is the non-const half of the class.
    public class SimpleContactEventListener : Const_SimpleContactEventListener
    {
        // Upcasts:
        public static unsafe implicit operator JPH.ContactListener(SimpleContactEventListener self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListener._Underlying *__SimpleContactEventListener_UpcastTo_JPH_ContactListener(_Underlying *_this);
            JPH.ContactListener ret = new(__SimpleContactEventListener_UpcastTo_JPH_ContactListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator SimpleContactEventListener(JPH.ContactListener parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener(JPH.ContactListener._Underlying *_this);
            SimpleContactEventListener ret = new(__SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public new unsafe ref int mValidateCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mValidateCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mValidateCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__SimpleContactEventListener_GetMutable_mValidateCount(_Underlying *_this);
                return ref *__SimpleContactEventListener_GetMutable_mValidateCount(_UnderlyingPtr);
            }
        }

        public new unsafe ref int mAddedCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mAddedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mAddedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__SimpleContactEventListener_GetMutable_mAddedCount(_Underlying *_this);
                return ref *__SimpleContactEventListener_GetMutable_mAddedCount(_UnderlyingPtr);
            }
        }

        public new unsafe ref int mPersistedCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mPersistedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mPersistedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__SimpleContactEventListener_GetMutable_mPersistedCount(_Underlying *_this);
                return ref *__SimpleContactEventListener_GetMutable_mPersistedCount(_UnderlyingPtr);
            }
        }

        public new unsafe ref int mRemovedCount
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mRemovedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mRemovedCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__SimpleContactEventListener_GetMutable_mRemovedCount(_Underlying *_this);
                return ref *__SimpleContactEventListener_GetMutable_mRemovedCount(_UnderlyingPtr);
            }
        }

        public new unsafe ref JPH.BodyID mLastAddedBody1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mLastAddedBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mLastAddedBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__SimpleContactEventListener_GetMutable_mLastAddedBody1(_Underlying *_this);
                return ref *__SimpleContactEventListener_GetMutable_mLastAddedBody1(_UnderlyingPtr);
            }
        }

        public new unsafe ref JPH.BodyID mLastAddedBody2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mLastAddedBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_GetMutable_mLastAddedBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__SimpleContactEventListener_GetMutable_mLastAddedBody2(_Underlying *_this);
                return ref *__SimpleContactEventListener_GetMutable_mLastAddedBody2(_UnderlyingPtr);
            }
        }

        internal unsafe SimpleContactEventListener(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SimpleContactEventListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SimpleContactEventListener._Underlying *__SimpleContactEventListener_DefaultConstruct();
            _UnderlyingPtr = __SimpleContactEventListener_DefaultConstruct();
        }

        /// Generated from constructor `SimpleContactEventListener::SimpleContactEventListener`.
        public unsafe SimpleContactEventListener(JPH._ByValue_SimpleContactEventListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SimpleContactEventListener._Underlying *__SimpleContactEventListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SimpleContactEventListener._Underlying *_other);
            _UnderlyingPtr = __SimpleContactEventListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `SimpleContactEventListener::SimpleContactEventListener`.
        public SimpleContactEventListener(Const_SimpleContactEventListener _other) : this(new _ByValue_SimpleContactEventListener(_other)) {}

        /// Generated from constructor `SimpleContactEventListener::SimpleContactEventListener`.
        public SimpleContactEventListener(SimpleContactEventListener _other) : this((Const_SimpleContactEventListener)_other) {}

        /// Generated from method `SimpleContactEventListener::operator=`.
        public unsafe JPH.SimpleContactEventListener Assign(JPH._ByValue_SimpleContactEventListener _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SimpleContactEventListener._Underlying *__SimpleContactEventListener_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SimpleContactEventListener._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__SimpleContactEventListener_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `SimpleContactEventListener::Reset`.
        public unsafe void Reset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __SimpleContactEventListener_Reset(_Underlying *_this);
            __SimpleContactEventListener_Reset(_UnderlyingPtr);
        }

        /// Generated from method `SimpleContactEventListener::OnContactValidate`.
        public unsafe JPH.ValidateResult OnContactValidate(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_Vec3 inBaseOffset, JPH.Const_CollideShapeResult inCollisionResult)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ValidateResult __SimpleContactEventListener_OnContactValidate(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Vec3._Underlying *inBaseOffset, JPH.Const_CollideShapeResult._Underlying *inCollisionResult);
            return __SimpleContactEventListener_OnContactValidate(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inBaseOffset._UnderlyingPtr, inCollisionResult._UnderlyingPtr);
        }

        /// Generated from method `SimpleContactEventListener::OnContactAdded`.
        public unsafe void OnContactAdded(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_ContactManifold inManifold, JPH.ContactSettings ioSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_OnContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_OnContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __SimpleContactEventListener_OnContactAdded(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Const_ContactManifold._Underlying *inManifold, JPH.ContactSettings._Underlying *ioSettings);
            __SimpleContactEventListener_OnContactAdded(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inManifold._UnderlyingPtr, ioSettings._UnderlyingPtr);
        }

        /// Generated from method `SimpleContactEventListener::OnContactPersisted`.
        public unsafe void OnContactPersisted(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_ContactManifold inManifold, JPH.ContactSettings ioSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_OnContactPersisted", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_OnContactPersisted", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __SimpleContactEventListener_OnContactPersisted(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Const_ContactManifold._Underlying *inManifold, JPH.ContactSettings._Underlying *ioSettings);
            __SimpleContactEventListener_OnContactPersisted(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inManifold._UnderlyingPtr, ioSettings._UnderlyingPtr);
        }

        /// Generated from method `SimpleContactEventListener::OnContactRemoved`.
        public unsafe void OnContactRemoved(JPH.Const_SubShapeIDPair inSubShapePair)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "SimpleContactEventListener_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "SimpleContactEventListener_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __SimpleContactEventListener_OnContactRemoved(_Underlying *_this, JPH.Const_SubShapeIDPair._Underlying *inSubShapePair);
            __SimpleContactEventListener_OnContactRemoved(_UnderlyingPtr, inSubShapePair._UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `SimpleContactEventListener` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `SimpleContactEventListener`/`Const_SimpleContactEventListener` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_SimpleContactEventListener
    {
        #pragma warning disable CS0649
        internal readonly Const_SimpleContactEventListener? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_SimpleContactEventListener() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_SimpleContactEventListener(Const_SimpleContactEventListener new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_SimpleContactEventListener(Const_SimpleContactEventListener arg) {return new(arg);}
        public _ByValue_SimpleContactEventListener(JPH._Moved<SimpleContactEventListener> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_SimpleContactEventListener(JPH._Moved<SimpleContactEventListener> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `SimpleContactEventListener` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SimpleContactEventListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SimpleContactEventListener`/`Const_SimpleContactEventListener` directly.
    public class _InOptMut_SimpleContactEventListener
    {
        public SimpleContactEventListener? Opt;

        public _InOptMut_SimpleContactEventListener() {}
        public _InOptMut_SimpleContactEventListener(SimpleContactEventListener value) {Opt = value;}
        public static implicit operator _InOptMut_SimpleContactEventListener(SimpleContactEventListener value) {return new(value);}
    }

    /// This is used for optional parameters of class `SimpleContactEventListener` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SimpleContactEventListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SimpleContactEventListener`/`Const_SimpleContactEventListener` to pass it to the function.
    public class _InOptConst_SimpleContactEventListener
    {
        public Const_SimpleContactEventListener? Opt;

        public _InOptConst_SimpleContactEventListener() {}
        public _InOptConst_SimpleContactEventListener(Const_SimpleContactEventListener value) {Opt = value;}
        public static implicit operator _InOptConst_SimpleContactEventListener(Const_SimpleContactEventListener value) {return new(value);}
    }

    // ---------------------------------------------------------------------------
    // ContactListenerTrampoline — concrete ContactListener that dispatches to
    // C# function pointers.  Set mContext and the four mXxxFn fields; leave any
    // field null to get the default (AcceptAll for Validate, no-op for the rest).
    //
    // Function pointer signatures (all __cdecl / C calling convention):
    //   OnContactValidate : int  (*)(void* ctx,
    //                                const JPH::Body* body1, const JPH::Body* body2,
    //                                const JPH::Vec3* baseOffset,
    //                                const JPH::CollideShapeResult* result)
    //                       Return value maps to JPH::ValidateResult (0 = AcceptAll, etc.)
    //   OnContactAdded    : void (*)(void* ctx,
    //                                const JPH::Body* body1, const JPH::Body* body2,
    //                                const JPH::ContactManifold* manifold,
    //                                JPH::ContactSettings* settings)
    //   OnContactPersisted: same signature as OnContactAdded
    //   OnContactRemoved  : void (*)(void* ctx, const JPH::SubShapeIDPair* pair)
    // ---------------------------------------------------------------------------
    /// Generated from class `ContactListenerTrampoline`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ContactListener`
    /// This is the const half of the class.
    public class Const_ContactListenerTrampoline : JPH.Object<Const_ContactListenerTrampoline>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __ContactListenerTrampoline_Destroy(_Underlying *_this);
            __ContactListenerTrampoline_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ContactListenerTrampoline() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_ContactListener(Const_ContactListenerTrampoline self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ContactListener._Underlying *__ContactListenerTrampoline_UpcastTo_JPH_ContactListener(_Underlying *_this);
            JPH.Const_ContactListener ret = new(__ContactListenerTrampoline_UpcastTo_JPH_ContactListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ContactListenerTrampoline(JPH.Const_ContactListener parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener(JPH.Const_ContactListener._Underlying *_this);
            Const_ContactListenerTrampoline ret = new(__ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_ContactListenerTrampoline(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ContactListenerTrampoline() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListenerTrampoline._Underlying *__ContactListenerTrampoline_DefaultConstruct();
            _UnderlyingPtr = __ContactListenerTrampoline_DefaultConstruct();
        }

        /// Generated from constructor `ContactListenerTrampoline::ContactListenerTrampoline`.
        public unsafe Const_ContactListenerTrampoline(JPH._ByValue_ContactListenerTrampoline _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListenerTrampoline._Underlying *__ContactListenerTrampoline_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.ContactListenerTrampoline._Underlying *_other);
            _UnderlyingPtr = __ContactListenerTrampoline_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `ContactListenerTrampoline::ContactListenerTrampoline`.
        public Const_ContactListenerTrampoline(Const_ContactListenerTrampoline _other) : this(new _ByValue_ContactListenerTrampoline(_other)) {}

        /// Generated from constructor `ContactListenerTrampoline::ContactListenerTrampoline`.
        public Const_ContactListenerTrampoline(ContactListenerTrampoline _other) : this((Const_ContactListenerTrampoline)_other) {}

        /// Generated from method `ContactListenerTrampoline::GetContext`.
        /// Returns a mutable pointer.
        public unsafe void *GetContext()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_GetContext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_GetContext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__ContactListenerTrampoline_GetContext(_Underlying *_this);
            return __ContactListenerTrampoline_GetContext(_UnderlyingPtr);
        }

        /// Generated from method `ContactListenerTrampoline::GetOnContactValidateFn`.
        /// Returns a mutable pointer.
        public unsafe void *GetOnContactValidateFn()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_GetOnContactValidateFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_GetOnContactValidateFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__ContactListenerTrampoline_GetOnContactValidateFn(_Underlying *_this);
            return __ContactListenerTrampoline_GetOnContactValidateFn(_UnderlyingPtr);
        }

        /// Generated from method `ContactListenerTrampoline::GetOnContactAddedFn`.
        /// Returns a mutable pointer.
        public unsafe void *GetOnContactAddedFn()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_GetOnContactAddedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_GetOnContactAddedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__ContactListenerTrampoline_GetOnContactAddedFn(_Underlying *_this);
            return __ContactListenerTrampoline_GetOnContactAddedFn(_UnderlyingPtr);
        }

        /// Generated from method `ContactListenerTrampoline::GetOnContactPersistedFn`.
        /// Returns a mutable pointer.
        public unsafe void *GetOnContactPersistedFn()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_GetOnContactPersistedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_GetOnContactPersistedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__ContactListenerTrampoline_GetOnContactPersistedFn(_Underlying *_this);
            return __ContactListenerTrampoline_GetOnContactPersistedFn(_UnderlyingPtr);
        }

        /// Generated from method `ContactListenerTrampoline::GetOnContactRemovedFn`.
        /// Returns a mutable pointer.
        public unsafe void *GetOnContactRemovedFn()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_GetOnContactRemovedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_GetOnContactRemovedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__ContactListenerTrampoline_GetOnContactRemovedFn(_Underlying *_this);
            return __ContactListenerTrampoline_GetOnContactRemovedFn(_UnderlyingPtr);
        }
    }

    // ---------------------------------------------------------------------------
    // ContactListenerTrampoline — concrete ContactListener that dispatches to
    // C# function pointers.  Set mContext and the four mXxxFn fields; leave any
    // field null to get the default (AcceptAll for Validate, no-op for the rest).
    //
    // Function pointer signatures (all __cdecl / C calling convention):
    //   OnContactValidate : int  (*)(void* ctx,
    //                                const JPH::Body* body1, const JPH::Body* body2,
    //                                const JPH::Vec3* baseOffset,
    //                                const JPH::CollideShapeResult* result)
    //                       Return value maps to JPH::ValidateResult (0 = AcceptAll, etc.)
    //   OnContactAdded    : void (*)(void* ctx,
    //                                const JPH::Body* body1, const JPH::Body* body2,
    //                                const JPH::ContactManifold* manifold,
    //                                JPH::ContactSettings* settings)
    //   OnContactPersisted: same signature as OnContactAdded
    //   OnContactRemoved  : void (*)(void* ctx, const JPH::SubShapeIDPair* pair)
    // ---------------------------------------------------------------------------
    /// Generated from class `ContactListenerTrampoline`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ContactListener`
    /// This is the non-const half of the class.
    public class ContactListenerTrampoline : Const_ContactListenerTrampoline
    {
        // Upcasts:
        public static unsafe implicit operator JPH.ContactListener(ContactListenerTrampoline self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListener._Underlying *__ContactListenerTrampoline_UpcastTo_JPH_ContactListener(_Underlying *_this);
            JPH.ContactListener ret = new(__ContactListenerTrampoline_UpcastTo_JPH_ContactListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator ContactListenerTrampoline(JPH.ContactListener parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener(JPH.ContactListener._Underlying *_this);
            ContactListenerTrampoline ret = new(__ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe ContactListenerTrampoline(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ContactListenerTrampoline() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListenerTrampoline._Underlying *__ContactListenerTrampoline_DefaultConstruct();
            _UnderlyingPtr = __ContactListenerTrampoline_DefaultConstruct();
        }

        /// Generated from constructor `ContactListenerTrampoline::ContactListenerTrampoline`.
        public unsafe ContactListenerTrampoline(JPH._ByValue_ContactListenerTrampoline _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListenerTrampoline._Underlying *__ContactListenerTrampoline_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.ContactListenerTrampoline._Underlying *_other);
            _UnderlyingPtr = __ContactListenerTrampoline_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `ContactListenerTrampoline::ContactListenerTrampoline`.
        public ContactListenerTrampoline(Const_ContactListenerTrampoline _other) : this(new _ByValue_ContactListenerTrampoline(_other)) {}

        /// Generated from constructor `ContactListenerTrampoline::ContactListenerTrampoline`.
        public ContactListenerTrampoline(ContactListenerTrampoline _other) : this((Const_ContactListenerTrampoline)_other) {}

        /// Generated from method `ContactListenerTrampoline::operator=`.
        public unsafe JPH.ContactListenerTrampoline Assign(JPH._ByValue_ContactListenerTrampoline _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListenerTrampoline._Underlying *__ContactListenerTrampoline_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.ContactListenerTrampoline._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__ContactListenerTrampoline_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `ContactListenerTrampoline::SetContext`.
        /// Parameter `v` is a mutable pointer.
        public unsafe void SetContext(void *v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_SetContext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_SetContext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __ContactListenerTrampoline_SetContext(_Underlying *_this, void *v);
            __ContactListenerTrampoline_SetContext(_UnderlyingPtr, v);
        }

        /// Generated from method `ContactListenerTrampoline::SetOnContactValidateFn`.
        /// Parameter `v` is a mutable pointer.
        public unsafe void SetOnContactValidateFn(void *v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_SetOnContactValidateFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_SetOnContactValidateFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __ContactListenerTrampoline_SetOnContactValidateFn(_Underlying *_this, void *v);
            __ContactListenerTrampoline_SetOnContactValidateFn(_UnderlyingPtr, v);
        }

        /// Generated from method `ContactListenerTrampoline::SetOnContactAddedFn`.
        /// Parameter `v` is a mutable pointer.
        public unsafe void SetOnContactAddedFn(void *v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_SetOnContactAddedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_SetOnContactAddedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __ContactListenerTrampoline_SetOnContactAddedFn(_Underlying *_this, void *v);
            __ContactListenerTrampoline_SetOnContactAddedFn(_UnderlyingPtr, v);
        }

        /// Generated from method `ContactListenerTrampoline::SetOnContactPersistedFn`.
        /// Parameter `v` is a mutable pointer.
        public unsafe void SetOnContactPersistedFn(void *v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_SetOnContactPersistedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_SetOnContactPersistedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __ContactListenerTrampoline_SetOnContactPersistedFn(_Underlying *_this, void *v);
            __ContactListenerTrampoline_SetOnContactPersistedFn(_UnderlyingPtr, v);
        }

        /// Generated from method `ContactListenerTrampoline::SetOnContactRemovedFn`.
        /// Parameter `v` is a mutable pointer.
        public unsafe void SetOnContactRemovedFn(void *v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_SetOnContactRemovedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_SetOnContactRemovedFn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __ContactListenerTrampoline_SetOnContactRemovedFn(_Underlying *_this, void *v);
            __ContactListenerTrampoline_SetOnContactRemovedFn(_UnderlyingPtr, v);
        }

        /// Generated from method `ContactListenerTrampoline::OnContactValidate`.
        public unsafe JPH.ValidateResult OnContactValidate(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_Vec3 inBaseOffset, JPH.Const_CollideShapeResult inCollisionResult)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ValidateResult __ContactListenerTrampoline_OnContactValidate(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Vec3._Underlying *inBaseOffset, JPH.Const_CollideShapeResult._Underlying *inCollisionResult);
            return __ContactListenerTrampoline_OnContactValidate(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inBaseOffset._UnderlyingPtr, inCollisionResult._UnderlyingPtr);
        }

        /// Generated from method `ContactListenerTrampoline::OnContactAdded`.
        public unsafe void OnContactAdded(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_ContactManifold inManifold, JPH.ContactSettings ioSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_OnContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_OnContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __ContactListenerTrampoline_OnContactAdded(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Const_ContactManifold._Underlying *inManifold, JPH.ContactSettings._Underlying *ioSettings);
            __ContactListenerTrampoline_OnContactAdded(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inManifold._UnderlyingPtr, ioSettings._UnderlyingPtr);
        }

        /// Generated from method `ContactListenerTrampoline::OnContactPersisted`.
        public unsafe void OnContactPersisted(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_ContactManifold inManifold, JPH.ContactSettings ioSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_OnContactPersisted", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_OnContactPersisted", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __ContactListenerTrampoline_OnContactPersisted(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Const_ContactManifold._Underlying *inManifold, JPH.ContactSettings._Underlying *ioSettings);
            __ContactListenerTrampoline_OnContactPersisted(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inManifold._UnderlyingPtr, ioSettings._UnderlyingPtr);
        }

        /// Generated from method `ContactListenerTrampoline::OnContactRemoved`.
        public unsafe void OnContactRemoved(JPH.Const_SubShapeIDPair inSubShapePair)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "ContactListenerTrampoline_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "ContactListenerTrampoline_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __ContactListenerTrampoline_OnContactRemoved(_Underlying *_this, JPH.Const_SubShapeIDPair._Underlying *inSubShapePair);
            __ContactListenerTrampoline_OnContactRemoved(_UnderlyingPtr, inSubShapePair._UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `ContactListenerTrampoline` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `ContactListenerTrampoline`/`Const_ContactListenerTrampoline` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_ContactListenerTrampoline
    {
        #pragma warning disable CS0649
        internal readonly Const_ContactListenerTrampoline? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_ContactListenerTrampoline() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_ContactListenerTrampoline(Const_ContactListenerTrampoline new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_ContactListenerTrampoline(Const_ContactListenerTrampoline arg) {return new(arg);}
        public _ByValue_ContactListenerTrampoline(JPH._Moved<ContactListenerTrampoline> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_ContactListenerTrampoline(JPH._Moved<ContactListenerTrampoline> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `ContactListenerTrampoline` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ContactListenerTrampoline`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ContactListenerTrampoline`/`Const_ContactListenerTrampoline` directly.
    public class _InOptMut_ContactListenerTrampoline
    {
        public ContactListenerTrampoline? Opt;

        public _InOptMut_ContactListenerTrampoline() {}
        public _InOptMut_ContactListenerTrampoline(ContactListenerTrampoline value) {Opt = value;}
        public static implicit operator _InOptMut_ContactListenerTrampoline(ContactListenerTrampoline value) {return new(value);}
    }

    /// This is used for optional parameters of class `ContactListenerTrampoline` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ContactListenerTrampoline`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ContactListenerTrampoline`/`Const_ContactListenerTrampoline` to pass it to the function.
    public class _InOptConst_ContactListenerTrampoline
    {
        public Const_ContactListenerTrampoline? Opt;

        public _InOptConst_ContactListenerTrampoline() {}
        public _InOptConst_ContactListenerTrampoline(Const_ContactListenerTrampoline value) {Opt = value;}
        public static implicit operator _InOptConst_ContactListenerTrampoline(Const_ContactListenerTrampoline value) {return new(value);}
    }

    // ---------------------------------------------------------------------------
    // EstimateResponseContactListener — concrete ContactListener that runs
    // EstimateCollisionResponse in OnContactAdded and stores the result.
    // ---------------------------------------------------------------------------
    /// Generated from class `EstimateResponseContactListener`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ContactListener`
    /// This is the const half of the class.
    public class Const_EstimateResponseContactListener : JPH.Object<Const_EstimateResponseContactListener>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __EstimateResponseContactListener_Destroy(_Underlying *_this);
            __EstimateResponseContactListener_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_EstimateResponseContactListener() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_ContactListener(Const_EstimateResponseContactListener self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ContactListener._Underlying *__EstimateResponseContactListener_UpcastTo_JPH_ContactListener(_Underlying *_this);
            JPH.Const_ContactListener ret = new(__EstimateResponseContactListener_UpcastTo_JPH_ContactListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_EstimateResponseContactListener(JPH.Const_ContactListener parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener(JPH.Const_ContactListener._Underlying *_this);
            Const_EstimateResponseContactListener ret = new(__EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public unsafe bool mWasCalled
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_Get_mWasCalled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_Get_mWasCalled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__EstimateResponseContactListener_Get_mWasCalled(_Underlying *_this);
                return *__EstimateResponseContactListener_Get_mWasCalled(_UnderlyingPtr);
            }
        }

        public unsafe JPH.Const_Vec3 mLinearVelocity1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_Get_mLinearVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_Get_mLinearVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__EstimateResponseContactListener_Get_mLinearVelocity1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__EstimateResponseContactListener_Get_mLinearVelocity1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mAngularVelocity1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_Get_mAngularVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_Get_mAngularVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__EstimateResponseContactListener_Get_mAngularVelocity1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__EstimateResponseContactListener_Get_mAngularVelocity1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mLinearVelocity2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_Get_mLinearVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_Get_mLinearVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__EstimateResponseContactListener_Get_mLinearVelocity2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__EstimateResponseContactListener_Get_mLinearVelocity2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mAngularVelocity2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_Get_mAngularVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_Get_mAngularVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__EstimateResponseContactListener_Get_mAngularVelocity2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__EstimateResponseContactListener_Get_mAngularVelocity2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_EstimateResponseContactListener(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_EstimateResponseContactListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EstimateResponseContactListener._Underlying *__EstimateResponseContactListener_DefaultConstruct();
            _UnderlyingPtr = __EstimateResponseContactListener_DefaultConstruct();
        }

        /// Generated from constructor `EstimateResponseContactListener::EstimateResponseContactListener`.
        public unsafe Const_EstimateResponseContactListener(JPH._ByValue_EstimateResponseContactListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EstimateResponseContactListener._Underlying *__EstimateResponseContactListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.EstimateResponseContactListener._Underlying *_other);
            _UnderlyingPtr = __EstimateResponseContactListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `EstimateResponseContactListener::EstimateResponseContactListener`.
        public Const_EstimateResponseContactListener(Const_EstimateResponseContactListener _other) : this(new _ByValue_EstimateResponseContactListener(_other)) {}

        /// Generated from constructor `EstimateResponseContactListener::EstimateResponseContactListener`.
        public Const_EstimateResponseContactListener(EstimateResponseContactListener _other) : this((Const_EstimateResponseContactListener)_other) {}

        /// Generated from method `EstimateResponseContactListener::WasCalled`.
        public unsafe bool WasCalled()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_WasCalled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_WasCalled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __EstimateResponseContactListener_WasCalled(_Underlying *_this);
            return __EstimateResponseContactListener_WasCalled(_UnderlyingPtr) != 0;
        }

        /// Generated from method `EstimateResponseContactListener::GetLinearVelocity1`.
        public unsafe JPH.Const_Vec3 GetLinearVelocity1()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_GetLinearVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_GetLinearVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Vec3._Underlying *__EstimateResponseContactListener_GetLinearVelocity1(_Underlying *_this);
            return new(__EstimateResponseContactListener_GetLinearVelocity1(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `EstimateResponseContactListener::GetAngularVelocity1`.
        public unsafe JPH.Const_Vec3 GetAngularVelocity1()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_GetAngularVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_GetAngularVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Vec3._Underlying *__EstimateResponseContactListener_GetAngularVelocity1(_Underlying *_this);
            return new(__EstimateResponseContactListener_GetAngularVelocity1(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `EstimateResponseContactListener::GetLinearVelocity2`.
        public unsafe JPH.Const_Vec3 GetLinearVelocity2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_GetLinearVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_GetLinearVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Vec3._Underlying *__EstimateResponseContactListener_GetLinearVelocity2(_Underlying *_this);
            return new(__EstimateResponseContactListener_GetLinearVelocity2(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `EstimateResponseContactListener::GetAngularVelocity2`.
        public unsafe JPH.Const_Vec3 GetAngularVelocity2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_GetAngularVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_GetAngularVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Vec3._Underlying *__EstimateResponseContactListener_GetAngularVelocity2(_Underlying *_this);
            return new(__EstimateResponseContactListener_GetAngularVelocity2(_UnderlyingPtr), is_owning: false);
        }
    }

    // ---------------------------------------------------------------------------
    // EstimateResponseContactListener — concrete ContactListener that runs
    // EstimateCollisionResponse in OnContactAdded and stores the result.
    // ---------------------------------------------------------------------------
    /// Generated from class `EstimateResponseContactListener`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ContactListener`
    /// This is the non-const half of the class.
    public class EstimateResponseContactListener : Const_EstimateResponseContactListener
    {
        // Upcasts:
        public static unsafe implicit operator JPH.ContactListener(EstimateResponseContactListener self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_UpcastTo_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListener._Underlying *__EstimateResponseContactListener_UpcastTo_JPH_ContactListener(_Underlying *_this);
            JPH.ContactListener ret = new(__EstimateResponseContactListener_UpcastTo_JPH_ContactListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator EstimateResponseContactListener(JPH.ContactListener parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener(JPH.ContactListener._Underlying *_this);
            EstimateResponseContactListener ret = new(__EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public new unsafe ref bool mWasCalled
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mWasCalled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mWasCalled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__EstimateResponseContactListener_GetMutable_mWasCalled(_Underlying *_this);
                return ref *__EstimateResponseContactListener_GetMutable_mWasCalled(_UnderlyingPtr);
            }
        }

        public new unsafe JPH.Vec3 mLinearVelocity1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mLinearVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mLinearVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__EstimateResponseContactListener_GetMutable_mLinearVelocity1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__EstimateResponseContactListener_GetMutable_mLinearVelocity1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mAngularVelocity1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mAngularVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mAngularVelocity1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__EstimateResponseContactListener_GetMutable_mAngularVelocity1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__EstimateResponseContactListener_GetMutable_mAngularVelocity1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mLinearVelocity2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mLinearVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mLinearVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__EstimateResponseContactListener_GetMutable_mLinearVelocity2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__EstimateResponseContactListener_GetMutable_mLinearVelocity2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mAngularVelocity2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mAngularVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_GetMutable_mAngularVelocity2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__EstimateResponseContactListener_GetMutable_mAngularVelocity2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__EstimateResponseContactListener_GetMutable_mAngularVelocity2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe EstimateResponseContactListener(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe EstimateResponseContactListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EstimateResponseContactListener._Underlying *__EstimateResponseContactListener_DefaultConstruct();
            _UnderlyingPtr = __EstimateResponseContactListener_DefaultConstruct();
        }

        /// Generated from constructor `EstimateResponseContactListener::EstimateResponseContactListener`.
        public unsafe EstimateResponseContactListener(JPH._ByValue_EstimateResponseContactListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EstimateResponseContactListener._Underlying *__EstimateResponseContactListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.EstimateResponseContactListener._Underlying *_other);
            _UnderlyingPtr = __EstimateResponseContactListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `EstimateResponseContactListener::EstimateResponseContactListener`.
        public EstimateResponseContactListener(Const_EstimateResponseContactListener _other) : this(new _ByValue_EstimateResponseContactListener(_other)) {}

        /// Generated from constructor `EstimateResponseContactListener::EstimateResponseContactListener`.
        public EstimateResponseContactListener(EstimateResponseContactListener _other) : this((Const_EstimateResponseContactListener)_other) {}

        /// Generated from method `EstimateResponseContactListener::operator=`.
        public unsafe JPH.EstimateResponseContactListener Assign(JPH._ByValue_EstimateResponseContactListener _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EstimateResponseContactListener._Underlying *__EstimateResponseContactListener_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.EstimateResponseContactListener._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__EstimateResponseContactListener_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `EstimateResponseContactListener::Reset`.
        public unsafe void Reset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __EstimateResponseContactListener_Reset(_Underlying *_this);
            __EstimateResponseContactListener_Reset(_UnderlyingPtr);
        }

        /// Generated from method `EstimateResponseContactListener::OnContactAdded`.
        public unsafe void OnContactAdded(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_ContactManifold inManifold, JPH.ContactSettings ioSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_OnContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_OnContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __EstimateResponseContactListener_OnContactAdded(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Const_ContactManifold._Underlying *inManifold, JPH.ContactSettings._Underlying *ioSettings);
            __EstimateResponseContactListener_OnContactAdded(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inManifold._UnderlyingPtr, ioSettings._UnderlyingPtr);
        }

        /// Called after detecting a collision between a body pair, but before calling OnContactAdded and before adding the contact constraint.
        /// If the function rejects the contact, the contact will not be processed by the simulation.
        /// This is a rather expensive time to reject a contact point since a lot of the collision detection has happened already, make sure you
        /// filter out the majority of undesired body pairs through the ObjectLayerPairFilter that is registered on the PhysicsSystem.
        ///
        /// This function may not be called again the next update if a contact persists and no new contact pairs between sub shapes are found.
        ///
        /// Note that this callback is called when all bodies are locked, so don't use any locking functions! See detailed class description of ContactListener.
        ///
        /// Body 1 will have a motion type that is larger or equal than body 2's motion type (order from large to small: dynamic -> kinematic -> static). When motion types are equal, they are ordered by BodyID.
        ///
        /// The collision result (inCollisionResult) is reported relative to inBaseOffset.
        /// Generated from method `EstimateResponseContactListener::OnContactValidate`.
        public unsafe JPH.ValidateResult OnContactValidate(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_Vec3 inBaseOffset, JPH.Const_CollideShapeResult inCollisionResult)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ValidateResult __EstimateResponseContactListener_OnContactValidate(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Vec3._Underlying *inBaseOffset, JPH.Const_CollideShapeResult._Underlying *inCollisionResult);
            return __EstimateResponseContactListener_OnContactValidate(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inBaseOffset._UnderlyingPtr, inCollisionResult._UnderlyingPtr);
        }

        /// Called whenever a contact is detected that was also detected last update.
        ///
        /// Note that this callback is called when all bodies are locked, so don't use any locking functions! See detailed class description of ContactListener.
        ///
        /// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
        ///
        /// If the structure of the shape of a body changes between simulation steps (e.g. by adding/removing a child shape of a compound shape),
        /// it is possible that the same sub shape ID used to identify the removed child shape is now reused for a different child shape. The physics
        /// system cannot detect this, so may send a 'contact persisted' callback even though the contact is now on a different child shape. You can
        /// detect this by keeping the old shape (before adding/removing a part) around until the next PhysicsSystem::Update (when the OnContactPersisted
        /// callbacks are triggered) and resolving the sub shape ID against both the old and new shape to see if they still refer to the same child shape.
        /// Generated from method `EstimateResponseContactListener::OnContactPersisted`.
        public unsafe void OnContactPersisted(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_ContactManifold inManifold, JPH.ContactSettings ioSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_OnContactPersisted", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_OnContactPersisted", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __EstimateResponseContactListener_OnContactPersisted(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Const_ContactManifold._Underlying *inManifold, JPH.ContactSettings._Underlying *ioSettings);
            __EstimateResponseContactListener_OnContactPersisted(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inManifold._UnderlyingPtr, ioSettings._UnderlyingPtr);
        }

        /// Called whenever a contact was detected last update but is not detected anymore.
        ///
        /// You cannot access the bodies at the time of this callback because:
        /// - All bodies are locked at the time of this callback.
        /// - Some properties of the bodies are being modified from another thread at the same time.
        /// - The body may have been removed and destroyed (you'll receive an OnContactRemoved callback in the PhysicsSystem::Update after the body has been removed).
        ///
        /// Cache what you need in the OnContactAdded and OnContactPersisted callbacks and store it in a separate structure to use during this callback.
        /// Alternatively, you could just record that the contact was removed and process it after PhysicsSystem::Update.
        ///
        /// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
        ///
        /// The sub shape IDs were created in the previous simulation step, so if the structure of a shape changes (e.g. by adding/removing a child shape of a compound shape),
        /// the sub shape ID may not be valid / may not point to the same sub shape anymore.
        /// If you want to know if this is the last contact between the two bodies, use PhysicsSystem::WereBodiesInContact.
        /// Generated from method `EstimateResponseContactListener::OnContactRemoved`.
        public unsafe void OnContactRemoved(JPH.Const_SubShapeIDPair inSubShapePair)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "EstimateResponseContactListener_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "EstimateResponseContactListener_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __EstimateResponseContactListener_OnContactRemoved(_Underlying *_this, JPH.Const_SubShapeIDPair._Underlying *inSubShapePair);
            __EstimateResponseContactListener_OnContactRemoved(_UnderlyingPtr, inSubShapePair._UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `EstimateResponseContactListener` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `EstimateResponseContactListener`/`Const_EstimateResponseContactListener` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_EstimateResponseContactListener
    {
        #pragma warning disable CS0649
        internal readonly Const_EstimateResponseContactListener? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_EstimateResponseContactListener() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_EstimateResponseContactListener(Const_EstimateResponseContactListener new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_EstimateResponseContactListener(Const_EstimateResponseContactListener arg) {return new(arg);}
        public _ByValue_EstimateResponseContactListener(JPH._Moved<EstimateResponseContactListener> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_EstimateResponseContactListener(JPH._Moved<EstimateResponseContactListener> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `EstimateResponseContactListener` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_EstimateResponseContactListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `EstimateResponseContactListener`/`Const_EstimateResponseContactListener` directly.
    public class _InOptMut_EstimateResponseContactListener
    {
        public EstimateResponseContactListener? Opt;

        public _InOptMut_EstimateResponseContactListener() {}
        public _InOptMut_EstimateResponseContactListener(EstimateResponseContactListener value) {Opt = value;}
        public static implicit operator _InOptMut_EstimateResponseContactListener(EstimateResponseContactListener value) {return new(value);}
    }

    /// This is used for optional parameters of class `EstimateResponseContactListener` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_EstimateResponseContactListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `EstimateResponseContactListener`/`Const_EstimateResponseContactListener` to pass it to the function.
    public class _InOptConst_EstimateResponseContactListener
    {
        public Const_EstimateResponseContactListener? Opt;

        public _InOptConst_EstimateResponseContactListener() {}
        public _InOptConst_EstimateResponseContactListener(Const_EstimateResponseContactListener value) {Opt = value;}
        public static implicit operator _InOptConst_EstimateResponseContactListener(Const_EstimateResponseContactListener value) {return new(value);}
    }

    /// Plain record of a single DrawLine call captured by RecordingDebugRenderer.
    /// Generated from class `DebugLineRecord`.
    /// This is the const half of the class.
    public class Const_DebugLineRecord : JPH.Object<Const_DebugLineRecord>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __DebugLineRecord_Destroy(_Underlying *_this);
            __DebugLineRecord_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_DebugLineRecord() {Dispose(false);}

        public unsafe JPH.Const_Vec3 mFrom
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_Get_mFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_Get_mFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__DebugLineRecord_Get_mFrom(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__DebugLineRecord_Get_mFrom(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mTo
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_Get_mTo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_Get_mTo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__DebugLineRecord_Get_mTo(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__DebugLineRecord_Get_mTo(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Color mColor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_Get_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_Get_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__DebugLineRecord_Get_mColor(_Underlying *_this);
                JPH.Const_Color __ret;
                __ret = new(__DebugLineRecord_Get_mColor(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_DebugLineRecord(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_DebugLineRecord() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugLineRecord._Underlying *__DebugLineRecord_DefaultConstruct();
            _UnderlyingPtr = __DebugLineRecord_DefaultConstruct();
        }

        /// Constructs `DebugLineRecord` elementwise.
        public unsafe Const_DebugLineRecord(JPH.Const_Vec3 mFrom, JPH.Const_Vec3 mTo, JPH.Const_Color mColor) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugLineRecord._Underlying *__DebugLineRecord_ConstructFrom(JPH.Vec3._Underlying *mFrom, JPH.Vec3._Underlying *mTo, JPH.Color._Underlying *mColor);
            _UnderlyingPtr = __DebugLineRecord_ConstructFrom(mFrom._UnderlyingPtr, mTo._UnderlyingPtr, mColor._UnderlyingPtr);
            _KeepAlive(mFrom);
            _KeepAlive(mTo);
            _KeepAlive(mColor);
        }

        /// Generated from constructor `DebugLineRecord::DebugLineRecord`.
        public unsafe Const_DebugLineRecord(JPH.Const_DebugLineRecord _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugLineRecord._Underlying *__DebugLineRecord_ConstructFromAnother(JPH.DebugLineRecord._Underlying *_other);
            _UnderlyingPtr = __DebugLineRecord_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `DebugLineRecord::DebugLineRecord`.
        public Const_DebugLineRecord(DebugLineRecord _other) : this((Const_DebugLineRecord)_other) {}
    }

    /// Plain record of a single DrawLine call captured by RecordingDebugRenderer.
    /// Generated from class `DebugLineRecord`.
    /// This is the non-const half of the class.
    public class DebugLineRecord : Const_DebugLineRecord
    {
        public new unsafe JPH.Vec3 mFrom
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_GetMutable_mFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_GetMutable_mFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__DebugLineRecord_GetMutable_mFrom(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__DebugLineRecord_GetMutable_mFrom(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mTo
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_GetMutable_mTo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_GetMutable_mTo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__DebugLineRecord_GetMutable_mTo(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__DebugLineRecord_GetMutable_mTo(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Color mColor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_GetMutable_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_GetMutable_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Color._Underlying *__DebugLineRecord_GetMutable_mColor(_Underlying *_this);
                JPH.Color __ret;
                __ret = new(__DebugLineRecord_GetMutable_mColor(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe DebugLineRecord(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe DebugLineRecord() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugLineRecord._Underlying *__DebugLineRecord_DefaultConstruct();
            _UnderlyingPtr = __DebugLineRecord_DefaultConstruct();
        }

        /// Constructs `DebugLineRecord` elementwise.
        public unsafe DebugLineRecord(JPH.Const_Vec3 mFrom, JPH.Const_Vec3 mTo, JPH.Const_Color mColor) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugLineRecord._Underlying *__DebugLineRecord_ConstructFrom(JPH.Vec3._Underlying *mFrom, JPH.Vec3._Underlying *mTo, JPH.Color._Underlying *mColor);
            _UnderlyingPtr = __DebugLineRecord_ConstructFrom(mFrom._UnderlyingPtr, mTo._UnderlyingPtr, mColor._UnderlyingPtr);
            _KeepAlive(mFrom);
            _KeepAlive(mTo);
            _KeepAlive(mColor);
        }

        /// Generated from constructor `DebugLineRecord::DebugLineRecord`.
        public unsafe DebugLineRecord(JPH.Const_DebugLineRecord _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugLineRecord._Underlying *__DebugLineRecord_ConstructFromAnother(JPH.DebugLineRecord._Underlying *_other);
            _UnderlyingPtr = __DebugLineRecord_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `DebugLineRecord::DebugLineRecord`.
        public DebugLineRecord(DebugLineRecord _other) : this((Const_DebugLineRecord)_other) {}

        /// Generated from method `DebugLineRecord::operator=`.
        public unsafe JPH.DebugLineRecord Assign(JPH.Const_DebugLineRecord _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugLineRecord_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugLineRecord_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugLineRecord._Underlying *__DebugLineRecord_AssignFromAnother(_Underlying *_this, JPH.DebugLineRecord._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__DebugLineRecord_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `DebugLineRecord` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_DebugLineRecord`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DebugLineRecord`/`Const_DebugLineRecord` directly.
    public class _InOptMut_DebugLineRecord
    {
        public DebugLineRecord? Opt;

        public _InOptMut_DebugLineRecord() {}
        public _InOptMut_DebugLineRecord(DebugLineRecord value) {Opt = value;}
        public static implicit operator _InOptMut_DebugLineRecord(DebugLineRecord value) {return new(value);}
    }

    /// This is used for optional parameters of class `DebugLineRecord` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_DebugLineRecord`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DebugLineRecord`/`Const_DebugLineRecord` to pass it to the function.
    public class _InOptConst_DebugLineRecord
    {
        public Const_DebugLineRecord? Opt;

        public _InOptConst_DebugLineRecord() {}
        public _InOptConst_DebugLineRecord(Const_DebugLineRecord value) {Opt = value;}
        public static implicit operator _InOptConst_DebugLineRecord(Const_DebugLineRecord value) {return new(value);}
    }

    /// Plain record of a single DrawTriangle call captured by RecordingDebugRenderer.
    /// Generated from class `DebugTriangleRecord`.
    /// This is the const half of the class.
    public class Const_DebugTriangleRecord : JPH.Object<Const_DebugTriangleRecord>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __DebugTriangleRecord_Destroy(_Underlying *_this);
            __DebugTriangleRecord_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_DebugTriangleRecord() {Dispose(false);}

        public unsafe JPH.Const_Vec3 mv1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_Get_mV1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_Get_mV1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__DebugTriangleRecord_Get_mV1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__DebugTriangleRecord_Get_mV1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mv2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_Get_mV2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_Get_mV2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__DebugTriangleRecord_Get_mV2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__DebugTriangleRecord_Get_mV2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mv3
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_Get_mV3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_Get_mV3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__DebugTriangleRecord_Get_mV3(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__DebugTriangleRecord_Get_mV3(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Color mColor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_Get_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_Get_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__DebugTriangleRecord_Get_mColor(_Underlying *_this);
                JPH.Const_Color __ret;
                __ret = new(__DebugTriangleRecord_Get_mColor(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_DebugTriangleRecord(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_DebugTriangleRecord() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugTriangleRecord._Underlying *__DebugTriangleRecord_DefaultConstruct();
            _UnderlyingPtr = __DebugTriangleRecord_DefaultConstruct();
        }

        /// Constructs `DebugTriangleRecord` elementwise.
        public unsafe Const_DebugTriangleRecord(JPH.Const_Vec3 mV1, JPH.Const_Vec3 mV2, JPH.Const_Vec3 mV3, JPH.Const_Color mColor) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugTriangleRecord._Underlying *__DebugTriangleRecord_ConstructFrom(JPH.Vec3._Underlying *mV1, JPH.Vec3._Underlying *mV2, JPH.Vec3._Underlying *mV3, JPH.Color._Underlying *mColor);
            _UnderlyingPtr = __DebugTriangleRecord_ConstructFrom(mV1._UnderlyingPtr, mV2._UnderlyingPtr, mV3._UnderlyingPtr, mColor._UnderlyingPtr);
            _KeepAlive(mV1);
            _KeepAlive(mV2);
            _KeepAlive(mV3);
            _KeepAlive(mColor);
        }

        /// Generated from constructor `DebugTriangleRecord::DebugTriangleRecord`.
        public unsafe Const_DebugTriangleRecord(JPH.Const_DebugTriangleRecord _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugTriangleRecord._Underlying *__DebugTriangleRecord_ConstructFromAnother(JPH.DebugTriangleRecord._Underlying *_other);
            _UnderlyingPtr = __DebugTriangleRecord_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `DebugTriangleRecord::DebugTriangleRecord`.
        public Const_DebugTriangleRecord(DebugTriangleRecord _other) : this((Const_DebugTriangleRecord)_other) {}
    }

    /// Plain record of a single DrawTriangle call captured by RecordingDebugRenderer.
    /// Generated from class `DebugTriangleRecord`.
    /// This is the non-const half of the class.
    public class DebugTriangleRecord : Const_DebugTriangleRecord
    {
        public new unsafe JPH.Vec3 mv1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_GetMutable_mV1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_GetMutable_mV1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__DebugTriangleRecord_GetMutable_mV1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__DebugTriangleRecord_GetMutable_mV1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mv2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_GetMutable_mV2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_GetMutable_mV2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__DebugTriangleRecord_GetMutable_mV2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__DebugTriangleRecord_GetMutable_mV2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mv3
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_GetMutable_mV3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_GetMutable_mV3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__DebugTriangleRecord_GetMutable_mV3(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__DebugTriangleRecord_GetMutable_mV3(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Color mColor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_GetMutable_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_GetMutable_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Color._Underlying *__DebugTriangleRecord_GetMutable_mColor(_Underlying *_this);
                JPH.Color __ret;
                __ret = new(__DebugTriangleRecord_GetMutable_mColor(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe DebugTriangleRecord(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe DebugTriangleRecord() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugTriangleRecord._Underlying *__DebugTriangleRecord_DefaultConstruct();
            _UnderlyingPtr = __DebugTriangleRecord_DefaultConstruct();
        }

        /// Constructs `DebugTriangleRecord` elementwise.
        public unsafe DebugTriangleRecord(JPH.Const_Vec3 mV1, JPH.Const_Vec3 mV2, JPH.Const_Vec3 mV3, JPH.Const_Color mColor) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugTriangleRecord._Underlying *__DebugTriangleRecord_ConstructFrom(JPH.Vec3._Underlying *mV1, JPH.Vec3._Underlying *mV2, JPH.Vec3._Underlying *mV3, JPH.Color._Underlying *mColor);
            _UnderlyingPtr = __DebugTriangleRecord_ConstructFrom(mV1._UnderlyingPtr, mV2._UnderlyingPtr, mV3._UnderlyingPtr, mColor._UnderlyingPtr);
            _KeepAlive(mV1);
            _KeepAlive(mV2);
            _KeepAlive(mV3);
            _KeepAlive(mColor);
        }

        /// Generated from constructor `DebugTriangleRecord::DebugTriangleRecord`.
        public unsafe DebugTriangleRecord(JPH.Const_DebugTriangleRecord _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugTriangleRecord._Underlying *__DebugTriangleRecord_ConstructFromAnother(JPH.DebugTriangleRecord._Underlying *_other);
            _UnderlyingPtr = __DebugTriangleRecord_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `DebugTriangleRecord::DebugTriangleRecord`.
        public DebugTriangleRecord(DebugTriangleRecord _other) : this((Const_DebugTriangleRecord)_other) {}

        /// Generated from method `DebugTriangleRecord::operator=`.
        public unsafe JPH.DebugTriangleRecord Assign(JPH.Const_DebugTriangleRecord _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "DebugTriangleRecord_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "DebugTriangleRecord_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugTriangleRecord._Underlying *__DebugTriangleRecord_AssignFromAnother(_Underlying *_this, JPH.DebugTriangleRecord._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__DebugTriangleRecord_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `DebugTriangleRecord` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_DebugTriangleRecord`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DebugTriangleRecord`/`Const_DebugTriangleRecord` directly.
    public class _InOptMut_DebugTriangleRecord
    {
        public DebugTriangleRecord? Opt;

        public _InOptMut_DebugTriangleRecord() {}
        public _InOptMut_DebugTriangleRecord(DebugTriangleRecord value) {Opt = value;}
        public static implicit operator _InOptMut_DebugTriangleRecord(DebugTriangleRecord value) {return new(value);}
    }

    /// This is used for optional parameters of class `DebugTriangleRecord` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_DebugTriangleRecord`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DebugTriangleRecord`/`Const_DebugTriangleRecord` to pass it to the function.
    public class _InOptConst_DebugTriangleRecord
    {
        public Const_DebugTriangleRecord? Opt;

        public _InOptConst_DebugTriangleRecord() {}
        public _InOptConst_DebugTriangleRecord(Const_DebugTriangleRecord value) {Opt = value;}
        public static implicit operator _InOptConst_DebugTriangleRecord(Const_DebugTriangleRecord value) {return new(value);}
    }

    /// Concrete DebugRenderer that records all DrawLine / DrawTriangle calls so
    /// C# can inspect them.  Inherits DebugRendererSimple to avoid re-implementing
    /// CreateTriangleBatch and DrawGeometry.
    ///
    /// Lifecycle: only one instance may exist at a time (enforced by
    /// DebugRenderer's singleton assert).  Call Clear() between frames.
    /// Generated from class `RecordingDebugRenderer`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DebugRendererSimple`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    ///     `JPH::DebugRenderer`
    /// This is the const half of the class.
    public class Const_RecordingDebugRenderer : JPH.Object<Const_RecordingDebugRenderer>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_Destroy(_Underlying *_this);
            __RecordingDebugRenderer_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RecordingDebugRenderer() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_RecordingDebugRenderer self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__RecordingDebugRenderer_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__RecordingDebugRenderer_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_DebugRenderer(Const_RecordingDebugRenderer self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_DebugRenderer._Underlying *__RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer(_Underlying *_this);
            JPH.Const_DebugRenderer ret = new(__RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_DebugRendererSimple(Const_RecordingDebugRenderer self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_DebugRendererSimple._Underlying *__RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple(_Underlying *_this);
            JPH.Const_DebugRendererSimple ret = new(__RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_RecordingDebugRenderer(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_RecordingDebugRenderer ret = new(__RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_RecordingDebugRenderer(JPH.Const_DebugRenderer parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer(JPH.Const_DebugRenderer._Underlying *_this);
            Const_RecordingDebugRenderer ret = new(__RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_RecordingDebugRenderer(JPH.Const_DebugRendererSimple parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple(JPH.Const_DebugRendererSimple._Underlying *_this);
            Const_RecordingDebugRenderer ret = new(__RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// Singleton instance
        public static unsafe JPH.DebugRenderer? SInstance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_Get_sInstance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_Get_sInstance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer._Underlying **__RecordingDebugRenderer_Get_sInstance();
                var ptr = __RecordingDebugRenderer_Get_sInstance();
                JPH.DebugRenderer? value = null;
                if (*ptr is not null)
                    value = new(*ptr, is_owning: false);
                return value;
            }
        }

        internal unsafe Const_RecordingDebugRenderer(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RecordingDebugRenderer() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RecordingDebugRenderer._Underlying *__RecordingDebugRenderer_DefaultConstruct();
            _UnderlyingPtr = __RecordingDebugRenderer_DefaultConstruct();
        }

        /// Generated from method `RecordingDebugRenderer::GetLineCount`.
        public unsafe uint GetLineCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_GetLineCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_GetLineCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __RecordingDebugRenderer_GetLineCount(_Underlying *_this);
            return __RecordingDebugRenderer_GetLineCount(_UnderlyingPtr);
        }

        /// Generated from method `RecordingDebugRenderer::GetTriangleCount`.
        public unsafe uint GetTriangleCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_GetTriangleCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_GetTriangleCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __RecordingDebugRenderer_GetTriangleCount(_Underlying *_this);
            return __RecordingDebugRenderer_GetTriangleCount(_UnderlyingPtr);
        }

        /// Generated from method `RecordingDebugRenderer::GetLine`.
        public unsafe JPH.Const_DebugLineRecord GetLine(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_GetLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_GetLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_DebugLineRecord._Underlying *__RecordingDebugRenderer_GetLine(_Underlying *_this, uint inIndex);
            return new(__RecordingDebugRenderer_GetLine(_UnderlyingPtr, inIndex), is_owning: false);
        }

        /// Generated from method `RecordingDebugRenderer::GetTriangle`.
        public unsafe JPH.Const_DebugTriangleRecord GetTriangle(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_GetTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_GetTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_DebugTriangleRecord._Underlying *__RecordingDebugRenderer_GetTriangle(_Underlying *_this, uint inIndex);
            return new(__RecordingDebugRenderer_GetTriangle(_UnderlyingPtr, inIndex), is_owning: false);
        }

        /// Calculate bounding box for a batch of triangles
        /// Generated from method `RecordingDebugRenderer::sCalculateBounds`.
        public static unsafe JPH.AABox SCalculateBounds(JPH.DebugRenderer.Const_Vertex? inVertices, int inVertexCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_sCalculateBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_sCalculateBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__RecordingDebugRenderer_sCalculateBounds(JPH.DebugRenderer.Const_Vertex._Underlying *inVertices, int inVertexCount);
            return new(__RecordingDebugRenderer_sCalculateBounds(inVertices is not null ? inVertices._UnderlyingPtr : null, inVertexCount), is_owning: true);
        }
    }

    /// Concrete DebugRenderer that records all DrawLine / DrawTriangle calls so
    /// C# can inspect them.  Inherits DebugRendererSimple to avoid re-implementing
    /// CreateTriangleBatch and DrawGeometry.
    ///
    /// Lifecycle: only one instance may exist at a time (enforced by
    /// DebugRenderer's singleton assert).  Call Clear() between frames.
    /// Generated from class `RecordingDebugRenderer`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DebugRendererSimple`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    ///     `JPH::DebugRenderer`
    /// This is the non-const half of the class.
    public class RecordingDebugRenderer : Const_RecordingDebugRenderer
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(RecordingDebugRenderer self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__RecordingDebugRenderer_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__RecordingDebugRenderer_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.DebugRenderer(RecordingDebugRenderer self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugRenderer._Underlying *__RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer(_Underlying *_this);
            JPH.DebugRenderer ret = new(__RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.DebugRendererSimple(RecordingDebugRenderer self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugRendererSimple._Underlying *__RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple(_Underlying *_this);
            JPH.DebugRendererSimple ret = new(__RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator RecordingDebugRenderer(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            RecordingDebugRenderer ret = new(__RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator RecordingDebugRenderer(JPH.DebugRenderer parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer(JPH.DebugRenderer._Underlying *_this);
            RecordingDebugRenderer ret = new(__RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator RecordingDebugRenderer(JPH.DebugRendererSimple parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple(JPH.DebugRendererSimple._Underlying *_this);
            RecordingDebugRenderer ret = new(__RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe RecordingDebugRenderer(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RecordingDebugRenderer() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RecordingDebugRenderer._Underlying *__RecordingDebugRenderer_DefaultConstruct();
            _UnderlyingPtr = __RecordingDebugRenderer_DefaultConstruct();
        }

        /// Generated from method `RecordingDebugRenderer::Clear`.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_Clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_Clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_Clear(_Underlying *_this);
            __RecordingDebugRenderer_Clear(_UnderlyingPtr);
        }

        /// Generated from method `RecordingDebugRenderer::DrawLine`.
        public unsafe void DrawLine(JPH.Const_Vec3 inFrom, JPH.Const_Vec3 inTo, JPH.Const_Color inColor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawLine(_Underlying *_this, JPH.Vec3._Underlying *inFrom, JPH.Vec3._Underlying *inTo, JPH.Color._Underlying *inColor);
            __RecordingDebugRenderer_DrawLine(_UnderlyingPtr, inFrom._UnderlyingPtr, inTo._UnderlyingPtr, inColor._UnderlyingPtr);
        }

        /// Generated from method `RecordingDebugRenderer::DrawTriangle`.
        public unsafe void DrawTriangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow inCastShadow)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawTriangle(_Underlying *_this, JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow inCastShadow);
            __RecordingDebugRenderer_DrawTriangle(_UnderlyingPtr, inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr, inCastShadow);
        }

        /// Should be called every frame by the application to provide the camera position.
        /// This is used to determine the correct LOD for rendering.
        /// Generated from method `RecordingDebugRenderer::SetCameraPos`.
        public unsafe void SetCameraPos(JPH.Const_Vec3 inCameraPos)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_SetCameraPos", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_SetCameraPos", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_SetCameraPos(_Underlying *_this, JPH.Vec3._Underlying *inCameraPos);
            __RecordingDebugRenderer_SetCameraPos(_UnderlyingPtr, inCameraPos._UnderlyingPtr);
        }

        /// Call once after frame is complete. Releases unused dynamically generated geometry assets.
        /// Generated from method `RecordingDebugRenderer::NextFrame`.
        public unsafe void NextFrame()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_NextFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_NextFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_NextFrame(_Underlying *_this);
            __RecordingDebugRenderer_NextFrame(_UnderlyingPtr);
        }

        /// Draw a marker on a position
        /// Generated from method `RecordingDebugRenderer::DrawMarker`.
        public unsafe void DrawMarker(JPH.Const_Vec3 inPosition, JPH.Const_Color inColor, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawMarker", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawMarker", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawMarker(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.Color._Underlying *inColor, float inSize);
            __RecordingDebugRenderer_DrawMarker(_UnderlyingPtr, inPosition._UnderlyingPtr, inColor._UnderlyingPtr, inSize);
        }

        /// Draw an arrow
        /// Generated from method `RecordingDebugRenderer::DrawArrow`.
        public unsafe void DrawArrow(JPH.Const_Vec3 inFrom, JPH.Const_Vec3 inTo, JPH.Const_Color inColor, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawArrow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawArrow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawArrow(_Underlying *_this, JPH.Vec3._Underlying *inFrom, JPH.Vec3._Underlying *inTo, JPH.Color._Underlying *inColor, float inSize);
            __RecordingDebugRenderer_DrawArrow(_UnderlyingPtr, inFrom._UnderlyingPtr, inTo._UnderlyingPtr, inColor._UnderlyingPtr, inSize);
        }

        /// Draw coordinate system (3 arrows, x = red, y = green, z = blue)
        /// Generated from method `RecordingDebugRenderer::DrawCoordinateSystem`.
        /// Parameter `inSize` defaults to `1.0f`.
        public unsafe void DrawCoordinateSystem(JPH.Const_Mat44 inTransform, float? inSize = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawCoordinateSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawCoordinateSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawCoordinateSystem(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform, float *inSize);
            float __deref_inSize = inSize.GetValueOrDefault();
            __RecordingDebugRenderer_DrawCoordinateSystem(_UnderlyingPtr, inTransform._UnderlyingPtr, inSize.HasValue ? &__deref_inSize : null);
        }

        /// Draw a plane through inPoint with normal inNormal
        /// Generated from method `RecordingDebugRenderer::DrawPlane`.
        public unsafe void DrawPlane(JPH.Const_Vec3 inPoint, JPH.Const_Vec3 inNormal, JPH.Const_Color inColor, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawPlane(_Underlying *_this, JPH.Vec3._Underlying *inPoint, JPH.Vec3._Underlying *inNormal, JPH.Color._Underlying *inColor, float inSize);
            __RecordingDebugRenderer_DrawPlane(_UnderlyingPtr, inPoint._UnderlyingPtr, inNormal._UnderlyingPtr, inColor._UnderlyingPtr, inSize);
        }

        /// Draw wireframe triangle
        /// Generated from method `RecordingDebugRenderer::DrawWireTriangle`.
        public unsafe void DrawWireTriangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawWireTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawWireTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawWireTriangle(_Underlying *_this, JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor);
            __RecordingDebugRenderer_DrawWireTriangle(_UnderlyingPtr, inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr);
        }

        /// Draw wireframe sphere
        /// Generated from method `RecordingDebugRenderer::DrawWireSphere`.
        /// Parameter `inLevel` defaults to `3`.
        public unsafe void DrawWireSphere(JPH.Const_Vec3 inCenter, float inRadius, JPH.Const_Color inColor, int? inLevel = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawWireSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawWireSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawWireSphere(_Underlying *_this, JPH.Vec3._Underlying *inCenter, float inRadius, JPH.Color._Underlying *inColor, int *inLevel);
            int __deref_inLevel = inLevel.GetValueOrDefault();
            __RecordingDebugRenderer_DrawWireSphere(_UnderlyingPtr, inCenter._UnderlyingPtr, inRadius, inColor._UnderlyingPtr, inLevel.HasValue ? &__deref_inLevel : null);
        }

        /// Generated from method `RecordingDebugRenderer::DrawWireUnitSphere`.
        /// Parameter `inLevel` defaults to `3`.
        public unsafe void DrawWireUnitSphere(JPH.Const_Mat44 inMatrix, JPH.Const_Color inColor, int? inLevel = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawWireUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawWireUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawWireUnitSphere(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, JPH.Color._Underlying *inColor, int *inLevel);
            int __deref_inLevel = inLevel.GetValueOrDefault();
            __RecordingDebugRenderer_DrawWireUnitSphere(_UnderlyingPtr, inMatrix._UnderlyingPtr, inColor._UnderlyingPtr, inLevel.HasValue ? &__deref_inLevel : null);
        }

        /// Draw a sphere
        /// Generated from method `RecordingDebugRenderer::DrawSphere`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawSphere(JPH.Const_Vec3 inCenter, float inRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawSphere(_Underlying *_this, JPH.Vec3._Underlying *inCenter, float inRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __RecordingDebugRenderer_DrawSphere(_UnderlyingPtr, inCenter._UnderlyingPtr, inRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Generated from method `RecordingDebugRenderer::DrawUnitSphere`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawUnitSphere(JPH.Const_Mat44 inMatrix, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawUnitSphere(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __RecordingDebugRenderer_DrawUnitSphere(_UnderlyingPtr, inMatrix._UnderlyingPtr, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a capsule with one half sphere at (0, -inHalfHeightOfCylinder, 0) and the other half sphere at (0, inHalfHeightOfCylinder, 0) and radius inRadius.
        /// The capsule will be transformed by inMatrix.
        /// Generated from method `RecordingDebugRenderer::DrawCapsule`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawCapsule(JPH.Const_Mat44 inMatrix, float inHalfHeightOfCylinder, float inRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawCapsule", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawCapsule", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawCapsule(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inHalfHeightOfCylinder, float inRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __RecordingDebugRenderer_DrawCapsule(_UnderlyingPtr, inMatrix._UnderlyingPtr, inHalfHeightOfCylinder, inRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a cylinder with top (0, inHalfHeight, 0) and bottom (0, -inHalfHeight, 0) and radius inRadius.
        /// The cylinder will be transformed by inMatrix
        /// Generated from method `RecordingDebugRenderer::DrawCylinder`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawCylinder(JPH.Const_Mat44 inMatrix, float inHalfHeight, float inRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawCylinder(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inHalfHeight, float inRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __RecordingDebugRenderer_DrawCylinder(_UnderlyingPtr, inMatrix._UnderlyingPtr, inHalfHeight, inRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a bottomless cone.
        /// @param inTop Top of cone, center of base is at inTop + inAxis.
        /// @param inAxis Height and direction of cone
        /// @param inPerpendicular Perpendicular vector to inAxis.
        /// @param inHalfAngle Specifies the cone angle in radians (angle measured between inAxis and cone surface).
        /// @param inLength The length of the cone.
        /// @param inColor Color to use for drawing the cone.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `RecordingDebugRenderer::DrawOpenCone`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawOpenCone(JPH.Const_Vec3 inTop, JPH.Const_Vec3 inAxis, JPH.Const_Vec3 inPerpendicular, float inHalfAngle, float inLength, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawOpenCone", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawOpenCone", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawOpenCone(_Underlying *_this, JPH.Vec3._Underlying *inTop, JPH.Vec3._Underlying *inAxis, JPH.Vec3._Underlying *inPerpendicular, float inHalfAngle, float inLength, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __RecordingDebugRenderer_DrawOpenCone(_UnderlyingPtr, inTop._UnderlyingPtr, inAxis._UnderlyingPtr, inPerpendicular._UnderlyingPtr, inHalfAngle, inLength, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draws cone rotation limits as used by the SwingTwistConstraintPart.
        /// @param inMatrix Matrix that transforms from constraint space to world space
        /// @param inSwingYHalfAngle See SwingTwistConstraintPart
        /// @param inSwingZHalfAngle See SwingTwistConstraintPart
        /// @param inEdgeLength Size of the edge of the cone shape
        /// @param inColor Color to use for drawing the cone.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `RecordingDebugRenderer::DrawSwingConeLimits`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawSwingConeLimits(JPH.Const_Mat44 inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawSwingConeLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawSwingConeLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawSwingConeLimits(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __RecordingDebugRenderer_DrawSwingConeLimits(_UnderlyingPtr, inMatrix._UnderlyingPtr, inSwingYHalfAngle, inSwingZHalfAngle, inEdgeLength, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draws rotation limits as used by the SwingTwistConstraintPart.
        /// @param inMatrix Matrix that transforms from constraint space to world space
        /// @param inMinSwingYAngle See SwingTwistConstraintPart
        /// @param inMaxSwingYAngle See SwingTwistConstraintPart
        /// @param inMinSwingZAngle See SwingTwistConstraintPart
        /// @param inMaxSwingZAngle See SwingTwistConstraintPart
        /// @param inEdgeLength Size of the edge of the cone shape
        /// @param inColor Color to use for drawing the cone.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `RecordingDebugRenderer::DrawSwingPyramidLimits`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawSwingPyramidLimits(JPH.Const_Mat44 inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawSwingPyramidLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawSwingPyramidLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawSwingPyramidLimits(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __RecordingDebugRenderer_DrawSwingPyramidLimits(_UnderlyingPtr, inMatrix._UnderlyingPtr, inMinSwingYAngle, inMaxSwingYAngle, inMinSwingZAngle, inMaxSwingZAngle, inEdgeLength, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a pie (part of a circle).
        /// @param inCenter The center of the circle.
        /// @param inRadius Radius of the circle.
        /// @param inNormal The plane normal in which the pie resides.
        /// @param inAxis The axis that defines an angle of 0 radians.
        /// @param inMinAngle The pie will be drawn between [inMinAngle, inMaxAngle] (in radians).
        /// @param inMaxAngle The pie will be drawn between [inMinAngle, inMaxAngle] (in radians).
        /// @param inColor Color to use for drawing the pie.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `RecordingDebugRenderer::DrawPie`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawPie(JPH.Const_Vec3 inCenter, float inRadius, JPH.Const_Vec3 inNormal, JPH.Const_Vec3 inAxis, float inMinAngle, float inMaxAngle, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawPie", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawPie", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawPie(_Underlying *_this, JPH.Vec3._Underlying *inCenter, float inRadius, JPH.Vec3._Underlying *inNormal, JPH.Vec3._Underlying *inAxis, float inMinAngle, float inMaxAngle, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __RecordingDebugRenderer_DrawPie(_UnderlyingPtr, inCenter._UnderlyingPtr, inRadius, inNormal._UnderlyingPtr, inAxis._UnderlyingPtr, inMinAngle, inMaxAngle, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a tapered cylinder
        /// @param inMatrix Matrix that transforms the cylinder to world space.
        /// @param inTop Top of cylinder (along Y axis)
        /// @param inBottom Bottom of cylinder (along Y axis)
        /// @param inTopRadius Radius at the top
        /// @param inBottomRadius Radius at the bottom
        /// @param inColor Color to use for drawing the pie.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `RecordingDebugRenderer::DrawTaperedCylinder`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawTaperedCylinder(JPH.Const_Mat44 inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "RecordingDebugRenderer_DrawTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "RecordingDebugRenderer_DrawTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __RecordingDebugRenderer_DrawTaperedCylinder(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __RecordingDebugRenderer_DrawTaperedCylinder(_UnderlyingPtr, inMatrix._UnderlyingPtr, inTop, inBottom, inTopRadius, inBottomRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }
    }

    /// This is used as a function parameter when the underlying function receives `RecordingDebugRenderer` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RecordingDebugRenderer
    {
        #pragma warning disable CS0649
        internal readonly Const_RecordingDebugRenderer? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RecordingDebugRenderer() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `RecordingDebugRenderer` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RecordingDebugRenderer`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RecordingDebugRenderer`/`Const_RecordingDebugRenderer` directly.
    public class _InOptMut_RecordingDebugRenderer
    {
        public RecordingDebugRenderer? Opt;

        public _InOptMut_RecordingDebugRenderer() {}
        public _InOptMut_RecordingDebugRenderer(RecordingDebugRenderer value) {Opt = value;}
        public static implicit operator _InOptMut_RecordingDebugRenderer(RecordingDebugRenderer value) {return new(value);}
    }

    /// This is used for optional parameters of class `RecordingDebugRenderer` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RecordingDebugRenderer`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RecordingDebugRenderer`/`Const_RecordingDebugRenderer` to pass it to the function.
    public class _InOptConst_RecordingDebugRenderer
    {
        public Const_RecordingDebugRenderer? Opt;

        public _InOptConst_RecordingDebugRenderer() {}
        public _InOptConst_RecordingDebugRenderer(Const_RecordingDebugRenderer value) {Opt = value;}
        public static implicit operator _InOptConst_RecordingDebugRenderer(Const_RecordingDebugRenderer value) {return new(value);}
    }
}
