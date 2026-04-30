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
| `UnitTests/Math/VectorTests.cpp` | — | ❌ | 0 | Template-heavy vector tests; requires specialized approach |
| `UnitTests/Math/MatrixTests.cpp` | — | ❌ | 0 | Generic matrix tests |
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
| `UnitTests/Geometry/EllipseTest.cpp` | — | ❌ | 0 | Ellipse class not yet bound |
| `UnitTests/Geometry/EPATests.cpp` | — | 🚫 | — | EPA solver internals; not exposed |
| `UnitTests/Geometry/GJKTests.cpp` | — | 🚫 | — | GJK collision internals; not exposed |
| `UnitTests/Geometry/RayAABoxTests.cpp` | — | ❌ | 0 | Ray-AABox intersections not yet bound |

---

## Physics Tests

| Native Test File | C# Test File | Status | Tests | Notes |
|---|---|---|---|---|
| `UnitTests/Physics/PhysicsTests.cpp` | `Tests_Physics.cs` | ⚠️ | 10 | Basic simulation: add body, step, position check; doesn't cover all scenarios |
| `UnitTests/Physics/ShapeTests.cpp` | `Tests_Shapes.cs` + `Tests_ShapeGeometry.cs` | ⚠️ | 38 | Shape creation and geometry queries; volume/surface area not covered for all shapes |
| `UnitTests/Physics/MutableCompoundShapeTests.cpp` | `Tests_MutableCompound.cs` | ✅ | 14 | Mutable compound shape operations |
| `UnitTests/Physics/OffsetCenterOfMassShapeTests.cpp` | `Tests_OffsetCOM.cs` | ✅ | 10 | Offset center of mass shape |
| `UnitTests/Physics/CollisionGroupTests.cpp` | `Tests_CollisionGroups.cs` | ✅ | 12 | Collision group and filter mask logic |
| `UnitTests/Physics/ObjectLayerPairFilterTableTests.cpp` | `Tests_ObjectLayers.cs` | ⚠️ | 9 | ObjectLayerPairFilterTable; mask filter not covered |
| `UnitTests/Physics/ObjectLayerPairFilterMaskTests.cpp` | — | ❌ | 0 | ObjectLayerPairFilterMask not yet bound |
| `UnitTests/Physics/BroadPhaseTests.cpp` | — | ❌ | 0 | Broadphase queries not directly exposed |
| `UnitTests/Physics/CastShapeTests.cpp` | — | ❌ | 0 | Shape cast queries not yet tested |
| `UnitTests/Physics/CollideShapeTests.cpp` | — | ❌ | 0 | CollideShape queries not yet tested |
| `UnitTests/Physics/RayShapeTests.cpp` | — | ❌ | 0 | Ray-shape intersections not yet tested |
| `UnitTests/Physics/TransformedShapeTests.cpp` | — | ❌ | 0 | TransformedShape not yet tested |
| `UnitTests/Physics/HeightFieldShapeTests.cpp` | `Tests_HeightFieldShape.cs` | ⚠️ | 12 | HeightFieldShapeSettings field defaults + round-trips; CalculateBitsPerSampleForError requires mHeightSamples (no sample-array constructor in bindings — not testable) |
| `UnitTests/Physics/DistanceConstraintTests.cpp` | `Tests_Constraints.cs` + `Tests_DistanceConstraint.cs` | ✅ | 20 | DistanceConstraintSettings defaults + round-trips, direct construction, GetMinDistance/MaxDistance, SetDistance, GetEnabled/SetEnabled, lambda after simulation |
| `UnitTests/Physics/HingeConstraintTests.cpp` | `Tests_HingeConstraint.cs` | ✅ | 11 | Settings field round-trips (limits, axes, points), constraint creation and simulation |
| `UnitTests/Physics/FixedConstraintTests.cpp` | `Tests_FixedConstraint.cs` + `Tests_Constraints.cs` | ✅ | 17 | Settings defaults + round-trips (AutoDetectPoint, Enabled, Priority, UserData, VelocitySteps), GetBody1/2, GetEnabled/SetEnabled, GetConstraintPriority/Set, lambda after simulation |
| `UnitTests/Physics/SliderConstraintTests.cpp` | — | ❌ | 0 | Slider constraint not yet tested |
| `UnitTests/Physics/SixDOFConstraintTests.cpp` | — | ❌ | 0 | 6DOF constraint not yet tested |
| `UnitTests/Physics/PathConstraintTests.cpp` | — | ❌ | 0 | Path constraint not yet tested |
| `UnitTests/Physics/ContactListenerTests.cpp` | — | ❌ | 0 | Contact listeners not yet tested |
| `UnitTests/Physics/SensorTests.cpp` | `Tests_Bodies.cs` + `Tests_BodyProperties.cs` | ⚠️ | 3 | SensorBody_DoesNotBlockDynamicBody; IsSensor getter for sensor and non-sensor bodies |
| `UnitTests/Physics/ActiveEdgesTests.cpp` | — | 🚫 | — | Internal mesh active-edge logic |
| `UnitTests/Physics/ConvexVsTrianglesTest.cpp` | — | 🚫 | — | Internal convex-triangle collision |
| `UnitTests/Physics/EstimateCollisionResponseTest.cpp` | — | ❌ | 0 | Not yet tested |
| `UnitTests/Physics/MotionQualityLinearCastTests.cpp` | — | ❌ | 0 | Linear cast motion quality not yet tested |
| `UnitTests/Physics/SubShapeIDTest.cpp` | — | 🚫 | — | SubShapeID internals; complex compound shape paths |
| `UnitTests/Physics/TaperedCylinderShapeTests.cpp` | `Tests_TaperedCylinder.cs` | ✅ | 12 | Settings field round-trips (parameterized constructor, mutable fields, SetDensity), dynamic body creation and simulation |
| `UnitTests/Physics/CharacterVirtualTests.cpp` | — | ❌ | 0 | CharacterVirtual partially bound (settings skipped) |
| `UnitTests/Physics/SoftBodyTests.cpp` | — | ❌ | 0 | SoftBody not yet bound |
| `UnitTests/Physics/WheeledVehicleTests.cpp` | — | ❌ | 0 | WheeledVehicle not yet bound |
| `UnitTests/Physics/ShapeFilterTests.cpp` | `Tests_ShapeFilter.cs` | ✅ | 9 | Const/mutable lifecycle, mBodyID2 default-invalid, ShouldCollide default pass-through (2-arg and 4-arg), use alongside physics system |
| `UnitTests/Physics/PhysicsDeterminismTests.cpp` | — | ❌ | 0 | Determinism tests require multi-run setup |
| `UnitTests/Physics/PhysicsStepListenerTests.cpp` | — | ❌ | 0 | StepListener not yet tested |

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

---

## Summary

| Category | Total C# Test Files | Total C# Tests |
|---|---|---|
| Math | 8 | 238 |
| Geometry | 2 | 35 |
| Physics | 20 | 251 |
| Other | 6 | 127 |
| **Total** | **36** | **651** |

> **Note:** Test count reflects state after this session.
> Added 3 new test files: `Tests_TaperedCapsuleShape.cs` (16), `Tests_TriangleAndPlaneShapes.cs` (16),
> `Tests_PhysicsSettings.cs` (16). Previous session total was 603 tests; new total is **651 tests**.

---

## Missing Bindings / Blockers

The following items would need new `--allow` lines in `generate.sh` (and possibly new wrapper
headers) before C# tests can be written:

- `JPH::ObjectLayerPairFilterMask` — needs `--allow JPH::ObjectLayerPairFilterMask`
- `JPH::Ellipse` — needs `--allow JPH::Ellipse` + Ellipse.h include
- `JPH::CharacterVirtual` (full) — `mShape`, `mInnerBodyShape`, `mBackFaceMode` fields are
  currently skipped due to complex types
- `JPH::SoftBodyCreationSettings` / `JPH::SoftBody` — not yet bound
- `JPH::WheeledVehicleController` — not yet bound
- `JPH::SubShapeID` — could be bound; complex compound sub-shape path tracking
- Ray/collision query result types (`RayCastResult`, `CollideShapeResult`, etc.) — needed for
  cast/collide tests; partially bound

## Generator Bug Fixed This Session

**Parser fix (src/parser/main.cpp):** The mrbind parser now fully qualifies static data
member references in default argument expressions (e.g., `cDefaultHalfExtent` → 
`JPH::PlaneShapeSettings::cDefaultHalfExtent`). Previously only enum constants were qualified.
This was blocking `PlaneShape.cpp` from compiling in the native library build.
