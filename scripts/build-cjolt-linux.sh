#!/bin/bash
# Build script for cjolt library on Linux
# Usage: ./build-cjolt-linux.sh [build_type]
# Example: ./build-cjolt-linux.sh Release
# Example: ./build-cjolt-linux.sh Debug

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
JOLT_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"
BINDINGS_C_DIR="$JOLT_DIR/bindings/c"
BUILD_DIR="$JOLT_DIR/build-linux"

# Parse arguments - default to Release
BUILD_TYPE="${1:-Release}"

echo "=========================================="
echo "Building cjolt for Linux"
echo "Build Type: $BUILD_TYPE"
echo "=========================================="

# Create build directory
mkdir -p "$BUILD_DIR"
cd "$BUILD_DIR"

# Prefer clang for better vectorization and fewer false-positive warnings with Jolt.
# Fall back to whatever the system provides if clang is not available.
if command -v clang++ &>/dev/null; then
    C_COMPILER="clang"
    CXX_COMPILER="clang++"
else
    C_COMPILER="${CC:-cc}"
    CXX_COMPILER="${CXX:-c++}"
fi
echo "Compiler: $CXX_COMPILER"

# Configure with CMake
cmake "$BINDINGS_C_DIR" \
    -DCMAKE_BUILD_TYPE="$BUILD_TYPE" \
    -DCMAKE_C_COMPILER="$C_COMPILER" \
    -DCMAKE_CXX_COMPILER="$CXX_COMPILER" \
    -DINTERPROCEDURAL_OPTIMIZATION=OFF \
    -DENABLE_OBJECT_STREAM=ON  # Clang LTO bitcode objects are incompatible with ld --whole-archive

# Build
cmake --build . --config "$BUILD_TYPE" -- -j$(nproc)

echo "=========================================="
echo "Build complete!"
echo "Output: $BUILD_DIR/libcjolt.so"
echo "=========================================="

# Verify the library was created
if [ -f "$BUILD_DIR/libcjolt.so" ]; then
    echo "✓ Successfully built libcjolt.so"
    file "$BUILD_DIR/libcjolt.so"

    # Copy to the expected location
    ARCH="X64"
    if [ "$BUILD_TYPE" = "Debug" ]; then
        OUTPUT_DIR="$JOLT_DIR/libs/linux/$ARCH/debug"
    else
        OUTPUT_DIR="$JOLT_DIR/libs/linux/$ARCH/release"
    fi

    mkdir -p "$OUTPUT_DIR"
    cp "$BUILD_DIR/libcjolt.so" "$OUTPUT_DIR/"

    # Strip debug symbols from release builds to reduce size (~35 MB → ~2.5 MB)
    if [ "$BUILD_TYPE" = "Release" ]; then
        strip --strip-unneeded "$OUTPUT_DIR/libcjolt.so"
        echo "✓ Stripped debug symbols"
    fi

    echo "=========================================="
    echo "✓ Copied to: $OUTPUT_DIR/libcjolt.so"
    echo "=========================================="
else
    echo "✗ Failed to build libcjolt.so"
    exit 1
fi
