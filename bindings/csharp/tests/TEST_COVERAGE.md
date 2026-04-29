# JoltPhysics C# Bindings — Test Coverage

This document tracks which native Jolt C++ unit tests have been ported to C#, which are
partially covered, and which are still missing.

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
| `UnitTests/Physics/HeightFieldShapeTests.cpp` | — | ❌ | 0 | HeightFieldShape not yet tested |
| `UnitTests/Physics/DistanceConstraintTests.cpp` | `Tests_Constraints.cs` | ⚠️ | 7 | Basic constraint setup; not all constraint types |
| `UnitTests/Physics/HingeConstraintTests.cpp` | — | ❌ | 0 | Hinge constraint not yet tested |
| `UnitTests/Physics/SliderConstraintTests.cpp` | — | ❌ | 0 | Slider constraint not yet tested |
| `UnitTests/Physics/SixDOFConstraintTests.cpp` | — | ❌ | 0 | 6DOF constraint not yet tested |
| `UnitTests/Physics/PathConstraintTests.cpp` | — | ❌ | 0 | Path constraint not yet tested |
| `UnitTests/Physics/ContactListenerTests.cpp` | — | ❌ | 0 | Contact listeners not yet tested |
| `UnitTests/Physics/SensorTests.cpp` | — | ❌ | 0 | Sensor bodies not yet tested |
| `UnitTests/Physics/ActiveEdgesTests.cpp` | — | 🚫 | — | Internal mesh active-edge logic |
| `UnitTests/Physics/ConvexVsTrianglesTest.cpp` | — | 🚫 | — | Internal convex-triangle collision |
| `UnitTests/Physics/EstimateCollisionResponseTest.cpp` | — | ❌ | 0 | Not yet tested |
| `UnitTests/Physics/MotionQualityLinearCastTests.cpp` | — | ❌ | 0 | Linear cast motion quality not yet tested |
| `UnitTests/Physics/SubShapeIDTest.cpp` | — | 🚫 | — | SubShapeID internals; complex compound shape paths |
| `UnitTests/Physics/TaperedCylinderShapeTests.cpp` | — | ❌ | 0 | TaperedCylinder not yet tested |
| `UnitTests/Physics/CharacterVirtualTests.cpp` | — | ❌ | 0 | CharacterVirtual partially bound (settings skipped) |
| `UnitTests/Physics/SoftBodyTests.cpp` | — | ❌ | 0 | SoftBody not yet bound |
| `UnitTests/Physics/WheeledVehicleTests.cpp` | — | ❌ | 0 | WheeledVehicle not yet bound |
| `UnitTests/Physics/ShapeFilterTests.cpp` | — | ❌ | 0 | ShapeFilter not yet tested |
| `UnitTests/Physics/PhysicsDeterminismTests.cpp` | — | ❌ | 0 | Determinism tests require multi-run setup |
| `UnitTests/Physics/PhysicsStepListenerTests.cpp` | — | ❌ | 0 | StepListener not yet tested |

---

## Other C# Test Files (no direct native counterpart)

| C# Test File | Tests | Description |
|---|---|---|
| `Tests_Bodies.cs` | 16 | Body creation, activation, property queries |
| `Tests_RefCounting.cs` | 8 | Ref-counted shape/settings lifetime |

---

## Summary

| Category | Total C# Test Files | Total C# Tests |
|---|---|---|
| Math | 8 | 238 |
| Geometry | 2 | 35 |
| Physics | 10 | 109 |
| Other | 2 | 24 |
| **Total** | **22** | **470** |

> **Note:** Test count above reflects state after adding `Tests_Plane.cs` (15 new tests).
> Previous session total was 455 tests; new total is **470 tests**.

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
