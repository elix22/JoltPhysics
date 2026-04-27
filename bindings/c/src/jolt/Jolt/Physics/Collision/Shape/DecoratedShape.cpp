// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/DecoratedShape.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/DecoratedShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const uint64_t *JPH_DecoratedShapeSettings_Get_mUserData(const JPH_DecoratedShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShapeSettings *)(_this)).mUserData);
}

void JPH_DecoratedShapeSettings_Set_mUserData(JPH_DecoratedShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DecoratedShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_DecoratedShapeSettings_GetMutable_mUserData(JPH_DecoratedShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DecoratedShapeSettings *)(_this)).mUserData);
}

void JPH_DecoratedShapeSettings_Destroy(const JPH_DecoratedShapeSettings *_this)
{
    delete ((const JPH::DecoratedShapeSettings *)_this);
}

void JPH_DecoratedShapeSettings_DestroyArray(const JPH_DecoratedShapeSettings *_this)
{
    delete[] ((const JPH::DecoratedShapeSettings *)_this);
}

void *Jolt_new_JPH_DecoratedShapeSettings_size_t(unsigned long inCount)
{
    return JPH::DecoratedShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_DecoratedShapeSettings_void_ptr(void *inPointer)
{
    JPH::DecoratedShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_DecoratedShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::DecoratedShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_DecoratedShapeSettings_size_t(unsigned long inCount)
{
    return JPH::DecoratedShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_DecoratedShapeSettings_void_ptr(void *inPointer)
{
    JPH::DecoratedShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_DecoratedShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::DecoratedShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_DecoratedShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::DecoratedShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_DecoratedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DecoratedShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_DecoratedShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::DecoratedShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_DecoratedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DecoratedShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_DecoratedShapeSettings_ClearCachedResult(JPH_DecoratedShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DecoratedShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_DecoratedShapeSettings_SetEmbedded(const JPH_DecoratedShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_DecoratedShapeSettings_GetRefCount(const JPH_DecoratedShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShapeSettings *)(_this)).GetRefCount();
}

void JPH_DecoratedShapeSettings_AddRef(const JPH_DecoratedShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShapeSettings *)(_this)).AddRef();
}

void JPH_DecoratedShapeSettings_Release(const JPH_DecoratedShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShapeSettings *)(_this)).Release();
}

int JPH_DecoratedShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::DecoratedShapeSettings::sInternalGetRefCountOffset();
}

const JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_OffsetPtr(const JPH_DecoratedShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_DecoratedShapeSettings *)(((const JPH::DecoratedShapeSettings *)ptr) + i);
}

JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_OffsetMutablePtr(JPH_DecoratedShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_DecoratedShapeSettings *)(((JPH::DecoratedShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_DecoratedShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_DecoratedShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::DecoratedShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_DecoratedShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_DecoratedShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::DecoratedShapeSettings *)object)
    ));
}

const JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_DecoratedShapeSettings *)(static_cast<const JPH::DecoratedShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_DecoratedShapeSettings *)(static_cast<JPH::DecoratedShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_DecoratedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_DecoratedShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::DecoratedShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_DecoratedShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_DecoratedShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::DecoratedShapeSettings *)object)
    ));
}

const JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_DecoratedShapeSettings *)(static_cast<const JPH::DecoratedShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_DecoratedShapeSettings *)(static_cast<JPH::DecoratedShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_DecoratedShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_DecoratedShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::DecoratedShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_DecoratedShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_DecoratedShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::DecoratedShapeSettings *)object)
    ));
}

const JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_DecoratedShapeSettings *)(static_cast<const JPH::DecoratedShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_DecoratedShapeSettings *JPH_DecoratedShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_DecoratedShapeSettings *)(static_cast<JPH::DecoratedShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const int *JPH_DecoratedShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::DecoratedShape::cGetTrianglesMinTrianglesRequested);
}

void JPH_DecoratedShape_Destroy(const JPH_DecoratedShape *_this)
{
    delete ((const JPH::DecoratedShape *)_this);
}

void JPH_DecoratedShape_DestroyArray(const JPH_DecoratedShape *_this)
{
    delete[] ((const JPH::DecoratedShape *)_this);
}

void *Jolt_new_JPH_DecoratedShape_size_t(unsigned long inCount)
{
    return JPH::DecoratedShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_DecoratedShape_void_ptr(void *inPointer)
{
    JPH::DecoratedShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_DecoratedShape_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::DecoratedShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_DecoratedShape_size_t(unsigned long inCount)
{
    return JPH::DecoratedShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_DecoratedShape_void_ptr(void *inPointer)
{
    JPH::DecoratedShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_DecoratedShape_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::DecoratedShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_DecoratedShape_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::DecoratedShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_DecoratedShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DecoratedShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_DecoratedShape_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::DecoratedShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_DecoratedShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DecoratedShape::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_Shape *JPH_DecoratedShape_GetInnerShape(const JPH_DecoratedShape *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetInnerShape());
}

bool JPH_DecoratedShape_MustBeStatic(const JPH_DecoratedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).MustBeStatic();
}

JPH_Vec3 *JPH_DecoratedShape_GetCenterOfMass(const JPH_DecoratedShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetCenterOfMass());
}

unsigned int JPH_DecoratedShape_GetSubShapeIDBitsRecursive(const JPH_DecoratedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetSubShapeIDBitsRecursive();
}

const JPH_Shape *JPH_DecoratedShape_GetLeafShape(const JPH_DecoratedShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

const JPH_PhysicsMaterial *JPH_DecoratedShape_GetMaterial(const JPH_DecoratedShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

uint64_t JPH_DecoratedShape_GetSubShapeUserData(const JPH_DecoratedShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

bool JPH_DecoratedShape_IsValidScale(const JPH_DecoratedShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_DecoratedShape_MakeScaleValid(const JPH_DecoratedShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

uint64_t JPH_DecoratedShape_GetUserData(const JPH_DecoratedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetUserData();
}

void JPH_DecoratedShape_SetUserData(JPH_DecoratedShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DecoratedShape *)(_this)).SetUserData(
        inUserData
    );
}

JPH_AABox *JPH_DecoratedShape_GetLocalBounds(const JPH_DecoratedShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetLocalBounds());
}

float JPH_DecoratedShape_GetInnerRadius(const JPH_DecoratedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetInnerRadius();
}

JPH_Vec3 *JPH_DecoratedShape_GetSurfaceNormal(const JPH_DecoratedShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_DecoratedShape_GetTrianglesStart(const JPH_DecoratedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_DecoratedShape_GetTrianglesNext(const JPH_DecoratedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_DecoratedShape_GetStats(const JPH_DecoratedShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetStats());
}

float JPH_DecoratedShape_GetVolume(const JPH_DecoratedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetVolume();
}

void JPH_DecoratedShape_SetEmbedded(const JPH_DecoratedShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).SetEmbedded();
}

unsigned int JPH_DecoratedShape_GetRefCount(const JPH_DecoratedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).GetRefCount();
}

void JPH_DecoratedShape_AddRef(const JPH_DecoratedShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).AddRef();
}

void JPH_DecoratedShape_Release(const JPH_DecoratedShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DecoratedShape *)(_this)).Release();
}

int JPH_DecoratedShape_sInternalGetRefCountOffset(void)
{
    return JPH::DecoratedShape::sInternalGetRefCountOffset();
}

const JPH_DecoratedShape *JPH_DecoratedShape_OffsetPtr(const JPH_DecoratedShape *ptr, ptrdiff_t i)
{
    return (const JPH_DecoratedShape *)(((const JPH::DecoratedShape *)ptr) + i);
}

JPH_DecoratedShape *JPH_DecoratedShape_OffsetMutablePtr(JPH_DecoratedShape *ptr, ptrdiff_t i)
{
    return (JPH_DecoratedShape *)(((JPH::DecoratedShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_DecoratedShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_DecoratedShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::DecoratedShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_DecoratedShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_DecoratedShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::DecoratedShape *)object)
    ));
}

const JPH_DecoratedShape *JPH_DecoratedShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_DecoratedShape *)(static_cast<const JPH::DecoratedShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_DecoratedShape *JPH_DecoratedShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_DecoratedShape *)(static_cast<JPH::DecoratedShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_DecoratedShape_UpcastTo_JPH_NonCopyable(const JPH_DecoratedShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::DecoratedShape *)object)
    ));
}

JPH_NonCopyable *JPH_DecoratedShape_MutableUpcastTo_JPH_NonCopyable(JPH_DecoratedShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::DecoratedShape *)object)
    ));
}

const JPH_DecoratedShape *JPH_DecoratedShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_DecoratedShape *)(static_cast<const JPH::DecoratedShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_DecoratedShape *JPH_DecoratedShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_DecoratedShape *)(static_cast<JPH::DecoratedShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_DecoratedShape_UpcastTo_JPH_Shape(const JPH_DecoratedShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::DecoratedShape *)object)
    ));
}

JPH_Shape *JPH_DecoratedShape_MutableUpcastTo_JPH_Shape(JPH_DecoratedShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::DecoratedShape *)object)
    ));
}

const JPH_DecoratedShape *JPH_DecoratedShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_DecoratedShape *)(static_cast<const JPH::DecoratedShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_DecoratedShape *JPH_DecoratedShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_DecoratedShape *)(static_cast<JPH::DecoratedShape *>(
        ((JPH::Shape *)object)
    ));
}

