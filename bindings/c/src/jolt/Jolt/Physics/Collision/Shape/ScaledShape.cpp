// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/ScaledShape.h"

#include <Jolt/Core/Color.h>
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
#include <Jolt/Physics/Collision/Shape/DecoratedShape.h>
#include <Jolt/Physics/Collision/Shape/ScaledShape.h>
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


const JPH_Vec3 *JPH_ScaledShapeSettings_Get_mScale(const JPH_ScaledShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShapeSettings *)(_this)).mScale);
}

JPH_Vec3 *JPH_ScaledShapeSettings_GetMutable_mScale(JPH_ScaledShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ScaledShapeSettings *)(_this)).mScale);
}

const uint64_t *JPH_ScaledShapeSettings_Get_mUserData(const JPH_ScaledShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShapeSettings *)(_this)).mUserData);
}

void JPH_ScaledShapeSettings_Set_mUserData(JPH_ScaledShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ScaledShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_ScaledShapeSettings_GetMutable_mUserData(JPH_ScaledShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ScaledShapeSettings *)(_this)).mUserData);
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ScaledShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ScaledShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ScaledShapeSettings *)(new JPH::ScaledShapeSettings[num_elems]{});
}

const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_OffsetPtr(const JPH_ScaledShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_ScaledShapeSettings *)(((const JPH::ScaledShapeSettings *)ptr) + i);
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_OffsetMutablePtr(JPH_ScaledShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_ScaledShapeSettings *)(((JPH::ScaledShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_ScaledShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_ScaledShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::ScaledShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ScaledShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::ScaledShapeSettings *)object)
    ));
}

const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_ScaledShapeSettings *)(static_cast<const JPH::ScaledShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_ScaledShapeSettings *)(static_cast<JPH::ScaledShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_ScaledShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_ScaledShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::ScaledShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_ScaledShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::ScaledShapeSettings *)object)
    ));
}

const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_ScaledShapeSettings *)(static_cast<const JPH::ScaledShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_ScaledShapeSettings *)(static_cast<JPH::ScaledShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_ScaledShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_ScaledShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::ScaledShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_ScaledShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::ScaledShapeSettings *)object)
    ));
}

const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_ScaledShapeSettings *)(static_cast<const JPH::ScaledShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_ScaledShapeSettings *)(static_cast<JPH::ScaledShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_DecoratedShapeSettings *JPH_ScaledShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(const JPH_ScaledShapeSettings *object)
{
    return (const JPH_DecoratedShapeSettings *)(static_cast<const JPH::DecoratedShapeSettings *>(
        ((const JPH::ScaledShapeSettings *)object)
    ));
}

JPH_DecoratedShapeSettings *JPH_ScaledShapeSettings_MutableUpcastTo_JPH_DecoratedShapeSettings(JPH_ScaledShapeSettings *object)
{
    return (JPH_DecoratedShapeSettings *)(static_cast<JPH::DecoratedShapeSettings *>(
        ((JPH::ScaledShapeSettings *)object)
    ));
}

const JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_StaticDowncastFrom_JPH_DecoratedShapeSettings(const JPH_DecoratedShapeSettings *object)
{
    return (const JPH_ScaledShapeSettings *)(static_cast<const JPH::ScaledShapeSettings *>(
        ((const JPH::DecoratedShapeSettings *)object)
    ));
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_MutableStaticDowncastFrom_JPH_DecoratedShapeSettings(JPH_DecoratedShapeSettings *object)
{
    return (JPH_ScaledShapeSettings *)(static_cast<JPH::ScaledShapeSettings *>(
        ((JPH::DecoratedShapeSettings *)object)
    ));
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ScaledShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ScaledShapeSettings);
    return (JPH_ScaledShapeSettings *)new JPH::ScaledShapeSettings(JPH::ScaledShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ScaledShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::ScaledShapeSettings), JPH::ScaledShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::ScaledShapeSettings), JPH::ScaledShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ScaledShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ScaledShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::ScaledShapeSettings))
    ));
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_Construct_const_JPH_ShapeSettings_ptr(const JPH_ShapeSettings *inShape, const JPH_Vec3 *inScale)
{
    return (JPH_ScaledShapeSettings *)new JPH::ScaledShapeSettings(JPH::ScaledShapeSettings(
        ((const JPH::ShapeSettings *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_Construct_const_JPH_Shape_ptr(const JPH_Shape *inShape, const JPH_Vec3 *inScale)
{
    return (JPH_ScaledShapeSettings *)new JPH::ScaledShapeSettings(JPH::ScaledShapeSettings(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_ScaledShapeSettings_Destroy(const JPH_ScaledShapeSettings *_this)
{
    delete ((const JPH::ScaledShapeSettings *)_this);
}

void JPH_ScaledShapeSettings_DestroyArray(const JPH_ScaledShapeSettings *_this)
{
    delete[] ((const JPH::ScaledShapeSettings *)_this);
}

JPH_ScaledShapeSettings *JPH_ScaledShapeSettings_AssignFromAnother(JPH_ScaledShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_ScaledShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ScaledShapeSettings);
    return (JPH_ScaledShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ScaledShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ScaledShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::ScaledShapeSettings), JPH::ScaledShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::ScaledShapeSettings), JPH::ScaledShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ScaledShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ScaledShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::ScaledShapeSettings))
    ));
}

void *Jolt_new_JPH_ScaledShapeSettings_size_t(size_t inCount)
{
    return JPH::ScaledShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ScaledShapeSettings_void_ptr(void *inPointer)
{
    JPH::ScaledShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ScaledShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ScaledShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ScaledShapeSettings_size_t(size_t inCount)
{
    return JPH::ScaledShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ScaledShapeSettings_void_ptr(void *inPointer)
{
    JPH::ScaledShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ScaledShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ScaledShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ScaledShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ScaledShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ScaledShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ScaledShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ScaledShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ScaledShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ScaledShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ScaledShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_ScaledShapeSettings_ClearCachedResult(JPH_ScaledShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ScaledShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_ScaledShapeSettings_SetEmbedded(const JPH_ScaledShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_ScaledShapeSettings_GetRefCount(const JPH_ScaledShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShapeSettings *)(_this)).GetRefCount();
}

void JPH_ScaledShapeSettings_AddRef(const JPH_ScaledShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShapeSettings *)(_this)).AddRef();
}

void JPH_ScaledShapeSettings_Release(const JPH_ScaledShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShapeSettings *)(_this)).Release();
}

int JPH_ScaledShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::ScaledShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_ScaledShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::ScaledShape::cGetTrianglesMinTrianglesRequested);
}

const bool *JPH_ScaledShape_Get_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::ScaledShape::sDrawSubmergedVolumes);
}

void JPH_ScaledShape_Set_sDrawSubmergedVolumes(bool value)
{
    JPH::ScaledShape::sDrawSubmergedVolumes = value;
}

bool *JPH_ScaledShape_GetMutable_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::ScaledShape::sDrawSubmergedVolumes);
}

JPH_ScaledShape *JPH_ScaledShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ScaledShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ScaledShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ScaledShape *JPH_ScaledShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ScaledShape *)(new JPH::ScaledShape[num_elems]{});
}

const JPH_ScaledShape *JPH_ScaledShape_OffsetPtr(const JPH_ScaledShape *ptr, ptrdiff_t i)
{
    return (const JPH_ScaledShape *)(((const JPH::ScaledShape *)ptr) + i);
}

JPH_ScaledShape *JPH_ScaledShape_OffsetMutablePtr(JPH_ScaledShape *ptr, ptrdiff_t i)
{
    return (JPH_ScaledShape *)(((JPH::ScaledShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_ScaledShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_ScaledShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::ScaledShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_ScaledShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_ScaledShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::ScaledShape *)object)
    ));
}

const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_ScaledShape *)(static_cast<const JPH::ScaledShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_ScaledShape *)(static_cast<JPH::ScaledShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_ScaledShape_UpcastTo_JPH_NonCopyable(const JPH_ScaledShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ScaledShape *)object)
    ));
}

JPH_NonCopyable *JPH_ScaledShape_MutableUpcastTo_JPH_NonCopyable(JPH_ScaledShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ScaledShape *)object)
    ));
}

const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ScaledShape *)(static_cast<const JPH::ScaledShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ScaledShape *)(static_cast<JPH::ScaledShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_ScaledShape_UpcastTo_JPH_Shape(const JPH_ScaledShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::ScaledShape *)object)
    ));
}

JPH_Shape *JPH_ScaledShape_MutableUpcastTo_JPH_Shape(JPH_ScaledShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::ScaledShape *)object)
    ));
}

const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_ScaledShape *)(static_cast<const JPH::ScaledShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_ScaledShape *)(static_cast<JPH::ScaledShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_DecoratedShape *JPH_ScaledShape_UpcastTo_JPH_DecoratedShape(const JPH_ScaledShape *object)
{
    return (const JPH_DecoratedShape *)(static_cast<const JPH::DecoratedShape *>(
        ((const JPH::ScaledShape *)object)
    ));
}

JPH_DecoratedShape *JPH_ScaledShape_MutableUpcastTo_JPH_DecoratedShape(JPH_ScaledShape *object)
{
    return (JPH_DecoratedShape *)(static_cast<JPH::DecoratedShape *>(
        ((JPH::ScaledShape *)object)
    ));
}

const JPH_ScaledShape *JPH_ScaledShape_StaticDowncastFrom_JPH_DecoratedShape(const JPH_DecoratedShape *object)
{
    return (const JPH_ScaledShape *)(static_cast<const JPH::ScaledShape *>(
        ((const JPH::DecoratedShape *)object)
    ));
}

JPH_ScaledShape *JPH_ScaledShape_MutableStaticDowncastFrom_JPH_DecoratedShape(JPH_DecoratedShape *object)
{
    return (JPH_ScaledShape *)(static_cast<JPH::ScaledShape *>(
        ((JPH::DecoratedShape *)object)
    ));
}

JPH_ScaledShape *JPH_ScaledShape_Construct_const_JPH_Shape_ptr(const JPH_Shape *inShape, const JPH_Vec3 *inScale)
{
    return (JPH_ScaledShape *)new JPH::ScaledShape(JPH::ScaledShape(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_ScaledShape_Destroy(const JPH_ScaledShape *_this)
{
    delete ((const JPH::ScaledShape *)_this);
}

void JPH_ScaledShape_DestroyArray(const JPH_ScaledShape *_this)
{
    delete[] ((const JPH::ScaledShape *)_this);
}

JPH_AABox *JPH_ScaledShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_ScaledShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::DMat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void *Jolt_new_JPH_ScaledShape_size_t(size_t inCount)
{
    return JPH::ScaledShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ScaledShape_void_ptr(void *inPointer)
{
    JPH::ScaledShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ScaledShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ScaledShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ScaledShape_size_t(size_t inCount)
{
    return JPH::ScaledShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ScaledShape_void_ptr(void *inPointer)
{
    JPH::ScaledShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ScaledShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ScaledShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ScaledShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ScaledShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ScaledShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ScaledShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ScaledShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ScaledShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ScaledShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ScaledShape::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Vec3 *JPH_ScaledShape_GetScale(const JPH_ScaledShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetScale());
}

JPH_Vec3 *JPH_ScaledShape_GetCenterOfMass(const JPH_ScaledShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_ScaledShape_GetLocalBounds(const JPH_ScaledShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetLocalBounds());
}

JPH_AABox *JPH_ScaledShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_ScaledShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

float JPH_ScaledShape_GetInnerRadius(const JPH_ScaledShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetInnerRadius();
}

JPH_TransformedShape *JPH_ScaledShape_GetSubShapeTransformedShape(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

JPH_Vec3 *JPH_ScaledShape_GetSurfaceNormal(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_ScaledShape_GetSubmergedVolume(const JPH_ScaledShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

void JPH_ScaledShape_Draw(const JPH_ScaledShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).Draw(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inUseMaterialColors,
        inDrawWireframe
    );
}

void JPH_ScaledShape_DrawGetSupportFunction(const JPH_ScaledShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).DrawGetSupportFunction(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inDrawSupportDirection
    );
}

void JPH_ScaledShape_DrawGetSupportingFace(const JPH_ScaledShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).DrawGetSupportingFace(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

bool JPH_ScaledShape_CastRay_3(const JPH_ScaledShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_ScaledShape_GetTrianglesStart(const JPH_ScaledShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_ScaledShape_GetTrianglesNext(const JPH_ScaledShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_ScaledShape_GetStats(const JPH_ScaledShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetStats());
}

float JPH_ScaledShape_GetVolume(const JPH_ScaledShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetVolume();
}

bool JPH_ScaledShape_IsValidScale(const JPH_ScaledShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_ScaledShape_MakeScaleValid(const JPH_ScaledShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_ScaledShape_sRegister(void)
{
    JPH::ScaledShape::sRegister();
}

const JPH_Shape *JPH_ScaledShape_GetInnerShape(const JPH_ScaledShape *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetInnerShape());
}

bool JPH_ScaledShape_MustBeStatic(const JPH_ScaledShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).MustBeStatic();
}

unsigned int JPH_ScaledShape_GetSubShapeIDBitsRecursive(const JPH_ScaledShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetSubShapeIDBitsRecursive();
}

const JPH_Shape *JPH_ScaledShape_GetLeafShape(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

const JPH_PhysicsMaterial *JPH_ScaledShape_GetMaterial(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

uint64_t JPH_ScaledShape_GetSubShapeUserData(const JPH_ScaledShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

uint64_t JPH_ScaledShape_GetUserData(const JPH_ScaledShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetUserData();
}

void JPH_ScaledShape_SetUserData(JPH_ScaledShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ScaledShape *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_ScaledShape_SetEmbedded(const JPH_ScaledShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).SetEmbedded();
}

unsigned int JPH_ScaledShape_GetRefCount(const JPH_ScaledShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).GetRefCount();
}

void JPH_ScaledShape_AddRef(const JPH_ScaledShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).AddRef();
}

void JPH_ScaledShape_Release(const JPH_ScaledShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ScaledShape *)(_this)).Release();
}

int JPH_ScaledShape_sInternalGetRefCountOffset(void)
{
    return JPH::ScaledShape::sInternalGetRefCountOffset();
}

