// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Renderer/DebugRendererSimple.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <Jolt/Renderer/DebugRendererSimple.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <functional>
#include <memory>
#include <stdexcept>


JPH_DebugRenderer *const *JPH_DebugRendererSimple_Get_sInstance(void)
{
    return (JPH_DebugRenderer *const *)std::addressof(JPH::DebugRendererSimple::sInstance);
}

void JPH_DebugRendererSimple_Set_sInstance(JPH_DebugRenderer *value)
{
    JPH::DebugRendererSimple::sInstance = ((JPH::DebugRenderer *)value);
}

JPH_DebugRenderer **JPH_DebugRendererSimple_GetMutable_sInstance(void)
{
    return (JPH_DebugRenderer **)std::addressof(JPH::DebugRendererSimple::sInstance);
}

void JPH_DebugRendererSimple_Destroy(const JPH_DebugRendererSimple *_this)
{
    delete ((const JPH::DebugRendererSimple *)_this);
}

void JPH_DebugRendererSimple_DestroyArray(const JPH_DebugRendererSimple *_this)
{
    delete[] ((const JPH::DebugRendererSimple *)_this);
}

void *Jolt_new_JPH_DebugRendererSimple_size_t(size_t inCount)
{
    return JPH::DebugRendererSimple::operator new(
        inCount
    );
}

void Jolt_delete_JPH_DebugRendererSimple_void_ptr(void *inPointer)
{
    JPH::DebugRendererSimple::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_DebugRendererSimple_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DebugRendererSimple::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_DebugRendererSimple_size_t(size_t inCount)
{
    return JPH::DebugRendererSimple::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_DebugRendererSimple_void_ptr(void *inPointer)
{
    JPH::DebugRendererSimple::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DebugRendererSimple::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_DebugRendererSimple_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DebugRendererSimple::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_DebugRendererSimple_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DebugRendererSimple::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_DebugRendererSimple_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DebugRendererSimple::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DebugRendererSimple::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_DebugRendererSimple_SetCameraPos(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inCameraPos)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).SetCameraPos(
        ((inCameraPos ? void() : MRBINDC_THROW("Parameter `inCameraPos` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCameraPos))
    );
}

void JPH_DebugRendererSimple_DrawTriangle(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor, JPH_DebugRenderer_ECastShadow inCastShadow)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawTriangle(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        ((JPH::DebugRenderer::ECastShadow)inCastShadow)
    );
}

void JPH_DebugRendererSimple_NextFrame(JPH_DebugRendererSimple *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).NextFrame();
}

void JPH_DebugRendererSimple_DrawLine(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawLine(
        ((inFrom ? void() : MRBINDC_THROW("Parameter `inFrom` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inFrom)),
        ((inTo ? void() : MRBINDC_THROW("Parameter `inTo` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTo)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor))
    );
}

void JPH_DebugRendererSimple_DrawMarker(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inPosition, const JPH_Color *inColor, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawMarker(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inSize
    );
}

void JPH_DebugRendererSimple_DrawArrow(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawArrow(
        ((inFrom ? void() : MRBINDC_THROW("Parameter `inFrom` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inFrom)),
        ((inTo ? void() : MRBINDC_THROW("Parameter `inTo` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTo)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inSize
    );
}

void JPH_DebugRendererSimple_DrawCoordinateSystem(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inTransform, const float *inSize)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawCoordinateSystem(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform)),
        (inSize ? *inSize : static_cast<float>(1.F))
    );
}

void JPH_DebugRendererSimple_DrawPlane(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inPoint, const JPH_Vec3 *inNormal, const JPH_Color *inColor, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawPlane(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint)),
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inSize
    );
}

void JPH_DebugRendererSimple_DrawWireTriangle(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawWireTriangle(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor))
    );
}

void JPH_DebugRendererSimple_DrawWireSphere(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const int *inLevel)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawWireSphere(
        ((inCenter ? void() : MRBINDC_THROW("Parameter `inCenter` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenter)),
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inLevel ? *inLevel : static_cast<int>(3))
    );
}

void JPH_DebugRendererSimple_DrawWireUnitSphere(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const int *inLevel)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawWireUnitSphere(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inLevel ? *inLevel : static_cast<int>(3))
    );
}

void JPH_DebugRendererSimple_DrawSphere(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawSphere(
        ((inCenter ? void() : MRBINDC_THROW("Parameter `inCenter` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenter)),
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRendererSimple_DrawUnitSphere(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawUnitSphere(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRendererSimple_DrawCapsule(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inHalfHeightOfCylinder, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawCapsule(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inHalfHeightOfCylinder,
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRendererSimple_DrawCylinder(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inHalfHeight, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawCylinder(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inHalfHeight,
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRendererSimple_DrawOpenCone(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inTop, const JPH_Vec3 *inAxis, const JPH_Vec3 *inPerpendicular, float inHalfAngle, float inLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawOpenCone(
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

void JPH_DebugRendererSimple_DrawSwingConeLimits(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawSwingConeLimits(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inSwingYHalfAngle,
        inSwingZHalfAngle,
        inEdgeLength,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void JPH_DebugRendererSimple_DrawSwingPyramidLimits(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawSwingPyramidLimits(
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

void JPH_DebugRendererSimple_DrawPie(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Vec3 *inNormal, const JPH_Vec3 *inAxis, float inMinAngle, float inMaxAngle, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawPie(
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

void JPH_DebugRendererSimple_DrawTaperedCylinder(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DebugRendererSimple *)(_this)).DrawTaperedCylinder(
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

JPH_AABox *JPH_DebugRendererSimple_sCalculateBounds(const JPH_DebugRenderer_Vertex *inVertices, int inVertexCount)
{
    return (JPH_AABox *)new JPH::AABox(JPH::DebugRendererSimple::sCalculateBounds(
        ((const JPH::DebugRenderer::Vertex *)inVertices),
        inVertexCount
    ));
}

const JPH_DebugRendererSimple *JPH_DebugRendererSimple_OffsetPtr(const JPH_DebugRendererSimple *ptr, ptrdiff_t i)
{
    return (const JPH_DebugRendererSimple *)(((const JPH::DebugRendererSimple *)ptr) + i);
}

JPH_DebugRendererSimple *JPH_DebugRendererSimple_OffsetMutablePtr(JPH_DebugRendererSimple *ptr, ptrdiff_t i)
{
    return (JPH_DebugRendererSimple *)(((JPH::DebugRendererSimple *)ptr) + i);
}

const JPH_NonCopyable *JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable(const JPH_DebugRendererSimple *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::DebugRendererSimple *)object)
    ));
}

JPH_NonCopyable *JPH_DebugRendererSimple_MutableUpcastTo_JPH_NonCopyable(JPH_DebugRendererSimple *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::DebugRendererSimple *)object)
    ));
}

const JPH_DebugRendererSimple *JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_DebugRendererSimple *)(static_cast<const JPH::DebugRendererSimple *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_DebugRendererSimple *JPH_DebugRendererSimple_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_DebugRendererSimple *)(static_cast<JPH::DebugRendererSimple *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_DebugRenderer *JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer(const JPH_DebugRendererSimple *object)
{
    return (const JPH_DebugRenderer *)(static_cast<const JPH::DebugRenderer *>(
        ((const JPH::DebugRendererSimple *)object)
    ));
}

JPH_DebugRenderer *JPH_DebugRendererSimple_MutableUpcastTo_JPH_DebugRenderer(JPH_DebugRendererSimple *object)
{
    return (JPH_DebugRenderer *)(static_cast<JPH::DebugRenderer *>(
        ((JPH::DebugRendererSimple *)object)
    ));
}

const JPH_DebugRendererSimple *JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer(const JPH_DebugRenderer *object)
{
    return (const JPH_DebugRendererSimple *)(static_cast<const JPH::DebugRendererSimple *>(
        ((const JPH::DebugRenderer *)object)
    ));
}

JPH_DebugRendererSimple *JPH_DebugRendererSimple_MutableStaticDowncastFrom_JPH_DebugRenderer(JPH_DebugRenderer *object)
{
    return (JPH_DebugRendererSimple *)(static_cast<JPH::DebugRendererSimple *>(
        ((JPH::DebugRenderer *)object)
    ));
}

