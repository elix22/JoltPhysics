#!/bin/bash

SCRIPT_DIR="$(cd "$(dirname "$BASH_SOURCE")" && pwd)"
# deps/JoltPhysics/bindings -> go up three levels to reach the repo root
cd "$SCRIPT_DIR/../../.."

set -euo pipefail

if [[ ! -f build/mrbind ]]; then
    echo 'Did not find build/mrbind. Build MRBind first.'
    exit 1
fi

# Find compiler config (check repo root first, fall back to examples/).
CXX_FILE=""
for f in cxx.txt examples/cxx.txt; do
    if [[ -f "$f" ]]; then CXX_FILE="$f"; break; fi
done
if [[ -z "$CXX_FILE" ]]; then
    echo 'Did not find cxx.txt. Put your compiler name in it (e.g. clang++).'
    exit 1
fi
export CLANG_CXX="$(xargs <"$CXX_FILE")"

./deps/JoltPhysics/bindings/clean.sh

ROOT="$(pwd)/deps/JoltPhysics"
BINDINGS="deps/JoltPhysics/bindings"
HELPER_DIR="$BINDINGS"
mkdir -p "$BINDINGS/c/include" "$BINDINGS/c/src" "$BINDINGS/csharp/src" "$BINDINGS/tmp"

# clean.sh removes bindings/c/ entirely; restore the CMakeLists.txt that the
# build scripts rely on (it is the authoritative copy — edit here, not there).
cp "$BINDINGS/CMakeLists.txt" "$BINDINGS/c/CMakeLists.txt"

# Clang-style flags for the parser.
# -DNDEBUG matches the Release build: suppresses JPH_DEBUG / JPH_ENABLE_ASSERTS
# so debug-only methods (e.g. Body::ValidateCachedBounds) are not generated.
# -DJPH_DEBUG_RENDERER enables DebugRenderer and related headers.
EXTRA_PARSER_CXX_FLAGS=(
    -std=c++17 -Wall -Wextra
    -fparse-all-comments
    -DNDEBUG
    -DJPH_DEBUG_RENDERER
    -I"$HELPER_DIR"
)

# Optional tunable flags for the parser.
EXTRA_PARSER_FLAGS=(
    --copy-inherited-members
)

# Optional tunable flags for the C generator.
EXTRA_GEN_C_FLAGS=(
    --max-header-name-length 100
    --no-handle-exceptions
    --expose-as-struct JPH::BodyID
    --no-dynamic-cast
    --vector-like-container "JPH::Array" "Jolt/Core/Array.h" --vector-like-container-raw-pointer-iterators
)

# Optional tunable flags for the C# generator.
EXTRA_GEN_FLAGS=(
    --csharp-version=12
    --dotnet-version=std2.0
    # Guard methods that assert a precondition internally in Jolt (would hang/crash if violated from C#).
    --method-precondition JPH_Body_GetInverseInertia "IsDynamic() || IsKinematic()" "Body.GetInverseInertia() requires a dynamic or kinematic body (static bodies have no motion properties)."
)

SHARED_LIBRARY_EXT=.so
SHARED_LIBRARY_PREFIX=lib

# Need extra flags on MSYS2.
if [[ $(uname -o 2>/dev/null) == Msys ]]; then
    EXTRA_PARSER_CXX_FLAGS+=(--sysroot="$MSYSTEM_PREFIX")
    SHARED_LIBRARY_EXT=.dll
    SHARED_LIBRARY_PREFIX=
fi

# Need the SDK sysroot on macOS.
PARSER_RESOURCE_DIR=""
if [[ $(uname) == Darwin ]]; then
    EXTRA_PARSER_CXX_FLAGS+=(-isysroot "$(xcrun --show-sdk-path)" -fno-blocks)
    SHARED_LIBRARY_EXT=.dylib
    SHARED_LIBRARY_PREFIX=lib
    # mrbind is built with Homebrew LLVM; use its resource dir so that
    # LLVM's arm_neon.h is found instead of Xcode's, which has Apple-specific
    # __builtin_neon___a64_* intrinsics that LLVM's parser does not support.
    if [[ -x /opt/homebrew/opt/llvm/bin/clang ]]; then
        PARSER_RESOURCE_DIR="$(/opt/homebrew/opt/llvm/bin/clang -print-resource-dir)"
    fi
fi

set -x

# Assemble the combined input header.
echo "#pragma once" >"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Jolt.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/Shape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/ConvexShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/DecoratedShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/CompoundShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Character/CharacterBase.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/bindings/jolt_init_wrapper.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Jolt.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/RegisterTypes.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Core/Factory.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Core/JobSystemThreadPool.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Core/JobSystemSingleThreaded.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/PhysicsSettings.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/PhysicsSystem.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/BoxShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/SphereShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/CapsuleShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/CylinderShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/RotatedTranslatedShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/TaperedCapsuleShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/TaperedCylinderShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/TriangleShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/PlaneShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/EmptyShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/ScaledShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/OffsetCenterOfMassShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/StaticCompoundShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/MutableCompoundShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/MeshShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/ConvexHullShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/HeightFieldShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Body/BodyCreationSettings.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Body/Body.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/PhysicsMaterial.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/CollisionGroup.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/TwoBodyConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/FixedConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/DistanceConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/PointConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/HingeConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/SliderConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/SixDOFConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/ConeConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/GearConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/PulleyConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/RackAndPinionConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/SwingTwistConstraint.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/ObjectLayerPairFilterMask.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Body/MotionQuality.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/SoftBody/SoftBodySharedSettings.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/SoftBody/SoftBodyCreationSettings.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Geometry/AABox.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Geometry/Plane.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Core/TempAllocator.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Body/BodyInterface.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Body/BodyActivationListener.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/SubShapeID.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/CastResult.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/Shape/SubShapeIDPair.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Body/BodyFilter.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/ShapeFilter.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/ContactListener.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/NarrowPhaseQuery.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Character/Character.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Character/CharacterBase.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Character/CharacterVirtual.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayerInterfaceTable.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/ObjectLayerPairFilterTable.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/BroadPhase/ObjectVsBroadPhaseLayerFilterTable.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/BVec16.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/DMat44.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Double3.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/DVec3.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Float2.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Float3.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Float4.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Mat44.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Matrix.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Quat.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/UVec4.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Vec3.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Vec4.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Math/Vector.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Geometry/Ellipse.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/BackFaceMode.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/ActiveEdgeMode.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/CollectFacesMode.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/RayCast.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/CollideShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/ShapeCast.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/TransformedShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/PhysicsStepListener.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Geometry/RayAABox.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/PathConstraintPath.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Constraints/PathConstraintPathHermite.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Vehicle/WheeledVehicleController.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Vehicle/MotorcycleController.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Vehicle/TrackedVehicleController.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Vehicle/VehicleTrack.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/SoftBody/SoftBodyMotionProperties.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/SoftBody/SoftBodyContactListener.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/SoftBody/SoftBodyManifold.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/SoftBody/SoftBodyShape.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/EstimateCollisionResponse.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Renderer/DebugRendererSimple.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Core/Color.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Skeleton/Skeleton.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Skeleton/SkeletalAnimation.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Skeleton/SkeletonPose.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Skeleton/SkeletonMapper.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Ragdoll/Ragdoll.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/AABoxCast.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/CollidePointResult.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/GroupFilter.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/GroupFilterTable.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/PhysicsMaterialSimple.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/SimShapeFilter.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayerInterfaceMask.h\"" >>"$BINDINGS/tmp/combined_input.h"
echo "#include \"$ROOT/Jolt/Physics/Collision/BroadPhase/ObjectVsBroadPhaseLayerFilterMask.h\"" >>"$BINDINGS/tmp/combined_input.h"


# Parse the input header.
./build/mrbind \
    "$BINDINGS/tmp/combined_input.h" \
    -o "$BINDINGS/tmp/parse_result.json" \
    --ignore :: \
    --skip-mentions-of std::align_val_t \
    --skip-mentions-of std::string_view \
    --skip-mentions-of JPH::StaticArray \
    --skip-mentions-of JPH::PhysicsStepListenerContext \
    --skip-mentions-of JPH::string_view \
    --skip-mentions-of JPH::StreamIn \
    --skip-mentions-of JPH::StreamOut \
    --ignore JPH::SkeletonMapper::Initialize \
    --allow JoltHelpers \
    --allow CountingPhysicsStepListener \
    --allow SimpleContactEventListener \
    --allow EstimateResponseContactListener \
    --allow ContactListenerTrampoline \
    --allow SoftBodyContactListenerTrampoline \
    --allow DebugLineRecord \
    --allow DebugTriangleRecord \
    --allow RecordingDebugRenderer \
    --allow JPH::Color \
    --allow JPH::DebugRenderer \
    --allow JPH::DebugRenderer::ECastShadow \
    --allow JPH::DebugRenderer::EDrawMode \
    --allow JPH::DebugRenderer::ECullMode \
    --allow JPH::DebugRendererSimple \
    --allow JPH::BVec16 \
    --allow JPH::DMat44 \
    --allow JPH::Double3 \
    --allow JPH::DVec3 \
    --allow JPH::Float2 \
    --allow JPH::Float3 \
    --allow JPH::Float4 \
    --allow JPH::Mat44 \
    --allow JPH::Matrix \
    --allow JPH::Quat \
    --allow JPH::UVec4 \
    --allow JPH::Vec3 \
    --allow JPH::Vec4 \
    --allow JPH::Plane \
    --allow JPH::Vector \
    --allow JPH::RefTarget \
    --allow JPH::NonCopyable \
    --allow JPH::SerializableObject \
    --allow JPH::EMotionType \
    --allow JPH::EMotionQuality \
    --allow JPH::EPhysicsUpdateError \
    --allow JPH::ShapeSettings \
    --allow JPH::ConvexShapeSettings \
    --allow JPH::DecoratedShapeSettings \
    --allow JPH::CompoundShapeSettings \
    --allow JPH::BoxShapeSettings \
    --allow JPH::SphereShapeSettings \
    --allow JPH::CapsuleShapeSettings \
    --allow JPH::CylinderShapeSettings \
    --allow JPH::TriangleShapeSettings \
    --allow JPH::TaperedCapsuleShapeSettings \
    --allow JPH::TaperedCylinderShapeSettings \
    --allow JPH::ConvexHullShapeSettings \
    --allow JPH::RotatedTranslatedShapeSettings \
    --allow JPH::ScaledShapeSettings \
    --allow JPH::OffsetCenterOfMassShapeSettings \
    --allow JPH::StaticCompoundShapeSettings \
    --allow JPH::MutableCompoundShapeSettings \
    --allow JPH::MeshShapeSettings \
    --allow JPH::EmptyShapeSettings \
    --allow JPH::PlaneShapeSettings \
    --allow JPH::HeightFieldShapeSettings \
    --allow JPH::Shape \
    --allow JPH::ConvexShape \
    --allow JPH::DecoratedShape \
    --allow JPH::CompoundShape \
    --allow JPH::BoxShape \
    --allow JPH::SphereShape \
    --allow JPH::CapsuleShape \
    --allow JPH::CylinderShape \
    --allow JPH::TriangleShape \
    --allow JPH::TaperedCapsuleShape \
    --allow JPH::TaperedCylinderShape \
    --allow JPH::ConvexHullShape \
    --allow JPH::RotatedTranslatedShape \
    --allow JPH::ScaledShape \
    --allow JPH::OffsetCenterOfMassShape \
    --allow JPH::StaticCompoundShape \
    --allow JPH::MutableCompoundShape \
    --allow JPH::MeshShape \
    --allow JPH::EmptyShape \
    --allow JPH::PlaneShape \
    --allow JPH::HeightFieldShape \
    --allow JPH::BodyCreationSettings \
    --allow JPH::Body \
    --allow JPH::PhysicsMaterial \
    --allow JPH::CollisionGroup \
    --allow JPH::ConstraintSettings \
    --allow JPH::TwoBodyConstraintSettings \
    --allow JPH::FixedConstraintSettings \
    --allow JPH::DistanceConstraintSettings \
    --allow JPH::PointConstraintSettings \
    --allow JPH::HingeConstraintSettings \
    --allow JPH::SliderConstraintSettings \
    --allow JPH::SixDOFConstraintSettings \
    --allow JPH::SixDOFConstraintSettings::EAxis \
    --allow JPH::Constraint \
    --allow JPH::TwoBodyConstraint \
    --allow JPH::FixedConstraint \
    --allow JPH::DistanceConstraint \
    --allow JPH::PointConstraint \
    --allow JPH::HingeConstraint \
    --allow JPH::SliderConstraint \
    --allow JPH::SixDOFConstraint \
    --allow JPH::ESpringMode \
    --allow JPH::SpringSettings \
    --allow JPH::EMotorState \
    --allow JPH::MotorSettings \
    --allow JPH::ConeConstraintSettings \
    --allow JPH::ConeConstraint \
    --allow JPH::GearConstraintSettings \
    --allow JPH::GearConstraint \
    --allow JPH::PulleyConstraintSettings \
    --allow JPH::PulleyConstraint \
    --allow JPH::RackAndPinionConstraintSettings \
    --allow JPH::RackAndPinionConstraint \
    --allow JPH::SwingTwistConstraintSettings \
    --allow JPH::SwingTwistConstraint \
    --allow JPH::SoftBodySharedSettings \
    --allow JPH::SoftBodyCreationSettings \
    --allow JPH::SoftBodyVertex \
    --allow JPH::MotionProperties \
    --allow JPH::SoftBodyMotionProperties \
    --allow JPH::SoftBodyValidateResult \
    --allow JPH::SoftBodyContactSettings \
    --allow JPH::SoftBodyContactListener \
    --allow JPH::SoftBodyManifold \
    --allow JPH::SoftBodyShape \
    --allow JPH::SubShapeID \
    --allow JPH::AABox \
    --allow JPH::BodyID \
    --allow JPH::EActivation \
    --allow JPH::BroadPhaseLayer \
    --allow JPH::BroadPhaseLayerInterface \
    --allow JPH::ObjectVsBroadPhaseLayerFilter \
    --allow JPH::BroadPhaseLayerFilter \
    --allow JPH::DefaultBroadPhaseLayerFilter \
    --allow JPH::SpecifiedBroadPhaseLayerFilter \
    --allow JPH::ObjectLayerPairFilter \
    --allow JPH::ObjectLayerFilter \
    --allow JPH::DefaultObjectLayerFilter \
    --allow JPH::SpecifiedObjectLayerFilter \
    --allow JPH::BodyActivationListener \
    --allow JPH::BodyInterface \
    --allow JPH::TempAllocator \
    --allow JPH::TempAllocatorImpl \
    --allow JPH::TempAllocatorMalloc \
    --allow JPH::TempAllocatorImplWithMallocFallback \
    --allow JPH::JobSystem \
    --allow JPH::JobSystemWithBarrier \
    --allow JPH::JobSystemThreadPool \
    --allow JPH::JobSystemSingleThreaded \
    --allow JPH::PhysicsSettings \
    --allow JPH::PhysicsSystem \
    --allow JPH::Factory \
    --allow JPH::BroadPhaseCastResult \
    --allow JPH::RayCastResult \
    --allow JPH::SubShapeIDPair \
    --allow JPH::BodyFilter \
    --allow JPH::IgnoreSingleBodyFilter \
    --allow JPH::IgnoreMultipleBodiesFilter \
    --allow JPH::ShapeFilter \
    --allow JPH::ReversedShapeFilter \
    --allow JPH::ContactManifold \
    --allow JPH::ContactSettings \
    --allow JPH::ContactListener \
    --allow JPH::ValidateResult \
    --allow JPH::BroadPhaseQuery \
    --allow JPH::NarrowPhaseQuery \
    --allow JPH::CharacterSettings \
    --allow JPH::Character \
    --allow JPH::CharacterBaseSettings \
    --allow JPH::CharacterBase \
    --allow JPH::CharacterVirtualSettings \
    --allow JPH::CharacterContactSettings \
    --allow JPH::CharacterContactListener \
    --allow JPH::CharacterVsCharacterCollision \
    --allow JPH::CharacterVsCharacterCollisionSimple \
    --allow JPH::CharacterID \
    --allow JPH::CharacterVirtual \
    --allow JPH::BroadPhaseLayerInterfaceTable \
    --allow JPH::ObjectLayerPairFilterTable \
    --allow JPH::ObjectLayerPairFilterMask \
    --allow JPH::ObjectVsBroadPhaseLayerFilterTable \
    --allow JPH::Ellipse \
    --allow JPH::EBackFaceMode \
    --allow JPH::EActiveEdgeMode \
    --allow JPH::ECollectFacesMode \
    --allow JPH::RayCastT \
    --allow JPH::RayCast \
    --allow JPH::RRayCast \
    --allow JPH::RayCastSettings \
    --allow JPH::CollideSettingsBase \
    --allow JPH::CollideShapeSettings \
    --allow JPH::CollideShapeResult \
    --allow JPH::ShapeCastT \
    --allow JPH::ShapeCast \
    --allow JPH::RShapeCast \
    --allow JPH::ShapeCastSettings \
    --allow JPH::ShapeCastResult \
    --allow JPH::TransformedShape \
    --allow JPH::SubShapeIDCreator \
    --allow JPH::PhysicsStepListenerContext \
    --allow JPH::PhysicsStepListener \
    --allow JPH::RayInvDirection \
    --allow JPH::PathConstraintPath \
    --allow JPH::PathConstraintPathHermite \
    --allow JPH::WheelSettings \
    --allow JPH::Wheel \
    --allow JPH::WheelSettingsWV \
    --allow JPH::WheelWV \
    --allow JPH::VehicleAntiRollBar \
    --allow JPH::VehicleControllerSettings \
    --allow JPH::VehicleController \
    --allow JPH::VehicleConstraintSettings \
    --allow JPH::VehicleConstraint \
    --allow JPH::VehicleEngineSettings \
    --allow JPH::VehicleEngine \
    --allow JPH::ETransmissionMode \
    --allow JPH::VehicleTransmissionSettings \
    --allow JPH::VehicleTransmission \
    --allow JPH::VehicleDifferentialSettings \
    --allow JPH::WheeledVehicleControllerSettings \
    --allow JPH::WheeledVehicleController \
    --allow JPH::MotorcycleControllerSettings \
    --allow JPH::MotorcycleController \
    --allow JPH::WheelSettingsTV \
    --allow JPH::WheelTV \
    --allow JPH::TrackedVehicleControllerSettings \
    --allow JPH::TrackedVehicleController \
    --allow JPH::ETrackSide \
    --allow JPH::VehicleTrackSettings \
    --allow JPH::VehicleTrack \
    --allow JPH::VehicleCollisionTester \
    --allow JPH::VehicleCollisionTesterRay \
    --allow JPH::VehicleCollisionTesterCastSphere \
    --allow JPH::VehicleCollisionTesterCastCylinder \
    --allow JPH::Skeleton \
    --allow JPH::Skeleton::Joint \
    --allow JPH::SkeletalAnimation \
    --allow JPH::SkeletalAnimation::JointState \
    --allow JPH::SkeletalAnimation::Keyframe \
    --allow JPH::SkeletalAnimation::AnimatedJoint \
    --allow JPH::SkeletonPose \
    --allow JPH::SkeletonPose::DrawSettings \
    --allow JPH::SkeletonMapper \
    --allow JPH::SkeletonMapper::Mapping \
    --allow JPH::SkeletonMapper::Chain \
    --allow JPH::SkeletonMapper::Unmapped \
    --allow JPH::SkeletonMapper::Locked \
    --allow JPH::RagdollSettings \
    --allow JPH::RagdollSettings::Part \
    --allow JPH::RagdollSettings::AdditionalConstraint \
    --allow JPH::Ragdoll \
    --allow JPH::AABoxCast \
    --allow JPH::CollidePointResult \
    --allow JPH::GroupFilter \
    --allow JPH::GroupFilterTable \
    --allow JPH::PhysicsMaterialSimple \
    --allow JPH::SimShapeFilter \
    --allow JPH::BroadPhaseLayerInterfaceMask \
    --allow JPH::ObjectVsBroadPhaseLayerFilterMask \
    --canonicalize-64-to-fixed-size-typedefs \
    "${EXTRA_PARSER_FLAGS[@]+"${EXTRA_PARSER_FLAGS[@]}"}" \
    -- \
    -xc++-header \
    -resource-dir="${PARSER_RESOURCE_DIR:-$("$CLANG_CXX" -print-resource-dir)}" \
    -I"$(pwd)/$HELPER_DIR" \
    -I"$ROOT" \
    "${EXTRA_PARSER_CXX_FLAGS[@]}"

# Generate the C bindings.
./build/mrbind_gen_c \
    --input "$BINDINGS/tmp/parse_result.json" \
    --output-header-dir "$BINDINGS/c/include" \
    --output-source-dir "$BINDINGS/c/src" \
    --output-desc-json "$BINDINGS/tmp/c_desc.json" \
    --helper-name-prefix Jolt_ \
    --helper-macro-name-prefix JOLT_ \
    --map-path "$(pwd)/$HELPER_DIR" jolt \
    --map-path "$(pwd)/deps/JoltPhysics" jolt \
    --assume-include-dir "$(pwd)/$HELPER_DIR" \
    --assume-include-dir "$(pwd)/deps/JoltPhysics" \
    --force-emit-common-helpers \
    "${EXTRA_GEN_C_FLAGS[@]}"

# Write ODR definitions for static const class members that the generated
# field-getter functions ODR-use (they take the member's address). Jolt doesn't
# provide these definitions because it never takes their address internally.
cat >"$BINDINGS/c/src/jolt_odr_defs.cpp" <<'EOF'
#include <Jolt/Physics/Collision/CollisionGroup.h>

namespace JPH {
const CollisionGroup::GroupID    CollisionGroup::cInvalidGroup;
const CollisionGroup::SubGroupID CollisionGroup::cInvalidSubGroup;
}
EOF

# Generate the C# bindings.
./build/mrbind_gen_csharp \
    --input-json "$BINDINGS/tmp/c_desc.json" \
    --output-dir "$BINDINGS/csharp/src" \
    --imported-lib-name cjolt \
    --helpers-namespace JPH \
    --force-namespace JPH \
    --intrinsic-ref-counted-base "JPH::RefTarget" \
    --array-overload-param JPH_BodyInterface_AddBodiesPrepare ioBodies inNumber \
    --array-overload-param JPH_BodyInterface_AddBodiesFinalize ioBodies inNumber \
    --array-overload-param JPH_BodyInterface_AddBodiesAbort ioBodies inNumber \
    --array-overload-param JPH_BodyInterface_RemoveBodies ioBodies inNumber \
    --array-overload-param JPH_BodyInterface_DestroyBodies inBodyIDs inNumber \
    --array-overload-param JPH_BodyInterface_UnassignBodyIDs inBodyIDs inNumber \
    "${EXTRA_GEN_FLAGS[@]}"

