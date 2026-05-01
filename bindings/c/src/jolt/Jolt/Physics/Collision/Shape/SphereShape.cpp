// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/SphereShape.h"

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
#include <Jolt/Physics/Collision/CastResult.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/RayCast.h>
#include <Jolt/Physics/Collision/Shape/ConvexShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SphereShape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_SphereShapeSettings_Get_mRadius(const JPH_SphereShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShapeSettings *)(_this)).mRadius);
}

void JPH_SphereShapeSettings_Set_mRadius(JPH_SphereShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShapeSettings *)(_this)).mRadius = value;
}

float *JPH_SphereShapeSettings_GetMutable_mRadius(JPH_SphereShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShapeSettings *)(_this)).mRadius);
}

const float *JPH_SphereShapeSettings_Get_mDensity(const JPH_SphereShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShapeSettings *)(_this)).mDensity);
}

void JPH_SphereShapeSettings_Set_mDensity(JPH_SphereShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShapeSettings *)(_this)).mDensity = value;
}

float *JPH_SphereShapeSettings_GetMutable_mDensity(JPH_SphereShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShapeSettings *)(_this)).mDensity);
}

const uint64_t *JPH_SphereShapeSettings_Get_mUserData(const JPH_SphereShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShapeSettings *)(_this)).mUserData);
}

void JPH_SphereShapeSettings_Set_mUserData(JPH_SphereShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_SphereShapeSettings_GetMutable_mUserData(JPH_SphereShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShapeSettings *)(_this)).mUserData);
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SphereShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SphereShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SphereShapeSettings *)(new JPH::SphereShapeSettings[num_elems]{});
}

const JPH_SphereShapeSettings *JPH_SphereShapeSettings_OffsetPtr(const JPH_SphereShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_SphereShapeSettings *)(((const JPH::SphereShapeSettings *)ptr) + i);
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_OffsetMutablePtr(JPH_SphereShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_SphereShapeSettings *)(((JPH::SphereShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_SphereShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_SphereShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::SphereShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_SphereShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_SphereShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::SphereShapeSettings *)object)
    ));
}

const JPH_SphereShapeSettings *JPH_SphereShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_SphereShapeSettings *)(static_cast<const JPH::SphereShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_SphereShapeSettings *)(static_cast<JPH::SphereShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_SphereShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_SphereShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::SphereShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_SphereShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_SphereShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::SphereShapeSettings *)object)
    ));
}

const JPH_SphereShapeSettings *JPH_SphereShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_SphereShapeSettings *)(static_cast<const JPH::SphereShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_SphereShapeSettings *)(static_cast<JPH::SphereShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_SphereShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_SphereShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::SphereShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_SphereShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_SphereShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::SphereShapeSettings *)object)
    ));
}

const JPH_SphereShapeSettings *JPH_SphereShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_SphereShapeSettings *)(static_cast<const JPH::SphereShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_SphereShapeSettings *)(static_cast<JPH::SphereShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_SphereShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_SphereShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::SphereShapeSettings *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_SphereShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_SphereShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::SphereShapeSettings *)object)
    ));
}

const JPH_SphereShapeSettings *JPH_SphereShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_SphereShapeSettings *)(static_cast<const JPH::SphereShapeSettings *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_SphereShapeSettings *)(static_cast<JPH::SphereShapeSettings *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SphereShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SphereShapeSettings);
    return (JPH_SphereShapeSettings *)new JPH::SphereShapeSettings(JPH::SphereShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SphereShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SphereShapeSettings), JPH::SphereShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SphereShapeSettings), JPH::SphereShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SphereShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SphereShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::SphereShapeSettings))
    ));
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_Construct(float inRadius, const JPH_PhysicsMaterial *inMaterial)
{
    return (JPH_SphereShapeSettings *)new JPH::SphereShapeSettings(JPH::SphereShapeSettings(
        inRadius,
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_SphereShapeSettings_Destroy(const JPH_SphereShapeSettings *_this)
{
    delete ((const JPH::SphereShapeSettings *)_this);
}

void JPH_SphereShapeSettings_DestroyArray(const JPH_SphereShapeSettings *_this)
{
    delete[] ((const JPH::SphereShapeSettings *)_this);
}

JPH_SphereShapeSettings *JPH_SphereShapeSettings_AssignFromAnother(JPH_SphereShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_SphereShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SphereShapeSettings);
    return (JPH_SphereShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SphereShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SphereShapeSettings), JPH::SphereShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SphereShapeSettings), JPH::SphereShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SphereShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SphereShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::SphereShapeSettings))
    ));
}

void *Jolt_new_JPH_SphereShapeSettings_size_t(size_t inCount)
{
    return JPH::SphereShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SphereShapeSettings_void_ptr(void *inPointer)
{
    JPH::SphereShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SphereShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SphereShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SphereShapeSettings_size_t(size_t inCount)
{
    return JPH::SphereShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SphereShapeSettings_void_ptr(void *inPointer)
{
    JPH::SphereShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SphereShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SphereShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SphereShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SphereShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SphereShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SphereShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SphereShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SphereShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SphereShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SphereShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_SphereShapeSettings_SetDensity(JPH_SphereShapeSettings *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShapeSettings *)(_this)).SetDensity(
        inDensity
    );
}

void JPH_SphereShapeSettings_ClearCachedResult(JPH_SphereShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_SphereShapeSettings_SetEmbedded(const JPH_SphereShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_SphereShapeSettings_GetRefCount(const JPH_SphereShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShapeSettings *)(_this)).GetRefCount();
}

void JPH_SphereShapeSettings_AddRef(const JPH_SphereShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShapeSettings *)(_this)).AddRef();
}

void JPH_SphereShapeSettings_Release(const JPH_SphereShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShapeSettings *)(_this)).Release();
}

int JPH_SphereShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::SphereShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_SphereShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::SphereShape::cGetTrianglesMinTrianglesRequested);
}

JPH_SphereShape *JPH_SphereShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SphereShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SphereShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SphereShape *JPH_SphereShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SphereShape *)(new JPH::SphereShape[num_elems]{});
}

const JPH_SphereShape *JPH_SphereShape_OffsetPtr(const JPH_SphereShape *ptr, ptrdiff_t i)
{
    return (const JPH_SphereShape *)(((const JPH::SphereShape *)ptr) + i);
}

JPH_SphereShape *JPH_SphereShape_OffsetMutablePtr(JPH_SphereShape *ptr, ptrdiff_t i)
{
    return (JPH_SphereShape *)(((JPH::SphereShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_SphereShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_SphereShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::SphereShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_SphereShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_SphereShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::SphereShape *)object)
    ));
}

const JPH_SphereShape *JPH_SphereShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_SphereShape *)(static_cast<const JPH::SphereShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_SphereShape *JPH_SphereShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_SphereShape *)(static_cast<JPH::SphereShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_SphereShape_UpcastTo_JPH_NonCopyable(const JPH_SphereShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::SphereShape *)object)
    ));
}

JPH_NonCopyable *JPH_SphereShape_MutableUpcastTo_JPH_NonCopyable(JPH_SphereShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::SphereShape *)object)
    ));
}

const JPH_SphereShape *JPH_SphereShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_SphereShape *)(static_cast<const JPH::SphereShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_SphereShape *JPH_SphereShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_SphereShape *)(static_cast<JPH::SphereShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_SphereShape_UpcastTo_JPH_Shape(const JPH_SphereShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::SphereShape *)object)
    ));
}

JPH_Shape *JPH_SphereShape_MutableUpcastTo_JPH_Shape(JPH_SphereShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::SphereShape *)object)
    ));
}

const JPH_SphereShape *JPH_SphereShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_SphereShape *)(static_cast<const JPH::SphereShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_SphereShape *JPH_SphereShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_SphereShape *)(static_cast<JPH::SphereShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_ConvexShape *JPH_SphereShape_UpcastTo_JPH_ConvexShape(const JPH_SphereShape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::SphereShape *)object)
    ));
}

JPH_ConvexShape *JPH_SphereShape_MutableUpcastTo_JPH_ConvexShape(JPH_SphereShape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::SphereShape *)object)
    ));
}

const JPH_SphereShape *JPH_SphereShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object)
{
    return (const JPH_SphereShape *)(static_cast<const JPH::SphereShape *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_SphereShape *JPH_SphereShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object)
{
    return (JPH_SphereShape *)(static_cast<JPH::SphereShape *>(
        ((JPH::ConvexShape *)object)
    ));
}

JPH_SphereShape *JPH_SphereShape_Construct_float(float inRadius, const JPH_PhysicsMaterial *inMaterial)
{
    return (JPH_SphereShape *)new JPH::SphereShape(JPH::SphereShape(
        inRadius,
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_SphereShape_Destroy(const JPH_SphereShape *_this)
{
    delete ((const JPH::SphereShape *)_this);
}

void JPH_SphereShape_DestroyArray(const JPH_SphereShape *_this)
{
    delete[] ((const JPH::SphereShape *)_this);
}

JPH_AABox *JPH_SphereShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_SphereShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::DMat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void *Jolt_new_JPH_SphereShape_size_t(size_t inCount)
{
    return JPH::SphereShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SphereShape_void_ptr(void *inPointer)
{
    JPH::SphereShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SphereShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SphereShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SphereShape_size_t(size_t inCount)
{
    return JPH::SphereShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SphereShape_void_ptr(void *inPointer)
{
    JPH::SphereShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SphereShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SphereShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SphereShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SphereShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SphereShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SphereShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SphereShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SphereShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SphereShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SphereShape::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_SphereShape_GetRadius(const JPH_SphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetRadius();
}

JPH_AABox *JPH_SphereShape_GetLocalBounds(const JPH_SphereShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetLocalBounds());
}

JPH_AABox *JPH_SphereShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_SphereShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

float JPH_SphereShape_GetInnerRadius(const JPH_SphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetInnerRadius();
}

JPH_Vec3 *JPH_SphereShape_GetSurfaceNormal(const JPH_SphereShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

const JPH_ConvexShape_Support *JPH_SphereShape_GetSupportFunction(const JPH_SphereShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale)
{
    return (const JPH_ConvexShape_Support *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetSupportFunction(
        ((JPH::ConvexShape::ESupportMode)inMode),
        ((inBuffer ? void() : MRBINDC_THROW("Parameter `inBuffer` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(inBuffer)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_SphereShape_GetSubmergedVolume(const JPH_SphereShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy))
    );
}

bool JPH_SphereShape_CastRay_3(const JPH_SphereShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_SphereShape_GetTrianglesStart(const JPH_SphereShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_SphereShape_GetTrianglesNext(const JPH_SphereShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_SphereShape_GetStats(const JPH_SphereShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetStats());
}

float JPH_SphereShape_GetVolume(const JPH_SphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetVolume();
}

bool JPH_SphereShape_IsValidScale(const JPH_SphereShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_SphereShape_MakeScaleValid(const JPH_SphereShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_SphereShape_sRegister(void)
{
    JPH::SphereShape::sRegister();
}

unsigned int JPH_SphereShape_GetSubShapeIDBitsRecursive(const JPH_SphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetSubShapeIDBitsRecursive();
}

void JPH_SphereShape_SetMaterial(JPH_SphereShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

void JPH_SphereShape_SetDensity(JPH_SphereShape *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShape *)(_this)).SetDensity(
        inDensity
    );
}

float JPH_SphereShape_GetDensity(const JPH_SphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetDensity();
}

uint64_t JPH_SphereShape_GetUserData(const JPH_SphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetUserData();
}

void JPH_SphereShape_SetUserData(JPH_SphereShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SphereShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_SphereShape_MustBeStatic(const JPH_SphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).MustBeStatic();
}

JPH_Vec3 *JPH_SphereShape_GetCenterOfMass(const JPH_SphereShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetCenterOfMass());
}

const JPH_Shape *JPH_SphereShape_GetLeafShape(const JPH_SphereShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_SphereShape_GetSubShapeUserData(const JPH_SphereShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_SphereShape_GetSubShapeTransformedShape(const JPH_SphereShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

void JPH_SphereShape_SetEmbedded(const JPH_SphereShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).SetEmbedded();
}

unsigned int JPH_SphereShape_GetRefCount(const JPH_SphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).GetRefCount();
}

void JPH_SphereShape_AddRef(const JPH_SphereShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).AddRef();
}

void JPH_SphereShape_Release(const JPH_SphereShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SphereShape *)(_this)).Release();
}

int JPH_SphereShape_sInternalGetRefCountOffset(void)
{
    return JPH::SphereShape::sInternalGetRefCountOffset();
}

