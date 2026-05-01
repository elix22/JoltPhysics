// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/TriangleShape.h"

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
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/Shape/TriangleShape.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const JPH_Vec3 *JPH_TriangleShapeSettings_Get_mV1(const JPH_TriangleShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).mV1);
}

JPH_Vec3 *JPH_TriangleShapeSettings_GetMutable_mV1(JPH_TriangleShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).mV1);
}

const JPH_Vec3 *JPH_TriangleShapeSettings_Get_mV2(const JPH_TriangleShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).mV2);
}

JPH_Vec3 *JPH_TriangleShapeSettings_GetMutable_mV2(JPH_TriangleShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).mV2);
}

const JPH_Vec3 *JPH_TriangleShapeSettings_Get_mV3(const JPH_TriangleShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).mV3);
}

JPH_Vec3 *JPH_TriangleShapeSettings_GetMutable_mV3(JPH_TriangleShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).mV3);
}

const float *JPH_TriangleShapeSettings_Get_mConvexRadius(const JPH_TriangleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).mConvexRadius);
}

void JPH_TriangleShapeSettings_Set_mConvexRadius(JPH_TriangleShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).mConvexRadius = value;
}

float *JPH_TriangleShapeSettings_GetMutable_mConvexRadius(JPH_TriangleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).mConvexRadius);
}

const float *JPH_TriangleShapeSettings_Get_mDensity(const JPH_TriangleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).mDensity);
}

void JPH_TriangleShapeSettings_Set_mDensity(JPH_TriangleShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).mDensity = value;
}

float *JPH_TriangleShapeSettings_GetMutable_mDensity(JPH_TriangleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).mDensity);
}

const uint64_t *JPH_TriangleShapeSettings_Get_mUserData(const JPH_TriangleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).mUserData);
}

void JPH_TriangleShapeSettings_Set_mUserData(JPH_TriangleShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_TriangleShapeSettings_GetMutable_mUserData(JPH_TriangleShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).mUserData);
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_DefaultConstruct(void)
{
    return (JPH_TriangleShapeSettings *)new JPH::TriangleShapeSettings(JPH::TriangleShapeSettings());
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_TriangleShapeSettings *)(new JPH::TriangleShapeSettings[num_elems]{});
}

const JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_OffsetPtr(const JPH_TriangleShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_TriangleShapeSettings *)(((const JPH::TriangleShapeSettings *)ptr) + i);
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_OffsetMutablePtr(JPH_TriangleShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_TriangleShapeSettings *)(((JPH::TriangleShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_TriangleShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_TriangleShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::TriangleShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_TriangleShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_TriangleShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::TriangleShapeSettings *)object)
    ));
}

const JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_TriangleShapeSettings *)(static_cast<const JPH::TriangleShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_TriangleShapeSettings *)(static_cast<JPH::TriangleShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_TriangleShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_TriangleShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::TriangleShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_TriangleShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_TriangleShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::TriangleShapeSettings *)object)
    ));
}

const JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_TriangleShapeSettings *)(static_cast<const JPH::TriangleShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_TriangleShapeSettings *)(static_cast<JPH::TriangleShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_TriangleShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_TriangleShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::TriangleShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_TriangleShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_TriangleShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::TriangleShapeSettings *)object)
    ));
}

const JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_TriangleShapeSettings *)(static_cast<const JPH::TriangleShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_TriangleShapeSettings *)(static_cast<JPH::TriangleShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_TriangleShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_TriangleShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::TriangleShapeSettings *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_TriangleShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_TriangleShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::TriangleShapeSettings *)object)
    ));
}

const JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_TriangleShapeSettings *)(static_cast<const JPH::TriangleShapeSettings *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_TriangleShapeSettings *)(static_cast<JPH::TriangleShapeSettings *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_TriangleShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TriangleShapeSettings);
    return (JPH_TriangleShapeSettings *)new JPH::TriangleShapeSettings(JPH::TriangleShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TriangleShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::TriangleShapeSettings), JPH::TriangleShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::TriangleShapeSettings), JPH::TriangleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TriangleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TriangleShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::TriangleShapeSettings))
    ));
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_Construct(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial)
{
    using namespace JPH;
    return (JPH_TriangleShapeSettings *)new JPH::TriangleShapeSettings(JPH::TriangleShapeSettings(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        (inConvexRadius ? *inConvexRadius : static_cast<float>(0.F)),
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_TriangleShapeSettings_Destroy(const JPH_TriangleShapeSettings *_this)
{
    delete ((const JPH::TriangleShapeSettings *)_this);
}

void JPH_TriangleShapeSettings_DestroyArray(const JPH_TriangleShapeSettings *_this)
{
    delete[] ((const JPH::TriangleShapeSettings *)_this);
}

JPH_TriangleShapeSettings *JPH_TriangleShapeSettings_AssignFromAnother(JPH_TriangleShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_TriangleShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TriangleShapeSettings);
    return (JPH_TriangleShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TriangleShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::TriangleShapeSettings), JPH::TriangleShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::TriangleShapeSettings), JPH::TriangleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TriangleShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TriangleShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::TriangleShapeSettings))
    ));
}

void *Jolt_new_JPH_TriangleShapeSettings_size_t(size_t inCount)
{
    return JPH::TriangleShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TriangleShapeSettings_void_ptr(void *inPointer)
{
    JPH::TriangleShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TriangleShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TriangleShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TriangleShapeSettings_size_t(size_t inCount)
{
    return JPH::TriangleShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr(void *inPointer)
{
    JPH::TriangleShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TriangleShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TriangleShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TriangleShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TriangleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TriangleShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TriangleShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TriangleShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TriangleShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TriangleShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_TriangleShapeSettings_SetDensity(JPH_TriangleShapeSettings *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).SetDensity(
        inDensity
    );
}

void JPH_TriangleShapeSettings_ClearCachedResult(JPH_TriangleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_TriangleShapeSettings_SetEmbedded(const JPH_TriangleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_TriangleShapeSettings_GetRefCount(const JPH_TriangleShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).GetRefCount();
}

void JPH_TriangleShapeSettings_AddRef(const JPH_TriangleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).AddRef();
}

void JPH_TriangleShapeSettings_Release(const JPH_TriangleShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShapeSettings *)(_this)).Release();
}

int JPH_TriangleShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::TriangleShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_TriangleShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::TriangleShape::cGetTrianglesMinTrianglesRequested);
}

JPH_TriangleShape *JPH_TriangleShape_DefaultConstruct(void)
{
    return (JPH_TriangleShape *)new JPH::TriangleShape(JPH::TriangleShape());
}

JPH_TriangleShape *JPH_TriangleShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_TriangleShape *)(new JPH::TriangleShape[num_elems]{});
}

const JPH_TriangleShape *JPH_TriangleShape_OffsetPtr(const JPH_TriangleShape *ptr, ptrdiff_t i)
{
    return (const JPH_TriangleShape *)(((const JPH::TriangleShape *)ptr) + i);
}

JPH_TriangleShape *JPH_TriangleShape_OffsetMutablePtr(JPH_TriangleShape *ptr, ptrdiff_t i)
{
    return (JPH_TriangleShape *)(((JPH::TriangleShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_TriangleShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_TriangleShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::TriangleShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_TriangleShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_TriangleShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::TriangleShape *)object)
    ));
}

const JPH_TriangleShape *JPH_TriangleShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_TriangleShape *)(static_cast<const JPH::TriangleShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_TriangleShape *JPH_TriangleShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_TriangleShape *)(static_cast<JPH::TriangleShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_TriangleShape_UpcastTo_JPH_NonCopyable(const JPH_TriangleShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::TriangleShape *)object)
    ));
}

JPH_NonCopyable *JPH_TriangleShape_MutableUpcastTo_JPH_NonCopyable(JPH_TriangleShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::TriangleShape *)object)
    ));
}

const JPH_TriangleShape *JPH_TriangleShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_TriangleShape *)(static_cast<const JPH::TriangleShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_TriangleShape *JPH_TriangleShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_TriangleShape *)(static_cast<JPH::TriangleShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_TriangleShape_UpcastTo_JPH_Shape(const JPH_TriangleShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::TriangleShape *)object)
    ));
}

JPH_Shape *JPH_TriangleShape_MutableUpcastTo_JPH_Shape(JPH_TriangleShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::TriangleShape *)object)
    ));
}

const JPH_TriangleShape *JPH_TriangleShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_TriangleShape *)(static_cast<const JPH::TriangleShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_TriangleShape *JPH_TriangleShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_TriangleShape *)(static_cast<JPH::TriangleShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_ConvexShape *JPH_TriangleShape_UpcastTo_JPH_ConvexShape(const JPH_TriangleShape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::TriangleShape *)object)
    ));
}

JPH_ConvexShape *JPH_TriangleShape_MutableUpcastTo_JPH_ConvexShape(JPH_TriangleShape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::TriangleShape *)object)
    ));
}

const JPH_TriangleShape *JPH_TriangleShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object)
{
    return (const JPH_TriangleShape *)(static_cast<const JPH::TriangleShape *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_TriangleShape *JPH_TriangleShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object)
{
    return (JPH_TriangleShape *)(static_cast<JPH::TriangleShape *>(
        ((JPH::ConvexShape *)object)
    ));
}

JPH_TriangleShape *JPH_TriangleShape_Construct_5(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial)
{
    using namespace JPH;
    return (JPH_TriangleShape *)new JPH::TriangleShape(JPH::TriangleShape(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        (inConvexRadius ? *inConvexRadius : static_cast<float>(0.F)),
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_TriangleShape_Destroy(const JPH_TriangleShape *_this)
{
    delete ((const JPH::TriangleShape *)_this);
}

void JPH_TriangleShape_DestroyArray(const JPH_TriangleShape *_this)
{
    delete[] ((const JPH::TriangleShape *)_this);
}

JPH_AABox *JPH_TriangleShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_TriangleShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::DMat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void *Jolt_new_JPH_TriangleShape_size_t(size_t inCount)
{
    return JPH::TriangleShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TriangleShape_void_ptr(void *inPointer)
{
    JPH::TriangleShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TriangleShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TriangleShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TriangleShape_size_t(size_t inCount)
{
    return JPH::TriangleShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TriangleShape_void_ptr(void *inPointer)
{
    JPH::TriangleShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TriangleShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TriangleShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TriangleShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TriangleShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TriangleShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TriangleShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TriangleShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TriangleShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TriangleShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TriangleShape::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Vec3 *JPH_TriangleShape_GetVertex1(const JPH_TriangleShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetVertex1());
}

JPH_Vec3 *JPH_TriangleShape_GetVertex2(const JPH_TriangleShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetVertex2());
}

JPH_Vec3 *JPH_TriangleShape_GetVertex3(const JPH_TriangleShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetVertex3());
}

float JPH_TriangleShape_GetConvexRadius(const JPH_TriangleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetConvexRadius();
}

JPH_AABox *JPH_TriangleShape_GetLocalBounds(const JPH_TriangleShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetLocalBounds());
}

JPH_AABox *JPH_TriangleShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_TriangleShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

float JPH_TriangleShape_GetInnerRadius(const JPH_TriangleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetInnerRadius();
}

JPH_Vec3 *JPH_TriangleShape_GetSurfaceNormal(const JPH_TriangleShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

const JPH_ConvexShape_Support *JPH_TriangleShape_GetSupportFunction(const JPH_TriangleShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale)
{
    return (const JPH_ConvexShape_Support *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetSupportFunction(
        ((JPH::ConvexShape::ESupportMode)inMode),
        ((inBuffer ? void() : MRBINDC_THROW("Parameter `inBuffer` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(inBuffer)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_TriangleShape_GetSubmergedVolume(const JPH_TriangleShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy))
    );
}

bool JPH_TriangleShape_CastRay_3(const JPH_TriangleShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_TriangleShape_GetTrianglesStart(const JPH_TriangleShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_TriangleShape_GetTrianglesNext(const JPH_TriangleShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_TriangleShape_GetStats(const JPH_TriangleShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetStats());
}

float JPH_TriangleShape_GetVolume(const JPH_TriangleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetVolume();
}

bool JPH_TriangleShape_IsValidScale(const JPH_TriangleShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_TriangleShape_MakeScaleValid(const JPH_TriangleShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_TriangleShape_sRegister(void)
{
    JPH::TriangleShape::sRegister();
}

unsigned int JPH_TriangleShape_GetSubShapeIDBitsRecursive(const JPH_TriangleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetSubShapeIDBitsRecursive();
}

void JPH_TriangleShape_SetMaterial(JPH_TriangleShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

void JPH_TriangleShape_SetDensity(JPH_TriangleShape *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShape *)(_this)).SetDensity(
        inDensity
    );
}

float JPH_TriangleShape_GetDensity(const JPH_TriangleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetDensity();
}

uint64_t JPH_TriangleShape_GetUserData(const JPH_TriangleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetUserData();
}

void JPH_TriangleShape_SetUserData(JPH_TriangleShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TriangleShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_TriangleShape_MustBeStatic(const JPH_TriangleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).MustBeStatic();
}

JPH_Vec3 *JPH_TriangleShape_GetCenterOfMass(const JPH_TriangleShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetCenterOfMass());
}

const JPH_Shape *JPH_TriangleShape_GetLeafShape(const JPH_TriangleShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_TriangleShape_GetSubShapeUserData(const JPH_TriangleShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_TriangleShape_GetSubShapeTransformedShape(const JPH_TriangleShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

void JPH_TriangleShape_SetEmbedded(const JPH_TriangleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).SetEmbedded();
}

unsigned int JPH_TriangleShape_GetRefCount(const JPH_TriangleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).GetRefCount();
}

void JPH_TriangleShape_AddRef(const JPH_TriangleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).AddRef();
}

void JPH_TriangleShape_Release(const JPH_TriangleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TriangleShape *)(_this)).Release();
}

int JPH_TriangleShape_sInternalGetRefCountOffset(void)
{
    return JPH::TriangleShape::sInternalGetRefCountOffset();
}

