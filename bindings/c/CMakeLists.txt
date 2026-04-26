cmake_minimum_required(VERSION 3.14)
project(cjolt)

# From bindings/c/:  ../..  = deps/JoltPhysics/
set(JOLT_ROOT "${CMAKE_CURRENT_SOURCE_DIR}/../..")
# Helper files (jolt_helper.h/cpp) live in bindings/ (one level up from bindings/c/)
set(HELPER_DIR "${CMAKE_CURRENT_SOURCE_DIR}/..")

file(GLOB_RECURSE BINDING_SOURCES
    "${CMAKE_CURRENT_SOURCE_DIR}/src/*.cpp"
)

file(GLOB_RECURSE JOLT_SOURCES
    "${JOLT_ROOT}/Jolt/*.cpp"
)

if(EMSCRIPTEN)
    add_library(cjolt STATIC
        ${BINDING_SOURCES}
        "${HELPER_DIR}/jolt_helper.cpp"
        ${JOLT_SOURCES}
    )
    set_target_properties(cjolt PROPERTIES PREFIX "")
else()
    add_library(cjolt SHARED
        ${BINDING_SOURCES}
        "${HELPER_DIR}/jolt_helper.cpp"
        ${JOLT_SOURCES}
    )
endif()

target_include_directories(cjolt PRIVATE
    "${CMAKE_CURRENT_SOURCE_DIR}/include"
    "${CMAKE_CURRENT_SOURCE_DIR}/src"
    "${HELPER_DIR}"
    "${JOLT_ROOT}"
)

set_target_properties(cjolt PROPERTIES
    OUTPUT_NAME "cjolt"
    POSITION_INDEPENDENT_CODE ON
    CXX_STANDARD 17
    CXX_STANDARD_REQUIRED ON
)

if(MSVC AND NOT CMAKE_CXX_COMPILER_ID STREQUAL "Clang")
    # Pure MSVC: relax EH flags
    string(REPLACE "/EHsc" "/EHs" CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS}")
    target_compile_options(cjolt PRIVATE /W0)
else()
    target_compile_options(cjolt PRIVATE
        -fvisibility=hidden
        -fvisibility-inlines-hidden
        -w
    )
endif()

if(APPLE AND CMAKE_SYSTEM_NAME STREQUAL "iOS")
    set_target_properties(cjolt PROPERTIES
        FRAMEWORK TRUE
        FRAMEWORK_VERSION A
        MACOSX_FRAMEWORK_IDENTIFIER com.jolt.cjolt
        MACOSX_FRAMEWORK_INFO_PLIST "${CMAKE_CURRENT_SOURCE_DIR}/../../scripts/Info.plist"
    )
endif()

# SIMD: armeabi-v7a needs explicit -mfpu=neon
if(NOT EMSCRIPTEN)
    if(ANDROID AND ANDROID_ABI STREQUAL "armeabi-v7a")
        target_compile_options(cjolt PRIVATE -mfpu=neon)
    elseif(NOT (MSVC AND NOT CMAKE_CXX_COMPILER_ID STREQUAL "Clang"))
        if(CMAKE_OSX_ARCHITECTURES STREQUAL "x86_64" OR
           (NOT CMAKE_OSX_ARCHITECTURES AND
            CMAKE_SYSTEM_PROCESSOR MATCHES "x86_64|AMD64|amd64"))
            target_compile_options(cjolt PRIVATE -msse4.1)
        endif()
    endif()
endif()
