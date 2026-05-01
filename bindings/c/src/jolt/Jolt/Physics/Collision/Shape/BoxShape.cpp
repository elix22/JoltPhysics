// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/BoxShape.h"

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
#include <Jolt/Physics/Collision/Shape/BoxShape.h>
#include <Jolt/Physics/Collision/Shape/ConvexShape.h>
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


const JPH_Vec3 *JPH_BoxShapeSettings_Get_mHalfExtent(const JPH_BoxShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShapeSettings *)(_this)).mHalfExtent);
}

JPH_Vec3 *JPH_BoxShapeSettings_GetMutable_mHalfExtent(JPH_BoxShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).mHalfExtent);
}

const float *JPH_BoxShapeSettings_Get_mConvexRadius(const JPH_BoxShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShapeSettings *)(_this)).mConvexRadius);
}

void JPH_BoxShapeSettings_Set_mConvexRadius(JPH_BoxShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).mConvexRadius = value;
}

float *JPH_BoxShapeSettings_GetMutable_mConvexRadius(JPH_BoxShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).mConvexRadius);
}

const float *JPH_BoxShapeSettings_Get_mDensity(const JPH_BoxShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShapeSettings *)(_this)).mDensity);
}

void JPH_BoxShapeSettings_Set_mDensity(JPH_BoxShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).mDensity = value;
}

float *JPH_BoxShapeSettings_GetMutable_mDensity(JPH_BoxShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).mDensity);
}

const uint64_t *JPH_BoxShapeSettings_Get_mUserData(const JPH_BoxShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShapeSettings *)(_this)).mUserData);
}

void JPH_BoxShapeSettings_Set_mUserData(JPH_BoxShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_BoxShapeSettings_GetMutable_mUserData(JPH_BoxShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).mUserData);
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::BoxShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_BoxShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BoxShapeSettings *)(new JPH::BoxShapeSettings[num_elems]{});
}

const JPH_BoxShapeSettings *JPH_BoxShapeSettings_OffsetPtr(const JPH_BoxShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_BoxShapeSettings *)(((const JPH::BoxShapeSettings *)ptr) + i);
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_OffsetMutablePtr(JPH_BoxShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_BoxShapeSettings *)(((JPH::BoxShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_BoxShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_BoxShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::BoxShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_BoxShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_BoxShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::BoxShapeSettings *)object)
    ));
}

const JPH_BoxShapeSettings *JPH_BoxShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_BoxShapeSettings *)(static_cast<const JPH::BoxShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_BoxShapeSettings *)(static_cast<JPH::BoxShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_BoxShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_BoxShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::BoxShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_BoxShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_BoxShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::BoxShapeSettings *)object)
    ));
}

const JPH_BoxShapeSettings *JPH_BoxShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_BoxShapeSettings *)(static_cast<const JPH::BoxShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_BoxShapeSettings *)(static_cast<JPH::BoxShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_BoxShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_BoxShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::BoxShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_BoxShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_BoxShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::BoxShapeSettings *)object)
    ));
}

const JPH_BoxShapeSettings *JPH_BoxShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_BoxShapeSettings *)(static_cast<const JPH::BoxShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_BoxShapeSettings *)(static_cast<JPH::BoxShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_ConvexShapeSettings *JPH_BoxShapeSettings_UpcastTo_JPH_ConvexShapeSettings(const JPH_BoxShapeSettings *object)
{
    return (const JPH_ConvexShapeSettings *)(static_cast<const JPH::ConvexShapeSettings *>(
        ((const JPH::BoxShapeSettings *)object)
    ));
}

JPH_ConvexShapeSettings *JPH_BoxShapeSettings_MutableUpcastTo_JPH_ConvexShapeSettings(JPH_BoxShapeSettings *object)
{
    return (JPH_ConvexShapeSettings *)(static_cast<JPH::ConvexShapeSettings *>(
        ((JPH::BoxShapeSettings *)object)
    ));
}

const JPH_BoxShapeSettings *JPH_BoxShapeSettings_StaticDowncastFrom_JPH_ConvexShapeSettings(const JPH_ConvexShapeSettings *object)
{
    return (const JPH_BoxShapeSettings *)(static_cast<const JPH::BoxShapeSettings *>(
        ((const JPH::ConvexShapeSettings *)object)
    ));
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_MutableStaticDowncastFrom_JPH_ConvexShapeSettings(JPH_ConvexShapeSettings *object)
{
    return (JPH_BoxShapeSettings *)(static_cast<JPH::BoxShapeSettings *>(
        ((JPH::ConvexShapeSettings *)object)
    ));
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_BoxShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::BoxShapeSettings);
    return (JPH_BoxShapeSettings *)new JPH::BoxShapeSettings(JPH::BoxShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::BoxShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::BoxShapeSettings), JPH::BoxShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::BoxShapeSettings), JPH::BoxShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::BoxShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::BoxShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::BoxShapeSettings))
    ));
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_Construct(const JPH_Vec3 *inHalfExtent, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial)
{
    using namespace JPH;
    return (JPH_BoxShapeSettings *)new JPH::BoxShapeSettings(JPH::BoxShapeSettings(
        ((inHalfExtent ? void() : MRBINDC_THROW("Parameter `inHalfExtent` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inHalfExtent)),
        (inConvexRadius ? *inConvexRadius : static_cast<float>(cDefaultConvexRadius)),
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_BoxShapeSettings_Destroy(const JPH_BoxShapeSettings *_this)
{
    delete ((const JPH::BoxShapeSettings *)_this);
}

void JPH_BoxShapeSettings_DestroyArray(const JPH_BoxShapeSettings *_this)
{
    delete[] ((const JPH::BoxShapeSettings *)_this);
}

JPH_BoxShapeSettings *JPH_BoxShapeSettings_AssignFromAnother(JPH_BoxShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_BoxShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::BoxShapeSettings);
    return (JPH_BoxShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::BoxShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::BoxShapeSettings), JPH::BoxShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::BoxShapeSettings), JPH::BoxShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::BoxShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::BoxShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::BoxShapeSettings))
    ));
}

void *Jolt_new_JPH_BoxShapeSettings_size_t(size_t inCount)
{
    return JPH::BoxShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_BoxShapeSettings_void_ptr(void *inPointer)
{
    JPH::BoxShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_BoxShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BoxShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_BoxShapeSettings_size_t(size_t inCount)
{
    return JPH::BoxShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_BoxShapeSettings_void_ptr(void *inPointer)
{
    JPH::BoxShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_BoxShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BoxShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_BoxShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BoxShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_BoxShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BoxShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_BoxShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BoxShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_BoxShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BoxShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_BoxShapeSettings_SetDensity(JPH_BoxShapeSettings *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).SetDensity(
        inDensity
    );
}

void JPH_BoxShapeSettings_ClearCachedResult(JPH_BoxShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_BoxShapeSettings_SetEmbedded(const JPH_BoxShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_BoxShapeSettings_GetRefCount(const JPH_BoxShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShapeSettings *)(_this)).GetRefCount();
}

void JPH_BoxShapeSettings_AddRef(const JPH_BoxShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShapeSettings *)(_this)).AddRef();
}

void JPH_BoxShapeSettings_Release(const JPH_BoxShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShapeSettings *)(_this)).Release();
}

int JPH_BoxShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::BoxShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_BoxShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::BoxShape::cGetTrianglesMinTrianglesRequested);
}

JPH_BoxShape *JPH_BoxShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::BoxShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_BoxShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_BoxShape *JPH_BoxShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BoxShape *)(new JPH::BoxShape[num_elems]{});
}

const JPH_BoxShape *JPH_BoxShape_OffsetPtr(const JPH_BoxShape *ptr, ptrdiff_t i)
{
    return (const JPH_BoxShape *)(((const JPH::BoxShape *)ptr) + i);
}

JPH_BoxShape *JPH_BoxShape_OffsetMutablePtr(JPH_BoxShape *ptr, ptrdiff_t i)
{
    return (JPH_BoxShape *)(((JPH::BoxShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_BoxShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_BoxShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::BoxShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_BoxShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_BoxShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::BoxShape *)object)
    ));
}

const JPH_BoxShape *JPH_BoxShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_BoxShape *)(static_cast<const JPH::BoxShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_BoxShape *JPH_BoxShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_BoxShape *)(static_cast<JPH::BoxShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_BoxShape_UpcastTo_JPH_NonCopyable(const JPH_BoxShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::BoxShape *)object)
    ));
}

JPH_NonCopyable *JPH_BoxShape_MutableUpcastTo_JPH_NonCopyable(JPH_BoxShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::BoxShape *)object)
    ));
}

const JPH_BoxShape *JPH_BoxShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_BoxShape *)(static_cast<const JPH::BoxShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_BoxShape *JPH_BoxShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_BoxShape *)(static_cast<JPH::BoxShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_BoxShape_UpcastTo_JPH_Shape(const JPH_BoxShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::BoxShape *)object)
    ));
}

JPH_Shape *JPH_BoxShape_MutableUpcastTo_JPH_Shape(JPH_BoxShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::BoxShape *)object)
    ));
}

const JPH_BoxShape *JPH_BoxShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_BoxShape *)(static_cast<const JPH::BoxShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_BoxShape *JPH_BoxShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_BoxShape *)(static_cast<JPH::BoxShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_ConvexShape *JPH_BoxShape_UpcastTo_JPH_ConvexShape(const JPH_BoxShape *object)
{
    return (const JPH_ConvexShape *)(static_cast<const JPH::ConvexShape *>(
        ((const JPH::BoxShape *)object)
    ));
}

JPH_ConvexShape *JPH_BoxShape_MutableUpcastTo_JPH_ConvexShape(JPH_BoxShape *object)
{
    return (JPH_ConvexShape *)(static_cast<JPH::ConvexShape *>(
        ((JPH::BoxShape *)object)
    ));
}

const JPH_BoxShape *JPH_BoxShape_StaticDowncastFrom_JPH_ConvexShape(const JPH_ConvexShape *object)
{
    return (const JPH_BoxShape *)(static_cast<const JPH::BoxShape *>(
        ((const JPH::ConvexShape *)object)
    ));
}

JPH_BoxShape *JPH_BoxShape_MutableStaticDowncastFrom_JPH_ConvexShape(JPH_ConvexShape *object)
{
    return (JPH_BoxShape *)(static_cast<JPH::BoxShape *>(
        ((JPH::ConvexShape *)object)
    ));
}

JPH_BoxShape *JPH_BoxShape_Construct_3(const JPH_Vec3 *inHalfExtent, const float *inConvexRadius, const JPH_PhysicsMaterial *inMaterial)
{
    using namespace JPH;
    return (JPH_BoxShape *)new JPH::BoxShape(JPH::BoxShape(
        ((inHalfExtent ? void() : MRBINDC_THROW("Parameter `inHalfExtent` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inHalfExtent)),
        (inConvexRadius ? *inConvexRadius : static_cast<float>(cDefaultConvexRadius)),
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

void JPH_BoxShape_Destroy(const JPH_BoxShape *_this)
{
    delete ((const JPH::BoxShape *)_this);
}

void JPH_BoxShape_DestroyArray(const JPH_BoxShape *_this)
{
    delete[] ((const JPH::BoxShape *)_this);
}

void *Jolt_new_JPH_BoxShape_size_t(size_t inCount)
{
    return JPH::BoxShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_BoxShape_void_ptr(void *inPointer)
{
    JPH::BoxShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_BoxShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BoxShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_BoxShape_size_t(size_t inCount)
{
    return JPH::BoxShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_BoxShape_void_ptr(void *inPointer)
{
    JPH::BoxShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_BoxShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BoxShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_BoxShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BoxShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_BoxShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BoxShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_BoxShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BoxShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_BoxShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BoxShape::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Vec3 *JPH_BoxShape_GetHalfExtent(const JPH_BoxShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetHalfExtent());
}

JPH_AABox *JPH_BoxShape_GetLocalBounds(const JPH_BoxShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetLocalBounds());
}

float JPH_BoxShape_GetInnerRadius(const JPH_BoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetInnerRadius();
}

JPH_Vec3 *JPH_BoxShape_GetSurfaceNormal(const JPH_BoxShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

const JPH_ConvexShape_Support *JPH_BoxShape_GetSupportFunction(const JPH_BoxShape *_this, JPH_ConvexShape_ESupportMode inMode, JPH_ConvexShape_SupportBuffer *inBuffer, const JPH_Vec3 *inScale)
{
    return (const JPH_ConvexShape_Support *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetSupportFunction(
        ((JPH::ConvexShape::ESupportMode)inMode),
        ((inBuffer ? void() : MRBINDC_THROW("Parameter `inBuffer` can not be null.", void)), *(JPH::ConvexShape::SupportBuffer *)(inBuffer)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

bool JPH_BoxShape_CastRay_3(const JPH_BoxShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_BoxShape_GetTrianglesStart(const JPH_BoxShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_BoxShape_GetTrianglesNext(const JPH_BoxShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_BoxShape_GetStats(const JPH_BoxShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetStats());
}

float JPH_BoxShape_GetVolume(const JPH_BoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetVolume();
}

float JPH_BoxShape_GetConvexRadius(const JPH_BoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetConvexRadius();
}

void JPH_BoxShape_sRegister(void)
{
    JPH::BoxShape::sRegister();
}

unsigned int JPH_BoxShape_GetSubShapeIDBitsRecursive(const JPH_BoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetSubShapeIDBitsRecursive();
}

void JPH_BoxShape_GetSubmergedVolume(const JPH_BoxShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy))
    );
}

void JPH_BoxShape_SetMaterial(JPH_BoxShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

void JPH_BoxShape_SetDensity(JPH_BoxShape *_this, float inDensity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShape *)(_this)).SetDensity(
        inDensity
    );
}

float JPH_BoxShape_GetDensity(const JPH_BoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetDensity();
}

uint64_t JPH_BoxShape_GetUserData(const JPH_BoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetUserData();
}

void JPH_BoxShape_SetUserData(JPH_BoxShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BoxShape *)(_this)).SetUserData(
        inUserData
    );
}

bool JPH_BoxShape_MustBeStatic(const JPH_BoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).MustBeStatic();
}

JPH_Vec3 *JPH_BoxShape_GetCenterOfMass(const JPH_BoxShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetCenterOfMass());
}

const JPH_Shape *JPH_BoxShape_GetLeafShape(const JPH_BoxShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_BoxShape_GetSubShapeUserData(const JPH_BoxShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_BoxShape_GetSubShapeTransformedShape(const JPH_BoxShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

bool JPH_BoxShape_IsValidScale(const JPH_BoxShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_BoxShape_MakeScaleValid(const JPH_BoxShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_BoxShape_SetEmbedded(const JPH_BoxShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).SetEmbedded();
}

unsigned int JPH_BoxShape_GetRefCount(const JPH_BoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).GetRefCount();
}

void JPH_BoxShape_AddRef(const JPH_BoxShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).AddRef();
}

void JPH_BoxShape_Release(const JPH_BoxShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BoxShape *)(_this)).Release();
}

int JPH_BoxShape_sInternalGetRefCountOffset(void)
{
    return JPH::BoxShape::sInternalGetRefCountOffset();
}

