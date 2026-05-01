// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/ConvexHullShape.h"

#include <Jolt/Core/Color.h>
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
#include <Jolt/Physics/Collision/Shape/ConvexHullShape.h>
#include <Jolt/Physics/Collision/Shape/ConvexShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_ConvexHullShapeSettings_Get_mMaxConvexRadius(const JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShapeSettings *)(_this)).mMaxConvexRadius);
}

void JPH_ConvexHullShapeSettings_Set_mMaxConvexRadius(JPH_ConvexHullShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mMaxConvexRadius = value;
}

float *JPH_ConvexHullShapeSettings_GetMutable_mMaxConvexRadius(JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mMaxConvexRadius);
}

const float *JPH_ConvexHullShapeSettings_Get_mMaxErrorConvexRadius(const JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShapeSettings *)(_this)).mMaxErrorConvexRadius);
}

void JPH_ConvexHullShapeSettings_Set_mMaxErrorConvexRadius(JPH_ConvexHullShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mMaxErrorConvexRadius = value;
}

float *JPH_ConvexHullShapeSettings_GetMutable_mMaxErrorConvexRadius(JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mMaxErrorConvexRadius);
}

const float *JPH_ConvexHullShapeSettings_Get_mHullTolerance(const JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShapeSettings *)(_this)).mHullTolerance);
}

void JPH_ConvexHullShapeSettings_Set_mHullTolerance(JPH_ConvexHullShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mHullTolerance = value;
}

float *JPH_ConvexHullShapeSettings_GetMutable_mHullTolerance(JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mHullTolerance);
}

const float *JPH_ConvexHullShapeSettings_Get_mDensity(const JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShapeSettings *)(_this)).mDensity);
}

void JPH_ConvexHullShapeSettings_Set_mDensity(JPH_ConvexHullShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mDensity = value;
}

float *JPH_ConvexHullShapeSettings_GetMutable_mDensity(JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mDensity);
}

const uint64_t *JPH_ConvexHullShapeSettings_Get_mUserData(const JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShapeSettings *)(_this)).mUserData);
}

void JPH_ConvexHullShapeSettings_Set_mUserData(JPH_ConvexHullShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_ConvexHullShapeSettings_GetMutable_mUserData(JPH_ConvexHullShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).mUserData);
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ConvexHullShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ConvexHullShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ConvexHullShapeSettings *)(new JPH::ConvexHullShapeSettings[num_elems]{});
}

const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_OffsetPtr(const JPH_ConvexHullShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_ConvexHullShapeSettings *)(((const JPH::ConvexHullShapeSettings *)ptr) + i);
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_OffsetMutablePtr(JPH_ConvexHullShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_ConvexHullShapeSettings *)(((JPH::ConvexHullShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_ConvexHullShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ConvexHullShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::ConvexHullShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_ConvexHullShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ConvexHullShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::ConvexHullShapeSettings *)object)
    ));
}

const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_ConvexHullShapeSettings *)(static_cast<const JPH::ConvexHullShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_ConvexHullShapeSettings *)(static_cast<JPH::ConvexHullShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_ConvexHullShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ConvexHullShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::ConvexHullShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_ConvexHullShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ConvexHullShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::ConvexHullShapeSettings *)object)
    ));
}

const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_ConvexHullShapeSettings *)(static_cast<const JPH::ConvexHullShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_ConvexHullShapeSettings *)(static_cast<JPH::ConvexHullShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_ConvexHullShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_ConvexHullShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::ConvexHullShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_ConvexHullShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_ConvexHullShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::ConvexHullShapeSettings *)object)
    ));
}

const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_ConvexHullShapeSettings *)(static_cast<const JPH::ConvexHullShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_ConvexHullShapeSettings *)(static_cast<JPH::ConvexHullShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_ConvexHullShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_ConvexHullShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::ConvexHullShapeSettings *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_ConvexHullShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_ConvexHullShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::ConvexHullShapeSettings *)object)
    ));
}

const JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_ConvexHullShapeSettings *)(static_cast<const JPH::ConvexHullShapeSettings *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_ConvexHullShapeSettings *)(static_cast<JPH::ConvexHullShapeSettings *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ConvexHullShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ConvexHullShapeSettings);
    return (JPH_ConvexHullShapeSettings *)new JPH::ConvexHullShapeSettings(JPH::ConvexHullShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::ConvexHullShapeSettings), JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::ConvexHullShapeSettings), JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::ConvexHullShapeSettings))
    ));
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_Construct_4(const JPH_Vec3 *inPoints, int inNumPoints, const float *inMaxConvexRadius, const JPH_PhysicsMaterial *inMaterial)
{
    using namespace JPH;
    return (JPH_ConvexHullShapeSettings *)new JPH::ConvexHullShapeSettings(JPH::ConvexHullShapeSettings(
        ((const JPH::Vec3 *)inPoints),
        inNumPoints,
        (inMaxConvexRadius ? *inMaxConvexRadius : static_cast<float>(cDefaultConvexRadius)),
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_ConvexHullShapeSettings_Destroy(const JPH_ConvexHullShapeSettings *_this)
{
    delete ((const JPH::ConvexHullShapeSettings *)_this);
}

void JPH_ConvexHullShapeSettings_DestroyArray(const JPH_ConvexHullShapeSettings *_this)
{
    delete[] ((const JPH::ConvexHullShapeSettings *)_this);
}

JPH_ConvexHullShapeSettings *JPH_ConvexHullShapeSettings_AssignFromAnother(JPH_ConvexHullShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_ConvexHullShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ConvexHullShapeSettings);
    return (JPH_ConvexHullShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::ConvexHullShapeSettings), JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::ConvexHullShapeSettings), JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ConvexHullShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::ConvexHullShapeSettings))
    ));
}

void *Jolt_new_JPH_ConvexHullShapeSettings_size_t(size_t inCount)
{
    return JPH::ConvexHullShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ConvexHullShapeSettings_void_ptr(void *inPointer)
{
    JPH::ConvexHullShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ConvexHullShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConvexHullShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ConvexHullShapeSettings_size_t(size_t inCount)
{
    return JPH::ConvexHullShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ConvexHullShapeSettings_void_ptr(void *inPointer)
{
    JPH::ConvexHullShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ConvexHullShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConvexHullShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ConvexHullShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConvexHullShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ConvexHullShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConvexHullShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ConvexHullShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConvexHullShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ConvexHullShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConvexHullShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_ConvexHullShapeSettings_SetDensity(JPH_ConvexHullShapeSettings *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).SetDensity(
        inDensity
    );
}

void JPH_ConvexHullShapeSettings_ClearCachedResult(JPH_ConvexHullShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_ConvexHullShapeSettings_SetEmbedded(const JPH_ConvexHullShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_ConvexHullShapeSettings_GetRefCount(const JPH_ConvexHullShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShapeSettings *)(_this)).GetRefCount();
}

void JPH_ConvexHullShapeSettings_AddRef(const JPH_ConvexHullShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShapeSettings *)(_this)).AddRef();
}

void JPH_ConvexHullShapeSettings_Release(const JPH_ConvexHullShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShapeSettings *)(_this)).Release();
}

int JPH_ConvexHullShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::ConvexHullShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_ConvexHullShape_Get_cMaxPointsInHull(void)
{
    return std::addressof(JPH::ConvexHullShape::cMaxPointsInHull);
}

const bool *JPH_ConvexHullShape_Get_sDrawFaceOutlines(void)
{
    return std::addressof(JPH::ConvexHullShape::sDrawFaceOutlines);
}

void JPH_ConvexHullShape_Set_sDrawFaceOutlines(bool value)
{
    JPH::ConvexHullShape::sDrawFaceOutlines = value;
}

bool *JPH_ConvexHullShape_GetMutable_sDrawFaceOutlines(void)
{
    return std::addressof(JPH::ConvexHullShape::sDrawFaceOutlines);
}

const int *JPH_ConvexHullShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::ConvexHullShape::cGetTrianglesMinTrianglesRequested);
}

const bool *JPH_ConvexHullShape_Get_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::ConvexHullShape::sDrawSubmergedVolumes);
}

void JPH_ConvexHullShape_Set_sDrawSubmergedVolumes(bool value)
{
    JPH::ConvexHullShape::sDrawSubmergedVolumes = value;
}

bool *JPH_ConvexHullShape_GetMutable_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::ConvexHullShape::sDrawSubmergedVolumes);
}

JPH_ConvexHullShape *JPH_ConvexHullShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ConvexHullShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ConvexHullShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ConvexHullShape *JPH_ConvexHullShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ConvexHullShape *)(new JPH::ConvexHullShape[num_elems]{});
}

const JPH_ConvexHullShape *JPH_ConvexHullShape_OffsetPtr(const JPH_ConvexHullShape *ptr, ptrdiff_t i)
{
    return (const JPH_ConvexHullShape *)(((const JPH::ConvexHullShape *)ptr) + i);
}

JPH_ConvexHullShape *JPH_ConvexHullShape_OffsetMutablePtr(JPH_ConvexHullShape *ptr, ptrdiff_t i)
{
    return (JPH_ConvexHullShape *)(((JPH::ConvexHullShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_ConvexHullShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_ConvexHullShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::ConvexHullShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_ConvexHullShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_ConvexHullShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::ConvexHullShape *)object)
    ));
}

const JPH_ConvexHullShape *JPH_ConvexHullShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_ConvexHullShape *)(static_cast<const JPH::ConvexHullShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_ConvexHullShape *JPH_ConvexHullShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_ConvexHullShape *)(static_cast<JPH::ConvexHullShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_ConvexHullShape_UpcastTo_JPH_NonCopyable(const JPH_ConvexHullShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ConvexHullShape *)object)
    ));
}

JPH_NonCopyable *JPH_ConvexHullShape_MutableUpcastTo_JPH_NonCopyable(JPH_ConvexHullShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ConvexHullShape *)object)
    ));
}

const JPH_ConvexHullShape *JPH_ConvexHullShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ConvexHullShape *)(static_cast<const JPH::ConvexHullShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ConvexHullShape *JPH_ConvexHullShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ConvexHullShape *)(static_cast<JPH::ConvexHullShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_ConvexHullShape_UpcastTo_JPH_Shape(const JPH_ConvexHullShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::ConvexHullShape *)object)
    ));
}

JPH_Shape *JPH_ConvexHullShape_MutableUpcastTo_JPH_Shape(JPH_ConvexHullShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::ConvexHullShape *)object)
    ));
}

const JPH_ConvexHullShape *JPH_ConvexHullShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_ConvexHullShape *)(static_cast<const JPH::ConvexHullShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_ConvexHullShape *JPH_ConvexHullShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_ConvexHullShape *)(static_cast<JPH::ConvexHullShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_ConvexShape *JPH_ConvexHullShape_UpcastTo_JPH_ConvexShape(const JPH_ConvexHullShape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::ConvexHullShape *)object)
    ));
}

JPH_ConvexShape *JPH_ConvexHullShape_MutableUpcastTo_JPH_ConvexShape(JPH_ConvexHullShape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::ConvexHullShape *)object)
    ));
}

const JPH_ConvexHullShape *JPH_ConvexHullShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object)
{
    return (const JPH_ConvexHullShape *)(static_cast<const JPH::ConvexHullShape *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_ConvexHullShape *JPH_ConvexHullShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object)
{
    return (JPH_ConvexHullShape *)(static_cast<JPH::ConvexHullShape *>(
        ((JPH::ConvexShape *)object)
    ));
}

void JPH_ConvexHullShape_Destroy(const JPH_ConvexHullShape *_this)
{
    delete ((const JPH::ConvexHullShape *)_this);
}

void JPH_ConvexHullShape_DestroyArray(const JPH_ConvexHullShape *_this)
{
    delete[] ((const JPH::ConvexHullShape *)_this);
}

void *Jolt_new_JPH_ConvexHullShape_size_t(size_t inCount)
{
    return JPH::ConvexHullShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ConvexHullShape_void_ptr(void *inPointer)
{
    JPH::ConvexHullShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ConvexHullShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConvexHullShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ConvexHullShape_size_t(size_t inCount)
{
    return JPH::ConvexHullShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ConvexHullShape_void_ptr(void *inPointer)
{
    JPH::ConvexHullShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ConvexHullShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConvexHullShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ConvexHullShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConvexHullShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ConvexHullShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConvexHullShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ConvexHullShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConvexHullShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ConvexHullShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConvexHullShape::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Vec3 *JPH_ConvexHullShape_GetCenterOfMass(const JPH_ConvexHullShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_ConvexHullShape_GetLocalBounds(const JPH_ConvexHullShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetLocalBounds());
}

float JPH_ConvexHullShape_GetInnerRadius(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetInnerRadius();
}

JPH_Vec3 *JPH_ConvexHullShape_GetSurfaceNormal(const JPH_ConvexHullShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

const JPH_ConvexShape_Support *JPH_ConvexHullShape_GetSupportFunction(const JPH_ConvexHullShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale)
{
    return (const JPH_ConvexShape_Support *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetSupportFunction(
        ((JPH::ConvexShape::ESupportMode)inMode),
        ((inBuffer ? void() : MRBINDC_THROW("Parameter `inBuffer` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(inBuffer)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_ConvexHullShape_GetSubmergedVolume(const JPH_ConvexHullShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

void JPH_ConvexHullShape_Draw(const JPH_ConvexHullShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).Draw(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inUseMaterialColors,
        inDrawWireframe
    );
}

void JPH_ConvexHullShape_DrawShrunkShape(const JPH_ConvexHullShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).DrawShrunkShape(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

bool JPH_ConvexHullShape_CastRay_3(const JPH_ConvexHullShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_ConvexHullShape_GetTrianglesStart(const JPH_ConvexHullShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_ConvexHullShape_GetTrianglesNext(const JPH_ConvexHullShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_ConvexHullShape_GetStats(const JPH_ConvexHullShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetStats());
}

float JPH_ConvexHullShape_GetVolume(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetVolume();
}

float JPH_ConvexHullShape_GetConvexRadius(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetConvexRadius();
}

unsigned int JPH_ConvexHullShape_GetNumPoints(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetNumPoints();
}

JPH_Vec3 *JPH_ConvexHullShape_GetPoint(const JPH_ConvexHullShape *_this, unsigned int inIndex)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetPoint(
        inIndex
    ));
}

unsigned int JPH_ConvexHullShape_GetNumFaces(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetNumFaces();
}

unsigned int JPH_ConvexHullShape_GetNumVerticesInFace(const JPH_ConvexHullShape *_this, unsigned int inFaceIndex)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetNumVerticesInFace(
        inFaceIndex
    );
}

unsigned int JPH_ConvexHullShape_GetFaceVertices(const JPH_ConvexHullShape *_this, unsigned int inFaceIndex, unsigned int inMaxVertices, unsigned int *outVertices)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetFaceVertices(
        inFaceIndex,
        inMaxVertices,
        outVertices
    );
}

void JPH_ConvexHullShape_sRegister(void)
{
    JPH::ConvexHullShape::sRegister();
}

unsigned int JPH_ConvexHullShape_GetSubShapeIDBitsRecursive(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetSubShapeIDBitsRecursive();
}

void JPH_ConvexHullShape_SetMaterial(JPH_ConvexHullShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

void JPH_ConvexHullShape_SetDensity(JPH_ConvexHullShape *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShape *)(_this)).SetDensity(
        inDensity
    );
}

float JPH_ConvexHullShape_GetDensity(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetDensity();
}

void JPH_ConvexHullShape_DrawGetSupportFunction(const JPH_ConvexHullShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).DrawGetSupportFunction(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inDrawSupportDirection
    );
}

void JPH_ConvexHullShape_DrawGetSupportingFace(const JPH_ConvexHullShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).DrawGetSupportingFace(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

uint64_t JPH_ConvexHullShape_GetUserData(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetUserData();
}

void JPH_ConvexHullShape_SetUserData(JPH_ConvexHullShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConvexHullShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_ConvexHullShape_MustBeStatic(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).MustBeStatic();
}

const JPH_Shape *JPH_ConvexHullShape_GetLeafShape(const JPH_ConvexHullShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_ConvexHullShape_GetSubShapeUserData(const JPH_ConvexHullShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_ConvexHullShape_GetSubShapeTransformedShape(const JPH_ConvexHullShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

bool JPH_ConvexHullShape_IsValidScale(const JPH_ConvexHullShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_ConvexHullShape_MakeScaleValid(const JPH_ConvexHullShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_ConvexHullShape_SetEmbedded(const JPH_ConvexHullShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).SetEmbedded();
}

unsigned int JPH_ConvexHullShape_GetRefCount(const JPH_ConvexHullShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).GetRefCount();
}

void JPH_ConvexHullShape_AddRef(const JPH_ConvexHullShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).AddRef();
}

void JPH_ConvexHullShape_Release(const JPH_ConvexHullShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConvexHullShape *)(_this)).Release();
}

int JPH_ConvexHullShape_sInternalGetRefCountOffset(void)
{
    return JPH::ConvexHullShape::sInternalGetRefCountOffset();
}

