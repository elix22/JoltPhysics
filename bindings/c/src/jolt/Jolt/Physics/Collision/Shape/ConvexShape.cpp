// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/ConvexShape.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/ConvexShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>
#include <type_traits>


const float *JPH_ConvexShapeSettings_Get_mDensity(const JPH_ConvexShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShapeSettings *)(_this)).mDensity);
}

void JPH_ConvexShapeSettings_Set_mDensity(JPH_ConvexShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShapeSettings *)(_this)).mDensity = value;
}

float *JPH_ConvexShapeSettings_GetMutable_mDensity(JPH_ConvexShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShapeSettings *)(_this)).mDensity);
}

const uint64_t *JPH_ConvexShapeSettings_Get_mUserData(const JPH_ConvexShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShapeSettings *)(_this)).mUserData);
}

void JPH_ConvexShapeSettings_Set_mUserData(JPH_ConvexShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_ConvexShapeSettings_GetMutable_mUserData(JPH_ConvexShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShapeSettings *)(_this)).mUserData);
}

void JPH_ConvexShapeSettings_Destroy(const JPH_ConvexShapeSettings *_this)
{
    delete ((const JPH::ConvexShapeSettings *)_this);
}

void JPH_ConvexShapeSettings_DestroyArray(const JPH_ConvexShapeSettings *_this)
{
    delete[] ((const JPH::ConvexShapeSettings *)_this);
}

void *Jolt_new_JPH_ConvexShapeSettings_size_t(size_t inCount)
{
    return JPH::ConvexShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ConvexShapeSettings_void_ptr(void *inPointer)
{
    JPH::ConvexShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ConvexShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConvexShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ConvexShapeSettings_size_t(size_t inCount)
{
    return JPH::ConvexShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ConvexShapeSettings_void_ptr(void *inPointer)
{
    JPH::ConvexShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ConvexShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConvexShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ConvexShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConvexShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ConvexShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConvexShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ConvexShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConvexShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ConvexShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConvexShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_ConvexShapeSettings_SetDensity(JPH_ConvexShapeSettings *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShapeSettings *)(_this)).SetDensity(
        inDensity
    );
}

void JPH_ConvexShapeSettings_ClearCachedResult(JPH_ConvexShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_ConvexShapeSettings_SetEmbedded(const JPH_ConvexShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_ConvexShapeSettings_GetRefCount(const JPH_ConvexShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShapeSettings *)(_this)).GetRefCount();
}

void JPH_ConvexShapeSettings_AddRef(const JPH_ConvexShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShapeSettings *)(_this)).AddRef();
}

void JPH_ConvexShapeSettings_Release(const JPH_ConvexShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShapeSettings *)(_this)).Release();
}

int JPH_ConvexShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::ConvexShapeSettings::sInternalGetRefCountOffset();
}

const JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_OffsetPtr(const JPH_ConvexShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_ConvexShapeSettings *)(((const JPH::ConvexShapeSettings *)ptr) + i);
}

JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_OffsetMutablePtr(JPH_ConvexShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_ConvexShapeSettings *)(((JPH::ConvexShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_ConvexShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_ConvexShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ConvexShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_ConvexShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_ConvexShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_ConvexShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_ConvexShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_ConvexShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const int *JPH_ConvexShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::ConvexShape::cGetTrianglesMinTrianglesRequested);
}

void JPH_ConvexShape_Destroy(const JPH_ConvexShape *_this)
{
    delete ((const JPH::ConvexShape *)_this);
}

void JPH_ConvexShape_DestroyArray(const JPH_ConvexShape *_this)
{
    delete[] ((const JPH::ConvexShape *)_this);
}

void *Jolt_new_JPH_ConvexShape_size_t(size_t inCount)
{
    return JPH::ConvexShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ConvexShape_void_ptr(void *inPointer)
{
    JPH::ConvexShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ConvexShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConvexShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ConvexShape_size_t(size_t inCount)
{
    return JPH::ConvexShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ConvexShape_void_ptr(void *inPointer)
{
    JPH::ConvexShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ConvexShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConvexShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ConvexShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConvexShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ConvexShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConvexShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ConvexShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConvexShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ConvexShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConvexShape::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_ConvexShape_GetSubShapeIDBitsRecursive(const JPH_ConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetSubShapeIDBitsRecursive();
}

const JPH_PhysicsMaterial *JPH_ConvexShape_GetMaterial_1(const JPH_ConvexShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

void JPH_ConvexShape_GetTrianglesStart(const JPH_ConvexShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_ConvexShape_GetTrianglesNext(const JPH_ConvexShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

void JPH_ConvexShape_GetSubmergedVolume(const JPH_ConvexShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy))
    );
}

const JPH_ConvexShape_Support *JPH_ConvexShape_GetSupportFunction(const JPH_ConvexShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale)
{
    return (const JPH_ConvexShape_Support *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetSupportFunction(
        ((JPH::ConvexShape::ESupportMode)inMode),
        ((inBuffer ? void() : MRBINDC_THROW("Parameter `inBuffer` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(inBuffer)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_ConvexShape_SetMaterial(JPH_ConvexShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

const JPH_PhysicsMaterial *JPH_ConvexShape_GetMaterial_0(const JPH_ConvexShape *_this)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetMaterial());
}

void JPH_ConvexShape_SetDensity(JPH_ConvexShape *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShape *)(_this)).SetDensity(
        inDensity
    );
}

float JPH_ConvexShape_GetDensity(const JPH_ConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetDensity();
}

void JPH_ConvexShape_sRegister(void)
{
    JPH::ConvexShape::sRegister();
}

uint64_t JPH_ConvexShape_GetUserData(const JPH_ConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetUserData();
}

void JPH_ConvexShape_SetUserData(JPH_ConvexShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_ConvexShape_MustBeStatic(const JPH_ConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).MustBeStatic();
}

JPH_Vec3 *JPH_ConvexShape_GetCenterOfMass(const JPH_ConvexShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_ConvexShape_GetLocalBounds(const JPH_ConvexShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetLocalBounds());
}

float JPH_ConvexShape_GetInnerRadius(const JPH_ConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetInnerRadius();
}

const JPH_Shape *JPH_ConvexShape_GetLeafShape(const JPH_ConvexShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

JPH_Vec3 *JPH_ConvexShape_GetSurfaceNormal(const JPH_ConvexShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

uint64_t JPH_ConvexShape_GetSubShapeUserData(const JPH_ConvexShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_Shape_Stats *JPH_ConvexShape_GetStats(const JPH_ConvexShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetStats());
}

float JPH_ConvexShape_GetVolume(const JPH_ConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetVolume();
}

bool JPH_ConvexShape_IsValidScale(const JPH_ConvexShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_ConvexShape_MakeScaleValid(const JPH_ConvexShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_ConvexShape_SetEmbedded(const JPH_ConvexShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).SetEmbedded();
}

unsigned int JPH_ConvexShape_GetRefCount(const JPH_ConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).GetRefCount();
}

void JPH_ConvexShape_AddRef(const JPH_ConvexShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).AddRef();
}

void JPH_ConvexShape_Release(const JPH_ConvexShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape *)(_this)).Release();
}

int JPH_ConvexShape_sInternalGetRefCountOffset(void)
{
    return JPH::ConvexShape::sInternalGetRefCountOffset();
}

const JPH_ConvexShape *JPH_ConvexShape_OffsetPtr(const JPH_ConvexShape *ptr, ptrdiff_t i)
{
    return (const JPH_ConvexShape *)(((const JPH::ConvexShape *)ptr) + i);
}

JPH_ConvexShape *JPH_ConvexShape_OffsetMutablePtr(JPH_ConvexShape *ptr, ptrdiff_t i)
{
    return (JPH_ConvexShape *)(((JPH::ConvexShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_ConvexShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_ConvexShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_ConvexShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_ConvexShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::ConvexShape *)object)
    ));
}

const JPH_ConvexShape *JPH_ConvexShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_ConvexShape *JPH_ConvexShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_ConvexShape_UpcastTo_JPH_NonCopyable(const JPH_ConvexShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_NonCopyable *JPH_ConvexShape_MutableUpcastTo_JPH_NonCopyable(JPH_ConvexShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ConvexShape *)object)
    ));
}

const JPH_ConvexShape *JPH_ConvexShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ConvexShape *JPH_ConvexShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_ConvexShape_UpcastTo_JPH_Shape(const JPH_ConvexShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_Shape *JPH_ConvexShape_MutableUpcastTo_JPH_Shape(JPH_ConvexShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::ConvexShape *)object)
    ));
}

const JPH_ConvexShape *JPH_ConvexShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_ConvexShape *JPH_ConvexShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::Shape *)object)
    ));
}

void JPH_ConvexShape_Support_Destroy(const JPH_ConvexShape_Support *_this)
{
    delete ((const JPH::ConvexShape::Support *)_this);
}

void JPH_ConvexShape_Support_DestroyArray(const JPH_ConvexShape_Support *_this)
{
    delete[] ((const JPH::ConvexShape::Support *)_this);
}

JPH_Vec3 *JPH_ConvexShape_Support_GetSupport(const JPH_ConvexShape_Support *_this, const JPH_Vec3 *inDirection)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape::Support *)(_this)).GetSupport(
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

float JPH_ConvexShape_Support_GetConvexRadius(const JPH_ConvexShape_Support *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape::Support *)(_this)).GetConvexRadius();
}

const JPH_ConvexShape_Support *JPH_ConvexShape_Support_OffsetPtr(const JPH_ConvexShape_Support *ptr, ptrdiff_t i)
{
    return (const JPH_ConvexShape_Support *)(((const JPH::ConvexShape::Support *)ptr) + i);
}

JPH_ConvexShape_Support *JPH_ConvexShape_Support_OffsetMutablePtr(JPH_ConvexShape_Support *ptr, ptrdiff_t i)
{
    return (JPH_ConvexShape_Support *)(((JPH::ConvexShape::Support *)ptr) + i);
}

const unsigned char *JPH_ConvexShape_SupportBuffer_Get_mData(const JPH_ConvexShape_SupportBuffer *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexShape::SupportBuffer *)(_this)).mData[0]);
}

unsigned char *JPH_ConvexShape_SupportBuffer_GetMutable_mData(JPH_ConvexShape_SupportBuffer *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(_this)).mData[0]);
}

size_t JPH_ConvexShape_SupportBuffer_GetSize_mData(void)
{
    return std::extent_v<decltype(JPH::ConvexShape::SupportBuffer::mData)>;
}

JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_DefaultConstruct(void)
{
    return (JPH_ConvexShape_SupportBuffer *)new JPH::ConvexShape::SupportBuffer(JPH::ConvexShape::SupportBuffer());
}

JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ConvexShape_SupportBuffer *)(new JPH::ConvexShape::SupportBuffer[num_elems]{});
}

const JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_OffsetPtr(const JPH_ConvexShape_SupportBuffer *ptr, ptrdiff_t i)
{
    return (const JPH_ConvexShape_SupportBuffer *)(((const JPH::ConvexShape::SupportBuffer *)ptr) + i);
}

JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_OffsetMutablePtr(JPH_ConvexShape_SupportBuffer *ptr, ptrdiff_t i)
{
    return (JPH_ConvexShape_SupportBuffer *)(((JPH::ConvexShape::SupportBuffer *)ptr) + i);
}

JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_ConstructFromAnother(const JPH_ConvexShape_SupportBuffer *_other)
{
    return (JPH_ConvexShape_SupportBuffer *)new JPH::ConvexShape::SupportBuffer(JPH::ConvexShape::SupportBuffer(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::ConvexShape::SupportBuffer(*(JPH::ConvexShape::SupportBuffer *)_other))
    ));
}

void JPH_ConvexShape_SupportBuffer_Destroy(const JPH_ConvexShape_SupportBuffer *_this)
{
    delete ((const JPH::ConvexShape::SupportBuffer *)_this);
}

void JPH_ConvexShape_SupportBuffer_DestroyArray(const JPH_ConvexShape_SupportBuffer *_this)
{
    delete[] ((const JPH::ConvexShape::SupportBuffer *)_this);
}

JPH_ConvexShape_SupportBuffer *JPH_ConvexShape_SupportBuffer_AssignFromAnother(JPH_ConvexShape_SupportBuffer *_this, const JPH_ConvexShape_SupportBuffer *_other)
{
    return (JPH_ConvexShape_SupportBuffer *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::ConvexShape::SupportBuffer(*(JPH::ConvexShape::SupportBuffer *)_other))
    ));
}

