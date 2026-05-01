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
}
