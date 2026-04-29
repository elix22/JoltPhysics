// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/CapsuleShape.h"

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
#include <Jolt/Physics/Collision/Shape/CapsuleShape.h>
#include <Jolt/Physics/Collision/Shape/ConvexShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const float *JPH_CapsuleShapeSettings_Get_mRadius(const JPH_CapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).mRadius);
}

void JPH_CapsuleShapeSettings_Set_mRadius(JPH_CapsuleShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).mRadius = value;
}

float *JPH_CapsuleShapeSettings_GetMutable_mRadius(JPH_CapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).mRadius);
}

const float *JPH_CapsuleShapeSettings_Get_mHalfHeightOfCylinder(const JPH_CapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).mHalfHeightOfCylinder);
}

void JPH_CapsuleShapeSettings_Set_mHalfHeightOfCylinder(JPH_CapsuleShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).mHalfHeightOfCylinder = value;
}

float *JPH_CapsuleShapeSettings_GetMutable_mHalfHeightOfCylinder(JPH_CapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).mHalfHeightOfCylinder);
}

const float *JPH_CapsuleShapeSettings_Get_mDensity(const JPH_CapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).mDensity);
}

void JPH_CapsuleShapeSettings_Set_mDensity(JPH_CapsuleShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).mDensity = value;
}

float *JPH_CapsuleShapeSettings_GetMutable_mDensity(JPH_CapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).mDensity);
}

const uint64_t *JPH_CapsuleShapeSettings_Get_mUserData(const JPH_CapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).mUserData);
}

void JPH_CapsuleShapeSettings_Set_mUserData(JPH_CapsuleShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_CapsuleShapeSettings_GetMutable_mUserData(JPH_CapsuleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).mUserData);
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_DefaultConstruct(void)
{
    return (JPH_CapsuleShapeSettings *)new JPH::CapsuleShapeSettings(JPH::CapsuleShapeSettings());
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CapsuleShapeSettings *)(new JPH::CapsuleShapeSettings[num_elems]{});
}

const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_OffsetPtr(const JPH_CapsuleShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_CapsuleShapeSettings *)(((const JPH::CapsuleShapeSettings *)ptr) + i);
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_OffsetMutablePtr(JPH_CapsuleShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_CapsuleShapeSettings *)(((JPH::CapsuleShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_CapsuleShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_CapsuleShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::CapsuleShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_CapsuleShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_CapsuleShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::CapsuleShapeSettings *)object)
    ));
}

const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_CapsuleShapeSettings *)(static_cast<const JPH::CapsuleShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_CapsuleShapeSettings *)(static_cast<JPH::CapsuleShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_CapsuleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_CapsuleShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::CapsuleShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_CapsuleShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_CapsuleShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::CapsuleShapeSettings *)object)
    ));
}

const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_CapsuleShapeSettings *)(static_cast<const JPH::CapsuleShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_CapsuleShapeSettings *)(static_cast<JPH::CapsuleShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_CapsuleShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_CapsuleShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::CapsuleShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_CapsuleShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_CapsuleShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::CapsuleShapeSettings *)object)
    ));
}

const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_CapsuleShapeSettings *)(static_cast<const JPH::CapsuleShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_CapsuleShapeSettings *)(static_cast<JPH::CapsuleShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_CapsuleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_CapsuleShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::CapsuleShapeSettings *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_CapsuleShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_CapsuleShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::CapsuleShapeSettings *)object)
    ));
}

const JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_CapsuleShapeSettings *)(static_cast<const JPH::CapsuleShapeSettings *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_CapsuleShapeSettings *)(static_cast<JPH::CapsuleShapeSettings *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CapsuleShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CapsuleShapeSettings);
    return (JPH_CapsuleShapeSettings *)new JPH::CapsuleShapeSettings(JPH::CapsuleShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CapsuleShapeSettings), JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::CapsuleShapeSettings), JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::CapsuleShapeSettings))
    ));
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_Construct(float inHalfHeightOfCylinder, float inRadius, const JPH_PhysicsMaterial *inMaterial)
{
    return (JPH_CapsuleShapeSettings *)new JPH::CapsuleShapeSettings(JPH::CapsuleShapeSettings(
        inHalfHeightOfCylinder,
        inRadius,
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_CapsuleShapeSettings_Destroy(const JPH_CapsuleShapeSettings *_this)
{
    delete ((const JPH::CapsuleShapeSettings *)_this);
}

void JPH_CapsuleShapeSettings_DestroyArray(const JPH_CapsuleShapeSettings *_this)
{
    delete[] ((const JPH::CapsuleShapeSettings *)_this);
}

JPH_CapsuleShapeSettings *JPH_CapsuleShapeSettings_AssignFromAnother(JPH_CapsuleShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_CapsuleShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CapsuleShapeSettings);
    return (JPH_CapsuleShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CapsuleShapeSettings), JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::CapsuleShapeSettings), JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CapsuleShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::CapsuleShapeSettings))
    ));
}

void *Jolt_new_JPH_CapsuleShapeSettings_size_t(size_t inCount)
{
    return JPH::CapsuleShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CapsuleShapeSettings_void_ptr(void *inPointer)
{
    JPH::CapsuleShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CapsuleShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CapsuleShapeSettings_size_t(size_t inCount)
{
    return JPH::CapsuleShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr(void *inPointer)
{
    JPH::CapsuleShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CapsuleShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CapsuleShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CapsuleShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CapsuleShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CapsuleShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CapsuleShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CapsuleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CapsuleShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_CapsuleShapeSettings_IsValid(const JPH_CapsuleShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).IsValid();
}

bool JPH_CapsuleShapeSettings_IsSphere(const JPH_CapsuleShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).IsSphere();
}

void JPH_CapsuleShapeSettings_SetDensity(JPH_CapsuleShapeSettings *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).SetDensity(
        inDensity
    );
}

void JPH_CapsuleShapeSettings_ClearCachedResult(JPH_CapsuleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_CapsuleShapeSettings_SetEmbedded(const JPH_CapsuleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_CapsuleShapeSettings_GetRefCount(const JPH_CapsuleShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).GetRefCount();
}

void JPH_CapsuleShapeSettings_AddRef(const JPH_CapsuleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).AddRef();
}

void JPH_CapsuleShapeSettings_Release(const JPH_CapsuleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShapeSettings *)(_this)).Release();
}

int JPH_CapsuleShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::CapsuleShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_CapsuleShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::CapsuleShape::cGetTrianglesMinTrianglesRequested);
}

JPH_CapsuleShape *JPH_CapsuleShape_DefaultConstruct(void)
{
    return (JPH_CapsuleShape *)new JPH::CapsuleShape(JPH::CapsuleShape());
}

JPH_CapsuleShape *JPH_CapsuleShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CapsuleShape *)(new JPH::CapsuleShape[num_elems]{});
}

const JPH_CapsuleShape *JPH_CapsuleShape_OffsetPtr(const JPH_CapsuleShape *ptr, ptrdiff_t i)
{
    return (const JPH_CapsuleShape *)(((const JPH::CapsuleShape *)ptr) + i);
}

JPH_CapsuleShape *JPH_CapsuleShape_OffsetMutablePtr(JPH_CapsuleShape *ptr, ptrdiff_t i)
{
    return (JPH_CapsuleShape *)(((JPH::CapsuleShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_CapsuleShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_CapsuleShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::CapsuleShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_CapsuleShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_CapsuleShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::CapsuleShape *)object)
    ));
}

const JPH_CapsuleShape *JPH_CapsuleShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_CapsuleShape *)(static_cast<const JPH::CapsuleShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_CapsuleShape *JPH_CapsuleShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_CapsuleShape *)(static_cast<JPH::CapsuleShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_CapsuleShape_UpcastTo_JPH_NonCopyable(const JPH_CapsuleShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::CapsuleShape *)object)
    ));
}

JPH_NonCopyable *JPH_CapsuleShape_MutableUpcastTo_JPH_NonCopyable(JPH_CapsuleShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::CapsuleShape *)object)
    ));
}

const JPH_CapsuleShape *JPH_CapsuleShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_CapsuleShape *)(static_cast<const JPH::CapsuleShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_CapsuleShape *JPH_CapsuleShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_CapsuleShape *)(static_cast<JPH::CapsuleShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_CapsuleShape_UpcastTo_JPH_Shape(const JPH_CapsuleShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::CapsuleShape *)object)
    ));
}

JPH_Shape *JPH_CapsuleShape_MutableUpcastTo_JPH_Shape(JPH_CapsuleShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::CapsuleShape *)object)
    ));
}

const JPH_CapsuleShape *JPH_CapsuleShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_CapsuleShape *)(static_cast<const JPH::CapsuleShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_CapsuleShape *JPH_CapsuleShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_CapsuleShape *)(static_cast<JPH::CapsuleShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_ConvexShape *JPH_CapsuleShape_UpcastTo_JPH_ConvexShape(const JPH_CapsuleShape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::CapsuleShape *)object)
    ));
}

JPH_ConvexShape *JPH_CapsuleShape_MutableUpcastTo_JPH_ConvexShape(JPH_CapsuleShape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::CapsuleShape *)object)
    ));
}

const JPH_CapsuleShape *JPH_CapsuleShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object)
{
    return (const JPH_CapsuleShape *)(static_cast<const JPH::CapsuleShape *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_CapsuleShape *JPH_CapsuleShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object)
{
    return (JPH_CapsuleShape *)(static_cast<JPH::CapsuleShape *>(
        ((JPH::ConvexShape *)object)
    ));
}

JPH_CapsuleShape *JPH_CapsuleShape_Construct_3(float inHalfHeightOfCylinder, float inRadius, const JPH_PhysicsMaterial *inMaterial)
{
    return (JPH_CapsuleShape *)new JPH::CapsuleShape(JPH::CapsuleShape(
        inHalfHeightOfCylinder,
        inRadius,
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_CapsuleShape_Destroy(const JPH_CapsuleShape *_this)
{
    delete ((const JPH::CapsuleShape *)_this);
}

void JPH_CapsuleShape_DestroyArray(const JPH_CapsuleShape *_this)
{
    delete[] ((const JPH::CapsuleShape *)_this);
}

JPH_AABox *JPH_CapsuleShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_CapsuleShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::DMat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void *Jolt_new_JPH_CapsuleShape_size_t(size_t inCount)
{
    return JPH::CapsuleShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CapsuleShape_void_ptr(void *inPointer)
{
    JPH::CapsuleShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CapsuleShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CapsuleShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CapsuleShape_size_t(size_t inCount)
{
    return JPH::CapsuleShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CapsuleShape_void_ptr(void *inPointer)
{
    JPH::CapsuleShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CapsuleShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CapsuleShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CapsuleShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CapsuleShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CapsuleShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CapsuleShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CapsuleShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CapsuleShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CapsuleShape::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_CapsuleShape_GetRadius(const JPH_CapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetRadius();
}

float JPH_CapsuleShape_GetHalfHeightOfCylinder(const JPH_CapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetHalfHeightOfCylinder();
}

JPH_AABox *JPH_CapsuleShape_GetLocalBounds(const JPH_CapsuleShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetLocalBounds());
}

JPH_AABox *JPH_CapsuleShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_CapsuleShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

float JPH_CapsuleShape_GetInnerRadius(const JPH_CapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetInnerRadius();
}

JPH_Vec3 *JPH_CapsuleShape_GetSurfaceNormal(const JPH_CapsuleShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

const JPH_ConvexShape_Support *JPH_CapsuleShape_GetSupportFunction(const JPH_CapsuleShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale)
{
    return (const JPH_ConvexShape_Support *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetSupportFunction(
        ((JPH::ConvexShape::ESupportMode)inMode),
        ((inBuffer ? void() : MRBINDC_THROW("Parameter `inBuffer` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(inBuffer)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_CapsuleShape_GetTrianglesStart(const JPH_CapsuleShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_CapsuleShape_GetTrianglesNext(const JPH_CapsuleShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_CapsuleShape_GetStats(const JPH_CapsuleShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetStats());
}

float JPH_CapsuleShape_GetVolume(const JPH_CapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetVolume();
}

bool JPH_CapsuleShape_IsValidScale(const JPH_CapsuleShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_CapsuleShape_MakeScaleValid(const JPH_CapsuleShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_CapsuleShape_sRegister(void)
{
    JPH::CapsuleShape::sRegister();
}

unsigned int JPH_CapsuleShape_GetSubShapeIDBitsRecursive(const JPH_CapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetSubShapeIDBitsRecursive();
}

void JPH_CapsuleShape_GetSubmergedVolume(const JPH_CapsuleShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy))
    );
}

void JPH_CapsuleShape_SetMaterial(JPH_CapsuleShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

void JPH_CapsuleShape_SetDensity(JPH_CapsuleShape *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShape *)(_this)).SetDensity(
        inDensity
    );
}

float JPH_CapsuleShape_GetDensity(const JPH_CapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetDensity();
}

uint64_t JPH_CapsuleShape_GetUserData(const JPH_CapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetUserData();
}

void JPH_CapsuleShape_SetUserData(JPH_CapsuleShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CapsuleShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_CapsuleShape_MustBeStatic(const JPH_CapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).MustBeStatic();
}

JPH_Vec3 *JPH_CapsuleShape_GetCenterOfMass(const JPH_CapsuleShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetCenterOfMass());
}

const JPH_Shape *JPH_CapsuleShape_GetLeafShape(const JPH_CapsuleShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_CapsuleShape_GetSubShapeUserData(const JPH_CapsuleShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

void JPH_CapsuleShape_SetEmbedded(const JPH_CapsuleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).SetEmbedded();
}

unsigned int JPH_CapsuleShape_GetRefCount(const JPH_CapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).GetRefCount();
}

void JPH_CapsuleShape_AddRef(const JPH_CapsuleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).AddRef();
}

void JPH_CapsuleShape_Release(const JPH_CapsuleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CapsuleShape *)(_this)).Release();
}

int JPH_CapsuleShape_sInternalGetRefCountOffset(void)
{
    return JPH::CapsuleShape::sInternalGetRefCountOffset();
}

