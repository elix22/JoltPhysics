// machine generated, do not edit
public static partial class JPH
{
    /// This class contains the runtime information of a soft body.
    //
    // Based on: XPBD, Extended Position Based Dynamics, Matthias Muller, Ten Minute Physics
    // See: https://matthias-research.github.io/pages/tenMinutePhysics/09-xpbd.pdf
    /// Generated from class `JPH::SoftBodyMotionProperties`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MotionProperties`
    /// This is the const half of the class.
    public class Const_SoftBodyMotionProperties : JPH.Object<Const_SoftBodyMotionProperties>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_Destroy(_Underlying *_this);
            __JPH_SoftBodyMotionProperties_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SoftBodyMotionProperties() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_MotionProperties(Const_SoftBodyMotionProperties self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_MotionProperties._Underlying *__JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties(_Underlying *_this);
            JPH.Const_MotionProperties ret = new(__JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_SoftBodyMotionProperties(JPH.Const_MotionProperties parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties(JPH.Const_MotionProperties._Underlying *_this);
            Const_SoftBodyMotionProperties ret = new(__JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Constant indicating that body is not active
        public static unsafe uint CInactiveIndex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_Get_cInactiveIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_Get_cInactiveIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_SoftBodyMotionProperties_Get_cInactiveIndex();
                return *__JPH_SoftBodyMotionProperties_Get_cInactiveIndex();
            }
        }

        internal unsafe Const_SoftBodyMotionProperties(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SoftBodyMotionProperties() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyMotionProperties._Underlying *__JPH_SoftBodyMotionProperties_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodyMotionProperties_DefaultConstruct();
        }

        /// Get the shared settings of the soft body
        /// Generated from method `JPH::SoftBodyMotionProperties::GetSettings`.
        public unsafe JPH.Const_SoftBodySharedSettings? GetSettings()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SoftBodySharedSettings._Underlying *__JPH_SoftBodyMotionProperties_GetSettings(_Underlying *_this);
            var __c_ret = __JPH_SoftBodyMotionProperties_GetSettings(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_SoftBodySharedSettings(__c_ret, is_owning: false) : null;
        }

        /// Access an individual vertex
        /// Generated from method `JPH::SoftBodyMotionProperties::GetVertex`.
        public unsafe JPH.Const_SoftBodyVertex GetVertex(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SoftBodyVertex._Underlying *__JPH_SoftBodyMotionProperties_GetVertex(_Underlying *_this, uint inIndex);
            return new(__JPH_SoftBodyMotionProperties_GetVertex(_UnderlyingPtr, inIndex), is_owning: false);
        }

        /// Access to the state of rods
        /// Generated from method `JPH::SoftBodyMotionProperties::GetRodRotation`.
        public unsafe JPH.Quat GetRodRotation(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetRodRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetRodRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_SoftBodyMotionProperties_GetRodRotation(_Underlying *_this, uint inIndex);
            return new(__JPH_SoftBodyMotionProperties_GetRodRotation(_UnderlyingPtr, inIndex), is_owning: true);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::GetRodAngularVelocity`.
        public unsafe JPH.Vec3 GetRodAngularVelocity(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetRodAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetRodAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_GetRodAngularVelocity(_Underlying *_this, uint inIndex);
            return new(__JPH_SoftBodyMotionProperties_GetRodAngularVelocity(_UnderlyingPtr, inIndex), is_owning: true);
        }

        /// Access to an individual face
        /// Generated from method `JPH::SoftBodyMotionProperties::GetFace`.
        public unsafe JPH.SoftBodySharedSettings.Const_Face GetFace(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings.Const_Face._Underlying *__JPH_SoftBodyMotionProperties_GetFace(_Underlying *_this, uint inIndex);
            return new(__JPH_SoftBodyMotionProperties_GetFace(_UnderlyingPtr, inIndex), is_owning: false);
        }

        /// Get the number of solver iterations
        /// Generated from method `JPH::SoftBodyMotionProperties::GetNumIterations`.
        public unsafe uint GetNumIterations()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SoftBodyMotionProperties_GetNumIterations(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetNumIterations(_UnderlyingPtr);
        }

        /// Get the pressure of the soft body
        /// Generated from method `JPH::SoftBodyMotionProperties::GetPressure`.
        public unsafe float GetPressure()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetPressure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetPressure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetPressure(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetPressure(_UnderlyingPtr);
        }

        /// Update the position of the body while simulating (set to false for something that is attached to the static world)
        /// Generated from method `JPH::SoftBodyMotionProperties::GetUpdatePosition`.
        public unsafe bool GetUpdatePosition()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetUpdatePosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetUpdatePosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SoftBodyMotionProperties_GetUpdatePosition(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetUpdatePosition(_UnderlyingPtr) != 0;
        }

        /// If the faces in this soft body should be treated as double sided for the purpose of collision detection (ray cast / collide shape / cast shape)
        /// Generated from method `JPH::SoftBodyMotionProperties::GetFacesDoubleSided`.
        public unsafe bool GetFacesDoubleSided()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetFacesDoubleSided", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetFacesDoubleSided", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SoftBodyMotionProperties_GetFacesDoubleSided(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetFacesDoubleSided(_UnderlyingPtr) != 0;
        }

        /// Global setting to turn on/off skin constraints
        /// Generated from method `JPH::SoftBodyMotionProperties::GetEnableSkinConstraints`.
        public unsafe bool GetEnableSkinConstraints()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetEnableSkinConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetEnableSkinConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SoftBodyMotionProperties_GetEnableSkinConstraints(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetEnableSkinConstraints(_UnderlyingPtr) != 0;
        }

        /// Multiplier applied to Skinned::mMaxDistance to allow tightening or loosening of the skin constraints. 0 to hard skin all vertices.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetSkinnedMaxDistanceMultiplier`.
        public unsafe float GetSkinnedMaxDistanceMultiplier()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetSkinnedMaxDistanceMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetSkinnedMaxDistanceMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetSkinnedMaxDistanceMultiplier(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetSkinnedMaxDistanceMultiplier(_UnderlyingPtr);
        }

        /// How big the particles are, can be used to push the vertices a little bit away from the surface of other bodies to prevent z-fighting
        /// Generated from method `JPH::SoftBodyMotionProperties::GetVertexRadius`.
        public unsafe float GetVertexRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetVertexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetVertexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetVertexRadius(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetVertexRadius(_UnderlyingPtr);
        }

        /// Get local bounding box
        /// Generated from method `JPH::SoftBodyMotionProperties::GetLocalBounds`.
        public unsafe JPH.Const_AABox GetLocalBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_AABox._Underlying *__JPH_SoftBodyMotionProperties_GetLocalBounds(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetLocalBounds(_UnderlyingPtr), is_owning: false);
        }

        /// Get the volume of the soft body. Note can become negative if the shape is inside out!
        /// Generated from method `JPH::SoftBodyMotionProperties::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetVolume(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetVolume(_UnderlyingPtr);
        }

        /// Draw the state of a soft body
        /// Generated from method `JPH::SoftBodyMotionProperties::DrawVertices`.
        public unsafe void DrawVertices(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DrawVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DrawVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_DrawVertices(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform);
            __JPH_SoftBodyMotionProperties_DrawVertices(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::DrawVertexVelocities`.
        public unsafe void DrawVertexVelocities(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DrawVertexVelocities", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DrawVertexVelocities", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_DrawVertexVelocities(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform);
            __JPH_SoftBodyMotionProperties_DrawVertexVelocities(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::DrawPredictedBounds`.
        public unsafe void DrawPredictedBounds(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DrawPredictedBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DrawPredictedBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_DrawPredictedBounds(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform);
            __JPH_SoftBodyMotionProperties_DrawPredictedBounds(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr);
        }

        /// Motion quality, or how well it detects collisions when it has a high velocity
        /// Generated from method `JPH::SoftBodyMotionProperties::GetMotionQuality`.
        public unsafe JPH.EMotionQuality GetMotionQuality()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EMotionQuality __JPH_SoftBodyMotionProperties_GetMotionQuality(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetMotionQuality(_UnderlyingPtr);
        }

        /// If this body can go to sleep.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetAllowSleeping`.
        public unsafe bool GetAllowSleeping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SoftBodyMotionProperties_GetAllowSleeping(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetAllowSleeping(_UnderlyingPtr) != 0;
        }

        /// Get world space linear velocity of the center of mass
        /// Generated from method `JPH::SoftBodyMotionProperties::GetLinearVelocity`.
        public unsafe JPH.Vec3 GetLinearVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_GetLinearVelocity(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetLinearVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Get world space angular velocity of the center of mass
        /// Generated from method `JPH::SoftBodyMotionProperties::GetAngularVelocity`.
        public unsafe JPH.Vec3 GetAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_GetAngularVelocity(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetAngularVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Maximum linear velocity that a body can achieve. Used to prevent the system from exploding.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetMaxLinearVelocity`.
        public unsafe float GetMaxLinearVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetMaxLinearVelocity(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetMaxLinearVelocity(_UnderlyingPtr);
        }

        /// Maximum angular velocity that a body can achieve. Used to prevent the system from exploding.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetMaxAngularVelocity`.
        public unsafe float GetMaxAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetMaxAngularVelocity(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetMaxAngularVelocity(_UnderlyingPtr);
        }

        /// Get linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetLinearDamping`.
        public unsafe float GetLinearDamping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetLinearDamping(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetLinearDamping(_UnderlyingPtr);
        }

        /// Get angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetAngularDamping`.
        public unsafe float GetAngularDamping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetAngularDamping(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetAngularDamping(_UnderlyingPtr);
        }

        /// Get gravity factor (1 = normal gravity, 0 = no gravity)
        /// Generated from method `JPH::SoftBodyMotionProperties::GetGravityFactor`.
        public unsafe float GetGravityFactor()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetGravityFactor(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetGravityFactor(_UnderlyingPtr);
        }

        /// Get inverse mass (1 / mass). Should only be called on a dynamic object (static or kinematic bodies have infinite mass so should be treated as 1 / mass = 0)
        /// Generated from method `JPH::SoftBodyMotionProperties::GetInverseMass`.
        public unsafe float GetInverseMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetInverseMass(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetInverseMass(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::GetInverseMassUnchecked`.
        public unsafe float GetInverseMassUnchecked()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInverseMassUnchecked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInverseMassUnchecked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SoftBodyMotionProperties_GetInverseMassUnchecked(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetInverseMassUnchecked(_UnderlyingPtr);
        }

        /// Diagonal of inverse inertia matrix: D. Should only be called on a dynamic object (static or kinematic bodies have infinite mass so should be treated as D = 0)
        /// Generated from method `JPH::SoftBodyMotionProperties::GetInverseInertiaDiagonal`.
        public unsafe JPH.Vec3 GetInverseInertiaDiagonal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInverseInertiaDiagonal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInverseInertiaDiagonal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_GetInverseInertiaDiagonal(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetInverseInertiaDiagonal(_UnderlyingPtr), is_owning: true);
        }

        /// Rotation (R) that takes inverse inertia diagonal to local space: \f$I_{body}^{-1} = R \: D \: R^{-1}\f$
        /// Generated from method `JPH::SoftBodyMotionProperties::GetInertiaRotation`.
        public unsafe JPH.Quat GetInertiaRotation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInertiaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInertiaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_SoftBodyMotionProperties_GetInertiaRotation(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetInertiaRotation(_UnderlyingPtr), is_owning: true);
        }

        /// Get inverse inertia matrix (\f$I_{body}^{-1}\f$). Will be a matrix of zeros for a static or kinematic object.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetLocalSpaceInverseInertia`.
        public unsafe JPH.Mat44 GetLocalSpaceInverseInertia()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertia(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertia(_UnderlyingPtr), is_owning: true);
        }

        /// Same as GetLocalSpaceInverseInertia() but doesn't check if the body is dynamic
        /// Generated from method `JPH::SoftBodyMotionProperties::GetLocalSpaceInverseInertiaUnchecked`.
        public unsafe JPH.Mat44 GetLocalSpaceInverseInertiaUnchecked()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertiaUnchecked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertiaUnchecked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertiaUnchecked(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertiaUnchecked(_UnderlyingPtr), is_owning: true);
        }

        /// Get inverse inertia matrix (\f$I^{-1}\f$) for a given object rotation (translation will be ignored). Zero if object is static or kinematic.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetInverseInertiaForRotation`.
        public unsafe JPH.Mat44 GetInverseInertiaForRotation(JPH.Const_Mat44 inRotation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInverseInertiaForRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetInverseInertiaForRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_SoftBodyMotionProperties_GetInverseInertiaForRotation(_Underlying *_this, JPH.Const_Mat44._Underlying *inRotation);
            return new(__JPH_SoftBodyMotionProperties_GetInverseInertiaForRotation(_UnderlyingPtr, inRotation._UnderlyingPtr), is_owning: true);
        }

        /// Multiply a vector with the inverse world space inertia tensor (\f$I_{world}^{-1}\f$). Zero if object is static or kinematic.
        /// Generated from method `JPH::SoftBodyMotionProperties::MultiplyWorldSpaceInverseInertiaByVector`.
        public unsafe JPH.Vec3 MultiplyWorldSpaceInverseInertiaByVector(JPH.Const_Quat inBodyRotation, JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_MultiplyWorldSpaceInverseInertiaByVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_MultiplyWorldSpaceInverseInertiaByVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_MultiplyWorldSpaceInverseInertiaByVector(_Underlying *_this, JPH.Quat._Underlying *inBodyRotation, JPH.Vec3._Underlying *inV);
            return new(__JPH_SoftBodyMotionProperties_MultiplyWorldSpaceInverseInertiaByVector(_UnderlyingPtr, inBodyRotation._UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Velocity of point inPoint (in center of mass space, e.g. on the surface of the body) of the body (unit: m/s)
        /// Generated from method `JPH::SoftBodyMotionProperties::GetPointVelocityCOM`.
        public unsafe JPH.Vec3 GetPointVelocityCOM(JPH.Const_Vec3 inPointRelativeToCOM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetPointVelocityCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetPointVelocityCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_GetPointVelocityCOM(_Underlying *_this, JPH.Vec3._Underlying *inPointRelativeToCOM);
            return new(__JPH_SoftBodyMotionProperties_GetPointVelocityCOM(_UnderlyingPtr, inPointRelativeToCOM._UnderlyingPtr), is_owning: true);
        }

        // Get the total amount of force applied to the center of mass this time step (through Body::AddForce calls). Note that it will reset to zero after PhysicsSystem::Update.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetAccumulatedForce`.
        public unsafe JPH.Vec3 GetAccumulatedForce()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAccumulatedForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAccumulatedForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_GetAccumulatedForce(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetAccumulatedForce(_UnderlyingPtr), is_owning: true);
        }

        // Get the total amount of torque applied to the center of mass this time step (through Body::AddForce/Body::AddTorque calls). Note that it will reset to zero after PhysicsSystem::Update.
        /// Generated from method `JPH::SoftBodyMotionProperties::GetAccumulatedTorque`.
        public unsafe JPH.Vec3 GetAccumulatedTorque()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAccumulatedTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAccumulatedTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_GetAccumulatedTorque(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetAccumulatedTorque(_UnderlyingPtr), is_owning: true);
        }

        /// Returns a vector where the linear components that are not allowed by mAllowedDOFs are set to 0 and the rest to 0xffffffff
        /// Generated from method `JPH::SoftBodyMotionProperties::GetLinearDOFsMask`.
        public unsafe JPH.UVec4 GetLinearDOFsMask()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLinearDOFsMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetLinearDOFsMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_SoftBodyMotionProperties_GetLinearDOFsMask(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetLinearDOFsMask(_UnderlyingPtr), is_owning: true);
        }

        /// Takes a translation vector inV and returns a vector where the components that are not allowed by mAllowedDOFs are set to 0
        /// Generated from method `JPH::SoftBodyMotionProperties::LockTranslation`.
        public unsafe JPH.Vec3 LockTranslation(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_LockTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_LockTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_LockTranslation(_Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__JPH_SoftBodyMotionProperties_LockTranslation(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Returns a vector where the angular components that are not allowed by mAllowedDOFs are set to 0 and the rest to 0xffffffff
        /// Generated from method `JPH::SoftBodyMotionProperties::GetAngularDOFsMask`.
        public unsafe JPH.UVec4 GetAngularDOFsMask()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAngularDOFsMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetAngularDOFsMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_SoftBodyMotionProperties_GetAngularDOFsMask(_Underlying *_this);
            return new(__JPH_SoftBodyMotionProperties_GetAngularDOFsMask(_UnderlyingPtr), is_owning: true);
        }

        /// Takes an angular velocity / torque vector inV and returns a vector where the components that are not allowed by mAllowedDOFs are set to 0
        /// Generated from method `JPH::SoftBodyMotionProperties::LockAngular`.
        public unsafe JPH.Vec3 LockAngular(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_LockAngular", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_LockAngular", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyMotionProperties_LockAngular(_Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__JPH_SoftBodyMotionProperties_LockAngular(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::GetNumVelocityStepsOverride`.
        public unsafe uint GetNumVelocityStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SoftBodyMotionProperties_GetNumVelocityStepsOverride(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetNumVelocityStepsOverride(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::GetNumPositionStepsOverride`.
        public unsafe uint GetNumPositionStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SoftBodyMotionProperties_GetNumPositionStepsOverride(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetNumPositionStepsOverride(_UnderlyingPtr);
        }

        /// Access to the island index
        /// Generated from method `JPH::SoftBodyMotionProperties::GetIslandIndexInternal`.
        public unsafe uint GetIslandIndexInternal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetIslandIndexInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetIslandIndexInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SoftBodyMotionProperties_GetIslandIndexInternal(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetIslandIndexInternal(_UnderlyingPtr);
        }

        /// Access to the index in the active bodies array
        /// Generated from method `JPH::SoftBodyMotionProperties::GetIndexInActiveBodiesInternal`.
        public unsafe uint GetIndexInActiveBodiesInternal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetIndexInActiveBodiesInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetIndexInActiveBodiesInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SoftBodyMotionProperties_GetIndexInActiveBodiesInternal(_Underlying *_this);
            return __JPH_SoftBodyMotionProperties_GetIndexInActiveBodiesInternal(_UnderlyingPtr);
        }

        /// Return code for ParallelUpdate
        public enum EStatus : int
        {
            ///< No work was done because other threads were still working on a batch that cannot run concurrently
            NoWork = 1,
            ///< Work was done to progress the update
            DidWork = 2,
            ///< All work is done
            Done = 4,
        }
    }

    /// This class contains the runtime information of a soft body.
    //
    // Based on: XPBD, Extended Position Based Dynamics, Matthias Muller, Ten Minute Physics
    // See: https://matthias-research.github.io/pages/tenMinutePhysics/09-xpbd.pdf
    /// Generated from class `JPH::SoftBodyMotionProperties`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MotionProperties`
    /// This is the non-const half of the class.
    public class SoftBodyMotionProperties : Const_SoftBodyMotionProperties
    {
        // Upcasts:
        public static unsafe implicit operator JPH.MotionProperties(SoftBodyMotionProperties self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotionProperties._Underlying *__JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties(_Underlying *_this);
            JPH.MotionProperties ret = new(__JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator SoftBodyMotionProperties(JPH.MotionProperties parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties(JPH.MotionProperties._Underlying *_this);
            SoftBodyMotionProperties ret = new(__JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe SoftBodyMotionProperties(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SoftBodyMotionProperties() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyMotionProperties._Underlying *__JPH_SoftBodyMotionProperties_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodyMotionProperties_DefaultConstruct();
        }

        /// Initialize the soft body motion properties
        /// Generated from method `JPH::SoftBodyMotionProperties::Initialize`.
        public unsafe void Initialize(JPH.Const_SoftBodyCreationSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_Initialize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_Initialize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_Initialize(_Underlying *_this, JPH.Const_SoftBodyCreationSettings._Underlying *inSettings);
            __JPH_SoftBodyMotionProperties_Initialize(_UnderlyingPtr, inSettings._UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::GetVertex`.
        public unsafe new JPH.SoftBodyVertex GetVertex(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetVertex_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_GetVertex_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyVertex._Underlying *__JPH_SoftBodyMotionProperties_GetVertex_mut(_Underlying *_this, uint inIndex);
            return new(__JPH_SoftBodyMotionProperties_GetVertex_mut(_UnderlyingPtr, inIndex), is_owning: false);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetNumIterations`.
        public unsafe void SetNumIterations(uint inNumIterations)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetNumIterations(_Underlying *_this, uint inNumIterations);
            __JPH_SoftBodyMotionProperties_SetNumIterations(_UnderlyingPtr, inNumIterations);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetPressure`.
        public unsafe void SetPressure(float inPressure)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetPressure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetPressure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetPressure(_Underlying *_this, float inPressure);
            __JPH_SoftBodyMotionProperties_SetPressure(_UnderlyingPtr, inPressure);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetUpdatePosition`.
        public unsafe void SetUpdatePosition(bool inUpdatePosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetUpdatePosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetUpdatePosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetUpdatePosition(_Underlying *_this, byte inUpdatePosition);
            __JPH_SoftBodyMotionProperties_SetUpdatePosition(_UnderlyingPtr, inUpdatePosition ? (byte)1 : (byte)0);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetFacesDoubleSided`.
        public unsafe void SetFacesDoubleSided(bool inDoubleSided)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetFacesDoubleSided", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetFacesDoubleSided", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetFacesDoubleSided(_Underlying *_this, byte inDoubleSided);
            __JPH_SoftBodyMotionProperties_SetFacesDoubleSided(_UnderlyingPtr, inDoubleSided ? (byte)1 : (byte)0);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetEnableSkinConstraints`.
        public unsafe void SetEnableSkinConstraints(bool inEnableSkinConstraints)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetEnableSkinConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetEnableSkinConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetEnableSkinConstraints(_Underlying *_this, byte inEnableSkinConstraints);
            __JPH_SoftBodyMotionProperties_SetEnableSkinConstraints(_UnderlyingPtr, inEnableSkinConstraints ? (byte)1 : (byte)0);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetSkinnedMaxDistanceMultiplier`.
        public unsafe void SetSkinnedMaxDistanceMultiplier(float inSkinnedMaxDistanceMultiplier)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetSkinnedMaxDistanceMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetSkinnedMaxDistanceMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetSkinnedMaxDistanceMultiplier(_Underlying *_this, float inSkinnedMaxDistanceMultiplier);
            __JPH_SoftBodyMotionProperties_SetSkinnedMaxDistanceMultiplier(_UnderlyingPtr, inSkinnedMaxDistanceMultiplier);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetVertexRadius`.
        public unsafe void SetVertexRadius(float inVertexRadius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetVertexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetVertexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetVertexRadius(_Underlying *_this, float inVertexRadius);
            __JPH_SoftBodyMotionProperties_SetVertexRadius(_UnderlyingPtr, inVertexRadius);
        }

        /// Calculate the total mass and inertia of this body based on the current state of the vertices
        /// Generated from method `JPH::SoftBodyMotionProperties::CalculateMassAndInertia`.
        public unsafe void CalculateMassAndInertia()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_CalculateMassAndInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_CalculateMassAndInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_CalculateMassAndInertia(_Underlying *_this);
            __JPH_SoftBodyMotionProperties_CalculateMassAndInertia(_UnderlyingPtr);
        }

        /// Skin vertices to supplied joints, information is used by the skinned constraints.
        /// @param inCenterOfMassTransform Value of Body::GetCenterOfMassTransform().
        /// @param inJointMatrices The joint matrices must be expressed relative to inCenterOfMassTransform.
        /// @param inNumJoints Indicates how large the inJointMatrices array is (used only for validating out of bounds).
        /// @param inHardSkinAll Can be used to position all vertices on the skinned vertices and can be used to hard reset the soft body.
        /// @param ioTempAllocator Allocator.
        /// Generated from method `JPH::SoftBodyMotionProperties::SkinVertices`.
        public unsafe void SkinVertices(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Mat44? inJointMatrices, uint inNumJoints, bool inHardSkinAll, JPH.TempAllocator ioTempAllocator)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SkinVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SkinVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SkinVertices(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Const_Mat44._Underlying *inJointMatrices, uint inNumJoints, byte inHardSkinAll, JPH.TempAllocator._Underlying *ioTempAllocator);
            __JPH_SoftBodyMotionProperties_SkinVertices(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inJointMatrices is not null ? inJointMatrices._UnderlyingPtr : null, inNumJoints, inHardSkinAll ? (byte)1 : (byte)0, ioTempAllocator._UnderlyingPtr);
        }

        /// This function allows you to update the soft body immediately without going through the PhysicsSystem.
        /// This is useful if the soft body is teleported and needs to 'settle' or it can be used if a the soft body
        /// is not added to the PhysicsSystem and needs to be updated manually. One reason for not adding it to the
        /// PhysicsSystem is that you might want to update a soft body immediately after updating an animated object
        /// that has the soft body attached to it. If the soft body is added to the PhysicsSystem it will be updated
        /// by it, so calling this function will effectively update it twice. Note that when you use this function,
        /// only the current thread will be used, whereas if you update through the PhysicsSystem, multiple threads may
        /// be used.
        /// Note that this will bypass any sleep checks. Since the dynamic objects that the soft body touches
        /// will not move during this call, there can be simulation artifacts if you call this function multiple times
        /// without running the physics simulation step.
        /// Generated from method `JPH::SoftBodyMotionProperties::CustomUpdate`.
        public unsafe void CustomUpdate(float inDeltaTime, JPH.Body ioSoftBody, JPH.PhysicsSystem inSystem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_CustomUpdate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_CustomUpdate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_CustomUpdate(_Underlying *_this, float inDeltaTime, JPH.Body._Underlying *ioSoftBody, JPH.PhysicsSystem._Underlying *inSystem);
            __JPH_SoftBodyMotionProperties_CustomUpdate(_UnderlyingPtr, inDeltaTime, ioSoftBody._UnderlyingPtr, inSystem._UnderlyingPtr);
        }

        /// Set world space linear velocity of the center of mass
        /// Generated from method `JPH::SoftBodyMotionProperties::SetLinearVelocity`.
        public unsafe void SetLinearVelocity(JPH.Const_Vec3 inLinearVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetLinearVelocity(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity);
            __JPH_SoftBodyMotionProperties_SetLinearVelocity(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr);
        }

        /// Set world space linear velocity of the center of mass, will make sure the value is clamped against the maximum linear velocity
        /// Generated from method `JPH::SoftBodyMotionProperties::SetLinearVelocityClamped`.
        public unsafe void SetLinearVelocityClamped(JPH.Const_Vec3 inLinearVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetLinearVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetLinearVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetLinearVelocityClamped(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity);
            __JPH_SoftBodyMotionProperties_SetLinearVelocityClamped(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr);
        }

        /// Set world space angular velocity of the center of mass
        /// Generated from method `JPH::SoftBodyMotionProperties::SetAngularVelocity`.
        public unsafe void SetAngularVelocity(JPH.Const_Vec3 inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetAngularVelocity(_Underlying *_this, JPH.Vec3._Underlying *inAngularVelocity);
            __JPH_SoftBodyMotionProperties_SetAngularVelocity(_UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
        }

        /// Set world space angular velocity of the center of mass, will make sure the value is clamped against the maximum angular velocity
        /// Generated from method `JPH::SoftBodyMotionProperties::SetAngularVelocityClamped`.
        public unsafe void SetAngularVelocityClamped(JPH.Const_Vec3 inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetAngularVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetAngularVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetAngularVelocityClamped(_Underlying *_this, JPH.Vec3._Underlying *inAngularVelocity);
            __JPH_SoftBodyMotionProperties_SetAngularVelocityClamped(_UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
        }

        /// Set velocity of body such that it will be rotate/translate by inDeltaPosition/Rotation in inDeltaTime seconds.
        /// Generated from method `JPH::SoftBodyMotionProperties::MoveKinematic`.
        public unsafe void MoveKinematic(JPH.Const_Vec3 inDeltaPosition, JPH.Const_Quat inDeltaRotation, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_MoveKinematic(_Underlying *_this, JPH.Vec3._Underlying *inDeltaPosition, JPH.Quat._Underlying *inDeltaRotation, float inDeltaTime);
            __JPH_SoftBodyMotionProperties_MoveKinematic(_UnderlyingPtr, inDeltaPosition._UnderlyingPtr, inDeltaRotation._UnderlyingPtr, inDeltaTime);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetMaxLinearVelocity`.
        public unsafe void SetMaxLinearVelocity(float inLinearVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetMaxLinearVelocity(_Underlying *_this, float inLinearVelocity);
            __JPH_SoftBodyMotionProperties_SetMaxLinearVelocity(_UnderlyingPtr, inLinearVelocity);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetMaxAngularVelocity`.
        public unsafe void SetMaxAngularVelocity(float inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetMaxAngularVelocity(_Underlying *_this, float inAngularVelocity);
            __JPH_SoftBodyMotionProperties_SetMaxAngularVelocity(_UnderlyingPtr, inAngularVelocity);
        }

        /// Clamp velocity according to limit
        /// Generated from method `JPH::SoftBodyMotionProperties::ClampLinearVelocity`.
        public unsafe void ClampLinearVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ClampLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ClampLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ClampLinearVelocity(_Underlying *_this);
            __JPH_SoftBodyMotionProperties_ClampLinearVelocity(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::ClampAngularVelocity`.
        public unsafe void ClampAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ClampAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ClampAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ClampAngularVelocity(_Underlying *_this);
            __JPH_SoftBodyMotionProperties_ClampAngularVelocity(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetLinearDamping`.
        public unsafe void SetLinearDamping(float inLinearDamping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetLinearDamping(_Underlying *_this, float inLinearDamping);
            __JPH_SoftBodyMotionProperties_SetLinearDamping(_UnderlyingPtr, inLinearDamping);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetAngularDamping`.
        public unsafe void SetAngularDamping(float inAngularDamping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetAngularDamping(_Underlying *_this, float inAngularDamping);
            __JPH_SoftBodyMotionProperties_SetAngularDamping(_UnderlyingPtr, inAngularDamping);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetGravityFactor`.
        public unsafe void SetGravityFactor(float inGravityFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetGravityFactor(_Underlying *_this, float inGravityFactor);
            __JPH_SoftBodyMotionProperties_SetGravityFactor(_UnderlyingPtr, inGravityFactor);
        }

        /// Set the inverse mass (1 / mass).
        /// Note that mass and inertia are linearly related (e.g. inertia of a sphere with mass m and radius r is \f$2/5 \: m \: r^2\f$).
        /// If you change mass, inertia should probably change as well. You can use ScaleToMass to update mass and inertia at the same time.
        /// If all your translation degrees of freedom are restricted, make sure this is zero (see EAllowedDOFs).
        /// Generated from method `JPH::SoftBodyMotionProperties::SetInverseMass`.
        public unsafe void SetInverseMass(float inInverseMass)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetInverseMass(_Underlying *_this, float inInverseMass);
            __JPH_SoftBodyMotionProperties_SetInverseMass(_UnderlyingPtr, inInverseMass);
        }

        /// Set the inverse inertia tensor in local space by setting the diagonal and the rotation: \f$I_{body}^{-1} = R \: D \: R^{-1}\f$.
        /// Note that mass and inertia are linearly related (e.g. inertia of a sphere with mass m and radius r is \f$2/5 \: m \: r^2\f$).
        /// If you change inertia, mass should probably change as well. You can use ScaleToMass to update mass and inertia at the same time.
        /// If all your rotation degrees of freedom are restricted, make sure this is zero (see EAllowedDOFs).
        /// Generated from method `JPH::SoftBodyMotionProperties::SetInverseInertia`.
        public unsafe void SetInverseInertia(JPH.Const_Vec3 inDiagonal, JPH.Const_Quat inRot)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetInverseInertia(_Underlying *_this, JPH.Vec3._Underlying *inDiagonal, JPH.Quat._Underlying *inRot);
            __JPH_SoftBodyMotionProperties_SetInverseInertia(_UnderlyingPtr, inDiagonal._UnderlyingPtr, inRot._UnderlyingPtr);
        }

        /// Sets the mass to inMass and scale the inertia tensor based on the ratio between the old and new mass.
        /// Note that this only works when the current mass is finite (i.e. the body is dynamic and translational degrees of freedom are not restricted).
        /// Generated from method `JPH::SoftBodyMotionProperties::ScaleToMass`.
        public unsafe void ScaleToMass(float inMass)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ScaleToMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ScaleToMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ScaleToMass(_Underlying *_this, float inMass);
            __JPH_SoftBodyMotionProperties_ScaleToMass(_UnderlyingPtr, inMass);
        }

        // Reset the total accumulated force, note that this will be done automatically after every time step.
        /// Generated from method `JPH::SoftBodyMotionProperties::ResetForce`.
        public unsafe void ResetForce()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ResetForce(_Underlying *_this);
            __JPH_SoftBodyMotionProperties_ResetForce(_UnderlyingPtr);
        }

        // Reset the total accumulated torque, note that this will be done automatically after every time step.
        /// Generated from method `JPH::SoftBodyMotionProperties::ResetTorque`.
        public unsafe void ResetTorque()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ResetTorque(_Underlying *_this);
            __JPH_SoftBodyMotionProperties_ResetTorque(_UnderlyingPtr);
        }

        // Reset the current velocity and accumulated force and torque.
        /// Generated from method `JPH::SoftBodyMotionProperties::ResetMotion`.
        public unsafe void ResetMotion()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetMotion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetMotion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ResetMotion(_Underlying *_this);
            __JPH_SoftBodyMotionProperties_ResetMotion(_UnderlyingPtr);
        }

        /// Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::SoftBodyMotionProperties::SetNumVelocityStepsOverride`.
        public unsafe void SetNumVelocityStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetNumVelocityStepsOverride(_Underlying *_this, uint inN);
            __JPH_SoftBodyMotionProperties_SetNumVelocityStepsOverride(_UnderlyingPtr, inN);
        }

        /// Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::SoftBodyMotionProperties::SetNumPositionStepsOverride`.
        public unsafe void SetNumPositionStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetNumPositionStepsOverride(_Underlying *_this, uint inN);
            __JPH_SoftBodyMotionProperties_SetNumPositionStepsOverride(_UnderlyingPtr, inN);
        }

        ///@name Update linear and angular velocity (used during constraint solving)
        ///@{
        /// Generated from method `JPH::SoftBodyMotionProperties::AddLinearVelocityStep`.
        public unsafe void AddLinearVelocityStep(JPH.Const_Vec3 inLinearVelocityChange)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_AddLinearVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_AddLinearVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_AddLinearVelocityStep(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocityChange);
            __JPH_SoftBodyMotionProperties_AddLinearVelocityStep(_UnderlyingPtr, inLinearVelocityChange._UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SubLinearVelocityStep`.
        public unsafe void SubLinearVelocityStep(JPH.Const_Vec3 inLinearVelocityChange)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SubLinearVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SubLinearVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SubLinearVelocityStep(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocityChange);
            __JPH_SoftBodyMotionProperties_SubLinearVelocityStep(_UnderlyingPtr, inLinearVelocityChange._UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::AddAngularVelocityStep`.
        public unsafe void AddAngularVelocityStep(JPH.Const_Vec3 inAngularVelocityChange)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_AddAngularVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_AddAngularVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_AddAngularVelocityStep(_Underlying *_this, JPH.Vec3._Underlying *inAngularVelocityChange);
            __JPH_SoftBodyMotionProperties_AddAngularVelocityStep(_UnderlyingPtr, inAngularVelocityChange._UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SubAngularVelocityStep`.
        public unsafe void SubAngularVelocityStep(JPH.Const_Vec3 inAngularVelocityChange)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SubAngularVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SubAngularVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SubAngularVelocityStep(_Underlying *_this, JPH.Vec3._Underlying *inAngularVelocityChange);
            __JPH_SoftBodyMotionProperties_SubAngularVelocityStep(_UnderlyingPtr, inAngularVelocityChange._UnderlyingPtr);
        }

        /// Apply the gyroscopic force (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
        /// Generated from method `JPH::SoftBodyMotionProperties::ApplyGyroscopicForceInternal`.
        public unsafe void ApplyGyroscopicForceInternal(JPH.Const_Quat inBodyRotation, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ApplyGyroscopicForceInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ApplyGyroscopicForceInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ApplyGyroscopicForceInternal(_Underlying *_this, JPH.Quat._Underlying *inBodyRotation, float inDeltaTime);
            __JPH_SoftBodyMotionProperties_ApplyGyroscopicForceInternal(_UnderlyingPtr, inBodyRotation._UnderlyingPtr, inDeltaTime);
        }

        /// Apply all accumulated forces, torques and drag (should only be called by the PhysicsSystem)
        /// Generated from method `JPH::SoftBodyMotionProperties::ApplyForceTorqueAndDragInternal`.
        public unsafe void ApplyForceTorqueAndDragInternal(JPH.Const_Quat inBodyRotation, JPH.Const_Vec3 inGravity, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ApplyForceTorqueAndDragInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ApplyForceTorqueAndDragInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ApplyForceTorqueAndDragInternal(_Underlying *_this, JPH.Quat._Underlying *inBodyRotation, JPH.Vec3._Underlying *inGravity, float inDeltaTime);
            __JPH_SoftBodyMotionProperties_ApplyForceTorqueAndDragInternal(_UnderlyingPtr, inBodyRotation._UnderlyingPtr, inGravity._UnderlyingPtr, inDeltaTime);
        }

        /// Generated from method `JPH::SoftBodyMotionProperties::SetIslandIndexInternal`.
        public unsafe void SetIslandIndexInternal(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetIslandIndexInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_SetIslandIndexInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_SetIslandIndexInternal(_Underlying *_this, uint inIndex);
            __JPH_SoftBodyMotionProperties_SetIslandIndexInternal(_UnderlyingPtr, inIndex);
        }

        /// Reset spheres to center around inPoints with radius 0
        /// Generated from method `JPH::SoftBodyMotionProperties::ResetSleepTestSpheres`.
        public unsafe void ResetSleepTestSpheres(JPH.Const_Vec3? inPoints)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetSleepTestSpheres", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetSleepTestSpheres", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ResetSleepTestSpheres(_Underlying *_this, JPH.Const_Vec3._Underlying *inPoints);
            __JPH_SoftBodyMotionProperties_ResetSleepTestSpheres(_UnderlyingPtr, inPoints is not null ? inPoints._UnderlyingPtr : null);
        }

        /// Reset the sleep test timer without resetting the sleep test spheres
        /// Generated from method `JPH::SoftBodyMotionProperties::ResetSleepTestTimer`.
        public unsafe void ResetSleepTestTimer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetSleepTestTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyMotionProperties_ResetSleepTestTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyMotionProperties_ResetSleepTestTimer(_Underlying *_this);
            __JPH_SoftBodyMotionProperties_ResetSleepTestTimer(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `SoftBodyMotionProperties` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_SoftBodyMotionProperties
    {
        #pragma warning disable CS0649
        internal readonly Const_SoftBodyMotionProperties? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_SoftBodyMotionProperties() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `SoftBodyMotionProperties` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SoftBodyMotionProperties`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyMotionProperties`/`Const_SoftBodyMotionProperties` directly.
    public class _InOptMut_SoftBodyMotionProperties
    {
        public SoftBodyMotionProperties? Opt;

        public _InOptMut_SoftBodyMotionProperties() {}
        public _InOptMut_SoftBodyMotionProperties(SoftBodyMotionProperties value) {Opt = value;}
        public static implicit operator _InOptMut_SoftBodyMotionProperties(SoftBodyMotionProperties value) {return new(value);}
    }

    /// This is used for optional parameters of class `SoftBodyMotionProperties` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SoftBodyMotionProperties`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyMotionProperties`/`Const_SoftBodyMotionProperties` to pass it to the function.
    public class _InOptConst_SoftBodyMotionProperties
    {
        public Const_SoftBodyMotionProperties? Opt;

        public _InOptConst_SoftBodyMotionProperties() {}
        public _InOptConst_SoftBodyMotionProperties(Const_SoftBodyMotionProperties value) {Opt = value;}
        public static implicit operator _InOptConst_SoftBodyMotionProperties(Const_SoftBodyMotionProperties value) {return new(value);}
    }
}
