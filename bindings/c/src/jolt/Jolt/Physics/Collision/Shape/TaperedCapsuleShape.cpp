// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/TaperedCapsuleShape.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/DMat44.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/ConvexShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/Shape/TaperedCapsuleShape.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const float *JPH_TaperedCapsuleShapeSettings_Get_mHalfHeightOfTaperedCylinder(const JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).mHalfHeightOfTaperedCylinder);
}

void JPH_TaperedCapsuleShapeSettings_Set_mHalfHeightOfTaperedCylinder(JPH_TaperedCapsuleShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mHalfHeightOfTaperedCylinder = value;
}

float *JPH_TaperedCapsuleShapeSettings_GetMutable_mHalfHeightOfTaperedCylinder(JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mHalfHeightOfTaperedCylinder);
}

const float *JPH_TaperedCapsuleShapeSettings_Get_mTopRadius(const JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).mTopRadius);
}

void JPH_TaperedCapsuleShapeSettings_Set_mTopRadius(JPH_TaperedCapsuleShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mTopRadius = value;
}

float *JPH_TaperedCapsuleShapeSettings_GetMutable_mTopRadius(JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mTopRadius);
}

const float *JPH_TaperedCapsuleShapeSettings_Get_mBottomRadius(const JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).mBottomRadius);
}

void JPH_TaperedCapsuleShapeSettings_Set_mBottomRadius(JPH_TaperedCapsuleShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mBottomRadius = value;
}

float *JPH_TaperedCapsuleShapeSettings_GetMutable_mBottomRadius(JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mBottomRadius);
}

const float *JPH_TaperedCapsuleShapeSettings_Get_mDensity(const JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).mDensity);
}

void JPH_TaperedCapsuleShapeSettings_Set_mDensity(JPH_TaperedCapsuleShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mDensity = value;
}

float *JPH_TaperedCapsuleShapeSettings_GetMutable_mDensity(JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mDensity);
}

const uint64_t *JPH_TaperedCapsuleShapeSettings_Get_mUserData(const JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).mUserData);
}

void JPH_TaperedCapsuleShapeSettings_Set_mUserData(JPH_TaperedCapsuleShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_TaperedCapsuleShapeSettings_GetMutable_mUserData(JPH_TaperedCapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).mUserData);
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_DefaultConstruct(void)
{
    return (JPH_TaperedCapsuleShapeSettings *)new JPH::TaperedCapsuleShapeSettings(JPH::TaperedCapsuleShapeSettings());
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_TaperedCapsuleShapeSettings *)(new JPH::TaperedCapsuleShapeSettings[num_elems]{});
}

const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_OffsetPtr(const JPH_TaperedCapsuleShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_TaperedCapsuleShapeSettings *)(((const JPH::TaperedCapsuleShapeSettings *)ptr) + i);
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_OffsetMutablePtr(JPH_TaperedCapsuleShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_TaperedCapsuleShapeSettings *)(((JPH::TaperedCapsuleShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_TaperedCapsuleShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::TaperedCapsuleShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_TaperedCapsuleShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_TaperedCapsuleShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::TaperedCapsuleShapeSettings *)object)
    ));
}

const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_TaperedCapsuleShapeSettings *)(static_cast<const JPH::TaperedCapsuleShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_TaperedCapsuleShapeSettings *)(static_cast<JPH::TaperedCapsuleShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_TaperedCapsuleShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::TaperedCapsuleShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_TaperedCapsuleShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::TaperedCapsuleShapeSettings *)object)
    ));
}

const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_TaperedCapsuleShapeSettings *)(static_cast<const JPH::TaperedCapsuleShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_TaperedCapsuleShapeSettings *)(static_cast<JPH::TaperedCapsuleShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_TaperedCapsuleShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::TaperedCapsuleShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_TaperedCapsuleShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::TaperedCapsuleShapeSettings *)object)
    ));
}

const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_TaperedCapsuleShapeSettings *)(static_cast<const JPH::TaperedCapsuleShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_TaperedCapsuleShapeSettings *)(static_cast<JPH::TaperedCapsuleShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_TaperedCapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_TaperedCapsuleShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::TaperedCapsuleShapeSettings *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_TaperedCapsuleShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::TaperedCapsuleShapeSettings *)object)
    ));
}

const JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_TaperedCapsuleShapeSettings *)(static_cast<const JPH::TaperedCapsuleShapeSettings *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_TaperedCapsuleShapeSettings *)(static_cast<JPH::TaperedCapsuleShapeSettings *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_TaperedCapsuleShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TaperedCapsuleShapeSettings);
    return (JPH_TaperedCapsuleShapeSettings *)new JPH::TaperedCapsuleShapeSettings(JPH::TaperedCapsuleShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::TaperedCapsuleShapeSettings), JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::TaperedCapsuleShapeSettings), JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::TaperedCapsuleShapeSettings))
    ));
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_Construct(float inHalfHeightOfTaperedCylinder, float inTopRadius, float inBottomRadius, const JPH_PhysicsMaterial *inMaterial)
{
    return (JPH_TaperedCapsuleShapeSettings *)new JPH::TaperedCapsuleShapeSettings(JPH::TaperedCapsuleShapeSettings(
        inHalfHeightOfTaperedCylinder,
        inTopRadius,
        inBottomRadius,
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_TaperedCapsuleShapeSettings_Destroy(const JPH_TaperedCapsuleShapeSettings *_this)
{
    delete ((const JPH::TaperedCapsuleShapeSettings *)_this);
}

void JPH_TaperedCapsuleShapeSettings_DestroyArray(const JPH_TaperedCapsuleShapeSettings *_this)
{
    delete[] ((const JPH::TaperedCapsuleShapeSettings *)_this);
}

JPH_TaperedCapsuleShapeSettings *JPH_TaperedCapsuleShapeSettings_AssignFromAnother(JPH_TaperedCapsuleShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_TaperedCapsuleShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TaperedCapsuleShapeSettings);
    return (JPH_TaperedCapsuleShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::TaperedCapsuleShapeSettings), JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::TaperedCapsuleShapeSettings), JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TaperedCapsuleShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::TaperedCapsuleShapeSettings))
    ));
}

void *Jolt_new_JPH_TaperedCapsuleShapeSettings_size_t(size_t inCount)
{
    return JPH::TaperedCapsuleShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr(void *inPointer)
{
    JPH::TaperedCapsuleShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TaperedCapsuleShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TaperedCapsuleShapeSettings_size_t(size_t inCount)
{
    return JPH::TaperedCapsuleShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr(void *inPointer)
{
    JPH::TaperedCapsuleShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TaperedCapsuleShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TaperedCapsuleShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TaperedCapsuleShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TaperedCapsuleShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TaperedCapsuleShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TaperedCapsuleShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TaperedCapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TaperedCapsuleShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_TaperedCapsuleShapeSettings_IsValid(const JPH_TaperedCapsuleShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).IsValid();
}

bool JPH_TaperedCapsuleShapeSettings_IsSphere(const JPH_TaperedCapsuleShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).IsSphere();
}

void JPH_TaperedCapsuleShapeSettings_SetDensity(JPH_TaperedCapsuleShapeSettings *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).SetDensity(
        inDensity
    );
}

void JPH_TaperedCapsuleShapeSettings_ClearCachedResult(JPH_TaperedCapsuleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_TaperedCapsuleShapeSettings_SetEmbedded(const JPH_TaperedCapsuleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_TaperedCapsuleShapeSettings_GetRefCount(const JPH_TaperedCapsuleShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).GetRefCount();
}

void JPH_TaperedCapsuleShapeSettings_AddRef(const JPH_TaperedCapsuleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).AddRef();
}

void JPH_TaperedCapsuleShapeSettings_Release(const JPH_TaperedCapsuleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShapeSettings *)(_this)).Release();
}

int JPH_TaperedCapsuleShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::TaperedCapsuleShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_TaperedCapsuleShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::TaperedCapsuleShape::cGetTrianglesMinTrianglesRequested);
}

JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_DefaultConstruct(void)
{
    return (JPH_TaperedCapsuleShape *)new JPH::TaperedCapsuleShape(JPH::TaperedCapsuleShape());
}

JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_TaperedCapsuleShape *)(new JPH::TaperedCapsuleShape[num_elems]{});
}

const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_OffsetPtr(const JPH_TaperedCapsuleShape *ptr, ptrdiff_t i)
{
    return (const JPH_TaperedCapsuleShape *)(((const JPH::TaperedCapsuleShape *)ptr) + i);
}

JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_OffsetMutablePtr(JPH_TaperedCapsuleShape *ptr, ptrdiff_t i)
{
    return (JPH_TaperedCapsuleShape *)(((JPH::TaperedCapsuleShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_TaperedCapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_TaperedCapsuleShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::TaperedCapsuleShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_TaperedCapsuleShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_TaperedCapsuleShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::TaperedCapsuleShape *)object)
    ));
}

const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_TaperedCapsuleShape *)(static_cast<const JPH::TaperedCapsuleShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_TaperedCapsuleShape *)(static_cast<JPH::TaperedCapsuleShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_TaperedCapsuleShape_UpcastTo_JPH_NonCopyable(const JPH_TaperedCapsuleShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::TaperedCapsuleShape *)object)
    ));
}

JPH_NonCopyable *JPH_TaperedCapsuleShape_MutableUpcastTo_JPH_NonCopyable(JPH_TaperedCapsuleShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::TaperedCapsuleShape *)object)
    ));
}

const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_TaperedCapsuleShape *)(static_cast<const JPH::TaperedCapsuleShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_TaperedCapsuleShape *)(static_cast<JPH::TaperedCapsuleShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_TaperedCapsuleShape_UpcastTo_JPH_Shape(const JPH_TaperedCapsuleShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::TaperedCapsuleShape *)object)
    ));
}

JPH_Shape *JPH_TaperedCapsuleShape_MutableUpcastTo_JPH_Shape(JPH_TaperedCapsuleShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::TaperedCapsuleShape *)object)
    ));
}

const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_TaperedCapsuleShape *)(static_cast<const JPH::TaperedCapsuleShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_TaperedCapsuleShape *)(static_cast<JPH::TaperedCapsuleShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_ConvexShape *JPH_TaperedCapsuleShape_UpcastTo_JPH_ConvexShape(const JPH_TaperedCapsuleShape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::TaperedCapsuleShape *)object)
    ));
}

JPH_ConvexShape *JPH_TaperedCapsuleShape_MutableUpcastTo_JPH_ConvexShape(JPH_TaperedCapsuleShape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::TaperedCapsuleShape *)object)
    ));
}

const JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object)
{
    return (const JPH_TaperedCapsuleShape *)(static_cast<const JPH::TaperedCapsuleShape *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_TaperedCapsuleShape *JPH_TaperedCapsuleShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object)
{
    return (JPH_TaperedCapsuleShape *)(static_cast<JPH::TaperedCapsuleShape *>(
        ((JPH::ConvexShape *)object)
    ));
}

void JPH_TaperedCapsuleShape_Destroy(const JPH_TaperedCapsuleShape *_this)
{
    delete ((const JPH::TaperedCapsuleShape *)_this);
}

void JPH_TaperedCapsuleShape_DestroyArray(const JPH_TaperedCapsuleShape *_this)
{
    delete[] ((const JPH::TaperedCapsuleShape *)_this);
}

JPH_AABox *JPH_TaperedCapsuleShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_TaperedCapsuleShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::DMat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void *Jolt_new_JPH_TaperedCapsuleShape_size_t(size_t inCount)
{
    return JPH::TaperedCapsuleShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TaperedCapsuleShape_void_ptr(void *inPointer)
{
    JPH::TaperedCapsuleShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TaperedCapsuleShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TaperedCapsuleShape_size_t(size_t inCount)
{
    return JPH::TaperedCapsuleShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr(void *inPointer)
{
    JPH::TaperedCapsuleShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TaperedCapsuleShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TaperedCapsuleShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TaperedCapsuleShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TaperedCapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TaperedCapsuleShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TaperedCapsuleShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TaperedCapsuleShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TaperedCapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TaperedCapsuleShape::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_TaperedCapsuleShape_GetTopRadius(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetTopRadius();
}

float JPH_TaperedCapsuleShape_GetBottomRadius(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetBottomRadius();
}

float JPH_TaperedCapsuleShape_GetHalfHeight(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetHalfHeight();
}

JPH_Vec3 *JPH_TaperedCapsuleShape_GetCenterOfMass(const JPH_TaperedCapsuleShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_TaperedCapsuleShape_GetLocalBounds(const JPH_TaperedCapsuleShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetLocalBounds());
}

JPH_AABox *JPH_TaperedCapsuleShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_TaperedCapsuleShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

float JPH_TaperedCapsuleShape_GetInnerRadius(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetInnerRadius();
}

JPH_Vec3 *JPH_TaperedCapsuleShape_GetSurfaceNormal(const JPH_TaperedCapsuleShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

const JPH_ConvexShape_Support *JPH_TaperedCapsuleShape_GetSupportFunction(const JPH_TaperedCapsuleShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale)
{
    return (const JPH_ConvexShape_Support *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetSupportFunction(
        ((JPH::ConvexShape::ESupportMode)inMode),
        ((inBuffer ? void() : MRBINDC_THROW("Parameter `inBuffer` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(inBuffer)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

JPH_Shape_Stats *JPH_TaperedCapsuleShape_GetStats(const JPH_TaperedCapsuleShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetStats());
}

float JPH_TaperedCapsuleShape_GetVolume(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetVolume();
}

bool JPH_TaperedCapsuleShape_IsValidScale(const JPH_TaperedCapsuleShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_TaperedCapsuleShape_MakeScaleValid(const JPH_TaperedCapsuleShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_TaperedCapsuleShape_sRegister(void)
{
    JPH::TaperedCapsuleShape::sRegister();
}

unsigned int JPH_TaperedCapsuleShape_GetSubShapeIDBitsRecursive(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetSubShapeIDBitsRecursive();
}

void JPH_TaperedCapsuleShape_GetTrianglesStart(const JPH_TaperedCapsuleShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_TaperedCapsuleShape_GetTrianglesNext(const JPH_TaperedCapsuleShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

void JPH_TaperedCapsuleShape_SetMaterial(JPH_TaperedCapsuleShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

void JPH_TaperedCapsuleShape_SetDensity(JPH_TaperedCapsuleShape *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShape *)(_this)).SetDensity(
        inDensity
    );
}

float JPH_TaperedCapsuleShape_GetDensity(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetDensity();
}

uint64_t JPH_TaperedCapsuleShape_GetUserData(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetUserData();
}

void JPH_TaperedCapsuleShape_SetUserData(JPH_TaperedCapsuleShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TaperedCapsuleShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_TaperedCapsuleShape_MustBeStatic(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).MustBeStatic();
}

const JPH_Shape *JPH_TaperedCapsuleShape_GetLeafShape(const JPH_TaperedCapsuleShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_TaperedCapsuleShape_GetSubShapeUserData(const JPH_TaperedCapsuleShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

void JPH_TaperedCapsuleShape_SetEmbedded(const JPH_TaperedCapsuleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).SetEmbedded();
}

unsigned int JPH_TaperedCapsuleShape_GetRefCount(const JPH_TaperedCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).GetRefCount();
}

void JPH_TaperedCapsuleShape_AddRef(const JPH_TaperedCapsuleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).AddRef();
}

void JPH_TaperedCapsuleShape_Release(const JPH_TaperedCapsuleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TaperedCapsuleShape *)(_this)).Release();
}

int JPH_TaperedCapsuleShape_sInternalGetRefCountOffset(void)
{
    return JPH::TaperedCapsuleShape::sInternalGetRefCountOffset();
}

