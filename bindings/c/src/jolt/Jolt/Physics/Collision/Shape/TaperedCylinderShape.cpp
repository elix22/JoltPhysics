// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/TaperedCylinderShape.h"

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
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/ConvexShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/Shape/TaperedCylinderShape.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_TaperedCylinderShapeSettings_Get_mHalfHeight(const JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).mHalfHeight);
}

void JPH_TaperedCylinderShapeSettings_Set_mHalfHeight(JPH_TaperedCylinderShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mHalfHeight = value;
}

float *JPH_TaperedCylinderShapeSettings_GetMutable_mHalfHeight(JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mHalfHeight);
}

const float *JPH_TaperedCylinderShapeSettings_Get_mTopRadius(const JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).mTopRadius);
}

void JPH_TaperedCylinderShapeSettings_Set_mTopRadius(JPH_TaperedCylinderShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mTopRadius = value;
}

float *JPH_TaperedCylinderShapeSettings_GetMutable_mTopRadius(JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mTopRadius);
}

const float *JPH_TaperedCylinderShapeSettings_Get_mBottomRadius(const JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).mBottomRadius);
}

void JPH_TaperedCylinderShapeSettings_Set_mBottomRadius(JPH_TaperedCylinderShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mBottomRadius = value;
}

float *JPH_TaperedCylinderShapeSettings_GetMutable_mBottomRadius(JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mBottomRadius);
}

const float *JPH_TaperedCylinderShapeSettings_Get_mConvexRadius(const JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).mConvexRadius);
}

void JPH_TaperedCylinderShapeSettings_Set_mConvexRadius(JPH_TaperedCylinderShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mConvexRadius = value;
}

float *JPH_TaperedCylinderShapeSettings_GetMutable_mConvexRadius(JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mConvexRadius);
}

const float *JPH_TaperedCylinderShapeSettings_Get_mDensity(const JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).mDensity);
}

void JPH_TaperedCylinderShapeSettings_Set_mDensity(JPH_TaperedCylinderShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mDensity = value;
}

float *JPH_TaperedCylinderShapeSettings_GetMutable_mDensity(JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mDensity);
}

const uint64_t *JPH_TaperedCylinderShapeSettings_Get_mUserData(const JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).mUserData);
}

void JPH_TaperedCylinderShapeSettings_Set_mUserData(JPH_TaperedCylinderShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_TaperedCylinderShapeSettings_GetMutable_mUserData(JPH_TaperedCylinderShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).mUserData);
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::TaperedCylinderShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_TaperedCylinderShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_TaperedCylinderShapeSettings *)(new JPH::TaperedCylinderShapeSettings[num_elems]);
}

const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_OffsetPtr(const JPH_TaperedCylinderShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_TaperedCylinderShapeSettings *)(((const JPH::TaperedCylinderShapeSettings *)ptr) + i);
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_OffsetMutablePtr(JPH_TaperedCylinderShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_TaperedCylinderShapeSettings *)(((JPH::TaperedCylinderShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_TaperedCylinderShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::TaperedCylinderShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_TaperedCylinderShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_TaperedCylinderShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::TaperedCylinderShapeSettings *)object)
    ));
}

const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_TaperedCylinderShapeSettings *)(static_cast<const JPH::TaperedCylinderShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_TaperedCylinderShapeSettings *)(static_cast<JPH::TaperedCylinderShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_TaperedCylinderShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::TaperedCylinderShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_TaperedCylinderShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_TaperedCylinderShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::TaperedCylinderShapeSettings *)object)
    ));
}

const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_TaperedCylinderShapeSettings *)(static_cast<const JPH::TaperedCylinderShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_TaperedCylinderShapeSettings *)(static_cast<JPH::TaperedCylinderShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_TaperedCylinderShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::TaperedCylinderShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_TaperedCylinderShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_TaperedCylinderShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::TaperedCylinderShapeSettings *)object)
    ));
}

const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_TaperedCylinderShapeSettings *)(static_cast<const JPH::TaperedCylinderShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_TaperedCylinderShapeSettings *)(static_cast<JPH::TaperedCylinderShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_TaperedCylinderShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_TaperedCylinderShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::TaperedCylinderShapeSettings *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_TaperedCylinderShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_TaperedCylinderShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::TaperedCylinderShapeSettings *)object)
    ));
}

const JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_TaperedCylinderShapeSettings *)(static_cast<const JPH::TaperedCylinderShapeSettings *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_TaperedCylinderShapeSettings *)(static_cast<JPH::TaperedCylinderShapeSettings *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_TaperedCylinderShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TaperedCylinderShapeSettings);
    return (JPH_TaperedCylinderShapeSettings *)new JPH::TaperedCylinderShapeSettings(JPH::TaperedCylinderShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::TaperedCylinderShapeSettings), JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::TaperedCylinderShapeSettings), JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::TaperedCylinderShapeSettings))
    ));
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_Construct(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial)
{
    using namespace JPH;
    return (JPH_TaperedCylinderShapeSettings *)new JPH::TaperedCylinderShapeSettings(JPH::TaperedCylinderShapeSettings(
        inHalfHeightOfTaperedCylinder,
        inTopRadius,
        inBottomRadius,
        (inConvexRadius ? *inConvexRadius : static_cast<float>(cDefaultConvexRadius)),
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_TaperedCylinderShapeSettings_Destroy(const JPH_TaperedCylinderShapeSettings *_this)
{
    delete ((const JPH::TaperedCylinderShapeSettings *)_this);
}

void JPH_TaperedCylinderShapeSettings_DestroyArray(const JPH_TaperedCylinderShapeSettings *_this)
{
    delete[] ((const JPH::TaperedCylinderShapeSettings *)_this);
}

JPH_TaperedCylinderShapeSettings *JPH_TaperedCylinderShapeSettings_AssignFromAnother(JPH_TaperedCylinderShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_TaperedCylinderShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TaperedCylinderShapeSettings);
    return (JPH_TaperedCylinderShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::TaperedCylinderShapeSettings), JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::TaperedCylinderShapeSettings), JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TaperedCylinderShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::TaperedCylinderShapeSettings))
    ));
}

void *Jolt_new_JPH_TaperedCylinderShapeSettings_size_t(size_t inCount)
{
    return JPH::TaperedCylinderShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr(void *inPointer)
{
    JPH::TaperedCylinderShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TaperedCylinderShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t(size_t inCount)
{
    return JPH::TaperedCylinderShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr(void *inPointer)
{
    JPH::TaperedCylinderShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TaperedCylinderShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TaperedCylinderShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TaperedCylinderShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TaperedCylinderShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TaperedCylinderShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TaperedCylinderShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TaperedCylinderShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TaperedCylinderShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_TaperedCylinderShapeSettings_SetDensity(JPH_TaperedCylinderShapeSettings *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).SetDensity(
        inDensity
    );
}

void JPH_TaperedCylinderShapeSettings_ClearCachedResult(JPH_TaperedCylinderShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_TaperedCylinderShapeSettings_SetEmbedded(const JPH_TaperedCylinderShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_TaperedCylinderShapeSettings_GetRefCount(const JPH_TaperedCylinderShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).GetRefCount();
}

void JPH_TaperedCylinderShapeSettings_AddRef(const JPH_TaperedCylinderShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).AddRef();
}

void JPH_TaperedCylinderShapeSettings_Release(const JPH_TaperedCylinderShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShapeSettings *)(_this)).Release();
}

int JPH_TaperedCylinderShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::TaperedCylinderShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_TaperedCylinderShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::TaperedCylinderShape::cGetTrianglesMinTrianglesRequested);
}

const bool *JPH_TaperedCylinderShape_Get_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::TaperedCylinderShape::sDrawSubmergedVolumes);
}

void JPH_TaperedCylinderShape_Set_sDrawSubmergedVolumes(bool value)
{
    JPH::TaperedCylinderShape::sDrawSubmergedVolumes = value;
}

bool *JPH_TaperedCylinderShape_GetMutable_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::TaperedCylinderShape::sDrawSubmergedVolumes);
}

JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::TaperedCylinderShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_TaperedCylinderShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_TaperedCylinderShape *)(new JPH::TaperedCylinderShape[num_elems]);
}

const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_OffsetPtr(const JPH_TaperedCylinderShape *ptr, ptrdiff_t i)
{
    return (const JPH_TaperedCylinderShape *)(((const JPH::TaperedCylinderShape *)ptr) + i);
}

JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_OffsetMutablePtr(JPH_TaperedCylinderShape *ptr, ptrdiff_t i)
{
    return (JPH_TaperedCylinderShape *)(((JPH::TaperedCylinderShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_TaperedCylinderShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_TaperedCylinderShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::TaperedCylinderShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_TaperedCylinderShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_TaperedCylinderShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::TaperedCylinderShape *)object)
    ));
}

const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_TaperedCylinderShape *)(static_cast<const JPH::TaperedCylinderShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_TaperedCylinderShape *)(static_cast<JPH::TaperedCylinderShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_TaperedCylinderShape_UpcastTo_JPH_NonCopyable(const JPH_TaperedCylinderShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::TaperedCylinderShape *)object)
    ));
}

JPH_NonCopyable *JPH_TaperedCylinderShape_MutableUpcastTo_JPH_NonCopyable(JPH_TaperedCylinderShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::TaperedCylinderShape *)object)
    ));
}

const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_TaperedCylinderShape *)(static_cast<const JPH::TaperedCylinderShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_TaperedCylinderShape *)(static_cast<JPH::TaperedCylinderShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_TaperedCylinderShape_UpcastTo_JPH_Shape(const JPH_TaperedCylinderShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::TaperedCylinderShape *)object)
    ));
}

JPH_Shape *JPH_TaperedCylinderShape_MutableUpcastTo_JPH_Shape(JPH_TaperedCylinderShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::TaperedCylinderShape *)object)
    ));
}

const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_TaperedCylinderShape *)(static_cast<const JPH::TaperedCylinderShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_TaperedCylinderShape *)(static_cast<JPH::TaperedCylinderShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_ConvexShape *JPH_TaperedCylinderShape_UpcastTo_JPH_ConvexShape(const JPH_TaperedCylinderShape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::TaperedCylinderShape *)object)
    ));
}

JPH_ConvexShape *JPH_TaperedCylinderShape_MutableUpcastTo_JPH_ConvexShape(JPH_TaperedCylinderShape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::TaperedCylinderShape *)object)
    ));
}

const JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object)
{
    return (const JPH_TaperedCylinderShape *)(static_cast<const JPH::TaperedCylinderShape *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_TaperedCylinderShape *JPH_TaperedCylinderShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object)
{
    return (JPH_TaperedCylinderShape *)(static_cast<JPH::TaperedCylinderShape *>(
        ((JPH::ConvexShape *)object)
    ));
}

void JPH_TaperedCylinderShape_Destroy(const JPH_TaperedCylinderShape *_this)
{
    delete ((const JPH::TaperedCylinderShape *)_this);
}

void JPH_TaperedCylinderShape_DestroyArray(const JPH_TaperedCylinderShape *_this)
{
    delete[] ((const JPH::TaperedCylinderShape *)_this);
}

void *Jolt_new_JPH_TaperedCylinderShape_size_t(size_t inCount)
{
    return JPH::TaperedCylinderShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TaperedCylinderShape_void_ptr(void *inPointer)
{
    JPH::TaperedCylinderShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TaperedCylinderShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TaperedCylinderShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TaperedCylinderShape_size_t(size_t inCount)
{
    return JPH::TaperedCylinderShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr(void *inPointer)
{
    JPH::TaperedCylinderShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TaperedCylinderShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TaperedCylinderShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TaperedCylinderShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TaperedCylinderShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TaperedCylinderShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TaperedCylinderShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TaperedCylinderShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TaperedCylinderShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TaperedCylinderShape::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_TaperedCylinderShape_GetTopRadius(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetTopRadius();
}

float JPH_TaperedCylinderShape_GetBottomRadius(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetBottomRadius();
}

float JPH_TaperedCylinderShape_GetConvexRadius(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetConvexRadius();
}

float JPH_TaperedCylinderShape_GetHalfHeight(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetHalfHeight();
}

JPH_Vec3 *JPH_TaperedCylinderShape_GetCenterOfMass(const JPH_TaperedCylinderShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_TaperedCylinderShape_GetLocalBounds(const JPH_TaperedCylinderShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetLocalBounds());
}

float JPH_TaperedCylinderShape_GetInnerRadius(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetInnerRadius();
}

JPH_Vec3 *JPH_TaperedCylinderShape_GetSurfaceNormal(const JPH_TaperedCylinderShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

const JPH_ConvexShape_Support *JPH_TaperedCylinderShape_GetSupportFunction(const JPH_TaperedCylinderShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale)
{
    return (const JPH_ConvexShape_Support *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetSupportFunction(
        ((JPH::ConvexShape::ESupportMode)inMode),
        ((inBuffer ? void() : MRBINDC_THROW("Parameter `inBuffer` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(inBuffer)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_TaperedCylinderShape_GetTrianglesStart(const JPH_TaperedCylinderShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_TaperedCylinderShape_GetTrianglesNext(const JPH_TaperedCylinderShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

void JPH_TaperedCylinderShape_Draw(const JPH_TaperedCylinderShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).Draw(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inUseMaterialColors,
        inDrawWireframe
    );
}

JPH_Shape_Stats *JPH_TaperedCylinderShape_GetStats(const JPH_TaperedCylinderShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetStats());
}

float JPH_TaperedCylinderShape_GetVolume(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetVolume();
}

bool JPH_TaperedCylinderShape_IsValidScale(const JPH_TaperedCylinderShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_TaperedCylinderShape_MakeScaleValid(const JPH_TaperedCylinderShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_TaperedCylinderShape_sRegister(void)
{
    JPH::TaperedCylinderShape::sRegister();
}

unsigned int JPH_TaperedCylinderShape_GetSubShapeIDBitsRecursive(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetSubShapeIDBitsRecursive();
}

void JPH_TaperedCylinderShape_GetSubmergedVolume(const JPH_TaperedCylinderShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

void JPH_TaperedCylinderShape_SetMaterial(JPH_TaperedCylinderShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

void JPH_TaperedCylinderShape_SetDensity(JPH_TaperedCylinderShape *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShape *)(_this)).SetDensity(
        inDensity
    );
}

float JPH_TaperedCylinderShape_GetDensity(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetDensity();
}

void JPH_TaperedCylinderShape_DrawGetSupportFunction(const JPH_TaperedCylinderShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).DrawGetSupportFunction(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inDrawSupportDirection
    );
}

void JPH_TaperedCylinderShape_DrawGetSupportingFace(const JPH_TaperedCylinderShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).DrawGetSupportingFace(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

uint64_t JPH_TaperedCylinderShape_GetUserData(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetUserData();
}

void JPH_TaperedCylinderShape_SetUserData(JPH_TaperedCylinderShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCylinderShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_TaperedCylinderShape_MustBeStatic(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).MustBeStatic();
}

const JPH_Shape *JPH_TaperedCylinderShape_GetLeafShape(const JPH_TaperedCylinderShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_TaperedCylinderShape_GetSubShapeUserData(const JPH_TaperedCylinderShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_TaperedCylinderShape_GetSubShapeTransformedShape(const JPH_TaperedCylinderShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

void JPH_TaperedCylinderShape_SetEmbedded(const JPH_TaperedCylinderShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).SetEmbedded();
}

unsigned int JPH_TaperedCylinderShape_GetRefCount(const JPH_TaperedCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).GetRefCount();
}

void JPH_TaperedCylinderShape_AddRef(const JPH_TaperedCylinderShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).AddRef();
}

void JPH_TaperedCylinderShape_Release(const JPH_TaperedCylinderShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCylinderShape *)(_this)).Release();
}

int JPH_TaperedCylinderShape_sInternalGetRefCountOffset(void)
{
    return JPH::TaperedCylinderShape::sInternalGetRefCountOffset();
}

