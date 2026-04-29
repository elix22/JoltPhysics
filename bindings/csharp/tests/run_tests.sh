#!/usr/bin/env bash
# run_tests.sh — Build and run the JoltPhysics C# binding tests.
#
# Usage:
#   bash run_tests.sh [dotnet-test options]
#
# The script detects the current OS/architecture and sets the appropriate
# native-library search path before invoking `dotnet test`.

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
LIBS_DIR="$(cd "$SCRIPT_DIR/../../../libs" && pwd)"   # deps/JoltPhysics/libs

# ── Detect platform + arch ────────────────────────────────────────────────────
OS="$(uname -s)"
ARCH="$(uname -m)"

case "$OS" in
  Darwin)
    PLATFORM="macos"
    case "$ARCH" in
      arm64)  ARCH_DIR="arm64"  ;;
      x86_64) ARCH_DIR="x86_64" ;;
      *)      echo "Unsupported macOS arch: $ARCH"; exit 1 ;;
    esac
    NATIVE_LIB_DIR="$LIBS_DIR/$PLATFORM/$ARCH_DIR/release"
    export DYLD_LIBRARY_PATH="$NATIVE_LIB_DIR${DYLD_LIBRARY_PATH:+:$DYLD_LIBRARY_PATH}"
    ;;
  Linux)
    PLATFORM="linux"
    case "$ARCH" in
      x86_64)  ARCH_DIR="X64"   ;;
      aarch64) ARCH_DIR="arm64" ;;
      *)       echo "Unsupported Linux arch: $ARCH"; exit 1 ;;
    esac
    NATIVE_LIB_DIR="$LIBS_DIR/$PLATFORM/$ARCH_DIR/release"
    export LD_LIBRARY_PATH="$NATIVE_LIB_DIR${LD_LIBRARY_PATH:+:$LD_LIBRARY_PATH}"
    ;;
  MINGW*|MSYS*|CYGWIN*|Windows*)
    PLATFORM="windows"
    ARCH_DIR="x64"
    NATIVE_LIB_DIR="$LIBS_DIR/$PLATFORM/$ARCH_DIR/release"
    # On Windows, native DLLs must be on PATH.
    export PATH="$NATIVE_LIB_DIR:$PATH"
    ;;
  *)
    echo "Unsupported OS: $OS"
    exit 1
    ;;
esac

echo "Platform : $PLATFORM"
echo "Arch dir : $ARCH_DIR"
echo "Native libs: $NATIVE_LIB_DIR"

if [ ! -d "$NATIVE_LIB_DIR" ]; then
  echo "ERROR: native library directory not found: $NATIVE_LIB_DIR"
  exit 1
fi

# ── Run tests ─────────────────────────────────────────────────────────────────
exec dotnet test "$SCRIPT_DIR/tests.csproj" \
    --logger "console;verbosity=detailed" \
    "$@"
