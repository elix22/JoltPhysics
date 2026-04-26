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

BINDINGS="deps/JoltPhysics/bindings"
HELPER_DIR="$BINDINGS"
mkdir -p "$BINDINGS/c/include" "$BINDINGS/c/src" "$BINDINGS/csharp/src" "$BINDINGS/tmp"

# clean.sh removes bindings/c/ entirely; restore the CMakeLists.txt that the
# build scripts rely on (it is the authoritative copy — edit here, not there).
cp "$BINDINGS/CMakeLists.txt" "$BINDINGS/c/CMakeLists.txt"

# Clang-style flags for the parser.
EXTRA_PARSER_CXX_FLAGS=(
    -std=c++17 -Wall -Wextra
    -fparse-all-comments
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
)

# Optional tunable flags for the C# generator.
EXTRA_GEN_FLAGS=(
    --csharp-version=12
    --dotnet-version=std2.0
)

DOTNET=dotnet
SHARED_LIBRARY_EXT=.so
SHARED_LIBRARY_PREFIX=lib

# Need extra flags on MSYS2.
if [[ $(uname -o 2>/dev/null) == Msys ]]; then
    EXTRA_PARSER_CXX_FLAGS+=(--sysroot="$MSYSTEM_PREFIX")
    DOTNET="C:/Program Files/dotnet/dotnet"
    SHARED_LIBRARY_EXT=.dll
    SHARED_LIBRARY_PREFIX=
fi

# Need the SDK sysroot on macOS.
if [[ $(uname) == Darwin ]]; then
    EXTRA_PARSER_CXX_FLAGS+=(-isysroot "$(xcrun --show-sdk-path)")
    SHARED_LIBRARY_EXT=.dylib
    SHARED_LIBRARY_PREFIX=lib
fi

set -x

# Assemble the combined input header.
echo "#pragma once" >"$BINDINGS/tmp/combined_input.h"
echo "#include \"$(pwd)/$HELPER_DIR/jolt_helper.h\"" >>"$BINDINGS/tmp/combined_input.h"

# Parse the input header.
./build/mrbind \
    "$BINDINGS/tmp/combined_input.h" \
    -o "$BINDINGS/tmp/parse_result.json" \
    --ignore :: \
    --allow JoltVec3f \
    --allow JoltVec3 \
    --allow JoltQuat \
    --allow JoltMat44 \
    --allow JoltRMat44 \
    --allow JoltAABox \
    --allow JoltCollisionGroup \
    --allow JoltPhysicsMaterial \
    --allow JoltTwoBodyConstraint \
    --allow JoltBodyID \
    --allow JoltBodyIDList \
    --allow JoltConstraintID \
    --allow JoltShape \
    --allow JoltBoxShape \
    --allow JoltSphereShape \
    --allow JoltCapsuleShape \
    --allow JoltCylinderShape \
    --allow JoltRotatedTranslatedShape \
    --allow JoltBodyCreationSettings \
    --allow JoltSoftBodySharedSettings \
    --allow JoltSoftBodyCreationSettings \
    --allow JoltPhysicsSystem \
    --allow JoltBodyInterface \
    --allow JoltWorld \
    "${EXTRA_PARSER_FLAGS[@]+"${EXTRA_PARSER_FLAGS[@]}"}" \
    -- \
    -xc++-header \
    -resource-dir="$("$CLANG_CXX" -print-resource-dir)" \
    -I"$(pwd)/$HELPER_DIR" \
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
    --assume-include-dir "$(pwd)/$HELPER_DIR" \
    --force-emit-common-helpers \
    "${EXTRA_GEN_C_FLAGS[@]}"

# Generate the C# bindings.
./build/mrbind_gen_csharp \
    --input-json "$BINDINGS/tmp/c_desc.json" \
    --output-dir "$BINDINGS/csharp/src" \
    --imported-lib-name cjolt \
    --helpers-namespace Jolt \
    --force-namespace Jolt \
    "${EXTRA_GEN_FLAGS[@]}"
