#!/bin/bash
# Build script for cjolt library on macOS
# Usage: ./build-cjolt-macos.sh [architecture] [build_type]
# Example: ./build-cjolt-macos.sh arm64 Release
# Example: ./build-cjolt-macos.sh x86_64 Debug

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
JOLT_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"
BINDINGS_C_DIR="$JOLT_DIR/bindings/c"

# Parse arguments
ARCH="${1:-arm64}"
BUILD_TYPE="${2:-Release}"

BUILD_DIR="$JOLT_DIR/build-xcode-macos-$ARCH"

echo "=========================================="
echo "Building cjolt for macOS"
echo "Architecture: $ARCH"
echo "Build Type: $BUILD_TYPE"
echo "=========================================="

# Create build directory
mkdir -p "$BUILD_DIR"
cd "$BUILD_DIR"

# Configure with CMake
cmake "$BINDINGS_C_DIR" \
    -G Xcode \
    -DCMAKE_OSX_ARCHITECTURES="$ARCH" \
    -DCMAKE_OSX_DEPLOYMENT_TARGET="11.0" \
    -DGENERATE_DEBUG_SYMBOLS=OFF

# Build
cmake --build . --config "$BUILD_TYPE"

echo "=========================================="
echo "Build complete!"
echo "Output: $BUILD_DIR/$BUILD_TYPE/libcjolt.dylib"
echo "=========================================="

# Verify the library was created
if [ -f "$BUILD_DIR/$BUILD_TYPE/libcjolt.dylib" ]; then
    echo "✓ Successfully built libcjolt.dylib"
    file "$BUILD_DIR/$BUILD_TYPE/libcjolt.dylib"

    # Copy to libs folder
    OUTPUT_DIR="$JOLT_DIR/libs/macos/$ARCH/$(echo "$BUILD_TYPE" | tr '[:upper:]' '[:lower:]')"
    mkdir -p "$OUTPUT_DIR"
    cp "$BUILD_DIR/$BUILD_TYPE/libcjolt.dylib" "$OUTPUT_DIR/"

    echo "=========================================="
    echo "✓ Copied to: $OUTPUT_DIR/libcjolt.dylib"
    echo "=========================================="
    echo "Tip: to create a universal binary run both arm64 and x86_64 builds then:"
    echo "  lipo -create libs/macos/arm64/release/libcjolt.dylib \\"
    echo "              libs/macos/x86_64/release/libcjolt.dylib \\"
    echo "       -output libs/macos/universal/release/libcjolt.dylib"
else
    echo "✗ Failed to build libcjolt.dylib"
    exit 1
fi
