// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Renderer/DebugRenderer.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Float2.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <functional>
#include <memory>
#include <new>
#include <stdexcept>
#include <type_traits>


JPH_DebugRenderer *const *JPH_DebugRenderer_Get_sInstance(void)
{
    return (JPH_DebugRenderer *const *)std::addressof(JPH::DebugRenderer::sInstance);
}

void JPH_DebugRenderer_Set_sInstance(JPH_DebugRenderer *value)
{
    JPH::DebugRenderer::sInstance = ((JPH::DebugRenderer *)value);
}

JPH_DebugRenderer **JPH_DebugRenderer_GetMutable_sInstance(void)
{
    return (JPH_DebugRenderer **)std::addressof(JPH::DebugRenderer::sInstance);
}

void JPH_DebugRenderer_Destroy(const JPH_DebugRenderer *_this)
{
    delete ((const JPH::DebugRenderer *)_this);
}

void JPH_DebugRenderer_DestroyArray(const JPH_DebugRenderer *_this)
{
    delete[] ((const JPH::DebugRenderer *)_this);
}

void *Jolt_new_JPH_DebugRenderer_size_t(size_t inCount)
{
    return JPH::DebugRenderer::operator new(
        inCount
    );
}

void Jolt_delete_JPH_DebugRenderer_void_ptr(void *inPointer)
{
    JPH::DebugRenderer::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_DebugRenderer_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DebugRenderer::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_DebugRenderer_size_t(size_t inCount)
{
    return JPH::DebugRenderer::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_DebugRenderer_void_ptr(void *inPointer)
{
    JPH::DebugRenderer::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_DebugRenderer_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DebugRenderer::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_DebugRenderer_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DebugRenderer::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_DebugRenderer_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DebugRenderer::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_DebugRenderer_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DebugRenderer::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_DebugRenderer_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DebugRenderer::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_DebugRenderer_NextFrame(JPH_DebugRenderer *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).NextFrame();
}

void JPH_DebugRenderer_DrawLine(JPH_DebugRenderer *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawLine(
        ((inFrom ? void() : MRBINDC_THROW("Parameter `inFrom` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inFrom)),
        ((inTo ? void() : MRBINDC_THROW("Parameter `inTo` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTo)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor))
    );
}

void JPH_DebugRenderer_DrawWireBox_2_JPH_AABox(JPH_DebugRenderer *_this, const JPH_AABox *inBox, const JPH_Color *inColor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawWireBox(
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor))
    );
}

void JPH_DebugRenderer_DrawWireBox_3(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_AABox *inBox, const JPH_Color *inColor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawWireBox(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor))
    );
}

void JPH_DebugRenderer_DrawMarker(JPH_DebugRenderer *_this, const JPH_Vec3 *inPosition, const JPH_Color *inColor, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawMarker(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inSize
    );
}

void JPH_DebugRenderer_DrawArrow(JPH_DebugRenderer *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawArrow(
        ((inFrom ? void() : MRBINDC_THROW("Parameter `inFrom` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inFrom)),
        ((inTo ? void() : MRBINDC_THROW("Parameter `inTo` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTo)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inSize
    );
}

void JPH_DebugRenderer_DrawCoordinateSystem(JPH_DebugRenderer *_this, const JPH_Mat44 *inTransform, const float *inSize)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawCoordinateSystem(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform)),
        (inSize ? *inSize : static_cast<float>(1.F))
    );
}

void JPH_DebugRenderer_DrawPlane(JPH_DebugRenderer *_this, const JPH_Vec3 *inPoint, const JPH_Vec3 *inNormal, const JPH_Color *inColor, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawPlane(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint)),
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inSize
    );
}

void JPH_DebugRenderer_DrawWireTriangle(JPH_DebugRenderer *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawWireTriangle(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor))
    );
}

void JPH_DebugRenderer_DrawWireSphere(JPH_DebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const int *inLevel)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawWireSphere(
        ((inCenter ? void() : MRBINDC_THROW("Parameter `inCenter` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenter)),
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inLevel ? *inLevel : static_cast<int>(3))
    );
}

void JPH_DebugRenderer_DrawWireUnitSphere(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const int *inLevel)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawWireUnitSphere(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inLevel ? *inLevel : static_cast<int>(3))
    );
}

void JPH_DebugRenderer_DrawTriangle(JPH_DebugRenderer *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawTriangle(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::Off))
    );
}

void JPH_DebugRenderer_DrawBox_4(JPH_DebugRenderer *_this, const JPH_AABox *inBox, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawBox(
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawBox_5(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_AABox *inBox, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawBox(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawSphere(JPH_DebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawSphere(
        ((inCenter ? void() : MRBINDC_THROW("Parameter `inCenter` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenter)),
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawUnitSphere(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawUnitSphere(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawCapsule(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inHalfHeightOfCylinder, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawCapsule(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inHalfHeightOfCylinder,
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawCylinder(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inHalfHeight, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawCylinder(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inHalfHeight,
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawOpenCone(JPH_DebugRenderer *_this, const JPH_Vec3 *inTop, const JPH_Vec3 *inAxis, const JPH_Vec3 *inPerpendicular, float inHalfAngle, float inLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawOpenCone(
        ((inTop ? void() : MRBINDC_THROW("Parameter `inTop` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTop)),
        ((inAxis ? void() : MRBINDC_THROW("Parameter `inAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAxis)),
        ((inPerpendicular ? void() : MRBINDC_THROW("Parameter `inPerpendicular` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPerpendicular)),
        inHalfAngle,
        inLength,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawSwingConeLimits(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawSwingConeLimits(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inSwingYHalfAngle,
        inSwingZHalfAngle,
        inEdgeLength,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawSwingPyramidLimits(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawSwingPyramidLimits(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inMinSwingYAngle,
        inMaxSwingYAngle,
        inMinSwingZAngle,
        inMaxSwingZAngle,
        inEdgeLength,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawPie(JPH_DebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Vec3 *inNormal, const JPH_Vec3 *inAxis, float inMinAngle, float inMaxAngle, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawPie(
        ((inCenter ? void() : MRBINDC_THROW("Parameter `inCenter` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenter)),
        inRadius,
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal)),
        ((inAxis ? void() : MRBINDC_THROW("Parameter `inAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAxis)),
        inMinAngle,
        inMaxAngle,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRenderer_DrawTaperedCylinder(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer *)(_this)).DrawTaperedCylinder(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inTop,
        inBottom,
        inTopRadius,
        inBottomRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

JPH_AABox *JPH_DebugRenderer_sCalculateBounds(const JPH_DebugRenderer_Vertex *inVertices, int inVertexCount)
{
    return (JPH_AABox *)new JPH::AABox(JPH::DebugRenderer::sCalculateBounds(
        ((const JPH::DebugRenderer::Vertex *)inVertices),
        inVertexCount
    ));
}

const JPH_DebugRenderer *JPH_DebugRenderer_OffsetPtr(const JPH_DebugRenderer *ptr, ptrdiff_t i)
{
    return (const JPH_DebugRenderer *)(((const JPH::DebugRenderer *)ptr) + i);
}

JPH_DebugRenderer *JPH_DebugRenderer_OffsetMutablePtr(JPH_DebugRenderer *ptr, ptrdiff_t i)
{
    return (JPH_DebugRenderer *)(((JPH::DebugRenderer *)ptr) + i);
}

const JPH_NonCopyable *JPH_DebugRenderer_UpcastTo_JPH_NonCopyable(const JPH_DebugRenderer *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::DebugRenderer *)object)
    ));
}

JPH_NonCopyable *JPH_DebugRenderer_MutableUpcastTo_JPH_NonCopyable(JPH_DebugRenderer *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::DebugRenderer *)object)
    ));
}

const JPH_DebugRenderer *JPH_DebugRenderer_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_DebugRenderer *)(static_cast<const JPH::DebugRenderer *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_DebugRenderer *JPH_DebugRenderer_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_DebugRenderer *)(static_cast<JPH::DebugRenderer *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Float3 *JPH_DebugRenderer_Vertex_Get_mPosition(const JPH_DebugRenderer_Vertex *_this)
{
    return (const JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Vertex *)(_this)).mPosition);
}

JPH_Float3 *JPH_DebugRenderer_Vertex_GetMutable_mPosition(JPH_DebugRenderer_Vertex *_this)
{
    return (JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Vertex *)(_this)).mPosition);
}

const JPH_Float3 *JPH_DebugRenderer_Vertex_Get_mNormal(const JPH_DebugRenderer_Vertex *_this)
{
    return (const JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Vertex *)(_this)).mNormal);
}

JPH_Float3 *JPH_DebugRenderer_Vertex_GetMutable_mNormal(JPH_DebugRenderer_Vertex *_this)
{
    return (JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Vertex *)(_this)).mNormal);
}

const JPH_Float2 *JPH_DebugRenderer_Vertex_Get_mUV(const JPH_DebugRenderer_Vertex *_this)
{
    return (const JPH_Float2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Vertex *)(_this)).mUV);
}

JPH_Float2 *JPH_DebugRenderer_Vertex_GetMutable_mUV(JPH_DebugRenderer_Vertex *_this)
{
    return (JPH_Float2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Vertex *)(_this)).mUV);
}

const JPH_Color *JPH_DebugRenderer_Vertex_Get_mColor(const JPH_DebugRenderer_Vertex *_this)
{
    return (const JPH_Color *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Vertex *)(_this)).mColor);
}

JPH_Color *JPH_DebugRenderer_Vertex_GetMutable_mColor(JPH_DebugRenderer_Vertex *_this)
{
    return (JPH_Color *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Vertex *)(_this)).mColor);
}

JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_DefaultConstruct(void)
{
    using _mrbind_T = JPH::DebugRenderer::Vertex;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_DebugRenderer_Vertex*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_DefaultConstructArray(size_t num_elems)
{
    return (JPH_DebugRenderer_Vertex *)(new JPH::DebugRenderer::Vertex[num_elems]);
}

JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_ConstructFrom(const JPH_Float3 *mPosition, const JPH_Float3 *mNormal, const JPH_Float2 *mUV, const JPH_Color *mColor)
{
    return (JPH_DebugRenderer_Vertex *)new JPH::DebugRenderer::Vertex(JPH::DebugRenderer::Vertex{
        ((mPosition ? void() : MRBINDC_THROW("Parameter `mPosition` can not be null.", void)), JPH::Float3(*(JPH::Float3 *)mPosition)),
        ((mNormal ? void() : MRBINDC_THROW("Parameter `mNormal` can not be null.", void)), JPH::Float3(*(JPH::Float3 *)mNormal)),
        ((mUV ? void() : MRBINDC_THROW("Parameter `mUV` can not be null.", void)), JPH::Float2(*(JPH::Float2 *)mUV)),
        ((mColor ? void() : MRBINDC_THROW("Parameter `mColor` can not be null.", void)), JPH::Color(*(JPH::Color *)mColor))
    });
}

const JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_OffsetPtr(const JPH_DebugRenderer_Vertex *ptr, ptrdiff_t i)
{
    return (const JPH_DebugRenderer_Vertex *)(((const JPH::DebugRenderer::Vertex *)ptr) + i);
}

JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_OffsetMutablePtr(JPH_DebugRenderer_Vertex *ptr, ptrdiff_t i)
{
    return (JPH_DebugRenderer_Vertex *)(((JPH::DebugRenderer::Vertex *)ptr) + i);
}

JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_ConstructFromAnother(const JPH_DebugRenderer_Vertex *_other)
{
    return (JPH_DebugRenderer_Vertex *)new JPH::DebugRenderer::Vertex(JPH::DebugRenderer::Vertex(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::DebugRenderer::Vertex(*(JPH::DebugRenderer::Vertex *)_other))
    ));
}

void JPH_DebugRenderer_Vertex_Destroy(const JPH_DebugRenderer_Vertex *_this)
{
    delete ((const JPH::DebugRenderer::Vertex *)_this);
}

void JPH_DebugRenderer_Vertex_DestroyArray(const JPH_DebugRenderer_Vertex *_this)
{
    delete[] ((const JPH::DebugRenderer::Vertex *)_this);
}

JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_AssignFromAnother(JPH_DebugRenderer_Vertex *_this, const JPH_DebugRenderer_Vertex *_other)
{
    return (JPH_DebugRenderer_Vertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Vertex *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::DebugRenderer::Vertex(*(JPH::DebugRenderer::Vertex *)_other))
    ));
}

const JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Triangle_Get_mV(const JPH_DebugRenderer_Triangle *_this)
{
    return (const JPH_DebugRenderer_Vertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Triangle *)(_this)).mV[0]);
}

JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Triangle_GetMutable_mV(JPH_DebugRenderer_Triangle *_this)
{
    return (JPH_DebugRenderer_Vertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Triangle *)(_this)).mV[0]);
}

size_t JPH_DebugRenderer_Triangle_GetSize_mV(void)
{
    return std::extent_v<decltype(JPH::DebugRenderer::Triangle::mV)>;
}

JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_DefaultConstruct(void)
{
    using _mrbind_T = JPH::DebugRenderer::Triangle;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_DebugRenderer_Triangle*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_DefaultConstructArray(size_t num_elems)
{
    return (JPH_DebugRenderer_Triangle *)(new JPH::DebugRenderer::Triangle[num_elems]);
}

const JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_OffsetPtr(const JPH_DebugRenderer_Triangle *ptr, ptrdiff_t i)
{
    return (const JPH_DebugRenderer_Triangle *)(((const JPH::DebugRenderer::Triangle *)ptr) + i);
}

JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_OffsetMutablePtr(JPH_DebugRenderer_Triangle *ptr, ptrdiff_t i)
{
    return (JPH_DebugRenderer_Triangle *)(((JPH::DebugRenderer::Triangle *)ptr) + i);
}

JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_ConstructFromAnother(const JPH_DebugRenderer_Triangle *_other)
{
    return (JPH_DebugRenderer_Triangle *)new JPH::DebugRenderer::Triangle(JPH::DebugRenderer::Triangle(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::DebugRenderer::Triangle(*(JPH::DebugRenderer::Triangle *)_other))
    ));
}

JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_Construct_4(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor)
{
    return (JPH_DebugRenderer_Triangle *)new JPH::DebugRenderer::Triangle(JPH::DebugRenderer::Triangle(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor))
    ));
}

JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_Construct_6(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor, const JPH_Vec3 *inUVOrigin, const JPH_Vec3 *inUVDirection)
{
    return (JPH_DebugRenderer_Triangle *)new JPH::DebugRenderer::Triangle(JPH::DebugRenderer::Triangle(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        ((inUVOrigin ? void() : MRBINDC_THROW("Parameter `inUVOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inUVOrigin)),
        ((inUVDirection ? void() : MRBINDC_THROW("Parameter `inUVDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inUVDirection))
    ));
}

void JPH_DebugRenderer_Triangle_Destroy(const JPH_DebugRenderer_Triangle *_this)
{
    delete ((const JPH::DebugRenderer::Triangle *)_this);
}

void JPH_DebugRenderer_Triangle_DestroyArray(const JPH_DebugRenderer_Triangle *_this)
{
    delete[] ((const JPH::DebugRenderer::Triangle *)_this);
}

JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_AssignFromAnother(JPH_DebugRenderer_Triangle *_this, const JPH_DebugRenderer_Triangle *_other)
{
    return (JPH_DebugRenderer_Triangle *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Triangle *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::DebugRenderer::Triangle(*(JPH::DebugRenderer::Triangle *)_other))
    ));
}

const float *JPH_DebugRenderer_LOD_Get_mDistance(const JPH_DebugRenderer_LOD *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::LOD *)(_this)).mDistance);
}

void JPH_DebugRenderer_LOD_Set_mDistance(JPH_DebugRenderer_LOD *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::LOD *)(_this)).mDistance = value;
}

float *JPH_DebugRenderer_LOD_GetMutable_mDistance(JPH_DebugRenderer_LOD *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::LOD *)(_this)).mDistance);
}

JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_DefaultConstruct(void)
{
    using _mrbind_T = JPH::DebugRenderer::LOD;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_DebugRenderer_LOD*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_DefaultConstructArray(size_t num_elems)
{
    return (JPH_DebugRenderer_LOD *)(new JPH::DebugRenderer::LOD[num_elems]);
}

const JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_OffsetPtr(const JPH_DebugRenderer_LOD *ptr, ptrdiff_t i)
{
    return (const JPH_DebugRenderer_LOD *)(((const JPH::DebugRenderer::LOD *)ptr) + i);
}

JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_OffsetMutablePtr(JPH_DebugRenderer_LOD *ptr, ptrdiff_t i)
{
    return (JPH_DebugRenderer_LOD *)(((JPH::DebugRenderer::LOD *)ptr) + i);
}

JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_DebugRenderer_LOD *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::DebugRenderer::LOD);
    return (JPH_DebugRenderer_LOD *)new JPH::DebugRenderer::LOD(JPH::DebugRenderer::LOD(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_COPY(_other, (JPH::DebugRenderer::LOD), JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_MOVE(_other, (JPH::DebugRenderer::LOD), JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_END(_other, JPH::DebugRenderer::LOD))
    ));
}

void JPH_DebugRenderer_LOD_Destroy(const JPH_DebugRenderer_LOD *_this)
{
    delete ((const JPH::DebugRenderer::LOD *)_this);
}

void JPH_DebugRenderer_LOD_DestroyArray(const JPH_DebugRenderer_LOD *_this)
{
    delete[] ((const JPH::DebugRenderer::LOD *)_this);
}

JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_AssignFromAnother(JPH_DebugRenderer_LOD *_this, Jolt_PassBy _other_pass_by, JPH_DebugRenderer_LOD *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::DebugRenderer::LOD);
    return (JPH_DebugRenderer_LOD *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::LOD *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_COPY(_other, (JPH::DebugRenderer::LOD), JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_MOVE(_other, (JPH::DebugRenderer::LOD), JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_END(_other, JPH::DebugRenderer::LOD))
    ));
}

const Jolt_JPH_Array_JPH_DebugRenderer_LOD *JPH_DebugRenderer_Geometry_Get_mLODs(const JPH_DebugRenderer_Geometry *_this)
{
    return (const Jolt_JPH_Array_JPH_DebugRenderer_LOD *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Geometry *)(_this)).mLODs);
}

void JPH_DebugRenderer_Geometry_Set_mLODs(JPH_DebugRenderer_Geometry *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_DebugRenderer_LOD *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::Array<JPH::DebugRenderer::LOD>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Geometry *)(_this)).mLODs = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_COPY(value, (JPH::Array<JPH::DebugRenderer::LOD>), JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_MOVE(value, (JPH::Array<JPH::DebugRenderer::LOD>), JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_END(value, JPH::Array<JPH::DebugRenderer::LOD>));
}

Jolt_JPH_Array_JPH_DebugRenderer_LOD *JPH_DebugRenderer_Geometry_GetMutable_mLODs(JPH_DebugRenderer_Geometry *_this)
{
    return (Jolt_JPH_Array_JPH_DebugRenderer_LOD *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Geometry *)(_this)).mLODs);
}

const JPH_AABox *JPH_DebugRenderer_Geometry_Get_mBounds(const JPH_DebugRenderer_Geometry *_this)
{
    return (const JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Geometry *)(_this)).mBounds);
}

void JPH_DebugRenderer_Geometry_Set_mBounds(JPH_DebugRenderer_Geometry *_this, const JPH_AABox *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Geometry *)(_this)).mBounds = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::AABox(*(JPH::AABox *)value));
}

JPH_AABox *JPH_DebugRenderer_Geometry_GetMutable_mBounds(JPH_DebugRenderer_Geometry *_this)
{
    return (JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Geometry *)(_this)).mBounds);
}

JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_DebugRenderer_Geometry *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::DebugRenderer::Geometry);
    return (JPH_DebugRenderer_Geometry *)new JPH::DebugRenderer::Geometry(JPH::DebugRenderer::Geometry(
        (MRBINDC_CLASSARG_COPY(_other, (JPH::DebugRenderer::Geometry), JPH::DebugRenderer::Geometry) MRBINDC_CLASSARG_MOVE(_other, (JPH::DebugRenderer::Geometry), JPH::DebugRenderer::Geometry) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::DebugRenderer::Geometry) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::DebugRenderer::Geometry) MRBINDC_CLASSARG_END(_other, JPH::DebugRenderer::Geometry))
    ));
}

const JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_OffsetPtr(const JPH_DebugRenderer_Geometry *ptr, ptrdiff_t i)
{
    return (const JPH_DebugRenderer_Geometry *)(((const JPH::DebugRenderer::Geometry *)ptr) + i);
}

JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_OffsetMutablePtr(JPH_DebugRenderer_Geometry *ptr, ptrdiff_t i)
{
    return (JPH_DebugRenderer_Geometry *)(((JPH::DebugRenderer::Geometry *)ptr) + i);
}

const JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(const JPH_DebugRenderer_Geometry *object)
{
    return (const JPH_RefTarget_JPH_DebugRenderer_Geometry *)(static_cast<const JPH::RefTarget<JPH::DebugRenderer::Geometry> *>(
        ((const JPH::DebugRenderer::Geometry *)object)
    ));
}

JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_MutableUpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(JPH_DebugRenderer_Geometry *object)
{
    return (JPH_RefTarget_JPH_DebugRenderer_Geometry *)(static_cast<JPH::RefTarget<JPH::DebugRenderer::Geometry> *>(
        ((JPH::DebugRenderer::Geometry *)object)
    ));
}

const JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_StaticDowncastFrom_JPH_RefTarget_JPH_DebugRenderer_Geometry(const JPH_RefTarget_JPH_DebugRenderer_Geometry *object)
{
    return (const JPH_DebugRenderer_Geometry *)(static_cast<const JPH::DebugRenderer::Geometry *>(
        ((const JPH::RefTarget<JPH::DebugRenderer::Geometry> *)object)
    ));
}

JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_MutableStaticDowncastFrom_JPH_RefTarget_JPH_DebugRenderer_Geometry(JPH_RefTarget_JPH_DebugRenderer_Geometry *object)
{
    return (JPH_DebugRenderer_Geometry *)(static_cast<JPH::DebugRenderer::Geometry *>(
        ((JPH::RefTarget<JPH::DebugRenderer::Geometry> *)object)
    ));
}

JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_Construct_1(const JPH_AABox *inBounds)
{
    return (JPH_DebugRenderer_Geometry *)new JPH::DebugRenderer::Geometry(JPH::DebugRenderer::Geometry(
        ((inBounds ? void() : MRBINDC_THROW("Parameter `inBounds` can not be null.", void)), *(const JPH::AABox *)(inBounds))
    ));
}

void JPH_DebugRenderer_Geometry_Destroy(const JPH_DebugRenderer_Geometry *_this)
{
    delete ((const JPH::DebugRenderer::Geometry *)_this);
}

void JPH_DebugRenderer_Geometry_DestroyArray(const JPH_DebugRenderer_Geometry *_this)
{
    delete[] ((const JPH::DebugRenderer::Geometry *)_this);
}

JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_AssignFromAnother(JPH_DebugRenderer_Geometry *_this, Jolt_PassBy _other_pass_by, JPH_DebugRenderer_Geometry *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::DebugRenderer::Geometry);
    return (JPH_DebugRenderer_Geometry *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRenderer::Geometry *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (JPH::DebugRenderer::Geometry), JPH::DebugRenderer::Geometry) MRBINDC_CLASSARG_MOVE(_other, (JPH::DebugRenderer::Geometry), JPH::DebugRenderer::Geometry) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::DebugRenderer::Geometry) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::DebugRenderer::Geometry) MRBINDC_CLASSARG_END(_other, JPH::DebugRenderer::Geometry))
    ));
}

void *Jolt_new_JPH_DebugRenderer_Geometry_size_t(size_t inCount)
{
    return JPH::DebugRenderer::Geometry::operator new(
        inCount
    );
}

void Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr(void *inPointer)
{
    JPH::DebugRenderer::Geometry::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DebugRenderer::Geometry::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_DebugRenderer_Geometry_size_t(size_t inCount)
{
    return JPH::DebugRenderer::Geometry::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr(void *inPointer)
{
    JPH::DebugRenderer::Geometry::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DebugRenderer::Geometry::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_DebugRenderer_Geometry_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DebugRenderer::Geometry::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DebugRenderer::Geometry::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_DebugRenderer_Geometry_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DebugRenderer::Geometry::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DebugRenderer::Geometry::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_DebugRenderer_LOD *JPH_DebugRenderer_Geometry_GetLOD(const JPH_DebugRenderer_Geometry *_this, const JPH_Vec3 *inCameraPosition, const JPH_AABox *inWorldSpaceBounds, float inLODScaleSq)
{
    return (const JPH_DebugRenderer_LOD *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Geometry *)(_this)).GetLOD(
        ((inCameraPosition ? void() : MRBINDC_THROW("Parameter `inCameraPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCameraPosition)),
        ((inWorldSpaceBounds ? void() : MRBINDC_THROW("Parameter `inWorldSpaceBounds` can not be null.", void)), *(const JPH::AABox *)(inWorldSpaceBounds)),
        inLODScaleSq
    ));
}

void JPH_DebugRenderer_Geometry_SetEmbedded(const JPH_DebugRenderer_Geometry *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Geometry *)(_this)).SetEmbedded();
}

unsigned int JPH_DebugRenderer_Geometry_GetRefCount(const JPH_DebugRenderer_Geometry *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Geometry *)(_this)).GetRefCount();
}

void JPH_DebugRenderer_Geometry_AddRef(const JPH_DebugRenderer_Geometry *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Geometry *)(_this)).AddRef();
}

void JPH_DebugRenderer_Geometry_Release(const JPH_DebugRenderer_Geometry *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DebugRenderer::Geometry *)(_this)).Release();
}

int JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset(void)
{
    return JPH::DebugRenderer::Geometry::sInternalGetRefCountOffset();
}

