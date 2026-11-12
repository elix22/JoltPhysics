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
# Pipe through awk which streams all output in real-time, buffers only the
# final "Test Run …" / "Test summary:" block, then injects a skipped/failed
# details section immediately before that block.  Works on macOS, Linux,
# Windows (Git Bash), and GitHub Actions — requires only POSIX awk and bash.
dotnet test "$SCRIPT_DIR/tests.csproj" \
    --logger "console;verbosity=detailed" \
    "$@" | awk '
BEGIN { in_summary = 0; buf = ""; skip_n = 0; fail_n = 0 }

/^  Skipped / {
    name = $0
    sub(/^  Skipped /, "", name)
    sub(/ \[.*$/, "", name)
    skipped[skip_n++] = name
}
/^  Failed / {
    name = $0
    sub(/^  Failed /, "", name)
    sub(/ \[.*$/, "", name)
    failed[fail_n++] = name
}

/^Test Run /     { in_summary = 1 }
/^Test summary:/ { in_summary = 1 }

in_summary { buf = buf $0 "\n"; next }
           { print; fflush() }

END {
    if (skip_n > 0 || fail_n > 0) {
        print ""
        print "--- Skipped / Failed test details ---"
        if (fail_n > 0) {
            print "Failed:"
            for (i = 0; i < fail_n; i++) print "  " failed[i]
        }
        if (skip_n > 0) {
            print "Skipped:"
            for (i = 0; i < skip_n; i++) print "  " skipped[i]
        }
        print "-------------------------------------"
    }
    printf "%s", buf
}
'
EXIT_CODE=${PIPESTATUS[0]}
exit $EXIT_CODE
