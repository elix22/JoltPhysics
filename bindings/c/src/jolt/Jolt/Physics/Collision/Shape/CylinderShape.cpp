// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/CylinderShape.h"

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
#include <Jolt/Physics/Collision/Shape/ConvexShape.h>
#include <Jolt/Physics/Collision/Shape/CylinderShape.h>
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


const float *JPH_CylinderShapeSettings_Get_mHalfHeight(const JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShapeSettings *)(_this)).mHalfHeight);
}

void JPH_CylinderShapeSettings_Set_mHalfHeight(JPH_CylinderShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mHalfHeight = value;
}

float *JPH_CylinderShapeSettings_GetMutable_mHalfHeight(JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mHalfHeight);
}

const float *JPH_CylinderShapeSettings_Get_mRadius(const JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShapeSettings *)(_this)).mRadius);
}

void JPH_CylinderShapeSettings_Set_mRadius(JPH_CylinderShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mRadius = value;
}

float *JPH_CylinderShapeSettings_GetMutable_mRadius(JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mRadius);
}

const float *JPH_CylinderShapeSettings_Get_mConvexRadius(const JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShapeSettings *)(_this)).mConvexRadius);
}

void JPH_CylinderShapeSettings_Set_mConvexRadius(JPH_CylinderShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mConvexRadius = value;
}

float *JPH_CylinderShapeSettings_GetMutable_mConvexRadius(JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mConvexRadius);
}

const float *JPH_CylinderShapeSettings_Get_mDensity(const JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShapeSettings *)(_this)).mDensity);
}

void JPH_CylinderShapeSettings_Set_mDensity(JPH_CylinderShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mDensity = value;
}

float *JPH_CylinderShapeSettings_GetMutable_mDensity(JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mDensity);
}

const uint64_t *JPH_CylinderShapeSettings_Get_mUserData(const JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShapeSettings *)(_this)).mUserData);
}

void JPH_CylinderShapeSettings_Set_mUserData(JPH_CylinderShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_CylinderShapeSettings_GetMutable_mUserData(JPH_CylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).mUserData);
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::CylinderShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_CylinderShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CylinderShapeSettings *)(new JPH::CylinderShapeSettings[num_elems]);
}

const JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_OffsetPtr(const JPH_CylinderShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_CylinderShapeSettings *)(((const JPH::CylinderShapeSettings *)ptr) + i);
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_OffsetMutablePtr(JPH_CylinderShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_CylinderShapeSettings *)(((JPH::CylinderShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_CylinderShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_CylinderShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::CylinderShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_CylinderShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_CylinderShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::CylinderShapeSettings *)object)
    ));
}

const JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_CylinderShapeSettings *)(static_cast<const JPH::CylinderShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_CylinderShapeSettings *)(static_cast<JPH::CylinderShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_CylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_CylinderShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::CylinderShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_CylinderShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_CylinderShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::CylinderShapeSettings *)object)
    ));
}

const JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_CylinderShapeSettings *)(static_cast<const JPH::CylinderShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_CylinderShapeSettings *)(static_cast<JPH::CylinderShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_CylinderShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_CylinderShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::CylinderShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_CylinderShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_CylinderShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::CylinderShapeSettings *)object)
    ));
}

const JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_CylinderShapeSettings *)(static_cast<const JPH::CylinderShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_CylinderShapeSettings *)(static_cast<JPH::CylinderShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_CylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_CylinderShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::CylinderShapeSettings *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_CylinderShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_CylinderShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::CylinderShapeSettings *)object)
    ));
}

const JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_CylinderShapeSettings *)(static_cast<const JPH::CylinderShapeSettings *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_CylinderShapeSettings *)(static_cast<JPH::CylinderShapeSettings *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CylinderShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CylinderShapeSettings);
    return (JPH_CylinderShapeSettings *)new JPH::CylinderShapeSettings(JPH::CylinderShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CylinderShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CylinderShapeSettings), JPH::CylinderShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::CylinderShapeSettings), JPH::CylinderShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CylinderShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CylinderShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::CylinderShapeSettings))
    ));
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_Construct(float inHalfHeight, float inRadius, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial)
{
    using namespace JPH;
    return (JPH_CylinderShapeSettings *)new JPH::CylinderShapeSettings(JPH::CylinderShapeSettings(
        inHalfHeight,
        inRadius,
        (inConvexRadius ? *inConvexRadius : static_cast<float>(cDefaultConvexRadius)),
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_CylinderShapeSettings_Destroy(const JPH_CylinderShapeSettings *_this)
{
    delete ((const JPH::CylinderShapeSettings *)_this);
}

void JPH_CylinderShapeSettings_DestroyArray(const JPH_CylinderShapeSettings *_this)
{
    delete[] ((const JPH::CylinderShapeSettings *)_this);
}

JPH_CylinderShapeSettings *JPH_CylinderShapeSettings_AssignFromAnother(JPH_CylinderShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_CylinderShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CylinderShapeSettings);
    return (JPH_CylinderShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CylinderShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CylinderShapeSettings), JPH::CylinderShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::CylinderShapeSettings), JPH::CylinderShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CylinderShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CylinderShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::CylinderShapeSettings))
    ));
}

void *Jolt_new_JPH_CylinderShapeSettings_size_t(size_t inCount)
{
    return JPH::CylinderShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CylinderShapeSettings_void_ptr(void *inPointer)
{
    JPH::CylinderShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CylinderShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CylinderShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CylinderShapeSettings_size_t(size_t inCount)
{
    return JPH::CylinderShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CylinderShapeSettings_void_ptr(void *inPointer)
{
    JPH::CylinderShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CylinderShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CylinderShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CylinderShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CylinderShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CylinderShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CylinderShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CylinderShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CylinderShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CylinderShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CylinderShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_CylinderShapeSettings_SetDensity(JPH_CylinderShapeSettings *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).SetDensity(
        inDensity
    );
}

void JPH_CylinderShapeSettings_ClearCachedResult(JPH_CylinderShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_CylinderShapeSettings_SetEmbedded(const JPH_CylinderShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_CylinderShapeSettings_GetRefCount(const JPH_CylinderShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShapeSettings *)(_this)).GetRefCount();
}

void JPH_CylinderShapeSettings_AddRef(const JPH_CylinderShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShapeSettings *)(_this)).AddRef();
}

void JPH_CylinderShapeSettings_Release(const JPH_CylinderShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShapeSettings *)(_this)).Release();
}

int JPH_CylinderShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::CylinderShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_CylinderShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::CylinderShape::cGetTrianglesMinTrianglesRequested);
}

const bool *JPH_CylinderShape_Get_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::CylinderShape::sDrawSubmergedVolumes);
}

void JPH_CylinderShape_Set_sDrawSubmergedVolumes(bool value)
{
    JPH::CylinderShape::sDrawSubmergedVolumes = value;
}

bool *JPH_CylinderShape_GetMutable_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::CylinderShape::sDrawSubmergedVolumes);
}

JPH_CylinderShape *JPH_CylinderShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::CylinderShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_CylinderShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_CylinderShape *JPH_CylinderShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CylinderShape *)(new JPH::CylinderShape[num_elems]);
}

const JPH_CylinderShape *JPH_CylinderShape_OffsetPtr(const JPH_CylinderShape *ptr, ptrdiff_t i)
{
    return (const JPH_CylinderShape *)(((const JPH::CylinderShape *)ptr) + i);
}

JPH_CylinderShape *JPH_CylinderShape_OffsetMutablePtr(JPH_CylinderShape *ptr, ptrdiff_t i)
{
    return (JPH_CylinderShape *)(((JPH::CylinderShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_CylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_CylinderShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::CylinderShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_CylinderShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_CylinderShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::CylinderShape *)object)
    ));
}

const JPH_CylinderShape *JPH_CylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_CylinderShape *)(static_cast<const JPH::CylinderShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_CylinderShape *JPH_CylinderShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_CylinderShape *)(static_cast<JPH::CylinderShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_CylinderShape_UpcastTo_JPH_NonCopyable(const JPH_CylinderShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::CylinderShape *)object)
    ));
}

JPH_NonCopyable *JPH_CylinderShape_MutableUpcastTo_JPH_NonCopyable(JPH_CylinderShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::CylinderShape *)object)
    ));
}

const JPH_CylinderShape *JPH_CylinderShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_CylinderShape *)(static_cast<const JPH::CylinderShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_CylinderShape *JPH_CylinderShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_CylinderShape *)(static_cast<JPH::CylinderShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_CylinderShape_UpcastTo_JPH_Shape(const JPH_CylinderShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::CylinderShape *)object)
    ));
}

JPH_Shape *JPH_CylinderShape_MutableUpcastTo_JPH_Shape(JPH_CylinderShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::CylinderShape *)object)
    ));
}

const JPH_CylinderShape *JPH_CylinderShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_CylinderShape *)(static_cast<const JPH::CylinderShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_CylinderShape *JPH_CylinderShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_CylinderShape *)(static_cast<JPH::CylinderShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_ConvexShape *JPH_CylinderShape_UpcastTo_JPH_ConvexShape(const JPH_CylinderShape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::CylinderShape *)object)
    ));
}

JPH_ConvexShape *JPH_CylinderShape_MutableUpcastTo_JPH_ConvexShape(JPH_CylinderShape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::CylinderShape *)object)
    ));
}

const JPH_CylinderShape *JPH_CylinderShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object)
{
    return (const JPH_CylinderShape *)(static_cast<const JPH::CylinderShape *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_CylinderShape *JPH_CylinderShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object)
{
    return (JPH_CylinderShape *)(static_cast<JPH::CylinderShape *>(
        ((JPH::ConvexShape *)object)
    ));
}

JPH_CylinderShape *JPH_CylinderShape_Construct_4(float inHalfHeight, float inRadius, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial)
{
    using namespace JPH;
    return (JPH_CylinderShape *)new JPH::CylinderShape(JPH::CylinderShape(
        inHalfHeight,
        inRadius,
        (inConvexRadius ? *inConvexRadius : static_cast<float>(cDefaultConvexRadius)),
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_CylinderShape_Destroy(const JPH_CylinderShape *_this)
{
    delete ((const JPH::CylinderShape *)_this);
}

void JPH_CylinderShape_DestroyArray(const JPH_CylinderShape *_this)
{
    delete[] ((const JPH::CylinderShape *)_this);
}

void *Jolt_new_JPH_CylinderShape_size_t(size_t inCount)
{
    return JPH::CylinderShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CylinderShape_void_ptr(void *inPointer)
{
    JPH::CylinderShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CylinderShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CylinderShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CylinderShape_size_t(size_t inCount)
{
    return JPH::CylinderShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CylinderShape_void_ptr(void *inPointer)
{
    JPH::CylinderShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CylinderShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CylinderShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CylinderShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CylinderShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CylinderShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CylinderShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CylinderShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CylinderShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CylinderShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CylinderShape::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_CylinderShape_GetHalfHeight(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetHalfHeight();
}

float JPH_CylinderShape_GetRadius(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetRadius();
}

JPH_AABox *JPH_CylinderShape_GetLocalBounds(const JPH_CylinderShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetLocalBounds());
}

float JPH_CylinderShape_GetInnerRadius(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetInnerRadius();
}

JPH_Vec3 *JPH_CylinderShape_GetSurfaceNormal(const JPH_CylinderShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

const JPH_ConvexShape_Support *JPH_CylinderShape_GetSupportFunction(const JPH_CylinderShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale)
{
    return (const JPH_ConvexShape_Support *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetSupportFunction(
        ((JPH::ConvexShape::ESupportMode)inMode),
        ((inBuffer ? void() : MRBINDC_THROW("Parameter `inBuffer` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(inBuffer)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_CylinderShape_Draw(const JPH_CylinderShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).Draw(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inUseMaterialColors,
        inDrawWireframe
    );
}

bool JPH_CylinderShape_CastRay_3(const JPH_CylinderShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_CylinderShape_GetTrianglesStart(const JPH_CylinderShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_CylinderShape_GetTrianglesNext(const JPH_CylinderShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_CylinderShape_GetStats(const JPH_CylinderShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetStats());
}

float JPH_CylinderShape_GetVolume(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetVolume();
}

float JPH_CylinderShape_GetConvexRadius(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetConvexRadius();
}

bool JPH_CylinderShape_IsValidScale(const JPH_CylinderShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_CylinderShape_MakeScaleValid(const JPH_CylinderShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_CylinderShape_sRegister(void)
{
    JPH::CylinderShape::sRegister();
}

unsigned int JPH_CylinderShape_GetSubShapeIDBitsRecursive(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetSubShapeIDBitsRecursive();
}

void JPH_CylinderShape_GetSubmergedVolume(const JPH_CylinderShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

void JPH_CylinderShape_SetMaterial(JPH_CylinderShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

void JPH_CylinderShape_SetDensity(JPH_CylinderShape *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShape *)(_this)).SetDensity(
        inDensity
    );
}

float JPH_CylinderShape_GetDensity(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetDensity();
}

void JPH_CylinderShape_DrawGetSupportFunction(const JPH_CylinderShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).DrawGetSupportFunction(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inDrawSupportDirection
    );
}

void JPH_CylinderShape_DrawGetSupportingFace(const JPH_CylinderShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).DrawGetSupportingFace(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

uint64_t JPH_CylinderShape_GetUserData(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetUserData();
}

void JPH_CylinderShape_SetUserData(JPH_CylinderShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CylinderShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_CylinderShape_MustBeStatic(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).MustBeStatic();
}

JPH_Vec3 *JPH_CylinderShape_GetCenterOfMass(const JPH_CylinderShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetCenterOfMass());
}

const JPH_Shape *JPH_CylinderShape_GetLeafShape(const JPH_CylinderShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_CylinderShape_GetSubShapeUserData(const JPH_CylinderShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_CylinderShape_GetSubShapeTransformedShape(const JPH_CylinderShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

void JPH_CylinderShape_SetEmbedded(const JPH_CylinderShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).SetEmbedded();
}

unsigned int JPH_CylinderShape_GetRefCount(const JPH_CylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).GetRefCount();
}

void JPH_CylinderShape_AddRef(const JPH_CylinderShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).AddRef();
}

void JPH_CylinderShape_Release(const JPH_CylinderShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CylinderShape *)(_this)).Release();
}

int JPH_CylinderShape_sInternalGetRefCountOffset(void)
{
    return JPH::CylinderShape::sInternalGetRefCountOffset();
}

