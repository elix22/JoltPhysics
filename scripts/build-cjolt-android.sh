#!/bin/bash
# Build script for cjolt library for Android
# Usage: ./build-cjolt-android.sh [abi] [build_type]
# Example: ./build-cjolt-android.sh arm64-v8a Release
# Example: ./build-cjolt-android.sh armeabi-v7a Debug
# Supported ABIs: arm64-v8a, armeabi-v7a, x86_64

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
JOLT_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"
BINDINGS_C_DIR="$JOLT_DIR/bindings/c"

# Parse arguments
ANDROID_ABI="${1:-arm64-v8a}"
BUILD_TYPE="${2:-Release}"
BUILD_DIR="$JOLT_DIR/build-android-$ANDROID_ABI"

echo "=========================================="
echo "Building cjolt for Android"
echo "ABI: $ANDROID_ABI"
echo "Build Type: $BUILD_TYPE"
echo "=========================================="

# Check for Android NDK
if [ -z "$ANDROID_NDK" ]; then
    if [ -z "$ANDROID_NDK_HOME" ]; then
        echo "Error: ANDROID_NDK or ANDROID_NDK_HOME environment variable not set"
        echo "Please set one of these to your Android NDK path"
        exit 1
    fi
    ANDROID_NDK="$ANDROID_NDK_HOME"
fi

if [ ! -d "$ANDROID_NDK" ]; then
    echo "Error: Android NDK not found at: $ANDROID_NDK"
    exit 1
fi

echo "Using Android NDK: $ANDROID_NDK"

# Determine API level
ANDROID_NATIVE_API_LEVEL="${ANDROID_NATIVE_API_LEVEL:-21}"
echo "API Level: $ANDROID_NATIVE_API_LEVEL"

# Create build directory
mkdir -p "$BUILD_DIR"
cd "$BUILD_DIR"

# Configure with CMake
cmake "$BINDINGS_C_DIR" \
    -DCMAKE_TOOLCHAIN_FILE="$ANDROID_NDK/build/cmake/android.toolchain.cmake" \
    -DANDROID_ABI="$ANDROID_ABI" \
    -DANDROID_NATIVE_API_LEVEL="$ANDROID_NATIVE_API_LEVEL" \
    -DANDROID_STL=c++_shared \
    -DANDROID_ARM_NEON=TRUE \
    -DCMAKE_BUILD_TYPE="$BUILD_TYPE" \
    -DENABLE_OBJECT_STREAM=ON

# Build
cmake --build . --config "$BUILD_TYPE" -- -j$(nproc)

echo "=========================================="
echo "Build complete!"
echo "Output: $BUILD_DIR/libcjolt.so"
echo "=========================================="

# Verify the library was created
if [ -f "$BUILD_DIR/libcjolt.so" ]; then
    echo "✓ Successfully built libcjolt.so for $ANDROID_ABI"
    ls -lh "$BUILD_DIR/libcjolt.so"

    # Copy to libs folder
    OUTPUT_DIR="$JOLT_DIR/libs/android/$ANDROID_ABI/$(echo "$BUILD_TYPE" | tr '[:upper:]' '[:lower:]')"
    mkdir -p "$OUTPUT_DIR"
    cp "$BUILD_DIR/libcjolt.so" "$OUTPUT_DIR/"

    # Strip debug symbols from release builds using the NDK's llvm-strip
    if [ "$BUILD_TYPE" = "Release" ]; then
        NDK_STRIP=$(find "$ANDROID_NDK/toolchains/llvm/prebuilt" -name "llvm-strip" 2>/dev/null | head -1)
        if [ -n "$NDK_STRIP" ]; then
            "$NDK_STRIP" --strip-unneeded "$OUTPUT_DIR/libcjolt.so"
            echo "✓ Stripped debug symbols"
        fi
    fi

    echo "=========================================="
    echo "✓ Copied to: $OUTPUT_DIR/libcjolt.so"
    echo "=========================================="
else
    echo "✗ Failed to build libcjolt.so"
    exit 1
fi
