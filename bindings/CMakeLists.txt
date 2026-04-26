cmake_minimum_required(VERSION 3.20)
project(cjolt)

# From bindings/c/: ../.. = deps/JoltPhysics/
set(JOLT_ROOT "${CMAKE_CURRENT_SOURCE_DIR}/../..")
set(HELPER_DIR "${CMAKE_CURRENT_SOURCE_DIR}/..")

# ---- Jolt build configuration ----
# Disable everything except the core library
set(TARGET_UNIT_TESTS                   OFF CACHE BOOL "" FORCE)
set(TARGET_HELLO_WORLD                  OFF CACHE BOOL "" FORCE)
set(TARGET_PERFORMANCE_TEST             OFF CACHE BOOL "" FORCE)
set(TARGET_SAMPLES                      OFF CACHE BOOL "" FORCE)
set(TARGET_VIEWER                       OFF CACHE BOOL "" FORCE)
set(ENABLE_ALL_WARNINGS                 OFF CACHE BOOL "" FORCE)
set(ENABLE_INSTALL                      OFF CACHE BOOL "" FORCE)
# Keep debug renderer and profiler out of the distribution build
set(DEBUG_RENDERER_IN_DEBUG_AND_RELEASE OFF CACHE BOOL "" FORCE)
set(PROFILER_IN_DEBUG_AND_RELEASE       OFF CACHE BOOL "" FORCE)
# Build Jolt as a static library so we can absorb it into libcjolt
set(BUILD_SHARED_LIBS                   OFF CACHE BOOL "" FORCE)

# All objects (Jolt and ours) must be compiled with PIC so they can
# be linked into a shared library on Linux / Android.
set(CMAKE_POSITION_INDEPENDENT_CODE ON)

# Pull in Jolt's proper build system — this creates the `Jolt` static-lib
# target with all the right compile flags (SIMD, LTO, -fno-rtti,
# -fno-exceptions, -ffp-model=precise, etc.)
add_subdirectory("${JOLT_ROOT}/Build" jolt_build)

# ---- Generated binding sources ----
file(GLOB_RECURSE BINDING_SOURCES "${CMAKE_CURRENT_SOURCE_DIR}/src/*.cpp")

# ---- cjolt target ----
if(EMSCRIPTEN)
    # Emscripten: static archive; just link Jolt normally
    add_library(cjolt STATIC
        ${BINDING_SOURCES}
        "${HELPER_DIR}/jolt_helper.cpp"
    )
    set_target_properties(cjolt PROPERTIES PREFIX "")
    target_link_libraries(cjolt PRIVATE Jolt)
else()
    add_library(cjolt SHARED
        ${BINDING_SOURCES}
        "${HELPER_DIR}/jolt_helper.cpp"
    )
    # Absorb the entire Jolt static lib into libcjolt so consumers only
    # need to link a single library.  We use add_dependencies for build
    # ordering and whole-archive flags for the actual symbol inclusion;
    # target_link_libraries is intentionally NOT used here to avoid
    # double-linking Jolt.
    add_dependencies(cjolt Jolt)
    if(APPLE)
        target_link_options(cjolt PRIVATE "LINKER:-force_load,$<TARGET_FILE:Jolt>")
    elseif(MSVC OR (CMAKE_CXX_COMPILER_ID STREQUAL "Clang" AND WIN32))
        target_link_options(cjolt PRIVATE "/WHOLEARCHIVE:$<TARGET_FILE:Jolt>")
    else()
        # Linux / Android
        target_link_options(cjolt PRIVATE
            "LINKER:--whole-archive"
            "$<TARGET_FILE:Jolt>"
            "LINKER:--no-whole-archive"
        )
    endif()
endif()

# Propagate Jolt's include dirs and compile definitions to our binding code
# so jolt_helper.cpp and the generated sources see the same defines Jolt used.
target_include_directories(cjolt PRIVATE
    "${CMAKE_CURRENT_SOURCE_DIR}/include"
    "${CMAKE_CURRENT_SOURCE_DIR}/src"
    "${HELPER_DIR}"
    "${JOLT_ROOT}"
    $<TARGET_PROPERTY:Jolt,INTERFACE_INCLUDE_DIRECTORIES>
)
target_compile_definitions(cjolt PRIVATE
    $<TARGET_PROPERTY:Jolt,INTERFACE_COMPILE_DEFINITIONS>
)

set_target_properties(cjolt PROPERTIES
    OUTPUT_NAME "cjolt"
    POSITION_INDEPENDENT_CODE ON
    CXX_STANDARD 17
    CXX_STANDARD_REQUIRED ON
)

if(MSVC AND NOT CMAKE_CXX_COMPILER_ID STREQUAL "Clang")
    string(REPLACE "/EHsc" "/EHs" CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS}")
else()
    target_compile_options(cjolt PRIVATE
        -fvisibility=hidden
        -fvisibility-inlines-hidden
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
