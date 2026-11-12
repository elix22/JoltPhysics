#!/bin/bash

SCRIPT_DIR="$(cd "$(dirname "$BASH_SOURCE")" && pwd)"
cd "$SCRIPT_DIR/../../.."   # repo root

rm -rf deps/JoltPhysics/bindings/c \
       deps/JoltPhysics/bindings/csharp/src \
       deps/JoltPhysics/bindings/csharp/bin \
       deps/JoltPhysics/bindings/csharp/obj \
       deps/JoltPhysics/bindings/tmp
