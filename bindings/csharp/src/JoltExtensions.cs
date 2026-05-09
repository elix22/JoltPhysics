// machine generated, do not edit
public static unsafe partial class JoltExtensions
{
    public static float RayAABox(this JPH.Const_Vec3 inOrigin, JPH.Const_RayInvDirection inInvDirection, JPH.Const_Vec3 inBoundsMin, JPH.Const_Vec3 inBoundsMax) => JPH.Const_JoltHelpers.RayAABox(inOrigin, inInvDirection, inBoundsMin, inBoundsMax);

    public static void VehicleSettingsAddWheel(this JPH.VehicleConstraintSettings settings, JPH.WheelSettingsWV? wheel) => JPH.Const_JoltHelpers.VehicleSettingsAddWheel(settings, wheel);

    public static void VehicleSettingsAddWheelTV(this JPH.VehicleConstraintSettings settings, JPH.WheelSettingsTV? wheel) => JPH.Const_JoltHelpers.VehicleSettingsAddWheelTV(settings, wheel);

    public static void VehicleSettingsSetController(this JPH.VehicleConstraintSettings settings, JPH.WheeledVehicleControllerSettings? ctrl) => JPH.Const_JoltHelpers.VehicleSettingsSetController(settings, ctrl);

    public static void VehicleSettingsSetTrackedController(this JPH.VehicleConstraintSettings settings, JPH.TrackedVehicleControllerSettings? ctrl) => JPH.Const_JoltHelpers.VehicleSettingsSetTrackedController(settings, ctrl);

    public static void AddWheelIndex(this JPH.VehicleTrackSettings track, uint wheelIndex) => JPH.Const_JoltHelpers.VehicleTrackSettingsAddWheelIndex(track, wheelIndex);

    public static void AddWheelIndex(this JPH.VehicleTrack track, uint wheelIndex) => JPH.Const_JoltHelpers.VehicleTrackSettingsAddWheelIndex(track, wheelIndex);

    public static void VehicleSettingsAddAntiRollBar(this JPH.VehicleConstraintSettings settings, JPH.Const_VehicleAntiRollBar bar) => JPH.Const_JoltHelpers.VehicleSettingsAddAntiRollBar(settings, bar);

    public static void WheeledControllerSettingsAddDifferential(this JPH.WheeledVehicleControllerSettings settings, JPH.Const_VehicleDifferentialSettings diff) => JPH.Const_JoltHelpers.WheeledControllerSettingsAddDifferential(settings, diff);

    public static void WheeledControllerSettingsAddDifferential(this JPH.MotorcycleControllerSettings settings, JPH.Const_VehicleDifferentialSettings diff) => JPH.Const_JoltHelpers.WheeledControllerSettingsAddDifferential(settings, diff);

    public static JPH.WheeledVehicleController? GetWheeledController(this JPH.VehicleConstraint constraint) => JPH.Const_JoltHelpers.VehicleConstraintGetWheeledController(constraint);

    public static void SetGearRatios(this JPH.VehicleTransmissionSettings inSettings, float? inRatios, uint inCount) => JPH.Const_JoltHelpers.VehicleTransmissionSettingsSetGearRatios(inSettings, inRatios, inCount);

    public static void SetGearRatios(this JPH.VehicleTransmission inSettings, float? inRatios, uint inCount) => JPH.Const_JoltHelpers.VehicleTransmissionSettingsSetGearRatios(inSettings, inRatios, inCount);

    public static void SetReverseGearRatios(this JPH.VehicleTransmissionSettings inSettings, float? inRatios, uint inCount) => JPH.Const_JoltHelpers.VehicleTransmissionSettingsSetReverseGearRatios(inSettings, inRatios, inCount);

    public static void SetReverseGearRatios(this JPH.VehicleTransmission inSettings, float? inRatios, uint inCount) => JPH.Const_JoltHelpers.VehicleTransmissionSettingsSetReverseGearRatios(inSettings, inRatios, inCount);

    public static void SetOverrideMassProperties(this JPH.BodyCreationSettings inSettings, int inMode) => JPH.Const_JoltHelpers.BodyCreationSettingsSetOverrideMassProperties(inSettings, inMode);

    public static void SetOverrideMassProperties(this JPH.RagdollSettings.Part inSettings, int inMode) => JPH.Const_JoltHelpers.BodyCreationSettingsSetOverrideMassProperties(inSettings, inMode);

    public static void SetMassOverride(this JPH.BodyCreationSettings inSettings, float inMass) => JPH.Const_JoltHelpers.BodyCreationSettingsSetMassOverride(inSettings, inMass);

    public static void SetMassOverride(this JPH.RagdollSettings.Part inSettings, float inMass) => JPH.Const_JoltHelpers.BodyCreationSettingsSetMassOverride(inSettings, inMass);

    public static float GetMassOverride(this JPH.Const_BodyCreationSettings inSettings) => JPH.Const_JoltHelpers.BodyCreationSettingsGetMassOverride(inSettings);

    public static float GetMassOverride(this JPH.RagdollSettings.Const_Part inSettings) => JPH.Const_JoltHelpers.BodyCreationSettingsGetMassOverride(inSettings);

    public static void HeightFieldSettingsSetHeightSamples(this JPH.HeightFieldShapeSettings inSettings, float? inSamples, uint inCount) => JPH.Const_JoltHelpers.HeightFieldSettingsSetHeightSamples(inSettings, inSamples, inCount);

    public static void HeightFieldSettingsResizeHeightSamples(this JPH.HeightFieldShapeSettings inSettings, uint inCount, float inFillValue) => JPH.Const_JoltHelpers.HeightFieldSettingsResizeHeightSamples(inSettings, inCount, inFillValue);

    public static void HeightFieldSettingsSetHeightSampleAt(this JPH.HeightFieldShapeSettings inSettings, uint inIndex, float inValue) => JPH.Const_JoltHelpers.HeightFieldSettingsSetHeightSampleAt(inSettings, inIndex, inValue);

    public static uint HeightFieldSettingsGetHeightSamplesCount(this JPH.Const_HeightFieldShapeSettings inSettings) => JPH.Const_JoltHelpers.HeightFieldSettingsGetHeightSamplesCount(inSettings);

    public static float HeightFieldSettingsGetHeightSample(this JPH.Const_HeightFieldShapeSettings inSettings, uint inIndex) => JPH.Const_JoltHelpers.HeightFieldSettingsGetHeightSample(inSettings, inIndex);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_Shape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_BoxShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_CapsuleShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_CompoundShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_ConvexHullShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_ConvexShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_CylinderShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_DecoratedShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_EmptyShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_HeightFieldShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_MeshShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_MutableCompoundShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_OffsetCenterOfMassShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_PlaneShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_RotatedTranslatedShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_ScaledShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_SoftBodyShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_SphereShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_StaticCompoundShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_TaperedCapsuleShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_TaperedCylinderShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static JPH.Vec3 HeightFieldShapeGetPosition(this JPH.Const_TriangleShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeGetPosition(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_Shape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_BoxShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_CapsuleShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_CompoundShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_ConvexHullShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_ConvexShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_CylinderShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_DecoratedShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_EmptyShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_HeightFieldShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_MeshShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_MutableCompoundShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_OffsetCenterOfMassShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_PlaneShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_RotatedTranslatedShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_ScaledShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_SoftBodyShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_SphereShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_StaticCompoundShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_TaperedCapsuleShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_TaperedCylinderShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static bool HeightFieldShapeIsNoCollision(this JPH.Const_TriangleShape inShape, uint inX, uint inY) => JPH.Const_JoltHelpers.HeightFieldShapeIsNoCollision(inShape, inX, inY);

    public static void SoftBodySettingsAddVertex(this JPH.SoftBodySharedSettings inSettings, JPH.SoftBodySharedSettings.Const_Vertex inVertex) => JPH.Const_JoltHelpers.SoftBodySettingsAddVertex(inSettings, inVertex);

    public static uint SoftBodySettingsGetVertexCount(this JPH.Const_SoftBodySharedSettings inSettings) => JPH.Const_JoltHelpers.SoftBodySettingsGetVertexCount(inSettings);

    public static uint SoftBodySettingsGetFaceCount(this JPH.Const_SoftBodySharedSettings inSettings) => JPH.Const_JoltHelpers.SoftBodySettingsGetFaceCount(inSettings);

    public static uint SoftBodySettingsGetFaceVertex(this JPH.Const_SoftBodySharedSettings inSettings, uint inFaceIndex, uint inVertexSlot) => JPH.Const_JoltHelpers.SoftBodySettingsGetFaceVertex(inSettings, inFaceIndex, inVertexSlot);

    public static void SoftBodySettingsAddRodStretchShear(this JPH.SoftBodySharedSettings inSettings, uint inVertex1, uint inVertex2) => JPH.Const_JoltHelpers.SoftBodySettingsAddRodStretchShear(inSettings, inVertex1, inVertex2);

    public static void SoftBodySettingsAddRodBendTwist(this JPH.SoftBodySharedSettings inSettings, uint inRod1, uint inRod2) => JPH.Const_JoltHelpers.SoftBodySettingsAddRodBendTwist(inSettings, inRod1, inRod2);

    public static uint SoftBodySettingsGetRodStretchShearCount(this JPH.Const_SoftBodySharedSettings inSettings) => JPH.Const_JoltHelpers.SoftBodySettingsGetRodStretchShearCount(inSettings);

    public static uint SoftBodySettingsGetRodStretchShearVertex(this JPH.Const_SoftBodySharedSettings inSettings, uint inIndex, uint inSlot) => JPH.Const_JoltHelpers.SoftBodySettingsGetRodStretchShearVertex(inSettings, inIndex, inSlot);

    public static uint SoftBodySettingsGetRodBendTwistCount(this JPH.Const_SoftBodySharedSettings inSettings) => JPH.Const_JoltHelpers.SoftBodySettingsGetRodBendTwistCount(inSettings);

    public static void SoftBodySettingsSetRodStretchShearCompliance(this JPH.SoftBodySharedSettings inSettings, uint inIndex, float inCompliance) => JPH.Const_JoltHelpers.SoftBodySettingsSetRodStretchShearCompliance(inSettings, inIndex, inCompliance);

    public static void SoftBodySettingsSetRodBendTwistCompliance(this JPH.SoftBodySharedSettings inSettings, uint inIndex, float inCompliance) => JPH.Const_JoltHelpers.SoftBodySettingsSetRodBendTwistCompliance(inSettings, inIndex, inCompliance);

    public static void SoftBodySettingsAddSkinned(this JPH.SoftBodySharedSettings inSettings, uint inVertex, float inMaxDistance, float inBackStopDistance, float inBackStopRadius) => JPH.Const_JoltHelpers.SoftBodySettingsAddSkinned(inSettings, inVertex, inMaxDistance, inBackStopDistance, inBackStopRadius);

    public static void SoftBodySettingsAddInvBind(this JPH.SoftBodySharedSettings inSettings, uint inJointIndex, JPH.Const_Mat44 inInvBind) => JPH.Const_JoltHelpers.SoftBodySettingsAddInvBind(inSettings, inJointIndex, inInvBind);

    public static void SoftBodySettingsAddSkinnedWithWeights(this JPH.SoftBodySharedSettings inSettings, uint inVertex, float inMaxDistance, float inBackStopDistance, float inBackStopRadius, uint inJoint0, float inWeight0, uint inJoint1, float inWeight1) => JPH.Const_JoltHelpers.SoftBodySettingsAddSkinnedWithWeights(inSettings, inVertex, inMaxDistance, inBackStopDistance, inBackStopRadius, inJoint0, inWeight0, inJoint1, inWeight1);

    public static void SoftBodySettingsSetAllEdgeCompliance(this JPH.SoftBodySharedSettings inSettings, float inCompliance) => JPH.Const_JoltHelpers.SoftBodySettingsSetAllEdgeCompliance(inSettings, inCompliance);

    public static uint GetVertexCount(this JPH.Const_SoftBodyManifold inManifold) => JPH.Const_JoltHelpers.SoftBodyManifoldGetVertexCount(inManifold);

    public static JPH.Const_SoftBodyVertex GetVertex(this JPH.Const_SoftBodyManifold inManifold, uint inIndex) => JPH.Const_JoltHelpers.SoftBodyManifoldGetVertex(inManifold, inIndex);

    public static uint GetSoftBodyVertexCount(this JPH.Const_Body inBody) => JPH.Const_JoltHelpers.BodyGetSoftBodyVertexCount(inBody);

    public static JPH.Vec3 GetSoftBodyVertexPosition(this JPH.Const_Body inBody, uint inIndex) => JPH.Const_JoltHelpers.BodyGetSoftBodyVertexPosition(inBody, inIndex);

    public static void SetSoftBodyVertexPosition(this JPH.Body inBody, uint inIndex, JPH.Const_Vec3 inPosition) => JPH.Const_JoltHelpers.BodySetSoftBodyVertexPosition(inBody, inIndex, inPosition);

    public static float GetInverseMass(this JPH.Const_Body inBody) => JPH.Const_JoltHelpers.BodyGetInverseMass(inBody);

    public static uint GetSoftBodyVertexCount(this JPH.Const_PhysicsSystem inSystem, in JPH.BodyID inBodyID) => JPH.Const_JoltHelpers.PhysicsSystemGetSoftBodyVertexCount(inSystem, inBodyID);

    public static JPH.Vec3 GetSoftBodyVertexPosition(this JPH.Const_PhysicsSystem inSystem, in JPH.BodyID inBodyID, uint inIndex) => JPH.Const_JoltHelpers.PhysicsSystemGetSoftBodyVertexPosition(inSystem, inBodyID, inIndex);

    public static void SetShape(this JPH.CharacterBaseSettings inSettings, JPH.Const_Shape? inShape) => JPH.Const_JoltHelpers.CharacterBaseSettingsSetShape(inSettings, inShape);

    public static void SetShape(this JPH.CharacterSettings inSettings, JPH.Const_Shape? inShape) => JPH.Const_JoltHelpers.CharacterBaseSettingsSetShape(inSettings, inShape);

    public static void SetShape(this JPH.CharacterVirtualSettings inSettings, JPH.Const_Shape? inShape) => JPH.Const_JoltHelpers.CharacterBaseSettingsSetShape(inSettings, inShape);

    public static void SetInnerBodyShape(this JPH.CharacterVirtualSettings inSettings, JPH.Const_Shape? inShape) => JPH.Const_JoltHelpers.CharacterVirtualSettingsSetInnerBodyShape(inSettings, inShape);

    public static void SetSkeleton(this JPH.RagdollSettings inSettings, JPH.Skeleton? inSkeleton) => JPH.Const_JoltHelpers.RagdollSettingsSetSkeleton(inSettings, inSkeleton);

    public static JPH.Skeleton? GetSkeleton(this JPH.Const_RagdollSettings inSettings) => JPH.Const_JoltHelpers.RagdollSettingsGetSkeleton(inSettings);

    public static void AddPart(this JPH.RagdollSettings inSettings, JPH.RagdollSettings.Const_Part inPart) => JPH.Const_JoltHelpers.RagdollSettingsAddPart(inSettings, inPart);

    public static uint GetPartCount(this JPH.Const_RagdollSettings inSettings) => JPH.Const_JoltHelpers.RagdollSettingsGetPartCount(inSettings);

    public static JPH.RagdollSettings.Const_Part GetPart(this JPH.Const_RagdollSettings inSettings, uint inIndex) => JPH.Const_JoltHelpers.RagdollSettingsGetPart(inSettings, inIndex);

    public static JPH.RagdollSettings.Part GetMutablePart(this JPH.RagdollSettings inSettings, uint inIndex) => JPH.Const_JoltHelpers.RagdollSettingsGetMutablePart(inSettings, inIndex);

    public static void RagdollSettingsPartSetToParent(this JPH.RagdollSettings.Part inPart, JPH.TwoBodyConstraintSettings? inConstraint) => JPH.Const_JoltHelpers.RagdollSettingsPartSetToParent(inPart, inConstraint);

    public static void Initialize(this JPH.SkeletonMapper ioMapper, JPH.Const_SkeletonPose inPose1, JPH.Const_SkeletonPose inPose2) => JPH.Const_JoltHelpers.SkeletonMapperInitialize(ioMapper, inPose1, inPose2);

    public static void SetSpace(this JPH.DistanceConstraintSettings inSettings, byte inSpace) => JPH.Const_JoltHelpers.DistanceConstraintSettingsSetSpace(inSettings, inSpace);

    public static uint AddJoint(this JPH.Skeleton inSkeleton, byte? inName) => JPH.Const_JoltHelpers.SkeletonAddJoint(inSkeleton, inName);

    public static uint AddJointWithParentName(this JPH.Skeleton inSkeleton, byte? inName, byte? inParentName) => JPH.Const_JoltHelpers.SkeletonAddJointWithParentName(inSkeleton, inName, inParentName);

    public static uint AddJointWithParentIndex(this JPH.Skeleton inSkeleton, byte? inName, int inParentIndex) => JPH.Const_JoltHelpers.SkeletonAddJointWithParentIndex(inSkeleton, inName, inParentIndex);

    public static int GetJointIndex(this JPH.Const_Skeleton inSkeleton, byte? inName) => JPH.Const_JoltHelpers.SkeletonGetJointIndex(inSkeleton, inName);
}
