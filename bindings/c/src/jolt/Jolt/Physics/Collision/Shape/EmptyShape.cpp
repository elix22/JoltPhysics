// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/EmptyShape.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/CastResult.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/RayCast.h>
#include <Jolt/Physics/Collision/Shape/EmptyShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_EmptyShapeSettings_Get_mCenterOfMass(const JPH_EmptyShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShapeSettings *)(_this)).mCenterOfMass);
}

JPH_Vec3 *JPH_EmptyShapeSettings_GetMutable_mCenterOfMass(JPH_EmptyShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::EmptyShapeSettings *)(_this)).mCenterOfMass);
}

const uint64_t *JPH_EmptyShapeSettings_Get_mUserData(const JPH_EmptyShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShapeSettings *)(_this)).mUserData);
}

void JPH_EmptyShapeSettings_Set_mUserData(JPH_EmptyShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::EmptyShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_EmptyShapeSettings_GetMutable_mUserData(JPH_EmptyShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::EmptyShapeSettings *)(_this)).mUserData);
}

JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::EmptyShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_EmptyShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_EmptyShapeSettings *)(new JPH::EmptyShapeSettings[num_elems]{});
}

const JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_OffsetPtr(const JPH_EmptyShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_EmptyShapeSettings *)(((const JPH::EmptyShapeSettings *)ptr) + i);
}

JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_OffsetMutablePtr(JPH_EmptyShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_EmptyShapeSettings *)(((JPH::EmptyShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_EmptyShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_EmptyShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::EmptyShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_EmptyShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_EmptyShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::EmptyShapeSettings *)object)
    ));
}

const JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_EmptyShapeSettings *)(static_cast<const JPH::EmptyShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_EmptyShapeSettings *)(static_cast<JPH::EmptyShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_EmptyShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_EmptyShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::EmptyShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_EmptyShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_EmptyShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::EmptyShapeSettings *)object)
    ));
}

const JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_EmptyShapeSettings *)(static_cast<const JPH::EmptyShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_EmptyShapeSettings *)(static_cast<JPH::EmptyShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_EmptyShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_EmptyShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::EmptyShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_EmptyShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_EmptyShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::EmptyShapeSettings *)object)
    ));
}

const JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_EmptyShapeSettings *)(static_cast<const JPH::EmptyShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_EmptyShapeSettings *)(static_cast<JPH::EmptyShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_EmptyShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::EmptyShapeSettings);
    return (JPH_EmptyShapeSettings *)new JPH::EmptyShapeSettings(JPH::EmptyShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::EmptyShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::EmptyShapeSettings), JPH::EmptyShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::EmptyShapeSettings), JPH::EmptyShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::EmptyShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::EmptyShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::EmptyShapeSettings))
    ));
}

JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_Construct(const JPH_Vec3 *inCenterOfMass)
{
    return (JPH_EmptyShapeSettings *)new JPH::EmptyShapeSettings(JPH::EmptyShapeSettings(
        ((inCenterOfMass ? void() : MRBINDC_THROW("Parameter `inCenterOfMass` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenterOfMass))
    ));
}

void JPH_EmptyShapeSettings_Destroy(const JPH_EmptyShapeSettings *_this)
{
    delete ((const JPH::EmptyShapeSettings *)_this);
}

void JPH_EmptyShapeSettings_DestroyArray(const JPH_EmptyShapeSettings *_this)
{
    delete[] ((const JPH::EmptyShapeSettings *)_this);
}

JPH_EmptyShapeSettings *JPH_EmptyShapeSettings_AssignFromAnother(JPH_EmptyShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_EmptyShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::EmptyShapeSettings);
    return (JPH_EmptyShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::EmptyShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::EmptyShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::EmptyShapeSettings), JPH::EmptyShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::EmptyShapeSettings), JPH::EmptyShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::EmptyShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::EmptyShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::EmptyShapeSettings))
    ));
}

void *Jolt_new_JPH_EmptyShapeSettings_size_t(size_t inCount)
{
    return JPH::EmptyShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_EmptyShapeSettings_void_ptr(void *inPointer)
{
    JPH::EmptyShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_EmptyShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::EmptyShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_EmptyShapeSettings_size_t(size_t inCount)
{
    return JPH::EmptyShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_EmptyShapeSettings_void_ptr(void *inPointer)
{
    JPH::EmptyShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_EmptyShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::EmptyShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_EmptyShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::EmptyShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_EmptyShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::EmptyShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_EmptyShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::EmptyShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_EmptyShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::EmptyShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_EmptyShapeSettings_ClearCachedResult(JPH_EmptyShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::EmptyShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_EmptyShapeSettings_SetEmbedded(const JPH_EmptyShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_EmptyShapeSettings_GetRefCount(const JPH_EmptyShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShapeSettings *)(_this)).GetRefCount();
}

void JPH_EmptyShapeSettings_AddRef(const JPH_EmptyShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShapeSettings *)(_this)).AddRef();
}

void JPH_EmptyShapeSettings_Release(const JPH_EmptyShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShapeSettings *)(_this)).Release();
}

int JPH_EmptyShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::EmptyShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_EmptyShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::EmptyShape::cGetTrianglesMinTrianglesRequested);
}

JPH_EmptyShape *JPH_EmptyShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::EmptyShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_EmptyShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_EmptyShape *JPH_EmptyShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_EmptyShape *)(new JPH::EmptyShape[num_elems]{});
}

const JPH_EmptyShape *JPH_EmptyShape_OffsetPtr(const JPH_EmptyShape *ptr, ptrdiff_t i)
{
    return (const JPH_EmptyShape *)(((const JPH::EmptyShape *)ptr) + i);
}

JPH_EmptyShape *JPH_EmptyShape_OffsetMutablePtr(JPH_EmptyShape *ptr, ptrdiff_t i)
{
    return (JPH_EmptyShape *)(((JPH::EmptyShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_EmptyShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_EmptyShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::EmptyShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_EmptyShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_EmptyShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::EmptyShape *)object)
    ));
}

const JPH_EmptyShape *JPH_EmptyShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_EmptyShape *)(static_cast<const JPH::EmptyShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_EmptyShape *JPH_EmptyShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_EmptyShape *)(static_cast<JPH::EmptyShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_EmptyShape_UpcastTo_JPH_NonCopyable(const JPH_EmptyShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::EmptyShape *)object)
    ));
}

JPH_NonCopyable *JPH_EmptyShape_MutableUpcastTo_JPH_NonCopyable(JPH_EmptyShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::EmptyShape *)object)
    ));
}

const JPH_EmptyShape *JPH_EmptyShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_EmptyShape *)(static_cast<const JPH::EmptyShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_EmptyShape *JPH_EmptyShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_EmptyShape *)(static_cast<JPH::EmptyShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_EmptyShape_UpcastTo_JPH_Shape(const JPH_EmptyShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::EmptyShape *)object)
    ));
}

JPH_Shape *JPH_EmptyShape_MutableUpcastTo_JPH_Shape(JPH_EmptyShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::EmptyShape *)object)
    ));
}

const JPH_EmptyShape *JPH_EmptyShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_EmptyShape *)(static_cast<const JPH::EmptyShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_EmptyShape *JPH_EmptyShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_EmptyShape *)(static_cast<JPH::EmptyShape *>(
        ((JPH::Shape *)object)
    ));
}

JPH_EmptyShape *JPH_EmptyShape_Construct_1(const JPH_Vec3 *inCenterOfMass)
{
    return (JPH_EmptyShape *)new JPH::EmptyShape(JPH::EmptyShape(
        ((inCenterOfMass ? void() : MRBINDC_THROW("Parameter `inCenterOfMass` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenterOfMass))
    ));
}

void JPH_EmptyShape_Destroy(const JPH_EmptyShape *_this)
{
    delete ((const JPH::EmptyShape *)_this);
}

void JPH_EmptyShape_DestroyArray(const JPH_EmptyShape *_this)
{
    delete[] ((const JPH::EmptyShape *)_this);
}

JPH_Vec3 *JPH_EmptyShape_GetCenterOfMass(const JPH_EmptyShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_EmptyShape_GetLocalBounds(const JPH_EmptyShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetLocalBounds());
}

unsigned int JPH_EmptyShape_GetSubShapeIDBitsRecursive(const JPH_EmptyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetSubShapeIDBitsRecursive();
}

float JPH_EmptyShape_GetInnerRadius(const JPH_EmptyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetInnerRadius();
}

const JPH_PhysicsMaterial *JPH_EmptyShape_GetMaterial(const JPH_EmptyShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

JPH_Vec3 *JPH_EmptyShape_GetSurfaceNormal(const JPH_EmptyShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_EmptyShape_GetSubmergedVolume(const JPH_EmptyShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy))
    );
}

bool JPH_EmptyShape_CastRay_3(const JPH_EmptyShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_EmptyShape_GetTrianglesStart(const JPH_EmptyShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_EmptyShape_GetTrianglesNext(const JPH_EmptyShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_EmptyShape_GetStats(const JPH_EmptyShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetStats());
}

float JPH_EmptyShape_GetVolume(const JPH_EmptyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetVolume();
}

bool JPH_EmptyShape_IsValidScale(const JPH_EmptyShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

void JPH_EmptyShape_sRegister(void)
{
    JPH::EmptyShape::sRegister();
}

uint64_t JPH_EmptyShape_GetUserData(const JPH_EmptyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetUserData();
}

void JPH_EmptyShape_SetUserData(JPH_EmptyShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::EmptyShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_EmptyShape_MustBeStatic(const JPH_EmptyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).MustBeStatic();
}

const JPH_Shape *JPH_EmptyShape_GetLeafShape(const JPH_EmptyShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_EmptyShape_GetSubShapeUserData(const JPH_EmptyShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_EmptyShape_GetSubShapeTransformedShape(const JPH_EmptyShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

JPH_Vec3 *JPH_EmptyShape_MakeScaleValid(const JPH_EmptyShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_EmptyShape_SetEmbedded(const JPH_EmptyShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).SetEmbedded();
}

unsigned int JPH_EmptyShape_GetRefCount(const JPH_EmptyShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).GetRefCount();
}

void JPH_EmptyShape_AddRef(const JPH_EmptyShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).AddRef();
}

void JPH_EmptyShape_Release(const JPH_EmptyShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::EmptyShape *)(_this)).Release();
}

int JPH_EmptyShape_sInternalGetRefCountOffset(void)
{
    return JPH::EmptyShape::sInternalGetRefCountOffset();
}

