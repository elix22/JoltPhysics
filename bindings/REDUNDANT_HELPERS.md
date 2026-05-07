# JoltHelpers Functions Made Redundant by Array Bindings

The `--vector-like-container "JPH::Array" ...` flag now generates a full C / C# API for every
`JPH::Array<T>` field that mrbind encounters.  The helpers below were written as workarounds for
the same fields, and are now redundant.

Each entry shows:
- the helper name in `JoltHelpers`
- the replacement C# expression using the generated bindings
- the generated Array type involved

---

## SoftBodySharedSettings — vertex / face arrays

| Helper | Replacement | Array type |
|--------|------------|-----------|
| `SoftBodySettingsAddVertex(settings, v)` | `settings.mVertices.PushBack(v)` | `Array_JPHSoftBodySharedSettingsVertex` |
| `SoftBodySettingsGetVertexCount(settings)` | `settings.mVertices.Size()` | same |
| `SoftBodySettingsGetFaceCount(settings)` | `settings.mFaces.Size()` | `Array_JPHSoftBodySharedSettingsFace` |
| `SoftBodySettingsGetFaceVertex(settings, fi, slot)` | `settings.mFaces[fi].mVertex[slot]` | same |

---

## SoftBodySharedSettings — rod constraints

| Helper | Replacement | Array type |
|--------|------------|-----------|
| `SoftBodySettingsAddRodStretchShear(settings, v1, v2)` | construct `RodStretchShear`, set `mVertex`, then `settings.mRodStretchShearConstraints.PushBack(...)` | `Array_JPHSoftBodySharedSettingsRodStretchShear` |
| `SoftBodySettingsGetRodStretchShearCount(settings)` | `settings.mRodStretchShearConstraints.Size()` | same |
| `SoftBodySettingsGetRodStretchShearVertex(settings, i, slot)` | `settings.mRodStretchShearConstraints[i].mVertex[slot]` | same |
| `SoftBodySettingsSetRodStretchShearCompliance(settings, i, c)` | `settings.mRodStretchShearConstraints[i].mCompliance = c` | same |
| `SoftBodySettingsAddRodBendTwist(settings, r1, r2)` | construct `RodBendTwist`, set fields, then `settings.mRodBendTwistConstraints.PushBack(...)` | `Array_JPHSoftBodySharedSettingsRodBendTwist` |
| `SoftBodySettingsGetRodBendTwistCount(settings)` | `settings.mRodBendTwistConstraints.Size()` | same |
| `SoftBodySettingsSetRodBendTwistCompliance(settings, i, c)` | `settings.mRodBendTwistConstraints[i].mCompliance = c` | same |

---

## SoftBodySharedSettings — skinning / inv-bind arrays

| Helper | Replacement | Array type |
|--------|------------|-----------|
| `SoftBodySettingsAddSkinned(settings, vertex, maxDist, bsDist, bsRadius)` | construct `Skinned`, set fields, then `settings.mSkinnedConstraints.PushBack(...)` | `Array_JPHSoftBodySharedSettingsSkinned` |
| `SoftBodySettingsAddInvBind(settings, jointIdx, invBind)` | construct `InvBind`, set `mJointIndex` + `mInvBind`, then `settings.mInvBindMatrices.PushBack(...)` | `Array_JPHSoftBodySharedSettingsInvBind` |

**Not redundant:** `SoftBodySettingsAddSkinnedWithWeights` performs weight normalization across two
joints — that logic is not provided by the plain `PushBack` path and must be kept.

---

## SoftBodyManifold / SoftBodyMotionProperties — runtime vertex access

`SoftBodyMotionProperties::GetVertices()` and `SoftBodyManifold::GetVertices()` now return an
`Array_JPHSoftBodyVertex` (confirmed in generated C headers).

| Helper | Replacement |
|--------|------------|
| `SoftBodyManifoldGetVertexCount(manifold)` | `manifold.GetVertices().Size()` |
| `SoftBodyManifoldGetVertex(manifold, i)` | `manifold.GetVertices()[i]` |
| `BodyGetSoftBodyVertexCount(body)` | `body.GetSoftBodyMotionProperties().GetVertices().Size()` |
| `BodyGetSoftBodyVertexPosition(body, i)` | `body.GetSoftBodyMotionProperties().GetVertices()[i].mPosition` |
| `BodySetSoftBodyVertexPosition(body, i, pos)` | `body.GetSoftBodyMotionProperties().GetVertices()[i].mPosition = pos` |

`PhysicsSystemGetSoftBodyVertexCount` and `PhysicsSystemGetSoftBodyVertexPosition` also become
redundant if the caller can hold the physics system lock and use the motion-properties path above.
They can be kept for convenience.

---

## HeightFieldShapeSettings — height samples

`HeightFieldShapeSettings::mHeightSamples` is now exposed as `Array_Float`.

| Helper | Replacement |
|--------|------------|
| `HeightFieldSettingsSetHeightSamples(settings, ptr, count)` | `settings.mHeightSamples.Assign(ptr, count)` |
| `HeightFieldSettingsResizeHeightSamples(settings, n, fill)` | `settings.mHeightSamples.ResizeWithDefaultValue(n, fill)` |
| `HeightFieldSettingsSetHeightSampleAt(settings, i, v)` | `settings.mHeightSamples[i] = v` |
| `HeightFieldSettingsGetHeightSamplesCount(settings)` | `settings.mHeightSamples.Size()` |
| `HeightFieldSettingsGetHeightSample(settings, i)` | `settings.mHeightSamples[i]` |

---

## Vehicle — anti-roll bars, differentials, track wheels, gear ratios

`VehicleConstraintSettings::mWheels` (`Array<WheelSettings*>`) was **not** emitted as a field
accessor by the generator (the field is skipped because it contains raw pointers to a type that
requires special handling), so `VehicleSettingsAddWheel` / `VehicleSettingsAddWheelTV` are
**still required**.

The following are confirmed redundant:

| Helper | Replacement | Array type |
|--------|------------|-----------|
| `VehicleSettingsAddAntiRollBar(settings, bar)` | `settings.mAntiRollBars.PushBack(bar)` | `Array_JPHVehicleAntiRollBar` |
| `WheeledControllerSettingsAddDifferential(settings, diff)` | `settings.mDifferentials.PushBack(diff)` | `Array_JPHVehicleDifferentialSettings` |
| `VehicleTrackSettingsAddWheelIndex(track, idx)` | `track.mWheels.PushBack(idx)` | `Array_UnsignedInt` |
| `VehicleTransmissionSettingsSetGearRatios(settings, ptr, n)` | `settings.mGearRatios.Assign(ptr, n)` | `Array_Float` |
| `VehicleTransmissionSettingsSetReverseGearRatios(settings, ptr, n)` | `settings.mReverseGearRatios.Assign(ptr, n)` | `Array_Float` |

---

## Ragdoll — parts array

`RagdollSettings::mParts` is now exposed as `Array_JPHRagdollSettingsPart`.

| Helper | Replacement |
|--------|------------|
| `RagdollSettingsAddPart(settings, part)` | `settings.mParts.PushBack(part)` |
| `RagdollSettingsGetPartCount(settings)` | `settings.mParts.Size()` |
| `RagdollSettingsGetPart(settings, i)` | `settings.mParts[i]` |

---

## Skeleton — joints array

`Skeleton::GetJoints()` now returns `Array_JPHSkeletonJoint` (mutable variant from `GetJoints()`
on the non-const class).

| Helper | Replacement |
|--------|------------|
| `SkeletonAddJoint(skeleton, name)` | construct `Skeleton.Joint`, set `mName` (and leave `mParentJointIndex = -1`), then `skeleton.GetJoints().PushBack(joint)` |
| `SkeletonAddJointWithParentName(skeleton, name, parentName)` | same, look up parent index first |
| `SkeletonAddJointWithParentIndex(skeleton, name, parentIdx)` | same, set `mParentJointIndex = parentIdx` |

---

## Summary counts

| Category | Redundant helpers | Still needed |
|----------|------------------|--------------|
| SoftBody settings | 14 | `AddSkinnedWithWeights`, `SetAllEdgeCompliance`, `SettingsCreateCube` |
| SoftBody runtime | 5 | `PhysicsSystemGet*` (convenience) |
| HeightField | 5 | — |
| Vehicle | 5 | `VehicleSettingsAddWheel`, `VehicleSettingsAddWheelTV` |
| Ragdoll | 3 | — |
| Skeleton | 3 | — |
| **Total** | **35** | |
