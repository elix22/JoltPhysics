# JoltPhysics C# Bindings — Test Coverage

This document tracks which native Jolt C++ unit tests have been ported to C#, which are
partially covered, and which are still missing.

**Regenerating the bindings:**

The C and C# binding sources under `deps/JoltPhysics/bindings/c/` and
`deps/JoltPhysics/bindings/csharp/src/` are **machine-generated** — never edit them by hand.
To regenerate after changing `generate.sh` or the upstream Jolt headers:

```bash
# From the repo root (mrbind must already be built):
bash deps/JoltPhysics/bindings/generate.sh
```

The script runs the full pipeline in order:
1. **mrbind** — parses the combined Jolt C++ input header into `bindings/tmp/parse_result.json`
2. **mrbind_gen_c** — generates the C header + source files into `bindings/c/`
3. **mrbind_gen_csharp** — generates the C# source files into `bindings/csharp/src/`

After regeneration, rebuild the native `cjolt` shared library using the platform build script
(e.g. `deps/JoltPhysics/scripts/build-cjolt-macos.sh`) before running tests.

**Running the tests:**

```bash
cd deps/JoltPhysics/bindings/csharp/tests
./run_tests.sh
```

`run_tests.sh` auto-detects the OS/architecture, sets `DYLD_LIBRARY_PATH` / `LD_LIBRARY_PATH` /
`PATH` to the pre-built `cjolt` native library under `deps/JoltPhysics/libs/`, and then calls
`dotnet test`. Do **not** call `dotnet test` directly — the native library will not be found.

**Legend:**
- ✅ Ported — C# test file exists with meaningful coverage
- ⚠️ Partial — Some tests ported, coverage is incomplete
- ❌ Not ported — No C# tests yet
- 🚫 Not applicable — Tests cover internal C++ details not exposed by the C/C# binding

---

## Math Tests

| Native Test File | C# Test File | Status | Tests | Notes |
|---|---|---|---|---|
| `UnitTests/Math/UVec4Tests.cpp` | `Tests_UVec4.cs` | ✅ | 29 | Full coverage: construct, getters, ==, !=, setters, SZero, SReplicate, SMin, SMax, SEquals, GetTrues, CountTrues, TestAllTrue/AnyTrue, TestAllXYZTrue/AnyXYZTrue, SSelect, SOr/SXor/SAnd/SNot, +/-/*, AddAssign, SplatX/Y/Z/W, Swizzle |
| `UnitTests/Math/DVec3Tests.cpp` | `Tests_DVec3.cs` | ✅ | 49 | Full coverage: SZero/SAxis/SNaN, construct, index, ==, !=, SetX/Y/Z/Component/Set, Vec4 cast, ToVec3Round, SReplicate, SMin/Max/Clamp, GetTrues, TestAnyTrue/AllTrue, SEquals/Less/LessOrEqual/Greater/GreaterOrEqual, SFusedMultiplyAdd, SSelect (CTrue/CFalse), IsClose/IsNormalized/IsNearZero/IsNaN, negate, +/-/*// (DVec3 and scalar), MulAssign/DivAssign/AddAssign/SubAssign, Reciprocal, Abs, Dot, LengthSq, Length, Normalized, Cross, Sqrt, GetSign |
| `UnitTests/Math/BVec16Tests.cpp` | `Tests_BVec16.cs` | ✅ | 14 | Full coverage: construct (16 bytes), index, ==, !=, SZero, SReplicate, SEquals+GetTrues, TestAnyTrue, TestAllTrue, SOr, SXor, SAnd, SNot |
| `UnitTests/Math/DMat44Tests.cpp` | `Tests_DMat44.cs` | ✅ | 22 | Full coverage: SZero, SIdentity, construct from cols, GetColumn4, SScale, GetRotation/SetRotation, SRotation, STranslation, SRotationTranslation, DMat44*Mat44, DMat44*DMat44, *Vec3/*DVec3 (point), Multiply3x3 (Vec3, DVec3), SetAxisX, SetTranslation, InversedRotationTranslation, IsClose, ==, != |
| `UnitTests/Math/Vec3Tests.cpp` | `Tests_Vec3Extended.cs` | ✅ | 32 | Extended Vec3 coverage beyond Tests_Math.cs |
| `UnitTests/Math/Vec4Tests.cpp` | `Tests_Vec4.cs` | ✅ | 45 | Full Vec4 coverage |
| `UnitTests/Math/Mat44Tests.cpp` | `Tests_Mat44.cs` | ✅ | 23 | Mat44 operations |
| `UnitTests/Math/QuatTests.cpp` | `Tests_QuatExtended.cs` + `Tests_QuatOperators.cs` | ✅ | 41 | Quaternion math and operators |
| `UnitTests/Math/MathTests.cpp` | `Tests_Math.cs` | ⚠️ | 12 | Basic Vec3/Quat; does not cover all of MathTests |
| `UnitTests/Math/VectorTests.cpp` | `Tests_Vector2Matrix.cs` | ⚠️ | 26 | Vector_2 (15 tests): construct/copy/+/-/*/÷/Dot/LengthSq/Length/Normalized/==; Matrix_2_2 (11 tests) covered by same file — see MatrixTests row |
| `UnitTests/Math/MatrixTests.cpp` | `Tests_Vector2Matrix.cs` | ⚠️ | — | Matrix_2_2 (11 tests): SZero/SIdentity/construct/SetRow/GetRow/==/*/Vec multiply; shared with VectorTests.cpp coverage in Tests_Vector2Matrix.cs |
| `UnitTests/Math/EigenValueSymmetricTests.cpp` | — | 🚫 | — | Internal numerical solver; not exposed via C bindings |
| `UnitTests/Math/HalfFloatTests.cpp` | — | 🚫 | — | Half-float conversion; not in binding API |
| `UnitTests/Math/TrigonometryTests.cpp` | — | 🚫 | — | Internal trig lookup tables |

---

## Geometry Tests

| Native Test File | C# Test File | Status | Tests | Notes |
|---|---|---|---|---|
| `UnitTests/Geometry/PlaneTests.cpp` | `Tests_Plane.cs` | ✅ | 15 | Full coverage: SFromPointAndNormal, SignedDistance (above/below/on), GetTransformed, SIntersectPlanes (found/not found), ProjectPointOnPlane, Offset, SFromPointsCCW |
| `UnitTests/Geometry/AABoxTests.cpp` | `Tests_AABox.cs` | ✅ | 20 | Axis-aligned bounding box operations |
| `UnitTests/Geometry/ClosestPointTests.cpp` | — | ❌ | 0 | ClosestPoint utilities not fully exposed |
| `UnitTests/Geometry/ConvexHullBuilderTest.cpp` | — | 🚫 | — | Internal builder; not in binding API |
| `UnitTests/Geometry/EllipseTest.cpp` | `Tests_Ellipse.cs` | ✅ | 11 | Ellipse construction, IsInside (inside/outside/boundary), GetClosestPoint on X/Y axis, GetNormal (non-normalized) |
| `UnitTests/Geometry/EPATests.cpp` | — | 🚫 | — | EPA solver internals; not exposed |
| `UnitTests/Geometry/GJKTests.cpp` | — | 🚫 | — | GJK collision internals; not exposed |
| `UnitTests/Geometry/RayAABoxTests.cpp` | — | ❌ | 0 | Ray-AABox intersections not yet bound |

---

## Physics Tests

| Native Test File | C# Test File | Status | Tests | Notes |
|---|---|---|---|---|
| `UnitTests/Physics/PhysicsTests.cpp` | `Tests_Physics.cs` | ⚠️ | 10 | Basic simulation: add body, step, position check; doesn't cover all scenarios |
| `UnitTests/Physics/ShapeTests.cpp` | `Tests_Shapes.cs` + `Tests_ShapeGeometry.cs` | ⚠️ | 38 | Shape creation and geometry queries; volume/surface area not covered for all shapes |
| `UnitTests/Physics/MutableCompoundShapeTests.cpp` | `Tests_MutableCompoundShape.cs` | ✅ | 14 | Mutable compound shape operations |
| `UnitTests/Physics/OffsetCenterOfMassShapeTests.cpp` | `Tests_OffsetCOM.cs` | ✅ | 10 | Offset center of mass shape |
| `UnitTests/Physics/CollisionGroupTests.cpp` | `Tests_CollisionGroupAndSettings.cs` | ✅ | 21 | CollisionGroup defaults + round-trips, CanCollide (no filter, different groups), PhysicsSettings defaults + round-trips, GetPhysicsSettings/SetPhysicsSettings integration |
| `UnitTests/Physics/ObjectLayerPairFilterTableTests.cpp` | `Tests_ObjectLayers.cs` | ⚠️ | 9 | ObjectLayerPairFilterTable; mask filter not covered |
| `UnitTests/Physics/ObjectLayerPairFilterMaskTests.cpp` | `Tests_ObjectLayerPairFilterMask.cs` | ✅ | 10 | ObjectLayerPairFilterMask lifecycle, CNumBits/CMask constants, SGetObjectLayer/SGetGroup/SGetMask static helpers, ShouldCollide logic |
| `UnitTests/Physics/BroadPhaseTests.cpp` | `Tests_PhysicsQuery.cs` + `Tests_CastResult.cs` | ⚠️ | 29 | GetBroadPhaseQuery / GetNarrowPhaseQuery, GetBounds after body add, gravity round-trip, WereBodiesInContact; BroadPhaseCastResult + RayCastResult result struct defaults, construction, Reset, GetEarlyOutFraction; full broadphase cast execution not yet tested |
| `UnitTests/Physics/CastShapeTests.cpp` | — | ❌ | 0 | Shape cast queries not yet tested |
| `UnitTests/Physics/CollideShapeTests.cpp` | `Tests_CollisionSettings.cs` | ⚠️ | 22 | Enum values (EBackFaceMode/EActiveEdgeMode/ECollectFacesMode); RayCastSettings defaults + round-trips; CollideSettingsBase defaults + round-trips; CollideShapeSettings defaults + round-trips; CollideShapeResult GetEarlyOutFraction/Reversed; ShapeCastSettings defaults + round-trips; ShapeCastResult GetEarlyOutFraction; actual CollideShape query execution not yet tested |
| `UnitTests/Physics/RayShapeTests.cpp` | `Tests_RayCastQuery.cs` | ⚠️ | 13 | RRayCast default + parameterized construction; NarrowPhaseQuery.CastRay miss (empty world) + hit (fraction in range, BodyID matches) + side miss; BodyInterface.GetTransformedShape (NoCrash, BodyID, position); TransformedShape.GetWorldSpaceBounds, CastRay hit + miss; ShapeCast not yet tested |
| `UnitTests/Physics/TransformedShapeTests.cpp` | `Tests_RayCastQuery.cs` | ⚠️ | — | GetTransformedShape/CastRay/GetWorldSpaceBounds covered (see RayShapeTests.cpp row) |
| `UnitTests/Physics/HeightFieldShapeTests.cpp` | `Tests_HeightFieldShape.cs` | ⚠️ | 12 | HeightFieldShapeSettings field defaults + round-trips; CalculateBitsPerSampleForError requires mHeightSamples (no sample-array constructor in bindings — not testable) |
| `UnitTests/Physics/DistanceConstraintTests.cpp` | `Tests_Constraints.cs` + `Tests_DistanceConstraint.cs` | ✅ | 20 | DistanceConstraintSettings defaults + round-trips, direct construction, GetMinDistance/MaxDistance, SetDistance, GetEnabled/SetEnabled, lambda after simulation |
| `UnitTests/Physics/HingeConstraintTests.cpp` | `Tests_HingeConstraint.cs` | ✅ | 11 | Settings field round-trips (limits, axes, points), constraint creation and simulation |
| `UnitTests/Physics/FixedConstraintTests.cpp` | `Tests_FixedConstraint.cs` + `Tests_Constraints.cs` | ✅ | 17 | Settings defaults + round-trips (AutoDetectPoint, Enabled, Priority, UserData, VelocitySteps), GetBody1/2, GetEnabled/SetEnabled, GetConstraintPriority/Set, lambda after simulation |
| `UnitTests/Physics/SliderConstraintTests.cpp` | `Tests_SliderConstraint.cs` | ✅ | 15 | SliderConstraintSettings defaults + round-trips, HasLimits, GetLimitsMin/Max, direct construction, simulation |
| `UnitTests/Physics/SixDOFConstraintTests.cpp` | `Tests_SixDOFConstraint.cs` | ✅ | 14 | SixDOFConstraintSettings defaults + EAxis enum, GetTranslationLimitsMin/Max, MakeFixedAxis/IsFixedAxis, direct construction, simulation |
| `UnitTests/Physics/PathConstraintTests.cpp` | — | ❌ | 0 | Path constraint not yet tested |
| `UnitTests/Physics/ContactListenerTests.cpp` | `Tests_ContactSettings.cs`, `Tests_ContactManifold.cs` | ⚠️ | 35 | ContactSettings (23): defaults mInvMassScale1/2=1, mInvInertiaScale1/2=1, mCombinedFriction/mCombinedRestitution=0, surface velocity defaults, round-trips, mIsSensor, ElementwiseConstructor; ContactManifold (12): default construct, mPenetrationDepth/mSubShapeID1/2 defaults + mutable round-trips, copy construct, SwapShapes; actual contact-listener callback wiring not yet tested |
| `UnitTests/Physics/SensorTests.cpp` | `Tests_Bodies.cs` + `Tests_BodyProperties.cs` | ⚠️ | 3 | SensorBody_DoesNotBlockDynamicBody; IsSensor getter for sensor and non-sensor bodies |
| `UnitTests/Physics/ActiveEdgesTests.cpp` | — | 🚫 | — | Internal mesh active-edge logic |
| `UnitTests/Physics/ConvexVsTrianglesTest.cpp` | — | 🚫 | — | Internal convex-triangle collision |
| `UnitTests/Physics/EstimateCollisionResponseTest.cpp` | — | ❌ | 0 | Not yet tested |
| `UnitTests/Physics/MotionQualityLinearCastTests.cpp` | `Tests_MotionQuality.cs` | ✅ | 11 | EMotionQuality enum values, GetMotionQuality/SetMotionQuality on BodyInterface, mMotionQuality on BodyCreationSettings |
| `UnitTests/Physics/SubShapeIDTest.cpp` | — | 🚫 | — | SubShapeID internals; complex compound shape paths |
| `UnitTests/Physics/TaperedCylinderShapeTests.cpp` | `Tests_TaperedCylinder.cs` | ✅ | 12 | Settings field round-trips (parameterized constructor, mutable fields, SetDensity), dynamic body creation and simulation |
| `UnitTests/Physics/CharacterVirtualTests.cpp` | `Tests_CharacterVirtualSettings.cs` + `Tests_CharacterVirtual.cs` | ⚠️ | 41 | CharacterVirtualSettings defaults + round-trips; CharacterContactSettings defaults + round-trips; CharacterVirtual construction/SetPosition/GetPosition/SetRotation/GetRotation/SetLinearVelocity/GetLinearVelocity/SetCharacterLayer/GetCharacterLayer/GetInnerBodyID/GetWorldTransform/GetCenterOfMassPosition/GetCenterOfMassTransform/GetActiveBodyID; Update step no-crash; full simulation edge-cases not yet tested |
| `UnitTests/Physics/SoftBodyTests.cpp` | `Tests_SoftBody.cs` | ⚠️ | 42 | SoftBodyCreationSettings (20 tests): field defaults + round-trips (mNumIterations/mLinearDamping/mMaxLinearVelocity/mRestitution/mFriction/mPressure/mGravityFactor/mVertexRadius/mUpdatePosition/mMakeRotationIdentity/mAllowSleeping/mFacesDoubleSided/mUserData/mObjectLayer); SoftBodySharedSettings (7 tests): construct/GetRefCount/AddRef/SetEmbedded/CalculateEdgeLengths/Optimize; inner Vertex (5)/Edge (5)/Face (5); full soft-body simulation not yet tested |
| `UnitTests/Physics/WheeledVehicleTests.cpp` | — | ❌ | 0 | WheeledVehicle not yet bound |
| `UnitTests/Physics/ShapeFilterTests.cpp` | `Tests_ShapeFilter.cs` | ✅ | 9 | Const/mutable lifecycle, mBodyID2 default-invalid, ShouldCollide default pass-through (2-arg and 4-arg), use alongside physics system |
| `UnitTests/Physics/PhysicsDeterminismTests.cpp` | `Tests_PhysicsDeterminism.cs` | ⚠️ | 5 | TwoIdenticalRuns_ProduceSamePosition (60 steps), SingleStep, ManySteps (180 steps) — all bit-exact; mDeterministicSimulation default=true + can disable; actual per-constraint determinism not verified |
| `UnitTests/Physics/PhysicsStepListenerTests.cpp` | `Tests_PhysicsStepListener.cs` | ⚠️ | 9 | PhysicsStepListenerContext default/parameterized/copy construct, mDeltaTime/mIsFirstStep/mIsLastStep/mPhysicsSystem field round-trips; context referencing a real PhysicsSystem; PhysicsStepListener is pure virtual — actual OnStep callback not testable without virtual dispatch wiring |

---

## Other C# Test Files (no direct native counterpart)

| C# Test File | Tests | Description |
|---|---|---|
| `Tests_Bodies.cs` | 16 | Body creation, activation, property queries |
| `Tests_BodyProperties.cs` | 15 | GravityFactor (default/set/zero), MotionType, IsSensor, ObjectLayer, UserData, SetPosition, GetPositionAndRotation, GetWorldTransform |
| `Tests_HingeConstraint.cs` | 11 | HingeConstraintSettings field round-trips, constraint creation and simulation |
| `Tests_PointConstraint.cs` | 7 | PointConstraintSettings field round-trips, constraint creation and two-body simulation |
| `Tests_TaperedCylinder.cs` | 12 | TaperedCylinderShapeSettings fields, dynamic body creation and simulation |
| `Tests_ShapeFilter.cs` | 9 | ShapeFilter lifecycle, mBodyID2, ShouldCollide default pass-through |
| `Tests_FixedConstraint.cs` | 14 | FixedConstraintSettings defaults + round-trips, GetBody1/2, GetEnabled/SetEnabled, GetConstraintPriority/Set, lambda after simulation |
| `Tests_DistanceConstraint.cs` | 13 | DistanceConstraintSettings defaults, direct construction, GetMinDistance/MaxDistance, SetDistance, GetEnabled/SetEnabled, lambda after simulation |
| `Tests_Velocity.cs` | 14 | Default/set/add linear velocity, AddImpulse, default/set angular velocity, GetLinearAndAngularVelocity, friction/restitution/maxV defaults + round-trips, body moves with initial velocity |
| `Tests_CapsuleShape.cs` | 13 | CapsuleShape construction, GetRadius, GetHalfHeightOfCylinder, GetLocalBounds, GetInnerRadius, GetVolume, SetDensity; CapsuleShapeSettings IsValid/IsSphere; dynamic body simulation |
| `Tests_DecoratedShapes.cs` | 11 | RotatedTranslatedShape (construction, GetPosition, GetRotation, GetLocalBounds, simulation); ScaledShape (construction, GetScale, GetLocalBounds, size comparison, static body) |
| `Tests_HeightFieldShape.cs` | 12 | HeightFieldShapeSettings field defaults (SampleCount, BlockSize, BitsPerSample, MinHeightValue, MaxHeightValue, ActiveEdgeCosThreshold) and round-trips |
| `Tests_RefCounting.cs` | 8 | Ref-counted shape/settings lifetime |
| `Tests_EmptyShape.cs` | 15 | EmptyShapeSettings defaults, mCenterOfMass/mUserData round-trips; EmptyShape construction, GetLocalBounds (zero-size), GetInnerRadius/GetVolume (zero), MustBeStatic, SetUserData/GetUserData, static body creation |
| `Tests_StaticCompoundShape.cs` | 13 | StaticCompoundShapeSettings defaults, mUserData round-trip, AddShape via CompoundShapeSettings upcast; StaticCompoundShape default construct/GetNumSubShapes/GetLocalBounds/MustBeStatic; static body creation, GetNumBodies increment/decrement, GetShape InnerRadius and Volume |
| `Tests_SliderConstraint.cs` | 15 | SliderConstraintSettings field round-trips, HasLimits, GetLimitsMin/Max, direct construction, simulation |
| `Tests_SixDOFConstraint.cs` | 14 | SixDOFConstraintSettings defaults + EAxis enum, GetTranslationLimitsMin/Max, MakeFixedAxis/IsFixedAxis, direct construction, simulation |
| `Tests_ObjectLayerPairFilterMask.cs` | 10 | ObjectLayerPairFilterMask lifecycle, CNumBits/CMask constants, SGetObjectLayer/SGetGroup/SGetMask static helpers, ShouldCollide logic |
| `Tests_MotionQuality.cs` | 11 | EMotionQuality enum values, GetMotionQuality/SetMotionQuality on BodyInterface, mMotionQuality on BodyCreationSettings |
| `Tests_CylinderShape.cs` | 19 | CylinderShapeSettings defaults + field round-trips (mHalfHeight, mRadius, mConvexRadius, mDensity); CylinderShape direct construction, GetHalfHeight, GetRadius, GetLocalBounds (height + width), GetInnerRadius, GetVolume, GetDensity, SetDensity; dynamic body simulation |
| `Tests_Float2Float3Float4.cs` | 22 | Float2 (constructor, x/y, ==, !=, Equals); Float3 (constructor, x/y/z, indexer, ==, !=, copy); Float4 (constructor, x/y/z/w, ==, !=, Equals) |
| `Tests_Double3.cs` | 11 | Double3 (default/parameterized/copy constructor, x/y/z fields, indexer, ==, !=, Equals) |
| `Tests_PhysicsQuery.cs` | 15 | GetGravity default/round-trip/zero; GetNumBodies init/add/remove; GetMaxBodies; WereBodiesInContact (separated and after collision); GetBroadPhaseQuery/GetNarrowPhaseQuery not-null; BroadPhaseQuery.GetBounds before/after body; activation/contact listener defaults |
| `Tests_TriangleShape.cs` | 19 | TriangleShapeSettings defaults + field round-trips (mV1/V2/V3, mConvexRadius, mDensity, SetDensity); TriangleShape direct construct, MustBeStatic (returns false), GetLocalBounds, GetInnerRadius, GetVolume, GetDensity, SetDensity; static body creation, dynamic body creation, dynamic body in compound falls due to gravity |
| `Tests_BoxShape.cs` | 19 | BoxShapeSettings defaults + field round-trips (mHalfExtent, mConvexRadius, mDensity, SetDensity); BoxShape direct construct, GetHalfExtent, GetConvexRadius, GetLocalBounds (2× halfExtent), GetInnerRadius, GetVolume (unit box = 8), MustBeStatic (false), GetDensity, SetDensity; static body creation, dynamic body falls due to gravity |
| `Tests_SphereShape.cs` | 16 | SphereShapeSettings defaults + field round-trips (mRadius, mDensity, SetDensity); SphereShape direct construct, GetRadius, GetLocalBounds (diameter = 2r), GetInnerRadius (= radius), GetVolume (≈ 4π/3 for r=1), MustBeStatic (false), GetDensity, SetDensity; dynamic body falls due to gravity |
| `Tests_BodyInterface.cs` | 15 | IsAdded (before/after AddBody); SetObjectLayer round-trip; GetMaxLinearVelocity default + SetMaxLinearVelocity; GetMaxAngularVelocity default + SetMaxAngularVelocity; GetUseManifoldReduction default + SetUseManifoldReduction; GetPointVelocity (static body = zero); SetRotation; GetCenterOfMassTransform translation; GetMotionQuality default = Discrete; CreateBodyWithoutID + AssignBodyID; ResetSleepTimer |
| `Tests_Body.cs` | 16 | Body type predicates: IsRigidBody (dynamic), IsDynamic, IsStatic, IsKinematic (false for dynamic), CanBeKinematicOrDynamic (true/false); GetShape non-null; GetInverseInertia non-zero for dynamic body (only valid on dynamic/kinematic); GetWorldSpaceBounds valid; IsInBroadPhase false before add / true after add; GetInverseCenterOfMassTransform valid; GetPosition matches creation coordinates; GetFriction/GetRestitution ≥ 0; GetAllowSleeping default true |
| `Tests_ConstraintBase.cs` | 12 | Constraint base: GetNumVelocityStepsOverride/SetNumVelocityStepsOverride round-trip (default=0); GetNumPositionStepsOverride/SetNumPositionStepsOverride round-trip (default=0); GetEnabled default true; SetEnabled false; IsActive true with active bodies after step; ResetWarmStart no-crash; TwoBodyConstraint: GetBody1/GetBody2 non-null; GetConstraintToBody1Matrix/GetConstraintToBody2Matrix valid Mat44 |
| `Tests_MeshShapeSettings.cs` | 9 | MeshShapeSettings default construct; mMaxTrianglesPerLeaf default=8 + round-trip; mActiveEdgeCosThresholdAngle default≈0.996195 + round-trip; mPerTriangleUserData default=false + round-trip; mBuildQuality default=FavorRuntimePerformance + round-trip |
| `Tests_BodyCreationSettings.cs` | 29 | BodyCreationSettings: default construct; mMotionType default=Dynamic + round-trip; HasMassProperties (Dynamic=true, Static=false, Static+mAllowDynamicOrKinematic=true); mIsSensor/mAllowSleeping/mApplyGyroscopicForce/mUseManifoldReduction/mCollideKinematicVsNonDynamic/mEnhancedInternalEdgeRemoval defaults; mFriction=0.2/mRestitution=0/mLinearDamping=0.05/mAngularDamping=0.05/mMaxLinearVelocity=500/mGravityFactor=1/mInertiaMultiplier=1 defaults; mNumVelocityStepsOverride=0/mNumPositionStepsOverride=0; mMotionQuality=Discrete; field round-trips (mFriction, mRestitution, mGravityFactor, mUserData, mAllowSleeping, mInertiaMultiplier); constructor with shape |
| `Tests_ConvexHullShape.cs` | 24 | ConvexHullShapeSettings: default construct; mMaxConvexRadius=0/mMaxErrorConvexRadius=0.05/mHullTolerance=0.001/mDensity=1000/mUserData=0 defaults; field round-trips (mMaxConvexRadius, mMaxErrorConvexRadius, mHullTolerance, mDensity, mUserData); SetDensity; CMaxPointsInHull/CGetTrianglesMinTrianglesRequested static consts; ConvexHullShape: default construct; GetNumPoints=0/GetNumFaces=0/GetDensity=1000/GetUserData=0/MustBeStatic=false/GetConvexRadius=0/GetInnerRadius=FLT_MAX on default-constructed; SetDensity/SetUserData round-trips |
| `Tests_MutableCompoundShape.cs` | 14 | MutableCompoundShapeSettings defaults; MutableCompoundShape construct/NumSubShapes, MustBeStatic (false), AddShape (index + count), RemoveShape, ModifyShape, GetLocalBounds (empty + with sphere), GetVolume/GetInnerRadius (with sphere), dynamic body simulation |
| `Tests_CollisionGroupAndSettings.cs` | 21 | CollisionGroup CInvalidGroup/CInvalidSubGroup/SInvalid constants; default construct + ID defaults; SetGroupID/SubGroupID round-trips; CanCollide (no filter, different groups); PhysicsSettings defaults (NumVelocitySteps=10, NumPositionSteps=2, AllowSleeping=true, DeterministicSimulation=true, Baumgarte≈0.2, ConstraintWarmStart=true); GetPhysicsSettings/SetPhysicsSettings integration round-trips |
| `Tests_BodyID.cs` | 19 | BodyID: CInvalidBodyID/CBroadPhaseBit/CMaxBodyIndex/CMaxSequenceNumber/CSequenceNumberShift constants; default construct IsInvalid/GetIndexAndSequenceNumber; BodyID(uint) GetIndex/GetSequenceNumber/GetIndexAndSequenceNumber/IsNotInvalid; BodyID(uint,byte) index+seq GetIndex/GetSequenceNumber/GetIndexAndSequenceNumber/IsNotInvalid; ==, !=, <, > operators; copy preserves value |
| `Tests_SubShapeID.cs` | 10 | SubShapeID: MaxBits==32 static constant; default construct NoCrash/IsEmpty/GetValue==0xFFFFFFFF; SetValue round-trip; SetValue(0) IsNotEmpty; SetValue(0xFFFFFFFF) IsEmpty; == same values; != different values; == both default |
| `Tests_BodyFilter.cs` | 13 | BodyFilter: default construct NoCrash; ShouldCollide returns true for any/invalid ID; IgnoreSingleBodyFilter: construct; ShouldCollide returns false for ignored ID/true for other/true for different seq-num; IgnoreMultipleBodiesFilter: default construct; ShouldCollide before ignore returns true; Reserve NoCrash; IgnoreBody ShouldCollide returns false; non-ignored returns true; multiple ignored all false; Clear resets ignore list |
| `Tests_CastResult.cs` | 14 | BroadPhaseCastResult: default construct (mBodyID.IsInvalid, mFraction>1); GetEarlyOutFraction==mFraction; construct with BodyID+fraction (mBodyID matches, mFraction matches, GetEarlyOutFraction); Reset restores mBodyID.IsInvalid+mFraction>1; copy construct preserves mBodyID+mFraction; RayCastResult: default construct (mBodyID.IsInvalid, mFraction>1, mSubShapeID2.IsEmpty) |
| `Tests_ContactSettings.cs` | 15 | ContactSettings: default construct NoCrash; mInvMassScale1/2=1.0 and mInvInertiaScale1/2=1.0 defaults; round-trips for mInvMassScale1/2 and mInvInertiaScale2; mIsSensor round-trips (set true/false); copy construct preserves mInvMassScale1/2; Const_ContactSettings: default construct NoCrash; mInvMassScale1=1.0 default |
| `Tests_CharacterVirtualSettings.cs` | 22 | CharacterVirtualSettings: default construct NoCrash; mMass=70/mMaxStrength=100/mPredictiveContactDistance=0.1/mMaxCollisionIterations=5/mMaxConstraintIterations=15/mCollisionTolerance=1e-3/mCharacterPadding=0.02/mMaxNumHits=256/mHitReductionCosMaxAngle=0.999/mPenetrationRecoverySpeed=1.0/mInnerBodyLayer=0/mEnhancedInternalEdgeRemoval=false/mMaxSlopeAngle=rad(50) defaults; round-trips for mMass/mMaxNumHits/mMaxCollisionIterations/mPenetrationRecoverySpeed; CharacterContactSettings: default construct; mCanPushCharacter=true/mCanReceiveImpulses=true defaults; round-trips for both |
| `Tests_CharacterID.cs` | 13 | CInvalidCharacterID==0xFFFFFFFFu; DefaultConstruct NoCrash/IsInvalid/GetValue==CInvalidCharacterID; CharacterID(999u) GetValue==999/IsNotInvalid; ==, !=, <, > operators; copy construct preserves value; GetHash same IDs same hash; Equals SameValue true |
| `Tests_SubShapeIDPair.cs` | 10 | DefaultConstruct NoCrash; Construct(BodyID(42),sub1,BodyID(99),sub2) GetBody1/2ID correct; GetSubShapeID1/2 values after SetValue; ==, != operators; copy construct preserves Body1ID; GetHash same pairs same hash; Equals SamePair true |
| `Tests_PhysicsMaterial.cs` | 7 | DefaultConstruct NoCrash; GetRefCount initially 1 (C binding calls AddRef); AddRef increments to 2; SetEmbedded adds cEmbedded (0x0ebedded) to refcount; SInternalGetRefCountOffset >= 0; Const_PhysicsMaterial default construct/GetRefCount==1 |
| `Tests_LayerTables.cs` | 12 | BroadPhaseLayer GetValue round-trip/==/!=/explicit byte cast/<; BroadPhaseLayerInterfaceTable GetNumBroadPhaseLayers/MapObjectToBroadPhaseLayer/GetBroadPhaseLayer round-trips; ObjectVsBroadPhaseLayerFilterTable construct NoCrash/ShouldCollide false (no collision enabled)/ShouldCollide true (EnableCollision)/symmetric moving vs non-moving |
| `Tests_PlaneShape.cs` | 13 | PlaneShapeSettings CDefaultHalfExtent==1000/defaults (mHalfExtent=CDefaultHalfExtent, mUserData=0)/mHalfExtent round-trip/mUserData round-trip/Construct with half extent; PlaneShape DefaultConstruct/GetHalfExtent==0/MustBeStatic/CGetTrianglesMinTrianglesRequested/Construct with half extent/GetHalfExtent after construct/GetLocalBounds |
| `Tests_CharacterVirtual.cs` | 19 | CharacterVirtual construction; SetPosition/GetPosition; SetRotation/GetRotation; SetLinearVelocity/GetLinearVelocity; SetCharacterLayer/GetCharacterLayer; GetInnerBodyID valid after add; GetWorldTransform/GetCenterOfMassPosition/GetCenterOfMassTransform valid; GetActiveBodyID after add; Update step no-crash |
| `Tests_MeshShape.cs` | 7 | MeshShapeSettings default construct; MeshShape DefaultConstruct NoCrash/MustBeStatic true/CGetTrianglesMinTrianglesRequested static const/GetUserData=0; GetLocalBounds/GetStats/GetSubShapeIDBitsRecursive skipped (internal tree bug) |
| `Tests_Vector2Matrix.cs` | 26 | Vector_2 (15 tests): construct/copy/+/-/*/÷/Dot/LengthSq/Length/Normalized/==; Matrix_2_2 (11 tests): SZero/SIdentity/construct from rows/SetRow/GetRow/==/multiply Mat/multiply Vec |
| `Tests_ShapeBase.cs` | 11 | Shape GetType/GetSubType round-trips; GetLocalBounds non-degenerate; GetMassProperties via sphere; GetLeafShape returns same as GetInnerShape for non-compound; GetMaterial via MeshShape (null when no material set); SetUserData/GetUserData round-trip |
| `Tests_SoftBody.cs` | 42 | SoftBodyCreationSettings field defaults + round-trips; SoftBodySharedSettings construct/GetRefCount/AddRef/SetEmbedded/CalculateEdgeLengths/Optimize; inner Vertex (default/invMass/parameterized), Edge (mRestLength/mCompliance), Face (IsDegenerate/mMaterialIndex) |
| `Tests_JobSystem.cs` | 8 | JobSystemSingleThreaded: default/parameterized construct; GetMaxConcurrency==1; Init then GetMaxConcurrency==1; JobSystemThreadPool: default/parameterized construct; GetMaxConcurrency>0; fixture Jobs GetMaxConcurrency>0 |
| `Tests_TempAllocator.cs` | 8 | TempAllocatorImpl: construct; GetSize==requested; IsEmpty initially true; GetUsage==0; CanAllocate small=true; CanAllocate oversized=false; fixture Alloc GetSize>=64MB; CanAllocate 1MB |
| `Tests_CollisionGroups.cs` | 12 | CollisionGroup CInvalidGroup/CInvalidSubGroup constants; default construct + ID defaults; SetGroupID/SubGroupID round-trips; CanCollide (no filter, different groups) |
| `Tests_MutableCompound.cs` | 14 | MutableCompound construction, NumSubShapes, AddShape (index + count), RemoveShape, ModifyShape, GetLocalBounds (empty + with sphere), GetVolume/GetInnerRadius, dynamic body simulation |
| `Tests_PhysicsSettings.cs` | 16 | PhysicsSettings defaults + round-trips for all fields including mDeterministicSimulation, NumVelocitySteps, NumPositionSteps, Baumgarte, etc. |
| `Tests_TaperedCapsuleShape.cs` | 16 | TaperedCapsuleShapeSettings fields, IsValid/IsSphere checks, dynamic body simulation |
| `Tests_TriangleAndPlaneShapes.cs` | 16 | Triangle shape settings and plane shape tests |
| `Tests_ContactManifold.cs` | 12 | ContactManifold default construct, mPenetrationDepth/mSubShapeID1/2 defaults + mutable round-trips, copy construct, SwapShapes |
| `Tests_DefaultObjectLayerFilter.cs` | 6 | DefaultObjectLayerFilter construct (from ObjectLayerPairFilterTable); ShouldCollide: enabled pair returns true, same layer returns false, symmetric; no-pairs filter returns false |
| `Tests_PhysicsDeterminism.cs` | 5 | Two identical 60-step simulations produce bit-exact positions; single-step + 180-step variants; mDeterministicSimulation default=true + disable |
| `Tests_Ellipse.cs` | 11 | Ellipse construction/copy; IsInside (origin, inside point, outside, boundary uses <=, Y-axis); GetClosestPoint on X and Y axis; GetNormal non-normalized (X and Y axis) |
| `Tests_CollisionSettings.cs` | 22 | EBackFaceMode/EActiveEdgeMode/ECollectFacesMode enum values; RayCastSettings default+round-trips (mBackFaceModeTriangles/Convex, mTreatConvexAsSolid); CollideSettingsBase default+round-trips (mActiveEdgeMode, mCollectFacesMode); CollideShapeSettings default+round-trip (mMaxSeparationDistance); CollideShapeResult GetEarlyOutFraction, Reversed; ShapeCastSettings default+round-trips; ShapeCastResult GetEarlyOutFraction |
| `Tests_RayCastQuery.cs` | 13 | RRayCast default + parameterized construction + field access; NarrowPhaseQuery.CastRay miss (empty world), hit (true, fraction in [0,1], BodyID matches), side-miss; BodyInterface.GetTransformedShape (NoCrash, BodyID matches, position matches); TransformedShape.GetWorldSpaceBounds valid; TransformedShape.CastRay hit + miss |
| `Tests_PhysicsStepListener.cs` | 9 | PhysicsStepListenerContext: default/parameterized/copy construct; mDeltaTime/mIsFirstStep/mIsLastStep/mPhysicsSystem field access; mutable round-trips; context holding a real PhysicsSystem |

---

## Summary

| Category | Total C# Test Files | Total C# Tests |
|---|---|---|
| Math | 10 | 297 |
| Geometry | 3 | 46 |
| Physics | 31 | 453 |
| Other | 45 | 550 |
| **Total** | **89** | **1346** |

> **Note:** Test count reflects state after latest updates.
> The total has grown across multiple sessions:
> - 1083 → 1138 (68 files): added Tests_CharacterID.cs, Tests_SubShapeIDPair.cs, Tests_PhysicsMaterial.cs, Tests_LayerTables.cs, Tests_PlaneShape.cs
> - 1138 → 1202 (72 files): added Tests_CharacterVirtual.cs (19), Tests_MeshShape.cs (7), Tests_Vector2Matrix.cs (26), Tests_ShapeBase.cs (11)
> - 1202 → **1260** (**75 files**): added Tests_SoftBody.cs (42), Tests_JobSystem.cs (8), Tests_TempAllocator.cs (8)
> - 1260 → **1291** (**84 files**): added Tests_ContactManifold.cs (12), Tests_DefaultObjectLayerFilter.cs (6), Tests_PhysicsDeterminism.cs (5); expanded Tests_ContactSettings.cs (+8); documented 5 pre-existing files: Tests_CollisionGroups.cs (12), Tests_MutableCompound.cs (14), Tests_PhysicsSettings.cs (16), Tests_TaperedCapsuleShape.cs (16), Tests_TriangleAndPlaneShapes.cs (16)
> - 1291 → **1346** (**89 files**): generated new bindings (Ellipse, RayCast/RRayCast, RayCastSettings, CollideSettingsBase/CollideShapeSettings/CollideShapeResult, ShapeCast/ShapeCastSettings/ShapeCastResult, TransformedShape, PhysicsStepListenerContext/PhysicsStepListener, EBackFaceMode/EActiveEdgeMode/ECollectFacesMode); added Tests_Ellipse.cs (11), Tests_CollisionSettings.cs (22), Tests_RayCastQuery.cs (13), Tests_PhysicsStepListener.cs (9)

---

## Missing Bindings / Blockers

The following items would need new `--allow` lines in `generate.sh` (and possibly new wrapper
headers) before C# tests can be written:

- `JPH::CharacterVirtual` (full) — `mShape`, `mInnerBodyShape`, `mBackFaceMode` fields are
  currently skipped due to complex types
- `JPH::SoftBodyCreationSettings` / `JPH::SoftBody` — bound; full simulation tests not yet written (no vertex/face collection accessors in bindings)
- `JPH::WheeledVehicleController` — not yet bound
- `JPH::SubShapeID` — could be bound; complex compound sub-shape path tracking
- `CollideShape` / `CastShape` query execution — settings/result types now bound; actual query methods on `NarrowPhaseQuery` not yet covered
- `PhysicsStepListener::OnStep` callback — pure virtual C++ class; virtual dispatch wiring not generated; cannot subclass from C#

## Generator Bug Fixed This Session

**Parser fix (src/parser/main.cpp):** The mrbind parser now fully qualifies static data
member references in default argument expressions (e.g., `cDefaultHalfExtent` → 
`JPH::PlaneShapeSettings::cDefaultHalfExtent`). Previously only enum constants were qualified.
This was blocking `PlaneShape.cpp` from compiling in the native library build.

**`--method-precondition` generator flag (mrbind_gen_csharp):** A new CLI flag injects a
runtime C# precondition guard into a generated method body before the native call. Used to
protect `GetInverseInertia()`, which has a Jolt-internal `JPH_ASSERT(IsDynamic())` that would
hang/crash the process if called on a static body. The guard throws
`System.InvalidOperationException` instead. Any other method with a similar Jolt-internal
assert (e.g. `GetLinearVelocity`, `GetAngularVelocity`, `AddForce` — all also assert
`IsDynamic()`) can be guarded the same way by adding more lines to `EXTRA_GEN_FLAGS` in
`generate.sh`.
