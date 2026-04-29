// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/Shape.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/DMat44.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>
#include <type_traits>


const uint64_t *JPH_ShapeSettings_Get_mUserData(const JPH_ShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeSettings *)(_this)).mUserData);
}

void JPH_ShapeSettings_Set_mUserData(JPH_ShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_ShapeSettings_GetMutable_mUserData(JPH_ShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeSettings *)(_this)).mUserData);
}

void JPH_ShapeSettings_Destroy(const JPH_ShapeSettings *_this)
{
    delete ((const JPH::ShapeSettings *)_this);
}

void JPH_ShapeSettings_DestroyArray(const JPH_ShapeSettings *_this)
{
    delete[] ((const JPH::ShapeSettings *)_this);
}

void *Jolt_new_JPH_ShapeSettings_size_t(size_t inCount)
{
    return JPH::ShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ShapeSettings_void_ptr(void *inPointer)
{
    JPH::ShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ShapeSettings_size_t(size_t inCount)
{
    return JPH::ShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ShapeSettings_void_ptr(void *inPointer)
{
    JPH::ShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_ShapeSettings_ClearCachedResult(JPH_ShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_ShapeSettings_SetEmbedded(const JPH_ShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_ShapeSettings_GetRefCount(const JPH_ShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeSettings *)(_this)).GetRefCount();
}

void JPH_ShapeSettings_AddRef(const JPH_ShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeSettings *)(_this)).AddRef();
}

void JPH_ShapeSettings_Release(const JPH_ShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeSettings *)(_this)).Release();
}

int JPH_ShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::ShapeSettings::sInternalGetRefCountOffset();
}

const JPH_ShapeSettings *JPH_ShapeSettings_OffsetPtr(const JPH_ShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_ShapeSettings *)(((const JPH::ShapeSettings *)ptr) + i);
}

JPH_ShapeSettings *JPH_ShapeSettings_OffsetMutablePtr(JPH_ShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_ShapeSettings *)(((JPH::ShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_ShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_ShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ShapeSettings *JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_ShapeSettings *JPH_ShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_ShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ShapeSettings *JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_ShapeSettings *JPH_ShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const int *JPH_Shape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::Shape::cGetTrianglesMinTrianglesRequested);
}

void JPH_Shape_Destroy(const JPH_Shape *_this)
{
    delete ((const JPH::Shape *)_this);
}

void JPH_Shape_DestroyArray(const JPH_Shape *_this)
{
    delete[] ((const JPH::Shape *)_this);
}

void *Jolt_new_JPH_Shape_size_t(size_t inCount)
{
    return JPH::Shape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Shape_void_ptr(void *inPointer)
{
    JPH::Shape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Shape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Shape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Shape_size_t(size_t inCount)
{
    return JPH::Shape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Shape_void_ptr(void *inPointer)
{
    JPH::Shape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Shape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Shape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Shape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Shape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Shape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Shape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Shape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Shape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Shape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Shape::operator delete[](
        inPointer,
        inPlace
    );
}

uint64_t JPH_Shape_GetUserData(const JPH_Shape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetUserData();
}

void JPH_Shape_SetUserData(JPH_Shape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Shape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_Shape_MustBeStatic(const JPH_Shape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).MustBeStatic();
}

JPH_Vec3 *JPH_Shape_GetCenterOfMass(const JPH_Shape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_Shape_GetLocalBounds(const JPH_Shape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetLocalBounds());
}

unsigned int JPH_Shape_GetSubShapeIDBitsRecursive(const JPH_Shape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetSubShapeIDBitsRecursive();
}

JPH_AABox *JPH_Shape_GetWorldSpaceBounds_JPH_Mat44(const JPH_Shape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

JPH_AABox *JPH_Shape_GetWorldSpaceBounds_JPH_DMat44(const JPH_Shape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::DMat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

float JPH_Shape_GetInnerRadius(const JPH_Shape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetInnerRadius();
}

const JPH_Shape *JPH_Shape_GetLeafShape(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

const JPH_PhysicsMaterial *JPH_Shape_GetMaterial(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

JPH_Vec3 *JPH_Shape_GetSurfaceNormal(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

uint64_t JPH_Shape_GetSubShapeUserData(const JPH_Shape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

void JPH_Shape_GetSubmergedVolume(const JPH_Shape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy))
    );
}

void JPH_Shape_GetTrianglesStart(const JPH_Shape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_Shape_GetTrianglesNext(const JPH_Shape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_Shape_GetStats(const JPH_Shape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetStats());
}

float JPH_Shape_GetVolume(const JPH_Shape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetVolume();
}

bool JPH_Shape_IsValidScale(const JPH_Shape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_Shape_MakeScaleValid(const JPH_Shape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_Shape_SetEmbedded(const JPH_Shape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).SetEmbedded();
}

unsigned int JPH_Shape_GetRefCount(const JPH_Shape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).GetRefCount();
}

void JPH_Shape_AddRef(const JPH_Shape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).AddRef();
}

void JPH_Shape_Release(const JPH_Shape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape *)(_this)).Release();
}

int JPH_Shape_sInternalGetRefCountOffset(void)
{
    return JPH::Shape::sInternalGetRefCountOffset();
}

const JPH_Shape *JPH_Shape_OffsetPtr(const JPH_Shape *ptr, ptrdiff_t i)
{
    return (const JPH_Shape *)(((const JPH::Shape *)ptr) + i);
}

JPH_Shape *JPH_Shape_OffsetMutablePtr(JPH_Shape *ptr, ptrdiff_t i)
{
    return (JPH_Shape *)(((JPH::Shape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_Shape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_Shape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_Shape *JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_Shape *JPH_Shape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_Shape_UpcastTo_JPH_NonCopyable(const JPH_Shape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_NonCopyable *JPH_Shape_MutableUpcastTo_JPH_NonCopyable(JPH_Shape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_Shape *JPH_Shape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_Shape *JPH_Shape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const unsigned char *JPH_Shape_GetTrianglesContext_Get_mData(const JPH_Shape_GetTrianglesContext *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape::GetTrianglesContext *)(_this)).mData[0]);
}

unsigned char *JPH_Shape_GetTrianglesContext_GetMutable_mData(JPH_Shape_GetTrianglesContext *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(_this)).mData[0]);
}

size_t JPH_Shape_GetTrianglesContext_GetSize_mData(void)
{
    return std::extent_v<decltype(JPH::Shape::GetTrianglesContext::mData)>;
}

JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_DefaultConstruct(void)
{
    return (JPH_Shape_GetTrianglesContext *)new JPH::Shape::GetTrianglesContext(JPH::Shape::GetTrianglesContext());
}

JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Shape_GetTrianglesContext *)(new JPH::Shape::GetTrianglesContext[num_elems]{});
}

const JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_OffsetPtr(const JPH_Shape_GetTrianglesContext *ptr, ptrdiff_t i)
{
    return (const JPH_Shape_GetTrianglesContext *)(((const JPH::Shape::GetTrianglesContext *)ptr) + i);
}

JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_OffsetMutablePtr(JPH_Shape_GetTrianglesContext *ptr, ptrdiff_t i)
{
    return (JPH_Shape_GetTrianglesContext *)(((JPH::Shape::GetTrianglesContext *)ptr) + i);
}

JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_ConstructFromAnother(const JPH_Shape_GetTrianglesContext *_other)
{
    return (JPH_Shape_GetTrianglesContext *)new JPH::Shape::GetTrianglesContext(JPH::Shape::GetTrianglesContext(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Shape::GetTrianglesContext(*(JPH::Shape::GetTrianglesContext *)_other))
    ));
}

void JPH_Shape_GetTrianglesContext_Destroy(const JPH_Shape_GetTrianglesContext *_this)
{
    delete ((const JPH::Shape::GetTrianglesContext *)_this);
}

void JPH_Shape_GetTrianglesContext_DestroyArray(const JPH_Shape_GetTrianglesContext *_this)
{
    delete[] ((const JPH::Shape::GetTrianglesContext *)_this);
}

JPH_Shape_GetTrianglesContext *JPH_Shape_GetTrianglesContext_AssignFromAnother(JPH_Shape_GetTrianglesContext *_this, const JPH_Shape_GetTrianglesContext *_other)
{
    return (JPH_Shape_GetTrianglesContext *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Shape::GetTrianglesContext(*(JPH::Shape::GetTrianglesContext *)_other))
    ));
}

const size_t *JPH_Shape_Stats_Get_mSizeBytes(const JPH_Shape_Stats *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape::Stats *)(_this)).mSizeBytes);
}

void JPH_Shape_Stats_Set_mSizeBytes(JPH_Shape_Stats *_this, size_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Shape::Stats *)(_this)).mSizeBytes = value;
}

size_t *JPH_Shape_Stats_GetMutable_mSizeBytes(JPH_Shape_Stats *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Shape::Stats *)(_this)).mSizeBytes);
}

const unsigned int *JPH_Shape_Stats_Get_mNumTriangles(const JPH_Shape_Stats *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Shape::Stats *)(_this)).mNumTriangles);
}

void JPH_Shape_Stats_Set_mNumTriangles(JPH_Shape_Stats *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Shape::Stats *)(_this)).mNumTriangles = value;
}

unsigned int *JPH_Shape_Stats_GetMutable_mNumTriangles(JPH_Shape_Stats *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Shape::Stats *)(_this)).mNumTriangles);
}

JPH_Shape_Stats *JPH_Shape_Stats_ConstructFromAnother(const JPH_Shape_Stats *_other)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(JPH::Shape::Stats(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Shape::Stats(*(JPH::Shape::Stats *)_other))
    ));
}

const JPH_Shape_Stats *JPH_Shape_Stats_OffsetPtr(const JPH_Shape_Stats *ptr, ptrdiff_t i)
{
    return (const JPH_Shape_Stats *)(((const JPH::Shape::Stats *)ptr) + i);
}

JPH_Shape_Stats *JPH_Shape_Stats_OffsetMutablePtr(JPH_Shape_Stats *ptr, ptrdiff_t i)
{
    return (JPH_Shape_Stats *)(((JPH::Shape::Stats *)ptr) + i);
}

JPH_Shape_Stats *JPH_Shape_Stats_Construct(size_t inSizeBytes, unsigned int inNumTriangles)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(JPH::Shape::Stats(
        inSizeBytes,
        inNumTriangles
    ));
}

void JPH_Shape_Stats_Destroy(const JPH_Shape_Stats *_this)
{
    delete ((const JPH::Shape::Stats *)_this);
}

void JPH_Shape_Stats_DestroyArray(const JPH_Shape_Stats *_this)
{
    delete[] ((const JPH::Shape::Stats *)_this);
}

JPH_Shape_Stats *JPH_Shape_Stats_AssignFromAnother(JPH_Shape_Stats *_this, const JPH_Shape_Stats *_other)
{
    return (JPH_Shape_Stats *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Shape::Stats *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Shape::Stats(*(JPH::Shape::Stats *)_other))
    ));
}

