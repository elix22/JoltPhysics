// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/SoftBody/SoftBodyShape.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Collision/CastResult.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/RayCast.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <Jolt/Physics/SoftBody/SoftBodyShape.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const int *JPH_SoftBodyShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::SoftBodyShape::cGetTrianglesMinTrianglesRequested);
}

const bool *JPH_SoftBodyShape_Get_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::SoftBodyShape::sDrawSubmergedVolumes);
}

void JPH_SoftBodyShape_Set_sDrawSubmergedVolumes(bool value)
{
    JPH::SoftBodyShape::sDrawSubmergedVolumes = value;
}

bool *JPH_SoftBodyShape_GetMutable_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::SoftBodyShape::sDrawSubmergedVolumes);
}

JPH_SoftBodyShape *JPH_SoftBodyShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SoftBodyShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SoftBodyShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SoftBodyShape *JPH_SoftBodyShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodyShape *)(new JPH::SoftBodyShape[num_elems]);
}

const JPH_SoftBodyShape *JPH_SoftBodyShape_OffsetPtr(const JPH_SoftBodyShape *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodyShape *)(((const JPH::SoftBodyShape *)ptr) + i);
}

JPH_SoftBodyShape *JPH_SoftBodyShape_OffsetMutablePtr(JPH_SoftBodyShape *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodyShape *)(((JPH::SoftBodyShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_SoftBodyShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_SoftBodyShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::SoftBodyShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_SoftBodyShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_SoftBodyShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::SoftBodyShape *)object)
    ));
}

const JPH_SoftBodyShape *JPH_SoftBodyShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_SoftBodyShape *)(static_cast<const JPH::SoftBodyShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_SoftBodyShape *JPH_SoftBodyShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_SoftBodyShape *)(static_cast<JPH::SoftBodyShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_SoftBodyShape_UpcastTo_JPH_NonCopyable(const JPH_SoftBodyShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::SoftBodyShape *)object)
    ));
}

JPH_NonCopyable *JPH_SoftBodyShape_MutableUpcastTo_JPH_NonCopyable(JPH_SoftBodyShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::SoftBodyShape *)object)
    ));
}

const JPH_SoftBodyShape *JPH_SoftBodyShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_SoftBodyShape *)(static_cast<const JPH::SoftBodyShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_SoftBodyShape *JPH_SoftBodyShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_SoftBodyShape *)(static_cast<JPH::SoftBodyShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_SoftBodyShape_UpcastTo_JPH_Shape(const JPH_SoftBodyShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::SoftBodyShape *)object)
    ));
}

JPH_Shape *JPH_SoftBodyShape_MutableUpcastTo_JPH_Shape(JPH_SoftBodyShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::SoftBodyShape *)object)
    ));
}

const JPH_SoftBodyShape *JPH_SoftBodyShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_SoftBodyShape *)(static_cast<const JPH::SoftBodyShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_SoftBodyShape *JPH_SoftBodyShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_SoftBodyShape *)(static_cast<JPH::SoftBodyShape *>(
        ((JPH::Shape *)object)
    ));
}

void JPH_SoftBodyShape_Destroy(const JPH_SoftBodyShape *_this)
{
    delete ((const JPH::SoftBodyShape *)_this);
}

void JPH_SoftBodyShape_DestroyArray(const JPH_SoftBodyShape *_this)
{
    delete[] ((const JPH::SoftBodyShape *)_this);
}

void *Jolt_new_JPH_SoftBodyShape_size_t(size_t inCount)
{
    return JPH::SoftBodyShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodyShape_void_ptr(void *inPointer)
{
    JPH::SoftBodyShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodyShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SoftBodyShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodyShape_size_t(size_t inCount)
{
    return JPH::SoftBodyShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodyShape_void_ptr(void *inPointer)
{
    JPH::SoftBodyShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodyShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SoftBodyShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodyShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SoftBodyShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodyShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodyShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodyShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SoftBodyShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodyShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodyShape::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_SoftBodyShape_GetSubShapeIDBits(const JPH_SoftBodyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetSubShapeIDBits();
}

unsigned int JPH_SoftBodyShape_GetFaceIndex(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetFaceIndex(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

bool JPH_SoftBodyShape_MustBeStatic(const JPH_SoftBodyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).MustBeStatic();
}

JPH_Vec3 *JPH_SoftBodyShape_GetCenterOfMass(const JPH_SoftBodyShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_SoftBodyShape_GetLocalBounds(const JPH_SoftBodyShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetLocalBounds());
}

unsigned int JPH_SoftBodyShape_GetSubShapeIDBitsRecursive(const JPH_SoftBodyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetSubShapeIDBitsRecursive();
}

float JPH_SoftBodyShape_GetInnerRadius(const JPH_SoftBodyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetInnerRadius();
}

const JPH_PhysicsMaterial *JPH_SoftBodyShape_GetMaterial(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

JPH_Vec3 *JPH_SoftBodyShape_GetSurfaceNormal(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_SoftBodyShape_GetSubmergedVolume(const JPH_SoftBodyShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

void JPH_SoftBodyShape_Draw(const JPH_SoftBodyShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).Draw(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inUseMaterialColors,
        inDrawWireframe
    );
}

bool JPH_SoftBodyShape_CastRay_3(const JPH_SoftBodyShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_SoftBodyShape_GetTrianglesStart(const JPH_SoftBodyShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_SoftBodyShape_GetTrianglesNext(const JPH_SoftBodyShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_SoftBodyShape_GetStats(const JPH_SoftBodyShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetStats());
}

float JPH_SoftBodyShape_GetVolume(const JPH_SoftBodyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetVolume();
}

void JPH_SoftBodyShape_sRegister(void)
{
    JPH::SoftBodyShape::sRegister();
}

uint64_t JPH_SoftBodyShape_GetUserData(const JPH_SoftBodyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetUserData();
}

void JPH_SoftBodyShape_SetUserData(JPH_SoftBodyShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyShape *)(_this)).SetUserData(
        inUserData
    );
}

const JPH_Shape *JPH_SoftBodyShape_GetLeafShape(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_SoftBodyShape_GetSubShapeUserData(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_SoftBodyShape_GetSubShapeTransformedShape(const JPH_SoftBodyShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

void JPH_SoftBodyShape_DrawGetSupportFunction(const JPH_SoftBodyShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).DrawGetSupportFunction(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inDrawSupportDirection
    );
}

void JPH_SoftBodyShape_DrawGetSupportingFace(const JPH_SoftBodyShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).DrawGetSupportingFace(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

bool JPH_SoftBodyShape_IsValidScale(const JPH_SoftBodyShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_SoftBodyShape_MakeScaleValid(const JPH_SoftBodyShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_SoftBodyShape_SetEmbedded(const JPH_SoftBodyShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).SetEmbedded();
}

unsigned int JPH_SoftBodyShape_GetRefCount(const JPH_SoftBodyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).GetRefCount();
}

void JPH_SoftBodyShape_AddRef(const JPH_SoftBodyShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).AddRef();
}

void JPH_SoftBodyShape_Release(const JPH_SoftBodyShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyShape *)(_this)).Release();
}

int JPH_SoftBodyShape_sInternalGetRefCountOffset(void)
{
    return JPH::SoftBodyShape::sInternalGetRefCountOffset();
}

